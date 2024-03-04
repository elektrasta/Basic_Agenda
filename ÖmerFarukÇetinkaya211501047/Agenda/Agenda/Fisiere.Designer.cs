namespace Agenda
{
    partial class Fisiere
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_agenda = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyalarim = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.yardim = new System.Windows.Forms.ToolStripMenuItem();
            this.cikis = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.upload = new System.Windows.Forms.Button();
            this.download = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.share = new System.Windows.Forms.Button();
            this.download_erisimdsy = new System.Windows.Forms.Button();
            this.upl_revizyon = new System.Windows.Forms.Button();
            this.rem_access = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1263, 30);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_agenda
            // 
            this.menu_agenda.Name = "menu_agenda";
            this.menu_agenda.Size = new System.Drawing.Size(70, 26);
            this.menu_agenda.Text = "Ajanda";
            this.menu_agenda.Click += new System.EventHandler(this.menu_agenda_click);
            // 
            // dosyalarim
            // 
            this.dosyalarim.Name = "dosyalarim";
            this.dosyalarim.Size = new System.Drawing.Size(98, 26);
            this.dosyalarim.Text = "Dosyalarım";
            this.dosyalarim.Click += new System.EventHandler(this.dosyalarim_Click);
            // 
            // hakkinda
            // 
            this.hakkinda.Name = "hakkinda";
            this.hakkinda.Size = new System.Drawing.Size(85, 26);
            this.hakkinda.Text = "Hakkında";
            this.hakkinda.Click += new System.EventHandler(this.hakkinda_Click);
            // 
            // yardim
            // 
            this.yardim.Name = "yardim";
            this.yardim.Size = new System.Drawing.Size(69, 26);
            this.yardim.Text = "Yardım";
            this.yardim.Click += new System.EventHandler(this.yardim_Click);
            // 
            // cikis
            // 
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(53, 26);
            this.cikis.Text = "Çıkış";
            this.cikis.Click += new System.EventHandler(this.meniu_iesire_click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 102);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(536, 452);
            this.dataGridView.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(209, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kendi dosyalarım:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(608, 102);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(639, 452);
            this.dataGridView1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(823, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Erişimin alındığı dosyalar:";
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(16, 66);
            this.upload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(100, 28);
            this.upload.TabIndex = 21;
            this.upload.Text = "Yükle";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(148, 66);
            this.download.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(100, 28);
            this.download.TabIndex = 22;
            this.download.Text = "İndir";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(293, 66);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 28);
            this.delete.TabIndex = 23;
            this.delete.Text = "Sil";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // share
            // 
            this.share.Location = new System.Drawing.Point(435, 66);
            this.share.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.share.Name = "share";
            this.share.Size = new System.Drawing.Size(100, 28);
            this.share.TabIndex = 24;
            this.share.Text = "Paylaş";
            this.share.UseVisualStyleBackColor = true;
            this.share.Click += new System.EventHandler(this.share_Click);
            // 
            // download_erisimdsy
            // 
            this.download_erisimdsy.Location = new System.Drawing.Point(653, 66);
            this.download_erisimdsy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.download_erisimdsy.Name = "download_erisimdsy";
            this.download_erisimdsy.Size = new System.Drawing.Size(100, 28);
            this.download_erisimdsy.TabIndex = 25;
            this.download_erisimdsy.Text = "İndir";
            this.download_erisimdsy.UseVisualStyleBackColor = true;
            this.download_erisimdsy.Click += new System.EventHandler(this.download_erisimdsy_Click);
            // 
            // upl_revizyon
            // 
            this.upl_revizyon.Location = new System.Drawing.Point(856, 66);
            this.upl_revizyon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.upl_revizyon.Name = "upl_revizyon";
            this.upl_revizyon.Size = new System.Drawing.Size(153, 28);
            this.upl_revizyon.TabIndex = 26;
            this.upl_revizyon.Text = "Revizyonu Yükle";
            this.upl_revizyon.UseVisualStyleBackColor = true;
            this.upl_revizyon.Click += new System.EventHandler(this.upload_revision_click);
            // 
            // rem_access
            // 
            this.rem_access.Location = new System.Drawing.Point(1079, 66);
            this.rem_access.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rem_access.Name = "rem_access";
            this.rem_access.Size = new System.Drawing.Size(140, 28);
            this.rem_access.TabIndex = 27;
            this.rem_access.Text = "Erişimi Kaldır";
            this.rem_access.UseVisualStyleBackColor = true;
            this.rem_access.Click += new System.EventHandler(this.rem_access_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Fisiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 569);
            this.Controls.Add(this.rem_access);
            this.Controls.Add(this.upl_revizyon);
            this.Controls.Add(this.download_erisimdsy);
            this.Controls.Add(this.share);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.download);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Fisiere";
            this.Text = "Dosyalar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_agenda;
        private System.Windows.Forms.ToolStripMenuItem dosyalarim;
        private System.Windows.Forms.ToolStripMenuItem hakkinda;
        private System.Windows.Forms.ToolStripMenuItem cikis;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button share;
        private System.Windows.Forms.Button download_erisimdsy;
        private System.Windows.Forms.Button upl_revizyon;
        private System.Windows.Forms.Button rem_access;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem yardim;
    }
}