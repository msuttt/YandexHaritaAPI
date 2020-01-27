namespace YandexHaritaApi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richtxtAdres = new System.Windows.Forms.RichTextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdreseDok = new System.Windows.Forms.Button();
            this.btnKonumBul = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtarama = new System.Windows.Forms.TextBox();
            this.richtxtsonuc = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SpringGreen;
            this.groupBox1.Controls.Add(this.txtLon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.richtxtAdres);
            this.groupBox1.Controls.Add(this.txtLat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdreseDok);
            this.groupBox1.Controls.Add(this.btnKonumBul);
            this.groupBox1.Location = new System.Drawing.Point(35, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 260);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtLon
            // 
            this.txtLon.Location = new System.Drawing.Point(162, 49);
            this.txtLon.Name = "txtLon";
            this.txtLon.Size = new System.Drawing.Size(56, 20);
            this.txtLon.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lon:";
            // 
            // richtxtAdres
            // 
            this.richtxtAdres.Location = new System.Drawing.Point(25, 121);
            this.richtxtAdres.Name = "richtxtAdres";
            this.richtxtAdres.Size = new System.Drawing.Size(203, 119);
            this.richtxtAdres.TabIndex = 11;
            this.richtxtAdres.Text = "";
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(53, 49);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(56, 20);
            this.txtLat.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lat:";
            // 
            // btnAdreseDok
            // 
            this.btnAdreseDok.Location = new System.Drawing.Point(25, 81);
            this.btnAdreseDok.Name = "btnAdreseDok";
            this.btnAdreseDok.Size = new System.Drawing.Size(203, 23);
            this.btnAdreseDok.TabIndex = 8;
            this.btnAdreseDok.Text = "Konumu Adrese Dök";
            this.btnAdreseDok.UseVisualStyleBackColor = true;
            // 
            // btnKonumBul
            // 
            this.btnKonumBul.Location = new System.Drawing.Point(25, 12);
            this.btnKonumBul.Name = "btnKonumBul";
            this.btnKonumBul.Size = new System.Drawing.Size(203, 23);
            this.btnKonumBul.TabIndex = 7;
            this.btnKonumBul.Text = "Konum Bul";
            this.btnKonumBul.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox2.Controls.Add(this.richtxtsonuc);
            this.groupBox2.Controls.Add(this.txtarama);
            this.groupBox2.Location = new System.Drawing.Point(351, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 248);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtarama
            // 
            this.txtarama.Location = new System.Drawing.Point(36, 32);
            this.txtarama.Name = "txtarama";
            this.txtarama.Size = new System.Drawing.Size(176, 20);
            this.txtarama.TabIndex = 0;
            this.txtarama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtarama_KeyDown);
            // 
            // richtxtsonuc
            // 
            this.richtxtsonuc.Location = new System.Drawing.Point(36, 71);
            this.richtxtsonuc.Name = "richtxtsonuc";
            this.richtxtsonuc.Size = new System.Drawing.Size(176, 171);
            this.richtxtsonuc.TabIndex = 1;
            this.richtxtsonuc.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(699, 309);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richtxtAdres;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdreseDok;
        private System.Windows.Forms.Button btnKonumBul;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richtxtsonuc;
        private System.Windows.Forms.TextBox txtarama;
    }
}

