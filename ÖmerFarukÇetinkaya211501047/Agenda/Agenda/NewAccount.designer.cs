namespace Agenda
{
    partial class NewAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswdBox1 = new System.Windows.Forms.TextBox();
            this.PasswdBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(59, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcıadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(59, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(59, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Onayla:";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(127, 235);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(100, 28);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OLUŞTUR";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.UsernameBox.Location = new System.Drawing.Point(188, 49);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(132, 27);
            this.UsernameBox.TabIndex = 4;
            // 
            // PasswdBox1
            // 
            this.PasswdBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.PasswdBox1.Location = new System.Drawing.Point(188, 108);
            this.PasswdBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswdBox1.Name = "PasswdBox1";
            this.PasswdBox1.PasswordChar = '*';
            this.PasswdBox1.Size = new System.Drawing.Size(132, 27);
            this.PasswdBox1.TabIndex = 5;
            // 
            // PasswdBox2
            // 
            this.PasswdBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.PasswdBox2.Location = new System.Drawing.Point(188, 165);
            this.PasswdBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswdBox2.Name = "PasswdBox2";
            this.PasswdBox2.PasswordChar = '*';
            this.PasswdBox2.Size = new System.Drawing.Size(132, 27);
            this.PasswdBox2.TabIndex = 6;
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.PasswdBox2);
            this.Controls.Add(this.PasswdBox1);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewAccount";
            this.Text = "Yeni Hesap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswdBox1;
        private System.Windows.Forms.TextBox PasswdBox2;
    }
}