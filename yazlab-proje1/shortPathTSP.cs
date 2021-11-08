using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazlab_proje1
{
    class shortPathTSP
    {
        static int count = 0;
        static int[] final_path;
        static Boolean[] visited;
        static double final_res = double.MaxValue;

        static void copyToFinal(int[] curr_path)
        {
            for(int i=0; i<count; i++)
            {
                final_path[i] = curr_path[i];
            }
            final_path[count] = curr_path[0];
        }

        static double firstMin(double[,] distMatrix, int i)
        {
            double min = double.MaxValue;

            for(int j=0; j<count; j++)
            {
                if (distMatrix[i, j] < min && i != j)
                    min = distMatrix[i, j];
            }

            return min;
        }

        static double secondMin(double[,] distMatrix, int i)
        {
            double first = double.MaxValue;
            double second = double.MaxValue;

            for(int j = 0; j<count; j++)
            {
                if (i == j)
                    continue;

                if (distMatrix[i, j] <= first)
                {
                    second = first;
                    first = distMatrix[i, j];
                }

                else if (distMatrix[i, j] <= second && distMatrix[i, j] != first)
                    second = distMatrix[i, j];
            }

            return second;
        }

        static void TSPRec(double[,] distMatrix, double curr_bound, double curr_weight, int level, int[] curr_path)
        {
            if(level == count)
            {
                if(distMatrix[curr_path[level-1],curr_path[0]] != 0)
                {
                    double curr_res = curr_weight + distMatrix[curr_path[level - 1], curr_path[0]];

                    if(curr_res < final_res)
                    {
                        copyToFinal(curr_path);
                        final_res = curr_res;
                    }
                }

                return;
            }

            for(int i=0; i<count; i++)
            {
                if(distMatrix[curr_path[level-1],i] != 0 && visited[i] == false)
                {
                    double temp = curr_bound;
                    curr_weight += distMatrix[curr_path[level - 1], i];

                    if(level == 1)
                    {
                        curr_bound -= ((firstMin(distMatrix, curr_path[level - 1]) + firstMin(distMatrix, i)) / 2);
                    }
                    else
                    {
                        curr_bound -= ((secondMin(distMatrix, curr_path[level - 1]) + secondMin(distMatrix, i)) / 2);

                    }

                    if(curr_bound + curr_weight < final_res)
                    {
                        curr_path[level] = i;
                        visited[i] = true;

                        TSPRec(distMatrix, curr_bound, curr_weight, level + 1, curr_path);
                    }

                    curr_weight -= distMatrix[curr_path[level - 1], i];
                    curr_bound = temp;

                    for (int x = 0; x < visited.Length; x++) 
                    { 
                        visited[x] = false; 
                    }

                    for(int j=0; j<=level-1; j++)
                    {
                        visited[curr_path[j]] = true;
                    }
                }
            }
        }

        static void TSP(double[,] distMatrix)
        {
            int[] curr_path = new int[count+1];
            double curr_bound = 0;

            for (int x = 0; x < curr_path.Length; x++)
            {
                curr_path[x] = -1;
            }

            for (int x = 0; x < visited.Length; x++)
            {
                visited[x] = false;
            }

            for(int i=0; i<count; i++)
            {
                curr_bound += (firstMin(distMatrix, i) + secondMin(distMatrix, i));
            }

            curr_bound = (curr_bound == 1)? curr_bound / 2 + 1 : curr_bound / 2;

            visited[0] = true;

            curr_path[0] = 0;

            TSPRec(distMatrix, curr_bound, 0, 1, curr_path);

        }

        public static int[] findShortPath(double[,] distMatrix)
        {
            count = distMatrix.GetLength(0);
            int N = count;
            final_path = new int[N + 1];
            visited = new Boolean[N];

            Array.Clear(final_path, 0, final_path.Length);
            final_res = double.MaxValue;
            Array.Clear(visited, 0, visited.Length);

            TSP(distMatrix);

            return final_path;
        }
    }
}
