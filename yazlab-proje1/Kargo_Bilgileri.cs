using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazlab_proje1
{
    public class Kargo_Bilgileri
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Adres { get; set; }
        public bool kargoDurum { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
    }
}
