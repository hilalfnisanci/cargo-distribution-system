using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace yazlab_proje1
{
    public partial class Sifre_Degistir : Form
    {
        public Sifre_Degistir()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "fW9XmyFHISjhXYvmzTvcgbqDm2XW7YvqXGxdZz38",
            BasePath = "https://yazlab1-92c44-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        private void Sifre_Degistir_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            #region
            if (
                string.IsNullOrWhiteSpace(username_textbox.Text) &&
                string.IsNullOrWhiteSpace(eskiSifre_textbox.Text) &&
                string.IsNullOrWhiteSpace(yeniSifre_textbox.Text) &&
                string.IsNullOrWhiteSpace(yeniSifreTekrar_textbox.Text))
            {
                MessageBox.Show("boşlukları doldurun.");
                
            }

            #endregion
            FirebaseResponse res = client.Get(@"Users/" + username_textbox.Text);
            MyUser resUser = res.ResultAs<MyUser>();
            MyUser curUser = new MyUser()
            {
                UserName = username_textbox.Text,
                Password = eskiSifre_textbox.Text,
            };

            if (MyUser.IsEqual(resUser, curUser))
            {
                if(yeniSifre_textbox.Text == yeniSifreTekrar_textbox.Text)
                {
                    MyUser newSifre = new MyUser()
                    {
                        ID = resUser.ID,
                        Name = resUser.Name,
                        FullName = resUser.FullName,
                        UserName = resUser.UserName,
                        Password = yeniSifre_textbox.Text,
                    };
                    FirebaseResponse set = client.Update(@"Users/" + resUser.UserName, newSifre);
                    MessageBox.Show("Başarıyla şifre güncellendi");
                } else
                {
                    MessageBox.Show("şifreler aynı olmalıdır");
                }
               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}