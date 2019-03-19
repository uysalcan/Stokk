namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.Adi = new System.Windows.Forms.TextBox();
            this.grup = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.Label();
            this.gr = new System.Windows.Forms.Label();
            this.stok = new System.Windows.Forms.Label();
            this.mstok = new System.Windows.Forms.TextBox();
            this.datagr = new System.Windows.Forms.DataGridView();
            this.Kaydet = new System.Windows.Forms.Button();
            this.Arama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Bilgileri";
            // 
            // Adi
            // 
            this.Adi.Location = new System.Drawing.Point(53, 30);
            this.Adi.Name = "Adi";
            this.Adi.Size = new System.Drawing.Size(100, 20);
            this.Adi.TabIndex = 1;
            this.Adi.TextChanged += new System.EventHandler(this.Adi_TextChanged);
            // 
            // grup
            // 
            this.grup.Location = new System.Drawing.Point(201, 30);
            this.grup.Name = "grup";
            this.grup.Size = new System.Drawing.Size(100, 20);
            this.grup.TabIndex = 2;
            this.grup.TextChanged += new System.EventHandler(this.grup_TextChanged);
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Location = new System.Drawing.Point(22, 34);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(31, 13);
            this.ad.TabIndex = 3;
            this.ad.Text = "Adı : ";
            this.ad.Click += new System.EventHandler(this.ad_Click);
            // 
            // gr
            // 
            this.gr.AutoSize = true;
            this.gr.Location = new System.Drawing.Point(156, 34);
            this.gr.Name = "gr";
            this.gr.Size = new System.Drawing.Size(42, 13);
            this.gr.TabIndex = 4;
            this.gr.Text = "Grubu :";
            this.gr.Click += new System.EventHandler(this.gr_Click);
            // 
            // stok
            // 
            this.stok.AutoSize = true;
            this.stok.Location = new System.Drawing.Point(307, 33);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(74, 13);
            this.stok.TabIndex = 5;
            this.stok.Text = "Mevcut Stok :";
            this.stok.Click += new System.EventHandler(this.stok_Click);
            // 
            // mstok
            // 
            this.mstok.Location = new System.Drawing.Point(387, 31);
            this.mstok.Name = "mstok";
            this.mstok.Size = new System.Drawing.Size(100, 20);
            this.mstok.TabIndex = 7;
            this.mstok.TextChanged += new System.EventHandler(this.mstok_TextChanged);
            // 
            // datagr
            // 
            this.datagr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagr.Location = new System.Drawing.Point(12, 89);
            this.datagr.Name = "datagr";
            this.datagr.Size = new System.Drawing.Size(676, 228);
            this.datagr.TabIndex = 9;
            this.datagr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(524, 30);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(75, 23);
            this.Kaydet.TabIndex = 10;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // Arama
            // 
            this.Arama.Location = new System.Drawing.Point(98, 60);
            this.Arama.Name = "Arama";
            this.Arama.Size = new System.Drawing.Size(389, 20);
            this.Arama.TabIndex = 11;
            this.Arama.TextChanged += new System.EventHandler(this.Arama_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Stok Arama : ";
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(610, 30);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(75, 23);
            this.Sil.TabIndex = 13;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 329);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Arama);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.datagr);
            this.Controls.Add(this.mstok);
            this.Controls.Add(this.stok);
            this.Controls.Add(this.gr);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.grup);
            this.Controls.Add(this.Adi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Stok Takip";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Adi;
        private System.Windows.Forms.TextBox grup;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label gr;
        private System.Windows.Forms.Label stok;
        private System.Windows.Forms.TextBox mstok;
        private System.Windows.Forms.DataGridView datagr;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.TextBox Arama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Sil;
    }
}

