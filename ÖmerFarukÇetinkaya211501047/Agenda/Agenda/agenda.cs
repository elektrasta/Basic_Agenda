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
    public partial class agenda : Form
    {
        string[] ore;
        string[] minute;
        bool modif = true;
        public agenda()
        {
            
            InitializeComponent();
            initializare_proprie();
            set_default_values();
            show_calendar_entries();
            button1.Hide();
            button2.Hide();
        }

        private void show_calendar_entries()
        {//tarihin kalın göstermesine neden olur
            
            foreach (DataRow dr in ManageAgenda.intrari_agenda.Rows)
            {
                DateTime ev = Convert.ToDateTime(dr["Data"]);
                
                monthCalendar.AddBoldedDate(ev);

            }
        }

        private void btn_kayitekle_click(object sender, EventArgs e)
        {
            string data = monthCalendar.SelectionRange.Start.ToShortDateString();
            string s2 = monthCalendar.SelectionRange.Start.ToShortTimeString();
            if (String.Compare("", tb_baslik.Text) == 0)
            {//erkler
                MessageBox.Show("Kayda bir başlık koymalısın!");
                return;
            }
            ManageAgenda.add_inregistrare(data, tb_saat.Text, cb_dakika.Text, tb_baslik.Text, tb_icerik.Text);
            restart_window();//formu günceller
        }

        private void initializare_proprie()
        {//form yeniden yüklenirken çalışır
            ore = new string[24];
            for (int i = 0; i < 24; i++)
            {
                if (i < 10) ore[i] += "0";
                ore[i] += Convert.ToString(i);
            }
            tb_saat.DataSource = ore;

            minute = new string[60];
            for (int i = 0; i < 60; i++)
            {
                if (i < 10) minute[i] += "0";
                minute[i] += Convert.ToString(i);
            }
            cb_dakika.DataSource = minute;

            ManageAgenda.get_datatable();
        }

        private void set_default_values()
        {//default olark gelen değerini belirledim
            tb_baslik.Text = "";
            tb_icerik.Text = "";
            tb_saat.Text = "00";
            cb_dakika.Text = "00";

        }

        private void restart_window()
        {
            this.Visible = false;
            agenda a = new agenda();
            a.ShowDialog();
            this.Close();
        }

        private void menu_agenda_click(object sender, EventArgs e)
        {
            restart_window();         
            
        }

        private void dosyalarim_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Fisiere a = new Fisiere();
            a.ShowDialog();
            this.Close();
        }


        private void meniu_iesire_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {    //takvimde gün seçilince olur
            if(modif)//sadece seçilen güne ait kayıtlar gelir
                ManageAgenda.set_rowfilter(e.Start.ToShortDateString());
                        
            dataGridView.DataSource = ManageAgenda.intrari_zilnice2;
            dataGridView1.DataSource = ManageAgenda.intrari_zilnice;
        }

        private void btn_kayitsil_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);//kaç satırın seçildiğini
            if (selectedRowCount == 1)//seçilen satır varsa
            {
                int index2 = dataGridView.CurrentRow.Index;
                int index = Convert.ToInt32(dataGridView1.Rows[index2].Cells[0].Value);
                ManageAgenda.del_inregistrare(index);
                restart_window();//günceller
            }
            else MessageBox.Show("Herhangi bir girdi seçmediniz.");
        }

        private void btn_kayitdegistir_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                button1.Show();//gizli olan butonu gösterir
                button2.Show();//gizli olan butonu gösterir
                int index2 = dataGridView.CurrentRow.Index;
                int index = Convert.ToInt32(dataGridView1.Rows[index2].Cells[0].Value);
                tb_baslik.Text = ManageAgenda.get_titlu(index);
                tb_icerik.Text = ManageAgenda.get_detalii(index);
                modif = false;
                btn_kayitekle.Hide();
                btn_kayitsil.Hide();
                btn_kayitdegistir.Hide();
            }
            else MessageBox.Show("Herhangi bir girdi seçmediniz.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //değişikliği kaydet
            int index2 = dataGridView.CurrentRow.Index;
            int index = Convert.ToInt32(dataGridView1.Rows[index2].Cells[0].Value);
            string data = monthCalendar.SelectionRange.Start.ToShortDateString();
            if (String.Compare("", tb_baslik.Text) == 0)
            {
                MessageBox.Show("Kayda bir başlık koymalısın!");
                return;
            }
            ManageAgenda.update(index, data, tb_saat.Text, cb_dakika.Text, tb_baslik.Text, tb_icerik.Text);
            restart_window();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //değişikliği iptal et
            button1.Hide();
            button2.Hide();
            tb_baslik.Text = "";
            tb_icerik.Text = "";
            modif = true;
            btn_kayitekle.Show();
            btn_kayitsil.Show();
            btn_kayitdegistir.Show();
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

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
