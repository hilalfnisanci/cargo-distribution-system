using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazlab_proje1
{
    class MyUser
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        private static string error = "error";
        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }

        public static bool IsEqual(MyUser user1, MyUser user2)
        {
            if (user1 == null || user2 == null) { return false; }

            if (user1.UserName != user2.UserName)
            {
                error = "kullanıcı adı uyuşmuyor.";
                return false;
            }

            else if (user1.Password != user2.Password)
            {
                error = "şifre uyuşmuyor.";
                return false;
            }
            return true;
        }

    }
}
