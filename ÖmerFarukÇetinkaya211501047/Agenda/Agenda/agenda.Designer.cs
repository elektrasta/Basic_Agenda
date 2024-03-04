namespace Agenda
{
    partial class agenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btn_kayitekle = new System.Windows.Forms.Button();
            this.lbl_ora = new System.Windows.Forms.Label();
            this.lbl_minut = new System.Windows.Forms.Label();
            this.tb_icerik = new System.Windows.Forms.RichTextBox();
            this.tb_baslik = new System.Windows.Forms.TextBox();
            this.lbl_titlu = new System.Windows.Forms.Label();
            this.tb_saat = new System.Windows.Forms.ComboBox();
            this.cb_dakika = new System.Windows.Forms.ComboBox();
            this.lbl_Detalii = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_kayitdegistir = new System.Windows.Forms.Button();
            this.btn_kayitsil = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_agenda = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyalarim = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.yardim = new System.Windows.Forms.ToolStripMenuItem();
            this.cikis = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar.Location = new System.Drawing.Point(711, 402);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowWeekNumbers = true;
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // btn_kayitekle
            // 
            this.btn_kayitekle.Location = new System.Drawing.Point(89, 84);
            this.btn_kayitekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kayitekle.Name = "btn_kayitekle";
            this.btn_kayitekle.Size = new System.Drawing.Size(160, 28);
            this.btn_kayitekle.TabIndex = 1;
            this.btn_kayitekle.Text = "Kayıt Ekle";
            this.btn_kayitekle.UseVisualStyleBackColor = true;
            this.btn_kayitekle.Click += new System.EventHandler(this.btn_kayitekle_click);
            // 
            // lbl_ora
            // 
            this.lbl_ora.AutoSize = true;
            this.lbl_ora.Location = new System.Drawing.Point(86, 592);
            this.lbl_ora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ora.Name = "lbl_ora";
            this.lbl_ora.Size = new System.Drawing.Size(41, 17);
            this.lbl_ora.TabIndex = 4;
            this.lbl_ora.Text = "Saat:";
            // 
            // lbl_minut
            // 
            this.lbl_minut.AutoSize = true;
            this.lbl_minut.Location = new System.Drawing.Point(343, 592);
            this.lbl_minut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_minut.Name = "lbl_minut";
            this.lbl_minut.Size = new System.Drawing.Size(55, 17);
            this.lbl_minut.TabIndex = 5;
            this.lbl_minut.Text = "Dakika:";
            // 
            // tb_icerik
            // 
            this.tb_icerik.Location = new System.Drawing.Point(89, 443);
            this.tb_icerik.Margin = new System.Windows.Forms.Padding(4);
            this.tb_icerik.MaxLength = 1000;
            this.tb_icerik.Name = "tb_icerik";
            this.tb_icerik.Size = new System.Drawing.Size(606, 117);
            this.tb_icerik.TabIndex = 6;
            this.tb_icerik.Text = "";
            // 
            // tb_baslik
            // 
            this.tb_baslik.Location = new System.Drawing.Point(89, 406);
            this.tb_baslik.Margin = new System.Windows.Forms.Padding(4);
            this.tb_baslik.MaxLength = 50;
            this.tb_baslik.Name = "tb_baslik";
            this.tb_baslik.Size = new System.Drawing.Size(606, 22);
            this.tb_baslik.TabIndex = 7;
            // 
            // lbl_titlu
            // 
            this.lbl_titlu.AutoSize = true;
            this.lbl_titlu.Location = new System.Drawing.Point(42, 411);
            this.lbl_titlu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titlu.Name = "lbl_titlu";
            this.lbl_titlu.Size = new System.Drawing.Size(49, 17);
            this.lbl_titlu.TabIndex = 8;
            this.lbl_titlu.Text = "Başlık:";
            // 
            // tb_saat
            // 
            this.tb_saat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_saat.FormattingEnabled = true;
            this.tb_saat.Location = new System.Drawing.Point(135, 589);
            this.tb_saat.Margin = new System.Windows.Forms.Padding(4);
            this.tb_saat.Name = "tb_saat";
            this.tb_saat.Size = new System.Drawing.Size(64, 24);
            this.tb_saat.Sorted = true;
            this.tb_saat.TabIndex = 9;
            // 
            // cb_dakika
            // 
            this.cb_dakika.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dakika.FormattingEnabled = true;
            this.cb_dakika.Location = new System.Drawing.Point(406, 592);
            this.cb_dakika.Margin = new System.Windows.Forms.Padding(4);
            this.cb_dakika.Name = "cb_dakika";
            this.cb_dakika.Size = new System.Drawing.Size(64, 24);
            this.cb_dakika.TabIndex = 10;
            // 
            // lbl_Detalii
            // 
            this.lbl_Detalii.AutoSize = true;
            this.lbl_Detalii.Location = new System.Drawing.Point(30, 446);
            this.lbl_Detalii.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Detalii.Name = "lbl_Detalii";
            this.lbl_Detalii.Size = new System.Drawing.Size(45, 17);
            this.lbl_Detalii.TabIndex = 11;
            this.lbl_Detalii.Text = "İçerik:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(428, 62);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(863, 310);
            this.dataGridView.TabIndex = 12;
            // 
            // btn_kayitdegistir
            // 
            this.btn_kayitdegistir.Location = new System.Drawing.Point(89, 135);
            this.btn_kayitdegistir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kayitdegistir.Name = "btn_kayitdegistir";
            this.btn_kayitdegistir.Size = new System.Drawing.Size(160, 28);
            this.btn_kayitdegistir.TabIndex = 13;
            this.btn_kayitdegistir.Text = "Kaydı Değiştir";
            this.btn_kayitdegistir.UseVisualStyleBackColor = true;
            this.btn_kayitdegistir.Click += new System.EventHandler(this.btn_kayitdegistir_Click);
            // 
            // btn_kayitsil
            // 
            this.btn_kayitsil.Location = new System.Drawing.Point(89, 184);
            this.btn_kayitsil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kayitsil.Name = "btn_kayitsil";
            this.btn_kayitsil.Size = new System.Drawing.Size(160, 28);
            this.btn_kayitsil.TabIndex = 14;
            this.btn_kayitsil.Text = "Kaydı Sil";
            this.btn_kayitsil.UseVisualStyleBackColor = true;
            this.btn_kayitsil.Click += new System.EventHandler(this.btn_kayitsil_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_agenda,
            this.dosyalarim,
            this.hakkinda,
            this.yardim,
            this.cikis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1338, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_agenda
            // 
            this.menu_agenda.Name = "menu_agenda";
            this.menu_agenda.Size = new System.Drawing.Size(70, 24);
            this.menu_agenda.Text = "Ajanda";
            this.menu_agenda.Click += new System.EventHandler(this.menu_agenda_click);
            // 
            // dosyalarim
            // 
            this.dosyalarim.Name = "dosyalarim";
            this.dosyalarim.Size = new System.Drawing.Size(98, 24);
            this.dosyalarim.Text = "Dosyalarım";
            this.dosyalarim.Click += new System.EventHandler(this.dosyalarim_Click);
            // 
            // hakkinda
            // 
            this.hakkinda.Name = "hakkinda";
            this.hakkinda.Size = new System.Drawing.Size(85, 24);
            this.hakkinda.Text = "Hakkında";
            this.hakkinda.Click += new System.EventHandler(this.hakkinda_Click);
            // 
            // yardim
            // 
            this.yardim.Name = "yardim";
            this.yardim.Size = new System.Drawing.Size(69, 24);
            this.yardim.Text = "Yardım";
            this.yardim.Click += new System.EventHandler(this.yardim_Click);
            // 
            // cikis
            // 
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(53, 24);
            this.cikis.Text = "Çıkış";
            this.cikis.Click += new System.EventHandler(this.meniu_iesire_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(754, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ajandaya girişler:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 238);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Değişikliği Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 291);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 28);
            this.button2.TabIndex = 18;
            this.button2.Text = "Değişikliği iptal Et";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(684, 74);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(320, 185);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.Visible = false;
            // 
            // agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 638);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kayitsil);
            this.Controls.Add(this.btn_kayitdegistir);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lbl_Detalii);
            this.Controls.Add(this.cb_dakika);
            this.Controls.Add(this.tb_saat);
            this.Controls.Add(this.lbl_titlu);
            this.Controls.Add(this.tb_baslik);
            this.Controls.Add(this.tb_icerik);
            this.Controls.Add(this.lbl_minut);
            this.Controls.Add(this.lbl_ora);
            this.Controls.Add(this.btn_kayitekle);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "agenda";
            this.Text = "Elektronik Ajanda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button btn_kayitekle;
        private System.Windows.Forms.Label lbl_ora;
        private System.Windows.Forms.Label lbl_minut;
        private System.Windows.Forms.RichTextBox tb_icerik;
        private System.Windows.Forms.TextBox tb_baslik;
        private System.Windows.Forms.Label lbl_titlu;
        private System.Windows.Forms.ComboBox tb_saat;
        private System.Windows.Forms.ComboBox cb_dakika;
        private System.Windows.Forms.Label lbl_Detalii;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_kayitdegistir;
        private System.Windows.Forms.Button btn_kayitsil;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_agenda;
        private System.Windows.Forms.ToolStripMenuItem dosyalarim;
        private System.Windows.Forms.ToolStripMenuItem hakkinda;
        private System.Windows.Forms.ToolStripMenuItem cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem yardim;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}