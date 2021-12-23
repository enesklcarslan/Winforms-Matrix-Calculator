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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev2_soru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string matrix = matrix1.Text;
            matrix = matrix.Replace(" \n", "\n");
            matrix = matrix.Trim();
            
            try
            {
                int[,] matrixarr = Matrix.MatrixTurn2Array(matrix);
                int satirsayisi = matrixarr.GetLength(0);
                int sutunsayisi = matrixarr.GetLength(1);
                matrix1_m.Text = satirsayisi.ToString();
                matrix1_n.Text = sutunsayisi.ToString();
                m1_uygun.Visible = true;
                m1_hatali.Visible = false;
            }
            catch(System.FormatException)
            {
                m1_uygun.Visible = false;
                m1_hatali.Visible = true;
            }
            
            
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            string matrix = matrix2.Text;
            matrix = matrix.Replace(" \n", "\n");
            matrix = matrix.Trim();
            try
            {
                int[,] matrixarr = Matrix.MatrixTurn2Array(matrix);
                int satirsayisi = matrixarr.GetLength(0);
                int sutunsayisi = matrixarr.GetLength(1);
                matrix2_m.Text = satirsayisi.ToString();
                matrix2_n.Text = sutunsayisi.ToString();
                m2_uygun.Visible = true;
                m2_hatali.Visible = false;
            }
            catch (System.FormatException)
            {
                m2_uygun.Visible = false;
                m2_hatali.Visible = true;
            }
        }
        private void sonuc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int[,] matrix = Matrix.MatrixTurn2Array(sonuc.Text);
                            int satirsayisi = matrix.GetLength(0);
                            int sutunsayisi = matrix.GetLength(1);
                            label15.Text = satirsayisi.ToString() + " x " + sutunsayisi.ToString() + "'lık Matris";
            }
            catch(System.FormatException)
            {
                label15.Text = matrix1_m.Text + " x " + matrix1_n.Text + "'lık Matris";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int satirSayisi = Convert.ToInt32(matrix1_m.Text);
            int sutunSayisi = Convert.ToInt32(matrix1_n.Text);
            string deger = matrix1_deger.Text;
            string matrix = Matrix.MatrixOlustur(deger, satirSayisi, sutunSayisi);
            matrix = matrix.Replace(" \n", "\n");
            matrix = matrix.Trim();
            matrix1.Text = matrix;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int satirSayisi = Convert.ToInt32(matrix2_m.Text);
            int sutunSayisi = Convert.ToInt32(matrix2_n.Text);
            string deger = matrix2_deger.Text;
            matrix2.Text = Matrix.MatrixOlustur(deger, satirSayisi, sutunSayisi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string readText = File.ReadAllText("logs.txt");
            logs_textbox.Text = readText;
            string message = "Matris Hesap Makinesi programına hoşgeldiniz!\nMatris girişi yaparken aynı satır elemanları arasında bir adet boşluk bırakınız.\n" +
                "Her satırı alt alta yazınız.\nİsterseniz Matris oluşturma kısmından istediğiniz Matris boyutunu girip uygun matrisi oluşturduktan sonra\n" +
                "elemanları istediğiniz sayılarla değiştirerek de Matris oluşturma işlemini tamamlayabilirsiniz!";
            string title = "Hoşgeldiniz.";
            MessageBox.Show(message, title);
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            string matrix = matrix1.Text;
            int satirsayisi = Convert.ToInt32(matrix1_m.Text);
            int sutunsayisi = Convert.ToInt32(matrix1_n.Text);
            int i = Convert.ToInt32(matrix1_i.Text);
            int j = Convert.ToInt32(matrix1_j.Text);
            string deger = Matrix.MatrixDegerGoster(matrix, i, j);
            label10.Text = deger;
        }

        private void matrix2_goster_Click(object sender, EventArgs e)
        {
            string matrix = matrix2.Text;
            int satirsayisi = Convert.ToInt32(matrix2_n.Text);
            int sutunsayisi = Convert.ToInt32(matrix2_m.Text);
            int i = Convert.ToInt32(matrix2_i.Text);
            int j = Convert.ToInt32(matrix2_j.Text);
            string deger = Matrix.MatrixDegerGoster(matrix, i, j);
            label12.Text = deger;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                sonuc.Text = Matrix.MatrixTopla(matrix1.Text, matrix2.Text);
                string log_text = "\nİşlem: Toplama\n\nMatris 1:\n" + matrix1.Text + "\n\nMatris 2:\n" + matrix2.Text + "\n\nSonuç:\n" + sonuc.Text + "\n\n\n--------------------------------------------------\n";
                File.AppendAllText("logs.txt", log_text);

            }
            if (comboBox1.SelectedIndex == 1)
            {
                sonuc.Text = Matrix.MatrixCarp(matrix1.Text, matrix2.Text, Convert.ToInt32(matrix1_m.Text), Convert.ToInt32(matrix1_n.Text), Convert.ToInt32(matrix2_m.Text), Convert.ToInt32(matrix2_n.Text));
                string log_text = "\nİşlem: Çarpma\n\nMatris 1:\n" + matrix1.Text + "\n\nMatris 2:\n" + matrix2.Text + "\n\nSonuç:\n" + sonuc.Text + "\n\n\n--------------------------------------------------\n";
                File.AppendAllText("logs.txt", log_text);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                sonuc.Text = Matrix.MatrixInverse(matrix1.Text);
                string log_text = "\nİşlem: Tersini Alma\n\nMatris 1:\n" + matrix1.Text + "\n\nSonuç:\n" + sonuc.Text + "\n\n\n--------------------------------------------------\n";
                File.AppendAllText("logs.txt", log_text);
            }
            if (comboBox1.SelectedIndex == 4)
            {
                string transpozematrix = Matrix.MatrixTranspoze(matrix1.Text);
                sonuc.Text = transpozematrix;
                string log_text = "\nİşlem: Transpoze Alma\n\nMatris 1:\n" + matrix1.Text + "\n\nSonuç:\n" + sonuc.Text + "\n\n\n--------------------------------------------------\n";
                File.AppendAllText("logs.txt", log_text);
            }
            if(comboBox1.SelectedIndex == 3)
            {
                int iz = Matrix.MatrixIzBul(matrix1.Text);
                sonuc.Text = iz.ToString();
                string log_text = "\nİşlem: İz Hesaplama\n\nMatris 1:\n" + matrix1.Text + "\n\nSonuç:\n" + sonuc.Text + "\n\n\n--------------------------------------------------\n";
                File.AppendAllText("logs.txt", log_text);
            }
            string readText = File.ReadAllText("logs.txt");
            logs_textbox.Text = readText;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void matrix1_n_TextChanged(object sender, EventArgs e)
        {
        }

        private void matrix1_Leave(object sender, EventArgs e)
        {
            matrix1.Text = matrix1.Text.Trim();
            matrix1.Text = matrix1.Text.Replace(" \n", "\n");
        }

        private void matrix2_Leave(object sender, EventArgs e)
        {
            matrix2.Text = matrix2.Text.Trim();
            matrix2.Text = matrix2.Text.Replace(" \n", "\n");
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (logs_textbox.Visible == false)
                logs_textbox.Visible = true;
            else
                logs_textbox.Visible = false;
            if (sil_button.Visible == false)
                sil_button.Visible = true;
            else
                sil_button.Visible = false;
        }

        private void sil_button_Click(object sender, EventArgs e)
        {
            File.WriteAllText("logs.txt", "");
            logs_textbox.Text = "";
        }
    }
}
