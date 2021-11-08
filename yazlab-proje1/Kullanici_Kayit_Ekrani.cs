using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazlab_proje1
{
    public partial class Kullanici_Kayit_Ekrani : Form
    {
        Giris_Ekrani loginPage = new Giris_Ekrani();

        public Kullanici_Kayit_Ekrani()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "fW9XmyFHISjhXYvmzTvcgbqDm2XW7YvqXGxdZz38",
            BasePath = "https://yazlab1-92c44-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void Kullanici_Kayit_Ekrani_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kaydolButton_Click(object sender, EventArgs e)
        {
            #region
            if (string.IsNullOrWhiteSpace(adTextBox.Text) &&
                string.IsNullOrWhiteSpace(soyadTextBox.Text) &&
                string.IsNullOrWhiteSpace(kullaniciAdiTextBox.Text) &&
                string.IsNullOrWhiteSpace(sifreTextBox.Text) &&
                string.IsNullOrWhiteSpace(tekrarSifreTextBox.Text)) MessageBox.Show("boşlukları doldurun.");
            #endregion
            Random rastgele = new Random();
            int IDNumber = rastgele.Next();

            MyUser user = new MyUser()
            {
                ID = IDNumber,
                Name = adTextBox.Text,
                FullName = soyadTextBox.Text,
                UserName = kullaniciAdiTextBox.Text,
                Password = sifreTextBox.Text
            };
            SetResponse set = client.Set(@"Users/" + kullaniciAdiTextBox.Text, user);
            messageLabel.Text = "Kayıt Başarılı!";
            
            this.Close();
        }
    }
}
