using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;
using System.Diagnostics;

using DatabaseCreate;
using CrossCutting;
using BusinessLayer;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//form nesnesinin bileşenlerini oluşturur
            Init_Database();//veritabanı tabloların kontrolün sağlar
        }

        private void Init_Database()
        {//veritabanı bağlantısını başlatır
            using (var db = new AgendaDBContext())
            {
                IEnumerable<int> id = (from u in db.Users
                                        select u.UserId);
                int max;
                if (id.Count() != 0)
                    max = id.Max();
                else
                {
                    max = 0;
                    DatabaseManagement.set_next_agenda_id(max);
                    IO_on_Db.read_users_table();
                    
                }
                //MessageBox.Show(max.ToString());
                DatabaseManagement.set_next_user_id(max);//kullanıcılar
                id = (from u in db.Agenda
                                         select u.Id);
                if (id.Count() != 0)
                    max = id.Max();//en son ı değerine bakarak yeni ıd değeri belirler
                else
                    max = 0;
                //MessageBox.Show(max.ToString());
                DatabaseManagement.set_next_agenda_id(max);//planlar

                id = from u in db.Fisiere select u.FisierId;
                if (id.Count() != 0)
                    max = id.Max();//en son ı değerine bakarak yeni ıd değeri belirler
                else
                    max = 0;
                DatabaseManagement.set_next_fisier_id(max);//dosyalar
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {//kullanıcının girdiği kullanıcı adı ve şifreyi doğrular
            string username = UsernameBox.Text;
            string passwd = PasswordBox.Text;
            bool x = Login.verify(username, passwd);
            if (x)
            {//eğer doğruysa yeni bir agenda nesnesi oluşturur
                //MessageBox.Show("Succes ");
                //ManageAgenda.get_datatable();
                this.Visible = false;
                agenda a = new agenda();
                a.ShowDialog();
                this.Close();
            }
            else
            {//hatalı giriş sonucu bu mesajı verir
                MessageBox.Show("İsim veya şifre yanlış tekrar deneyin.");
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {//yeni heasap luşturmaya gönderir
            this.Visible = false;
            NewAccount a = new NewAccount();
            a.ShowDialog();
            this.Close();
        }

    }
}
