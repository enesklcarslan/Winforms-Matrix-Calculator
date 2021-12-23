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
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace odev2_soru2
{
    static class Matrix
    {
        public static string MatrixOlustur(string x, int m, int n)
        {
            string matrix = "";
            for(int i = 0; i < m; ++i, matrix += "\n")
            {
                for(int k = 0; k < n; ++k, matrix += " ")
                {
                    matrix += x;
                }
            }
            matrix = matrix.Trim();
            matrix = matrix.Replace(" \n", "\n");
            return matrix;
        }
        public static string MatrixDegerGoster(string matrix, int i, int j)
        {
            matrix = matrix.Trim();
            matrix = matrix.Replace(" \n", "\n");
            int[,] matrixarr = Matrix.MatrixTurn2Array(matrix);
            int eleman = matrixarr[i-1, j-1];
            return Convert.ToString(eleman);
        }
        public static int MatrixDegerOku(string matrix, int i, int j)
        {
            int sonuc = Convert.ToInt32(MatrixDegerGoster(matrix, i, j));
            return sonuc;
        }
        public static string MatrixTopla(string m1, string m2)
        {
            string sonuc = "";
            int[,] matrix1 = Matrix.MatrixTurn2Array(m1);
            int[,] matrix2 = Matrix.MatrixTurn2Array(m2);
            int m1_satirsayisi = matrix1.GetLength(0);
            int m2_satirsayisi = matrix2.GetLength(0);
            int m1_sutunsayisi = matrix1.GetLength(1);
            int m2_sutunsayisi = matrix2.GetLength(1);
            if ((m1_satirsayisi != m2_satirsayisi) | (m1_sutunsayisi != m2_sutunsayisi))
            {
                sonuc = "0";
                string message = "Boyutu aynı olmayan matrisler toplanamaz!";
                string title = "İşlem Hatası!";
                MessageBox.Show(message, title);
                return sonuc;
            }
            for(int i=0; i < m1_satirsayisi; ++i)
            {
                for(int j=0; j<m1_sutunsayisi; ++j)
                {
                    int v = matrix1[i, j] + matrix2[i, j];
                    sonuc += v.ToString() + " ";
                }
                sonuc += "\n";
            }
            sonuc = sonuc.Trim();
            sonuc = sonuc.Replace(" \n", "\n");
            return sonuc;
        }
        public static string MatrixTranspoze(string matrix)
        {
            matrix = matrix.Replace(" \n", "\n");
            matrix = matrix.Trim();
            int[,] matrixarr = Matrix.MatrixTurn2Array(matrix);
            string transpozeMatrix = "";
            int satirsayisi = matrixarr.GetLength(0);
            int sutunsayisi = matrixarr.GetLength(1);
            for(int i = 0; i<sutunsayisi; ++i)
            {
                for(int j=0; j<satirsayisi; ++j)
                {
                    transpozeMatrix += matrixarr[j, i] + " ";
                }
                transpozeMatrix += "\n";
            }
            transpozeMatrix = transpozeMatrix.Replace(" \n", "\n");
            transpozeMatrix = transpozeMatrix.Trim();
            return transpozeMatrix;
        }
        public static int MatrixIzBul(string matrix)
        {
            matrix = matrix.Replace(" \n", "\n");
            matrix = matrix.Trim();
            int[,] matrixarr = Matrix.MatrixTurn2Array(matrix);
            int iz = 0;
            int satirsayisi = matrixarr.GetLength(0);
            int sutunsayisi = matrixarr.GetLength(1);
            if(satirsayisi != sutunsayisi)
            {
                string message = "Kare olmayan matris'in izi bulunamaz!";
                string title = "İşlem Hatası!";
                MessageBox.Show(message, title);
                return iz;
            }
            for(int i =0; i<satirsayisi; ++i)
            {
                iz += matrixarr[i, i];
            }
            return iz;
        }
        public static string MatrixInverse(string m)
        {
            m = m.Replace(" \n", "\n");
            m = m.Trim();
            int[,] matrix_i = Matrix.MatrixTurn2Array(m);
            int satirsayisi = matrix_i.GetLength(0);
            int sutunsayisi = matrix_i.GetLength(1);
            float[,] matrix = new float[satirsayisi, sutunsayisi];
            for(int i=0; i<satirsayisi; ++i)
            {
                for (int j = 0; j < sutunsayisi; ++j)
                    matrix[i, j] = matrix_i[i, j];
            }
            if (satirsayisi != sutunsayisi)
            {
                string message = "Kare olmayan matris'in tersi bulunmaz!";
                string title = "İşlem Hatası!";
                MessageBox.Show(message, title);
                return "0";
            }
            int ss = satirsayisi;
            float[,] b = new float[ss, ss];
            float[,] c = new float[ss, ss];
            for(int i=0; i<ss;++i)
            {
                for(int j=0;j<ss;++j)
                {
                    if (i == j)
                        b[i, j] = 1;
                    else
                        b[i, j] = 0;
                }
            }
            float d, k;
            for(int i=0;i<ss;++i)
            {
                d = matrix[i, i];
                for(int j=0;j<ss;++j)
                {
                    matrix[i, j] = matrix[i, j] / d;
                    b[i, j] = b[i, j] / d;
                }
                for(int x=0;x<ss;++x)
                {
                    if(x!=i)
                    {
                        k = matrix[x, i];
                        for(int j=0;j<ss;j++)
                        {
                            matrix[x, j] = matrix[x, j] - (matrix[i, j] * k);
                            b[x, j] = b[x, j] - (b[i, j] * k);
                        }
                    }
                }

            }
            string cikti_sonuc = "";
            for(int i=0; i < ss; ++i)
            {
                for(int j=0; j < ss; ++j)
                {
                    cikti_sonuc += b[i, j].ToString("0.#####") + " ";
                }
                cikti_sonuc += "\n";
            }
            cikti_sonuc = cikti_sonuc.Trim();
            cikti_sonuc = cikti_sonuc.Replace(" \n", "\n");
            return cikti_sonuc;
        }
        public static string MatrixCarp(string m1, string m2, int m1_satirsayisi, int m1_sutunsayisi, int m2_satirsayisi, int m2_sutunsayisi)
        {
            int[,] sonuc = new int[m1_satirsayisi, m2_sutunsayisi];
            for (int matrix1_row = 0; matrix1_row < m1_satirsayisi; matrix1_row++)
            {
                for (int matrix2_col = 0; matrix2_col < m2_sutunsayisi; matrix2_col++)
                {
                    for (int matrix1_col = 0; matrix1_col < m1_sutunsayisi; matrix1_col++)
                    {
                        sonuc[matrix1_row, matrix2_col] += MatrixTurn2Array(m1)[matrix1_row, matrix1_col] * MatrixTurn2Array(m2)[matrix1_col, matrix2_col];
                    }
                }
            }
            string cikti = "";
            for(int i = 0; i < sonuc.GetLength(0); ++i)
            {
                for(int k=0; k<sonuc.GetLength(1); ++k)
                {
                    cikti += sonuc[i, k] + " ";
                }
                cikti += "\n";
            }
            cikti = cikti.Trim();
            cikti = cikti.Replace(" \n", "\n");
            return cikti;
        }
        public static int[,] MatrixTurn2Array(string matrix)
        {
            matrix = matrix.Trim();
            matrix = matrix.Replace(" \n", "\n");
            string[][] MultiArray = matrix.Split('\n').Select(t => t.Split(' ')).ToArray();
            int dim1 = MultiArray.Length;
            int dim2 = MultiArray.Select(a => a.Length).Max();
            int[,] arr = new int[dim1, dim2];
            for (int i = 0; i < dim1; i++)
                for (int j = 0; j < MultiArray[i].Length; j++)
                    arr[i, j] = int.Parse(MultiArray[i][j]);
            return arr;
        }

    }
}
