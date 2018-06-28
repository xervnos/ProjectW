namespace AplikasiElektronikHP
{
    partial class FormKonsumen
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
            this.btn_ubah = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cb_cari = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ubah)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ubah
            // 
            this.btn_ubah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.btn_ubah.Location = new System.Drawing.Point(12, 12);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(669, 272);
            this.btn_ubah.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 2;
            // 
            // cb_cari
            // 
            this.cb_cari.FormattingEnabled = true;
            this.cb_cari.Items.AddRange(new object[] {
            "NAMA",
            "NIK"});
            this.cb_cari.Location = new System.Drawing.Point(6, 15);
            this.cb_cari.Name = "cb_cari";
            this.cb_cari.Size = new System.Drawing.Size(97, 24);
            this.cb_cari.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_cari);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CARI";
            // 
            // btn_prev
            // 
            this.btn_prev.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev.Location = new System.Drawing.Point(244, 290);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(75, 23);
            this.btn_prev.TabIndex = 5;
            this.btn_prev.Text = "PREV";
            this.btn_prev.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(372, 290);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 6;
            this.btn_next.Text = "NEXT";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_tambah
            // 
            this.btn_tambah.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambah.Location = new System.Drawing.Point(310, 330);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(83, 38);
            this.btn_tambah.TabIndex = 7;
            this.btn_tambah.Text = "TAMBAH";
            this.btn_tambah.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(408, 330);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 38);
            this.button4.TabIndex = 8;
            this.button4.Text = "UBAH";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_hapus
            // 
            this.btn_hapus.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.Location = new System.Drawing.Point(513, 330);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(87, 38);
            this.btn_hapus.TabIndex = 9;
            this.btn_hapus.Text = "HAPUS";
            this.btn_hapus.UseVisualStyleBackColor = true;
            // 
            // FormKonsumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 400);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ubah);
            this.Name = "FormKonsumen";
            this.Text = "DATA KONSUMEN";
            ((System.ComponentModel.ISupportInitialize)(this.btn_ubah)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView btn_ubah;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cb_cari;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_hapus;
    }
}