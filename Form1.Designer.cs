/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**		     BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**			    NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 2
**				ÖĞRENCİ ADI............: ENES KILIÇARSLAN
**				ÖĞRENCİ NUMARASI.......: g201210016
**              DERSİN ALINDIĞI GRUP...: 2D
****************************************************************************/
namespace odev2_soru2
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
            this.matrix1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.matrix1_m = new System.Windows.Forms.TextBox();
            this.matrix1_n = new System.Windows.Forms.TextBox();
            this.matrix1_deger = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.matrix1_olustur = new System.Windows.Forms.Button();
            this.matrix2_olustur = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.matrix2_deger = new System.Windows.Forms.TextBox();
            this.matrix2_n = new System.Windows.Forms.TextBox();
            this.matrix2_m = new System.Windows.Forms.TextBox();
            this.matrix2 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.matrix1_j = new System.Windows.Forms.TextBox();
            this.matrix1_i = new System.Windows.Forms.TextBox();
            this.matrix1_goster = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.sonuc = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.matrix2_goster = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.matrix2_j = new System.Windows.Forms.TextBox();
            this.matrix2_i = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.m1_hatali = new System.Windows.Forms.Label();
            this.m1_uygun = new System.Windows.Forms.Label();
            this.m2_uygun = new System.Windows.Forms.Label();
            this.m2_hatali = new System.Windows.Forms.Label();
            this.logs_textbox = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.sil_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // matrix1
            // 
            this.matrix1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matrix1.Location = new System.Drawing.Point(39, 44);
            this.matrix1.Name = "matrix1";
            this.matrix1.Size = new System.Drawing.Size(243, 222);
            this.matrix1.TabIndex = 0;
            this.matrix1.Text = "0 0 0 0 0 \n0 0 0 0 0 \n0 0 0 0 0 \n0 0 0 0 0 \n0 0 0 0 0";
            this.matrix1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.matrix1.Leave += new System.EventHandler(this.matrix1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Birinci Matris";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // matrix1_m
            // 
            this.matrix1_m.Location = new System.Drawing.Point(76, 351);
            this.matrix1_m.Name = "matrix1_m";
            this.matrix1_m.Size = new System.Drawing.Size(54, 23);
            this.matrix1_m.TabIndex = 2;
            this.matrix1_m.Text = "5";
            this.matrix1_m.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // matrix1_n
            // 
            this.matrix1_n.Location = new System.Drawing.Point(156, 351);
            this.matrix1_n.Name = "matrix1_n";
            this.matrix1_n.Size = new System.Drawing.Size(54, 23);
            this.matrix1_n.TabIndex = 3;
            this.matrix1_n.Text = "5";
            this.matrix1_n.TextChanged += new System.EventHandler(this.matrix1_n_TextChanged);
            // 
            // matrix1_deger
            // 
            this.matrix1_deger.Location = new System.Drawing.Point(76, 286);
            this.matrix1_deger.Name = "matrix1_deger";
            this.matrix1_deger.Size = new System.Drawing.Size(54, 23);
            this.matrix1_deger.TabIndex = 4;
            this.matrix1_deger.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(135, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Değerinden Oluşan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(136, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(216, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "\'lık matris";
            // 
            // matrix1_olustur
            // 
            this.matrix1_olustur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matrix1_olustur.Location = new System.Drawing.Point(110, 393);
            this.matrix1_olustur.Name = "matrix1_olustur";
            this.matrix1_olustur.Size = new System.Drawing.Size(75, 23);
            this.matrix1_olustur.TabIndex = 8;
            this.matrix1_olustur.Text = "OLUŞTUR";
            this.matrix1_olustur.UseVisualStyleBackColor = true;
            this.matrix1_olustur.Click += new System.EventHandler(this.button1_Click);
            // 
            // matrix2_olustur
            // 
            this.matrix2_olustur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matrix2_olustur.Location = new System.Drawing.Point(490, 393);
            this.matrix2_olustur.Name = "matrix2_olustur";
            this.matrix2_olustur.Size = new System.Drawing.Size(75, 23);
            this.matrix2_olustur.TabIndex = 16;
            this.matrix2_olustur.Text = "OLUŞTUR";
            this.matrix2_olustur.UseVisualStyleBackColor = true;
            this.matrix2_olustur.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(596, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "\'lık matris";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(516, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(515, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Değerinden Oluşan";
            // 
            // matrix2_deger
            // 
            this.matrix2_deger.Location = new System.Drawing.Point(456, 286);
            this.matrix2_deger.Name = "matrix2_deger";
            this.matrix2_deger.Size = new System.Drawing.Size(54, 23);
            this.matrix2_deger.TabIndex = 12;
            this.matrix2_deger.Text = "1";
            // 
            // matrix2_n
            // 
            this.matrix2_n.Location = new System.Drawing.Point(536, 351);
            this.matrix2_n.Name = "matrix2_n";
            this.matrix2_n.Size = new System.Drawing.Size(54, 23);
            this.matrix2_n.TabIndex = 11;
            this.matrix2_n.Text = "5";
            // 
            // matrix2_m
            // 
            this.matrix2_m.Location = new System.Drawing.Point(456, 351);
            this.matrix2_m.Name = "matrix2_m";
            this.matrix2_m.Size = new System.Drawing.Size(54, 23);
            this.matrix2_m.TabIndex = 10;
            this.matrix2_m.Text = "5";
            // 
            // matrix2
            // 
            this.matrix2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matrix2.Location = new System.Drawing.Point(419, 44);
            this.matrix2.Name = "matrix2";
            this.matrix2.Size = new System.Drawing.Size(251, 222);
            this.matrix2.TabIndex = 9;
            this.matrix2.Text = "1 1 1 1 1\n1 1 1 1 1\n1 1 1 1 1\n1 1 1 1 1\n1 1 1 1 1";
            this.matrix2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            this.matrix2.Leave += new System.EventHandler(this.matrix2_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Topla",
            "Çarp",
            "Tersini Al",
            "İzi Bul",
            "Transpoze"});
            this.comboBox1.Location = new System.Drawing.Point(288, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Text = "İşlem Seçiniz";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(216, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "elemanın değeri: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(136, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "x";
            // 
            // matrix1_j
            // 
            this.matrix1_j.Location = new System.Drawing.Point(156, 456);
            this.matrix1_j.Name = "matrix1_j";
            this.matrix1_j.Size = new System.Drawing.Size(54, 23);
            this.matrix1_j.TabIndex = 19;
            this.matrix1_j.Text = "1";
            // 
            // matrix1_i
            // 
            this.matrix1_i.Location = new System.Drawing.Point(76, 456);
            this.matrix1_i.Name = "matrix1_i";
            this.matrix1_i.Size = new System.Drawing.Size(54, 23);
            this.matrix1_i.TabIndex = 18;
            this.matrix1_i.Text = "1";
            // 
            // matrix1_goster
            // 
            this.matrix1_goster.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matrix1_goster.Location = new System.Drawing.Point(110, 497);
            this.matrix1_goster.Name = "matrix1_goster";
            this.matrix1_goster.Size = new System.Drawing.Size(75, 23);
            this.matrix1_goster.TabIndex = 22;
            this.matrix1_goster.Text = "HESAPLA";
            this.matrix1_goster.UseVisualStyleBackColor = true;
            this.matrix1_goster.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 483);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 15);
            this.label10.TabIndex = 23;
            // 
            // sonuc
            // 
            this.sonuc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sonuc.Location = new System.Drawing.Point(826, 44);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(262, 222);
            this.sonuc.TabIndex = 24;
            this.sonuc.Text = "";
            this.sonuc.TextChanged += new System.EventHandler(this.sonuc_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(479, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "İkinci Matris";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(618, 480);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 15);
            this.label12.TabIndex = 31;
            // 
            // matrix2_goster
            // 
            this.matrix2_goster.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matrix2_goster.Location = new System.Drawing.Point(490, 494);
            this.matrix2_goster.Name = "matrix2_goster";
            this.matrix2_goster.Size = new System.Drawing.Size(75, 23);
            this.matrix2_goster.TabIndex = 30;
            this.matrix2_goster.Text = "HESAPLA";
            this.matrix2_goster.UseVisualStyleBackColor = true;
            this.matrix2_goster.Click += new System.EventHandler(this.matrix2_goster_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(596, 456);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "elemanın değeri: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(516, 456);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "x";
            // 
            // matrix2_j
            // 
            this.matrix2_j.Location = new System.Drawing.Point(536, 453);
            this.matrix2_j.Name = "matrix2_j";
            this.matrix2_j.Size = new System.Drawing.Size(54, 23);
            this.matrix2_j.TabIndex = 27;
            this.matrix2_j.Text = "1";
            // 
            // matrix2_i
            // 
            this.matrix2_i.Location = new System.Drawing.Point(456, 453);
            this.matrix2_i.Name = "matrix2_i";
            this.matrix2_i.Size = new System.Drawing.Size(54, 23);
            this.matrix2_i.TabIndex = 26;
            this.matrix2_i.Text = "1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(693, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 46);
            this.button1.TabIndex = 32;
            this.button1.Text = "İŞLEMİ YAP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(862, 289);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 25);
            this.label15.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(905, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 25);
            this.label16.TabIndex = 34;
            this.label16.Text = "Sonuç";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // m1_hatali
            // 
            this.m1_hatali.AutoSize = true;
            this.m1_hatali.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m1_hatali.ForeColor = System.Drawing.Color.Red;
            this.m1_hatali.Location = new System.Drawing.Point(94, 322);
            this.m1_hatali.Name = "m1_hatali";
            this.m1_hatali.Size = new System.Drawing.Size(127, 15);
            this.m1_hatali.TabIndex = 35;
            this.m1_hatali.Text = "Hatalı Matris Formatı!";
            this.m1_hatali.Visible = false;
            // 
            // m1_uygun
            // 
            this.m1_uygun.AutoSize = true;
            this.m1_uygun.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m1_uygun.ForeColor = System.Drawing.Color.YellowGreen;
            this.m1_uygun.Location = new System.Drawing.Point(92, 322);
            this.m1_uygun.Name = "m1_uygun";
            this.m1_uygun.Size = new System.Drawing.Size(144, 15);
            this.m1_uygun.TabIndex = 36;
            this.m1_uygun.Text = "Matris Formatı Geçerli.";
            // 
            // m2_uygun
            // 
            this.m2_uygun.AutoSize = true;
            this.m2_uygun.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m2_uygun.ForeColor = System.Drawing.Color.YellowGreen;
            this.m2_uygun.Location = new System.Drawing.Point(474, 322);
            this.m2_uygun.Name = "m2_uygun";
            this.m2_uygun.Size = new System.Drawing.Size(144, 15);
            this.m2_uygun.TabIndex = 37;
            this.m2_uygun.Text = "Matris Formatı Geçerli.";
            // 
            // m2_hatali
            // 
            this.m2_hatali.AutoSize = true;
            this.m2_hatali.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m2_hatali.ForeColor = System.Drawing.Color.Red;
            this.m2_hatali.Location = new System.Drawing.Point(490, 322);
            this.m2_hatali.Name = "m2_hatali";
            this.m2_hatali.Size = new System.Drawing.Size(127, 15);
            this.m2_hatali.TabIndex = 38;
            this.m2_hatali.Text = "Hatalı Matris Formatı!";
            this.m2_hatali.Visible = false;
            // 
            // logs_textbox
            // 
            this.logs_textbox.Location = new System.Drawing.Point(826, 394);
            this.logs_textbox.Name = "logs_textbox";
            this.logs_textbox.Size = new System.Drawing.Size(411, 197);
            this.logs_textbox.TabIndex = 39;
            this.logs_textbox.Text = "";
            this.logs_textbox.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(826, 355);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(157, 19);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.Text = "Log Kayıtlarını Görüntüle";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // sil_button
            // 
            this.sil_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sil_button.Location = new System.Drawing.Point(989, 355);
            this.sil_button.Name = "sil_button";
            this.sil_button.Size = new System.Drawing.Size(138, 23);
            this.sil_button.TabIndex = 41;
            this.sil_button.Text = "LOG KAYITLARINI SİL";
            this.sil_button.UseVisualStyleBackColor = true;
            this.sil_button.Visible = false;
            this.sil_button.Click += new System.EventHandler(this.sil_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 612);
            this.Controls.Add(this.sil_button);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.logs_textbox);
            this.Controls.Add(this.m2_hatali);
            this.Controls.Add(this.m2_uygun);
            this.Controls.Add(this.m1_uygun);
            this.Controls.Add(this.m1_hatali);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.matrix2_goster);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.matrix2_j);
            this.Controls.Add(this.matrix2_i);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.matrix1_goster);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.matrix1_j);
            this.Controls.Add(this.matrix1_i);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.matrix2_olustur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.matrix2_deger);
            this.Controls.Add(this.matrix2_n);
            this.Controls.Add(this.matrix2_m);
            this.Controls.Add(this.matrix2);
            this.Controls.Add(this.matrix1_olustur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matrix1_deger);
            this.Controls.Add(this.matrix1_n);
            this.Controls.Add(this.matrix1_m);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matrix1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox matrix1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox matrix1_m;
        private System.Windows.Forms.TextBox matrix1_n;
        private System.Windows.Forms.TextBox matrix1_deger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button matrix1_olustur;
        private System.Windows.Forms.Button matrix2_olustur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox matrix2_deger;
        private System.Windows.Forms.TextBox matrix2_n;
        private System.Windows.Forms.TextBox matrix2_m;
        private System.Windows.Forms.RichTextBox matrix2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox matrix1_j;
        private System.Windows.Forms.TextBox matrix1_i;
        private System.Windows.Forms.Button matrix1_goster;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox sonuc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button matrix2_goster;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox matrix2_j;
        private System.Windows.Forms.TextBox matrix2_i;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label m1_hatali;
        private System.Windows.Forms.Label m1_uygun;
        private System.Windows.Forms.Label m2_uygun;
        private System.Windows.Forms.Label m2_hatali;
        private System.Windows.Forms.RichTextBox logs_textbox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button sil_button;
    }
}

