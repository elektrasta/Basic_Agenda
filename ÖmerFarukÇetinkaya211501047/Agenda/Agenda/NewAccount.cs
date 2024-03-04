using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLayer;

namespace Agenda
{
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();//metodu çağırdık
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            bool x=ManageUsers.insert(UsernameBox.Text, PasswdBox1.Text, PasswdBox2.Text);//giriş yapar kullanıcı buraya
            if (x == false)//yanlışsa
            {//temizler
                PasswdBox1.Clear();
                PasswdBox2.Clear();
            }
            else//doğruysa ekleme işlemi olur
            {
                this.Visible = false;
                Form1 f = new Form1();
                f.ShowDialog();
                this.Close();//ekran kapanır
            }
        }
    }
}
