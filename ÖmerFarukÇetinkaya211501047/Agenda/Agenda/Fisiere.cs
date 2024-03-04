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
using CrossCutting;

namespace Agenda
{
    public partial class Fisiere : Form
    {
        string filename = "";//kullanıcının seçtiği dosyanın adını tutar
        public Fisiere()//sınıf oluşturulduğunda çalıştırılır ve form nesnesini oluşturur
        {
            InitializeComponent(); //Windows Forms tasarım arayüzündeki bileşenleri yükler
            ManageFisiere.get_dvs();//veritabanından dosya verilerini alır
            show_gridviewData();//kullanıcıya gösterir
        }

        private void show_gridviewData()
        {//dataGridView ve dataGridView1 biririne bağlar

            dataGridView.DataSource = ManageFisiere.dv_fisiere_proprii;//doldurur
            dataGridView1.DataSource = ManageFisiere.dv_fisiere_externe;//doldurur
        }

        private void restart_window()
        {//yeniden başlatır dosyalarım ekranını
            this.Visible = false;
            Fisiere a = new Fisiere();
            a.ShowDialog();
            this.Close();//ekranı kapatır
        }

        private void menu_agenda_click(object sender, EventArgs e)
        {//ajanda menüsünü getirir
            //restart_window();
            this.Visible = false;
            agenda a = new agenda();
            a.ShowDialog();
            this.Close();
        }

        private void dosyalarim_Click(object sender, EventArgs e)
        {//dosyalarım menüsünü getirir
            //this.Visible = false;
            //Fisiere a = new Fisiere();
            //a.ShowDialog();
            //this.Close();
            //Face ceva??
        }


        private void meniu_iesire_click(object sender, EventArgs e)
        {//çıkış yapar
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


        private void upload_Click(object sender, EventArgs e)
        {//bir dosya seçme penceresi açılır
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)//seçtiysek
            {
                filename = ofd.FileName;
                //açılış, şifreleme ve dosya depolama için iş katmanını arıcaz
                ManageFisiere.upload_fisier(filename);//dosyayı şifreler
                restart_window();//günceller
            }
            else filename = "";//kapatırsak bir şey seçmeden boş olarak olur
        }

        private void upload_revision_click(object sender, EventArgs e)
        {
            //revizyon yüklemesi yapar sunucuya yükler  
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
             if (selectedRowCount == 1)//seçili satır varsa
             {
                        OpenFileDialog ofd = new OpenFileDialog();
                        DialogResult dr = ofd.ShowDialog();

                        if (dr == DialogResult.OK)
                        {
                            int index = dataGridView1.CurrentRow.Index;
                            filename = ofd.FileName;
                    //açılış, şifreleme ve dosya depolama için iş katmanını arıcaz
                    ManageFisiere.upload_revision(index,filename);//şifreler ve sunucuya yükler
                            restart_window();
                        }
                        else filename = "";//seçilmemişse boş olur
             }
             else MessageBox.Show("Herhangi bir girdi seçmediniz.");//hata mesajı
        }

        private void share_Click(object sender, EventArgs e)
        {
         //paylaşma
            Int32 selectedRowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)//seçili olan dosya varmı
            {
                string fisier =dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                ManageFisiere.set_fis_selectat(fisier);//depolar
                Share s = new Share();
                s.ShowDialog();
                restart_window();//formu yeniler
            }
            else MessageBox.Show("Herhangi bir girdi seçmediniz.");
        }
        
private void download_Click(object sender, EventArgs e)
         {//indirme
             Int32 selectedRowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
             if (selectedRowCount == 1)//seçilen satır 1 se 
             {
                 SaveFileDialog saveFileDialog1 = new SaveFileDialog();
 
                 saveFileDialog1.RestoreDirectory = true;//nereye kaydedicez kutusu gelir
 
                 if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                 {
                     int index = dataGridView.CurrentRow.Index;
                     bool ok = ManageFisiere.download(index,saveFileDialog1.FileName);//indirir
 
                     MessageBox.Show("Dosya başarıyla indirildi!");
                     //restart_window();
                 }
             }
             else MessageBox.Show("Herhangi bir girdi seçmediniz.");
         }
 
         private void download_erisimdsy_Click(object sender, EventArgs e)
         {//indirme
             Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
             if (selectedRowCount == 1)//seçilen satır 1 se 
            {
                 SaveFileDialog saveFileDialog1 = new SaveFileDialog();
 
                 saveFileDialog1.RestoreDirectory = true;//nereye indiricez onu gösterir
 
                 if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                 {
                     int index = dataGridView1.CurrentRow.Index;
                     bool ok = ManageFisiere.download_ext(index, saveFileDialog1.FileName);//indirir
 
                     MessageBox.Show("Dosya başarıyla indirildi!");
                     //restart_window();
                 }
             }
             else MessageBox.Show("Herhangi bir girdi seçmediniz.");
         }

         private void delete_Click(object sender, EventArgs e)
         {//siler
             Int32 selectedRowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
             
             if (selectedRowCount == 1)//seçilen satır 1 se 
            {
                 string fisier = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                 int index = dataGridView.CurrentRow.Index;
                 ManageFisiere.del_fis_selectat(fisier,index);//siler
                 //Share s = new Share();
                 //s.ShowDialog();
                 restart_window();
             }
             else MessageBox.Show("Herhangi bir girdi seçmediniz.");
        }

        private void rem_access_Click(object sender, EventArgs e)
        {//erişimi kaybetmeye yarar
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)//seçilen satır 1 se 
            {
                string fisier = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                ManageFisiere.remove_access(fisier);//erişimi kaybet
                restart_window();
            }
            else MessageBox.Show("Herhangi bir girdi seçmediniz.");
        }

        private void hakkinda_Click(object sender, EventArgs e)
        {
            Despre d = new Despre();
            d.ShowDialog();
        }

        private void yardim_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();
        }
    }
}
