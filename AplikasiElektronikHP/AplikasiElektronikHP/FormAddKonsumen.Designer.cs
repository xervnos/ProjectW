namespace AplikasiElektronikHP
{
    partial class FormAddKonsumen
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cb_jk = new System.Windows.Forms.ComboBox();
            this.tb_alamat = new System.Windows.Forms.TextBox();
            this.tb_nik = new System.Windows.Forms.MaskedTextBox();
            this.tb_norumah = new System.Windows.Forms.MaskedTextBox();
            this.tb_nohp = new System.Windows.Forms.MaskedTextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAMA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TGL LAHIR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "JENIS KELAMIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "NO RUMAH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "NO HP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "ALAMAT SAAT INI";
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(102, 60);
            this.tb_nama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(151, 20);
            this.tb_nama.TabIndex = 8;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(102, 99);
            this.date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(151, 20);
            this.date.TabIndex = 9;
            // 
            // cb_jk
            // 
            this.cb_jk.FormattingEnabled = true;
            this.cb_jk.Items.AddRange(new object[] {
            "LAKI-LAKI",
            "PEREMPUAN"});
            this.cb_jk.Location = new System.Drawing.Point(102, 147);
            this.cb_jk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_jk.Name = "cb_jk";
            this.cb_jk.Size = new System.Drawing.Size(151, 24);
            this.cb_jk.TabIndex = 10;
            // 
            // tb_alamat
            // 
            this.tb_alamat.Location = new System.Drawing.Point(381, 13);
            this.tb_alamat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_alamat.Multiline = true;
            this.tb_alamat.Name = "tb_alamat";
            this.tb_alamat.Size = new System.Drawing.Size(151, 66);
            this.tb_alamat.TabIndex = 11;
            // 
            // tb_nik
            // 
            this.tb_nik.Location = new System.Drawing.Point(102, 16);
            this.tb_nik.Mask = "00-00-00-000000-0000";
            this.tb_nik.Name = "tb_nik";
            this.tb_nik.Size = new System.Drawing.Size(151, 20);
            this.tb_nik.TabIndex = 14;
            // 
            // tb_norumah
            // 
            this.tb_norumah.Location = new System.Drawing.Point(381, 103);
            this.tb_norumah.Mask = "0000-0000000";
            this.tb_norumah.Name = "tb_norumah";
            this.tb_norumah.Size = new System.Drawing.Size(151, 20);
            this.tb_norumah.TabIndex = 15;
            // 
            // tb_nohp
            // 
            this.tb_nohp.Location = new System.Drawing.Point(381, 147);
            this.tb_nohp.Mask = "0000-0000-0000";
            this.tb_nohp.Name = "tb_nohp";
            this.tb_nohp.Size = new System.Drawing.Size(151, 20);
            this.tb_nohp.TabIndex = 16;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(457, 194);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 42);
            this.btn_ok.TabIndex = 17;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // FormAddKonsumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 257);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tb_nohp);
            this.Controls.Add(this.tb_norumah);
            this.Controls.Add(this.tb_nik);
            this.Controls.Add(this.tb_alamat);
            this.Controls.Add(this.cb_jk);
            this.Controls.Add(this.date);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddKonsumen";
            this.Text = "TAMBAH DATA KONSUMEN";
            this.Load += new System.EventHandler(this.FormAddKonsumen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox cb_jk;
        private System.Windows.Forms.TextBox tb_alamat;
        private System.Windows.Forms.MaskedTextBox tb_nik;
        private System.Windows.Forms.MaskedTextBox tb_norumah;
        private System.Windows.Forms.MaskedTextBox tb_nohp;
        private System.Windows.Forms.Button btn_ok;
    }
}