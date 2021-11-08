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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazlab_proje1
{
    public partial class Giris_Ekrani : Form
    {
        Teslimat_Ekrani teslimat_Ekrani = new Teslimat_Ekrani();
        Map_Ekrani map_ekrani = new Map_Ekrani();

        public Giris_Ekrani()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "fW9XmyFHISjhXYvmzTvcgbqDm2XW7YvqXGxdZz38",
            BasePath = "https://yazlab1-92c44-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void Giris_Ekrani_Load(object sender, EventArgs e)
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

        private void girisButton_Click(object sender, EventArgs e) 
        {
            #region
            if (
                string.IsNullOrWhiteSpace(usernameTextBox.Text) &&
                string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("boşlukları doldurun.");
                return;
            }
            #endregion

            FirebaseResponse res = client.Get(@"Users/" + usernameTextBox.Text);
            MyUser resUser = res.ResultAs<MyUser>();
            MyUser curUser = new MyUser()
            {
                UserName = usernameTextBox.Text,
                Password = passwordTextBox.Text
            };

            if (MyUser.IsEqual(resUser, curUser))
            {
                teslimat_Ekrani.Show();
                map_ekrani.Show();
            }
            else
            {
                MyUser.ShowError();
            }
        }


        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void kayitOlButton_Click(object sender, EventArgs e)
        {
            Kullanici_Kayit_Ekrani kayit_form = new Kullanici_Kayit_Ekrani();
            kayit_form.Show();
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            Sifre_Degistir sifre_degistir = new Sifre_Degistir();
            sifre_degistir.Show();
        }
    }
}
