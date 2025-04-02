namespace RastgeleDiziOlusturma
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSatirSayisi = new System.Windows.Forms.TextBox();
            this.txtSutunSayisi = new System.Windows.Forms.TextBox();
            this.txtDusuk = new System.Windows.Forms.TextBox();
            this.txtYuksek = new System.Windows.Forms.TextBox();
            this.btnDiziOlustur = new System.Windows.Forms.Button();
            this.btnDiziGoster = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satır Sayısı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sütun Sayısı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "En Düşük Sayı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(36, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "En Yüksek Sayısı : ";
            // 
            // txtSatirSayisi
            // 
            this.txtSatirSayisi.Location = new System.Drawing.Point(166, 29);
            this.txtSatirSayisi.Name = "txtSatirSayisi";
            this.txtSatirSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtSatirSayisi.TabIndex = 4;
            // 
            // txtSutunSayisi
            // 
            this.txtSutunSayisi.Location = new System.Drawing.Point(166, 64);
            this.txtSutunSayisi.Name = "txtSutunSayisi";
            this.txtSutunSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtSutunSayisi.TabIndex = 5;
            // 
            // txtDusuk
            // 
            this.txtDusuk.Location = new System.Drawing.Point(197, 99);
            this.txtDusuk.Name = "txtDusuk";
            this.txtDusuk.Size = new System.Drawing.Size(100, 20);
            this.txtDusuk.TabIndex = 6;
            // 
            // txtYuksek
            // 
            this.txtYuksek.Location = new System.Drawing.Point(230, 131);
            this.txtYuksek.Name = "txtYuksek";
            this.txtYuksek.Size = new System.Drawing.Size(100, 20);
            this.txtYuksek.TabIndex = 7;
            // 
            // btnDiziOlustur
            // 
            this.btnDiziOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDiziOlustur.ForeColor = System.Drawing.Color.Maroon;
            this.btnDiziOlustur.Location = new System.Drawing.Point(157, 182);
            this.btnDiziOlustur.Name = "btnDiziOlustur";
            this.btnDiziOlustur.Size = new System.Drawing.Size(109, 68);
            this.btnDiziOlustur.TabIndex = 8;
            this.btnDiziOlustur.Text = "Dizi Olustur";
            this.btnDiziOlustur.UseVisualStyleBackColor = true;
            this.btnDiziOlustur.Click += new System.EventHandler(this.btnDiziOlustur_Click);
            // 
            // btnDiziGoster
            // 
            this.btnDiziGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDiziGoster.ForeColor = System.Drawing.Color.Maroon;
            this.btnDiziGoster.Location = new System.Drawing.Point(435, 16);
            this.btnDiziGoster.Name = "btnDiziGoster";
            this.btnDiziGoster.Size = new System.Drawing.Size(109, 68);
            this.btnDiziGoster.TabIndex = 9;
            this.btnDiziGoster.Text = "Dizi Göster";
            this.btnDiziGoster.UseVisualStyleBackColor = true;
            this.btnDiziGoster.Click += new System.EventHandler(this.btnDiziGoster_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(362, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 220);
            this.listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 361);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDiziGoster);
            this.Controls.Add(this.btnDiziOlustur);
            this.Controls.Add(this.txtYuksek);
            this.Controls.Add(this.txtDusuk);
            this.Controls.Add(this.txtSutunSayisi);
            this.Controls.Add(this.txtSatirSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSatirSayisi;
        private System.Windows.Forms.TextBox txtSutunSayisi;
        private System.Windows.Forms.TextBox txtDusuk;
        private System.Windows.Forms.TextBox txtYuksek;
        private System.Windows.Forms.Button btnDiziOlustur;
        private System.Windows.Forms.Button btnDiziGoster;
        private System.Windows.Forms.ListBox listBox1;
    }
}

