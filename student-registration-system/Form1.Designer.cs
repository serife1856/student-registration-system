namespace student_registration_system
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
            this.label1 = new System.Windows.Forms.Label();
            this.textAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textVize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textFinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textOrt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonkaydet = new System.Windows.Forms.Button();
            this.buttonHes = new System.Windows.Forms.Button();
            this.buttonTem = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextNo = new System.Windows.Forms.MaskedTextBox();
            this.textDrm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(137, 96);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(134, 22);
            this.textAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÖĞRENCİ NOT KAYIT SİSTEMİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(80, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ders:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Diferansiyel Denklemler",
            "Veri Yapıları ve Algoritma",
            "Görsel Programlama",
            "Web Tasarım",
            "Lineer Cebir",
            "Enerji Verimliliği",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(137, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // textVize
            // 
            this.textVize.Location = new System.Drawing.Point(479, 99);
            this.textVize.Name = "textVize";
            this.textVize.Size = new System.Drawing.Size(53, 22);
            this.textVize.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(422, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vize:";
            // 
            // textFinal
            // 
            this.textFinal.Location = new System.Drawing.Point(479, 130);
            this.textFinal.Name = "textFinal";
            this.textFinal.Size = new System.Drawing.Size(53, 22);
            this.textFinal.TabIndex = 5;
            this.textFinal.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(419, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Final:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textOrt
            // 
            this.textOrt.Enabled = false;
            this.textOrt.Location = new System.Drawing.Point(646, 96);
            this.textOrt.Name = "textOrt";
            this.textOrt.ReadOnly = true;
            this.textOrt.Size = new System.Drawing.Size(53, 22);
            this.textOrt.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(600, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ort:";
            // 
            // buttonkaydet
            // 
            this.buttonkaydet.BackColor = System.Drawing.Color.Plum;
            this.buttonkaydet.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonkaydet.Location = new System.Drawing.Point(135, 238);
            this.buttonkaydet.Name = "buttonkaydet";
            this.buttonkaydet.Size = new System.Drawing.Size(108, 44);
            this.buttonkaydet.TabIndex = 11;
            this.buttonkaydet.Text = "Kaydet";
            this.buttonkaydet.UseVisualStyleBackColor = false;
            this.buttonkaydet.Click += new System.EventHandler(this.buttonkaydet_Click);
            // 
            // buttonHes
            // 
            this.buttonHes.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonHes.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHes.Location = new System.Drawing.Point(249, 238);
            this.buttonHes.Name = "buttonHes";
            this.buttonHes.Size = new System.Drawing.Size(108, 44);
            this.buttonHes.TabIndex = 12;
            this.buttonHes.Text = "Hesapla";
            this.buttonHes.UseVisualStyleBackColor = false;
            this.buttonHes.Click += new System.EventHandler(this.buttonHes_Click);
            // 
            // buttonTem
            // 
            this.buttonTem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonTem.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTem.Location = new System.Drawing.Point(363, 238);
            this.buttonTem.Name = "buttonTem";
            this.buttonTem.Size = new System.Drawing.Size(108, 44);
            this.buttonTem.TabIndex = 13;
            this.buttonTem.Text = "Temizle";
            this.buttonTem.UseVisualStyleBackColor = false;
            this.buttonTem.Click += new System.EventHandler(this.buttonTem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(135, 327);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(773, 244);
            this.listBox1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(19, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Öğrenci NO:";
            // 
            // maskedTextNo
            // 
            this.maskedTextNo.Location = new System.Drawing.Point(137, 134);
            this.maskedTextNo.Mask = "00000";
            this.maskedTextNo.Name = "maskedTextNo";
            this.maskedTextNo.Size = new System.Drawing.Size(78, 22);
            this.maskedTextNo.TabIndex = 2;
            this.maskedTextNo.ValidatingType = typeof(int);
            // 
            // textDrm
            // 
            this.textDrm.Enabled = false;
            this.textDrm.Location = new System.Drawing.Point(646, 134);
            this.textDrm.Name = "textDrm";
            this.textDrm.ReadOnly = true;
            this.textDrm.Size = new System.Drawing.Size(145, 22);
            this.textDrm.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(571, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Durum:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(479, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 44);
            this.button1.TabIndex = 19;
            this.button1.Text = "Çizgi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 608);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textDrm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maskedTextNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonTem);
            this.Controls.Add(this.buttonHes);
            this.Controls.Add(this.buttonkaydet);
            this.Controls.Add(this.textOrt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textVize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textVize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textOrt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonkaydet;
        private System.Windows.Forms.Button buttonHes;
        private System.Windows.Forms.Button buttonTem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextNo;
        private System.Windows.Forms.TextBox textDrm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}

