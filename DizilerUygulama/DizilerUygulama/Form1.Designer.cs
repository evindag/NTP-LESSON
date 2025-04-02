<<<<<<< HEAD
﻿namespace DizilerUygulama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtAdSoyad = new TextBox();
            txtDersNotu = new TextBox();
            txtEnYuksek = new TextBox();
            txtEnDusuk = new TextBox();
            txtOrtalama = new TextBox();
            btnEkle = new Button();
            btnEnYuksek = new Button();
            btnEnDusuk = new Button();
            btnOrtalama = new Button();
            listBox1 = new ListBox();
            btnListele = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(24, 46);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(24, 87);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 1;
            label2.Text = "Ders Notu";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(138, 51);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 27);
            txtAdSoyad.TabIndex = 2;
            // 
            // txtDersNotu
            // 
            txtDersNotu.Location = new Point(148, 91);
            txtDersNotu.Name = "txtDersNotu";
            txtDersNotu.Size = new Size(125, 27);
            txtDersNotu.TabIndex = 3;
            // 
            // txtEnYuksek
            // 
            txtEnYuksek.Location = new Point(271, 191);
            txtEnYuksek.Name = "txtEnYuksek";
            txtEnYuksek.Size = new Size(125, 27);
            txtEnYuksek.TabIndex = 4;
            // 
            // txtEnDusuk
            // 
            txtEnDusuk.Location = new Point(271, 248);
            txtEnDusuk.Name = "txtEnDusuk";
            txtEnDusuk.Size = new Size(125, 27);
            txtEnDusuk.TabIndex = 5;
            // 
            // txtOrtalama
            // 
            txtOrtalama.Location = new Point(271, 309);
            txtOrtalama.Name = "txtOrtalama";
            txtOrtalama.Size = new Size(125, 27);
            txtOrtalama.TabIndex = 6;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(138, 143);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnEnYuksek
            // 
            btnEnYuksek.Location = new Point(138, 189);
            btnEnYuksek.Name = "btnEnYuksek";
            btnEnYuksek.Size = new Size(94, 29);
            btnEnYuksek.TabIndex = 8;
            btnEnYuksek.Text = "En Yuksek";
            btnEnYuksek.UseVisualStyleBackColor = true;
            btnEnYuksek.Click += btnEnYuksek_Click;
            // 
            // btnEnDusuk
            // 
            btnEnDusuk.Location = new Point(138, 248);
            btnEnDusuk.Name = "btnEnDusuk";
            btnEnDusuk.Size = new Size(94, 29);
            btnEnDusuk.TabIndex = 9;
            btnEnDusuk.Text = "En  Düşük";
            btnEnDusuk.UseVisualStyleBackColor = true;
            btnEnDusuk.Click += btnEnDusuk_Click;
            // 
            // btnOrtalama
            // 
            btnOrtalama.Location = new Point(138, 307);
            btnOrtalama.Name = "btnOrtalama";
            btnOrtalama.Size = new Size(94, 29);
            btnOrtalama.TabIndex = 10;
            btnOrtalama.Text = "Ortalama";
            btnOrtalama.UseVisualStyleBackColor = true;
            btnOrtalama.Click += btnOrtalama_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(478, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(267, 304);
            listBox1.TabIndex = 11;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(520, 371);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(94, 29);
            btnListele.TabIndex = 12;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListele);
            Controls.Add(listBox1);
            Controls.Add(btnOrtalama);
            Controls.Add(btnEnDusuk);
            Controls.Add(btnEnYuksek);
            Controls.Add(btnEkle);
            Controls.Add(txtOrtalama);
            Controls.Add(txtEnDusuk);
            Controls.Add(txtEnYuksek);
            Controls.Add(txtDersNotu);
            Controls.Add(txtAdSoyad);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAdSoyad;
        private TextBox txtDersNotu;
        private TextBox txtEnYuksek;
        private TextBox txtEnDusuk;
        private TextBox txtOrtalama;
        private Button btnEkle;
        private Button btnEnYuksek;
        private Button btnEnDusuk;
        private Button btnOrtalama;
        private ListBox listBox1;
        private Button btnListele;
    }
}
=======
﻿namespace DizilerUygulama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtAdSoyad = new TextBox();
            txtDersNotu = new TextBox();
            txtEnYuksek = new TextBox();
            txtEnDusuk = new TextBox();
            txtOrtalama = new TextBox();
            btnEkle = new Button();
            btnEnYuksek = new Button();
            btnEnDusuk = new Button();
            btnOrtalama = new Button();
            listBox1 = new ListBox();
            btnListele = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(24, 46);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(24, 87);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 1;
            label2.Text = "Ders Notu";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(138, 51);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 27);
            txtAdSoyad.TabIndex = 2;
            // 
            // txtDersNotu
            // 
            txtDersNotu.Location = new Point(148, 91);
            txtDersNotu.Name = "txtDersNotu";
            txtDersNotu.Size = new Size(125, 27);
            txtDersNotu.TabIndex = 3;
            // 
            // txtEnYuksek
            // 
            txtEnYuksek.Location = new Point(271, 191);
            txtEnYuksek.Name = "txtEnYuksek";
            txtEnYuksek.Size = new Size(125, 27);
            txtEnYuksek.TabIndex = 4;
            // 
            // txtEnDusuk
            // 
            txtEnDusuk.Location = new Point(271, 248);
            txtEnDusuk.Name = "txtEnDusuk";
            txtEnDusuk.Size = new Size(125, 27);
            txtEnDusuk.TabIndex = 5;
            // 
            // txtOrtalama
            // 
            txtOrtalama.Location = new Point(271, 309);
            txtOrtalama.Name = "txtOrtalama";
            txtOrtalama.Size = new Size(125, 27);
            txtOrtalama.TabIndex = 6;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(138, 143);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnEnYuksek
            // 
            btnEnYuksek.Location = new Point(138, 189);
            btnEnYuksek.Name = "btnEnYuksek";
            btnEnYuksek.Size = new Size(94, 29);
            btnEnYuksek.TabIndex = 8;
            btnEnYuksek.Text = "En Yuksek";
            btnEnYuksek.UseVisualStyleBackColor = true;
            btnEnYuksek.Click += btnEnYuksek_Click;
            // 
            // btnEnDusuk
            // 
            btnEnDusuk.Location = new Point(138, 248);
            btnEnDusuk.Name = "btnEnDusuk";
            btnEnDusuk.Size = new Size(94, 29);
            btnEnDusuk.TabIndex = 9;
            btnEnDusuk.Text = "En  Düşük";
            btnEnDusuk.UseVisualStyleBackColor = true;
            btnEnDusuk.Click += btnEnDusuk_Click;
            // 
            // btnOrtalama
            // 
            btnOrtalama.Location = new Point(138, 307);
            btnOrtalama.Name = "btnOrtalama";
            btnOrtalama.Size = new Size(94, 29);
            btnOrtalama.TabIndex = 10;
            btnOrtalama.Text = "Ortalama";
            btnOrtalama.UseVisualStyleBackColor = true;
            btnOrtalama.Click += btnOrtalama_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(478, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(267, 304);
            listBox1.TabIndex = 11;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(520, 371);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(94, 29);
            btnListele.TabIndex = 12;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListele);
            Controls.Add(listBox1);
            Controls.Add(btnOrtalama);
            Controls.Add(btnEnDusuk);
            Controls.Add(btnEnYuksek);
            Controls.Add(btnEkle);
            Controls.Add(txtOrtalama);
            Controls.Add(txtEnDusuk);
            Controls.Add(txtEnYuksek);
            Controls.Add(txtDersNotu);
            Controls.Add(txtAdSoyad);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAdSoyad;
        private TextBox txtDersNotu;
        private TextBox txtEnYuksek;
        private TextBox txtEnDusuk;
        private TextBox txtOrtalama;
        private Button btnEkle;
        private Button btnEnYuksek;
        private Button btnEnDusuk;
        private Button btnOrtalama;
        private ListBox listBox1;
        private Button btnListele;
    }
}
>>>>>>> e7099af7a2f209c3c13628e2842f187bafab2e60
