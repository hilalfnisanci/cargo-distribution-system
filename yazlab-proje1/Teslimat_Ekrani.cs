using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GoogleMaps.LocationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazlab_proje1
{
    
    public partial class Teslimat_Ekrani : Form
    {

        public List<PointLatLng> points = new List<PointLatLng>();
        public int IDNumber;
        public static int sayac ;
        Map_Ekrani map2 = new Map_Ekrani();

        public Teslimat_Ekrani()
        {
            InitializeComponent();
            adresPaneli.Visible = true;
            
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "fW9XmyFHISjhXYvmzTvcgbqDm2XW7YvqXGxdZz38",
            BasePath = "https://yazlab1-92c44-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void Teslimat_Ekrani_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
                dataCall();
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void map_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyCOzizXBIp-X3KMZ5TEwijwHa_7kv6DEcw";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache";
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.ShowCenter = false;
            map.Position = new PointLatLng(40.7750, 29.9480);

            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;
        }

        private void LoadLocationToMap(PointLatLng point)
        {
            map.Position = point;
        }

        private void btnAddressPage_Click(object sender, EventArgs e)
        {
            durumPanel.Visible = false;
            adresPaneli.Visible = true;
        }

        private void btnDurumPage_Click(object sender, EventArgs e)
        {
            adresPaneli.Visible = false;
            durumPanel.Visible = true;
            dataCall();
            sayac = 0;

        }

        private void map_MouseClick(object sender, MouseEventArgs e) 
        {
            if (!(string.IsNullOrWhiteSpace(txtAdSoyad.Text)))
            {
                if (e.Button == MouseButtons.Right)
                {
                    
                    map2.Update();
                    var point = map.FromLocalToLatLng(e.X, e.Y);

                    double lat = point.Lat;
                    double lng = point.Lng;

                    points.Add(new PointLatLng(lat, lng));

                    //Load location
                    LoadLocationToMap(point);

                    //Adding markers
                    AddMarker(points);

                    //Get Address
                    var addresses = GetAddress(point);
                    int sayac = 0;

                    if (addresses == null)
                        MessageBox.Show("Unable to load address");
                    else
                    {
                        Console.WriteLine(sayac + " - " + addresses[0]);
                        sayac++;
                    }
                    ///// veri tabanına enlem boylam ekleme
                    ///

                    Random rastgele = new Random();
                    int IDNumber = rastgele.Next();

                    Kargo_Bilgileri kargoBilgileri = new Kargo_Bilgileri()
                    {
                        ID = IDNumber,
                        FullName = txtAdSoyad.Text,
                        Adres = addresses[0].ToString(),
                        latitude = lat,
                        longitude = lng,
                        kargoDurum = false,

                    };

                    SetResponse set = client.Set(@"KargoBilgileri/" + IDNumber, kargoBilgileri);

                    MessageBox.Show("başarıyla eklendi");
                }
            }
            else
            {
                MessageBox.Show("Lütfen adınızı ve soyadınızı girin!");

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                Id_text.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                ad_soyad_text.Text = dataGridView1.Rows[e.RowIndex].Cells["AD SOYAD"].FormattedValue.ToString();
                adres_text.Text = dataGridView1.Rows[e.RowIndex].Cells["ADRES"].FormattedValue.ToString();
                durum_text.Text = dataGridView1.Rows[e.RowIndex].Cells["DURUM"].FormattedValue.ToString();
            }
        }

        private void AddMarker(List<PointLatLng> points, GMarkerGoogleType markerType = GMarkerGoogleType.arrow)
        {
            var markers = new GMapOverlay("markers");

            foreach (var Point in points)
            {
                var marker = new GMarkerGoogle(Point, markerType);
                markers.Markers.Add(marker);
            }

            map.Overlays.Add(markers);
        }

        private List<String> GetAddress(PointLatLng point)
        {
            List<Placemark> placemarks;

            List<String> addresses = new List<string>();
            GeoCoderStatusCode statusCode;
            statusCode = GMapProviders.GoogleMap.GetPlacemarks(point, out placemarks);

            if (statusCode == GeoCoderStatusCode.OK && placemarks != null)
            {
                foreach (var placemark in placemarks)
                {
                    addresses.Add(placemark.Address);
                }
                return addresses;
            }
            return null;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            
            #region
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) &&
                string.IsNullOrWhiteSpace(lng_textBox.Text)) MessageBox.Show("boşlukları doldurun.");
            #endregion

            Random rastgele = new Random();
            int IDNumber = rastgele.Next();
            Kargo_Bilgileri kargoBilgileri = new Kargo_Bilgileri()
            {
                ID = IDNumber,
                FullName = txtAdSoyad.Text,
                Adres = lng_textBox.Text,
                kargoDurum = false,
            };

            SetResponse set = client.Set(@"KargoBilgileri/" + IDNumber, kargoBilgileri);
            Kargo_Bilgileri kargoData = set.ResultAs<Kargo_Bilgileri>();
            MessageBox.Show(kargoData.ID + " / " + kargoData.FullName + " / " + kargoData.Adres);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrWhiteSpace(Id_text.Text) &&
                !string.IsNullOrWhiteSpace(ad_soyad_text.Text) &&
                !string.IsNullOrWhiteSpace(adres_text.Text) &&
                !string.IsNullOrWhiteSpace(durum_text.Text))
            {
                FirebaseResponse res = client.Get(@"KargoBilgileri/" + Id_text.Text);
                Kargo_Bilgileri resKargo = res.ResultAs<Kargo_Bilgileri>();
                Kargo_Bilgileri kargoBilgileri = new Kargo_Bilgileri()
                {
                    ID = int.Parse(Id_text.Text),
                    FullName = ad_soyad_text.Text,
                    Adres = adres_text.Text,
                    kargoDurum = bool.Parse(durum_text.Text),
                    latitude = resKargo.latitude,
                    longitude = resKargo.longitude,
                };

                FirebaseResponse set = client.Update(@"KargoBilgileri/" + Id_text.Text, kargoBilgileri);
                MessageBox.Show("başarıyla güncellendi");
                Id_text.Text = string.Empty;
                ad_soyad_text.Text = string.Empty;
                adres_text.Text = string.Empty;
                durum_text.Text = string.Empty;

                dataCall();
            } else
            {
                MessageBox.Show("Boşlukları doldurun.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FirebaseResponse set = client.Delete(@"KargoBilgileri/" + Id_text.Text);
            MessageBox.Show("başarıyla silindi");
            dataCall();
        }

        private double[] GetLocation(String address)
        {

            var locationService = new GoogleLocationService();
            var point = locationService.GetLatLongFromAddress(address);
            double[] pointLoc = new double[2];

            var lat = point.Latitude;
            var lng = point.Longitude;
            pointLoc[0] = lat;
            pointLoc[1] = lng;

            return pointLoc;
        }
        
        async void dataCall()
        {
            FirebaseResponse res = await client.GetAsync(@"KargoBilgileri");
            Dictionary<string, Kargo_Bilgileri> data = JsonConvert.DeserializeObject<Dictionary<string, Kargo_Bilgileri>>(res.Body.ToString());
            gridAyari(data);

        }

        void gridAyari(Dictionary<string, Kargo_Bilgileri> record)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.ReadOnly = true; // sadece okunabilir olması yani veri düzenleme kapalı
            dataGridView1.AllowUserToDeleteRows = false; // satırların silinmesi engelleniyor
            //dataGridView1.ColumnCount = 4; //Kaç kolon olacağı belirleniyor…
            dataGridView1.Columns.Add("ID", "ID");//Kolonların adı belirleniyor
            dataGridView1.Columns.Add("AD SOYAD", "AD SOYAD");
            dataGridView1.Columns.Add("ADRES", "ADRES");
            dataGridView1.Columns.Add("DURUM", "DURUM");

            dataGridView1.Columns[0].Width = 80; //belirlenen kolonların genişliği ayarlanıyor
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 235;
            dataGridView1.Columns[3].Width = 100;

            foreach (var item in record)
            {
                dataGridView1.Rows.Add(item.Key, item.Value.FullName, item.Value.Adres, item.Value.kargoDurum);
            }
        }
    }
}
