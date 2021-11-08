using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace yazlab_proje1
{
    public partial class Map_Ekrani : Form
    {
        public int count = 0;
        public double[,] DistanceMatrix;
        public double[,] graph;
        public int[] path;
        public int sayac = 0;
        List<PointLatLng> map2Points;
        public int i = 0;

        public Map_Ekrani()
        {
            InitializeComponent();
            Activate();
            
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "fW9XmyFHISjhXYvmzTvcgbqDm2XW7YvqXGxdZz38",
            BasePath = "https://yazlab1-92c44-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        public void Map_Ekrani_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
                timer1.Enabled = true;
                
                dataCall();
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void Map2_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyCOzizXBIp-X3KMZ5TEwijwHa_7kv6DEcw";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map2.CacheLocation = @"cache";
            map2.DragButton = MouseButtons.Left;
            map2.MapProvider = GMapProviders.GoogleMap;
            map2.ShowCenter = false;
            map2.Position = new PointLatLng(40.7750, 29.9480);

            map2.MinZoom = 5;
            map2.MaxZoom = 100;
            map2.Zoom = 10;

        }

        async void dataCall()
        {
            FirebaseResponse res = await client.GetAsync(@"KargoBilgileri");
            Dictionary<string, Kargo_Bilgileri> data = JsonConvert.DeserializeObject<Dictionary<string, Kargo_Bilgileri>>(res.Body.ToString());

            path = shortPathTSP.findShortPath(calculateDistanceMatrix(data));
            lokasyonCekme(data);
        }

        void lokasyonCekme(Dictionary<string, Kargo_Bilgileri> record)
        {
            map2Points = new List<PointLatLng>();
            var point = new PointLatLng();
            var startPoint = new PointLatLng();
            startPoint.Lat = 40.7750;
            startPoint.Lng = 29.9480;
            map2Points.Add(startPoint);

            foreach (var item in record)
            {
                if (item.Value.kargoDurum == false)
                {
                    point.Lat = item.Value.latitude;
                    point.Lng = item.Value.longitude;
                    map2Points.Add(point);
                    AddMarker(map2Points);
                }
            }
            drawPath(map2Points, path);

        }

        public void AddMarker(List<PointLatLng> points, GMarkerGoogleType markerType = GMarkerGoogleType.arrow)
        {
            map2.Overlays.Clear();
            var markers = new GMapOverlay("markers");
            var startPoint = new PointLatLng();
            startPoint.Lat = 40.7750;
            startPoint.Lng = 29.9480;

            foreach (var Point in points)
            {
                var marker = new GMarkerGoogle(Point, markerType);
                markers.Markers.Add(marker);
            }
            markers.Markers.Add(new GMarkerGoogle(startPoint, GMarkerGoogleType.blue));
            map2.Overlays.Add(markers);
        }

        public double[,] calculateDistanceMatrix(Dictionary<string, Kargo_Bilgileri> record)
        {
            var point = new PointLatLng();
            var startPoint = new PointLatLng();
            startPoint.Lat = 40.7750;
            startPoint.Lng = 29.9480;

            List<PointLatLng> distancePoints = new List<PointLatLng>();
            distancePoints.Add(startPoint);
            count = 1;
            foreach (var item in record)
            {
                if (item.Value.kargoDurum == false)
                {
                    point.Lat = item.Value.latitude;
                    point.Lng = item.Value.longitude;
                    distancePoints.Add(point);
                    count++;
                }

            }

            DistanceMatrix = new double[count, count];

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    try
                    {
                        DistanceMatrix[i, j] = distanceTo((distancePoints[i]), distancePoints[j]);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                Console.Write("\n");
            }

            return DistanceMatrix;
        }

        public double distanceTo(PointLatLng p1, PointLatLng p2)
        {
            double rlat1 = Math.PI * p1.Lat / 180;
            double rlat2 = Math.PI * p2.Lat / 180;
            double theta = p1.Lng - p2.Lng;
            double rtheta = Math.PI * theta / 180;
            double dist = Math.Sin(rlat1) * Math.Sin(rlat2) + Math.Cos(rlat1) *
                          Math.Cos(rlat2) * Math.Cos(rtheta);

            dist = Math.Acos(dist);
            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

            return dist;
        }

        public void drawPath(List<PointLatLng> points, int[] path)
        {
            var routes = new GMapOverlay("routes");

            if (points.Count == 2)
            {
                var route = GoogleMapProvider.Instance.GetRoute(points[0], points[1], false, false, 14);
                var r = new GMapRoute(route.Points, "My Short Path Points")
                {
                    Stroke = new Pen(Color.Red, 3)
                };

                routes.Routes.Add(r);
            }
            else
            {
                for (int i = 0; i < points.Count; i++)
                {

                    var route = GoogleMapProvider.Instance.GetRoute(points[path[i]], points[path[i + 1]], false, false, 14);
                    var r = new GMapRoute(route.Points, "My Short Path Points")
                    {
                        Stroke = new Pen(Color.Red, 3)
                    };

                    routes.Routes.Add(r);
                }

            }


            map2.Overlays.Add(routes);
            pathLabel.Text = "En kısa yol: ";

            for (int i = 0; i < points.Count; i++)
            {
                pathLabel.Text += points[path[i]] + "\n";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;

            FirebaseResponse res = client.Get(@"KargoBilgileri");
            Dictionary<string, Kargo_Bilgileri> data = JsonConvert.DeserializeObject<Dictionary<string, Kargo_Bilgileri>>(res.Body.ToString());
           
            foreach (var item in data)
            {
                if (sayac % 10 == 0 && sayac!=0)
                {
                    if (map2Points != null && i < map2Points.Count)
                    {   
                        if (item.Value.latitude == map2Points[path[i]].Lat &&
                            item.Value.longitude == map2Points[path[i]].Lng)
                        {
                            item.Value.kargoDurum = true;
                            
                            Kargo_Bilgileri kargoBilgileri = new Kargo_Bilgileri()
                            {
                                ID = item.Value.ID,
                                FullName = item.Value.FullName,
                                Adres = item.Value.Adres,
                                kargoDurum = item.Value.kargoDurum,
                                latitude = item.Value.latitude,
                                longitude = item.Value.longitude,
                            };
                            FirebaseResponse set = client.Update(@"KargoBilgileri/" + item.Value.ID, kargoBilgileri);
                        }
                    }
                    if(map2Points.Count == 2)
                    {
                        if (item.Value.latitude == map2Points[path[1]].Lat &&
                            item.Value.longitude == map2Points[path[1]].Lng)
                        {
                            Console.WriteLine("kontrol");
                            item.Value.kargoDurum = true;

                            Kargo_Bilgileri kargoBilgileri = new Kargo_Bilgileri()
                            {
                                ID = item.Value.ID,
                                FullName = item.Value.FullName,
                                Adres = item.Value.Adres,
                                kargoDurum = item.Value.kargoDurum,
                                latitude = item.Value.latitude,
                                longitude = item.Value.longitude,
                            };
                            FirebaseResponse set = client.Update(@"KargoBilgileri/" + item.Value.ID, kargoBilgileri);
                        }
                    }
                }
            }
            if (sayac % 10 == 0)
                i++;

            if (i == map2Points.Count)
                timer1.Dispose();
        }
    }
}
