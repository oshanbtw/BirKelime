using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirKelime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button9.Visible = false;

            string[] harf = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "U", "Ü", "P", "R", "S", "Ş", "T", "V", "Y", "Z" };
            Random rnd = new Random(); //Butonlara random harfler atıyor
            button1.Text = Convert.ToString(harf[rnd.Next(0, 29)]);
            button2.Text = Convert.ToString(harf[rnd.Next(0, 29)]);
            if(button2.Text == button1.Text) //Bu kısımdan 65. satıra kadar random gelen harflerin aynı olmamasını sağlayan kodlar
            {
                while(button2.Text == button1.Text)
                    button2.Text = Convert.ToString(harf[rnd.Next(0, 29)]);
            }
            button3.Text = Convert.ToString(harf[rnd.Next(0, 29)]);
            if (button3.Text == button1.Text || button3.Text == button2.Text)
            {
                while (button3.Text == button1.Text || button3.Text == button2.Text)
                    button3.Text = Convert.ToString(harf[rnd.Next(0, 29)]);
            }
            button4.Text = Convert.ToString(harf[rnd.Next(0, 29)]);
            if (button4.Text == button1.Text || button4.Text == button2.Text || button4.Text == button3.Text)
            {
                while (button4.Text == button1.Text || button4.Text == button2.Text || button4.Text == button3.Text)
                    button4.Text = Convert.ToString(harf[rnd.Next(0, 29)]);
            }
            button5.Text = Convert.ToString(harf[rnd.Next(0, 29)]);
            if (button5.Text == button1.Text || button5.Text == button2.Text || button5.Text == button3.Text || button5.Text == button4.Text)
            {
                while (button5.Text == button1.Text || button5.Text == button2.Text || button5.Text == button3.Text || button5.Text == button4.Text)
                    button5.Text = Convert.ToString(harf[rnd.Next(0, 29)]);
            }
            button6.Text = Convert.ToString(harf[rnd.Next(0, 29)]);
            if (button6.Text == button1.Text || button6.Text == button2.Text || button6.Text == button3.Text || button6.Text == button4.Text || button6.Text == button5.Text)
            {
                while (button6.Text == button1.Text || button6.Text == button2.Text || button6.Text == button3.Text || button6.Text == button4.Text || button6.Text == button5.Text)
                    button6.Text = Convert.ToString(harf[rnd.Next(0, 29)]);
            }
            button7.Text = Convert.ToString(harf[rnd.Next(0, 29)]);
            if (button7.Text == button1.Text || button7.Text == button2.Text || button7.Text == button3.Text || button7.Text == button4.Text || button7.Text == button5.Text || button7.Text == button6.Text)
            {
                while (button7.Text == button1.Text || button7.Text == button2.Text || button7.Text == button3.Text || button7.Text == button4.Text || button7.Text == button5.Text || button7.Text == button6.Text)
                    button7.Text = Convert.ToString(harf[rnd.Next(0, 29)]);
            }
            button8.Text = Convert.ToString(harf[rnd.Next(0, 29)]);
            if (button8.Text == button1.Text || button8.Text == button2.Text || button8.Text == button3.Text || button8.Text == button4.Text || button8.Text == button5.Text || button8.Text == button6.Text || button8.Text == button7.Text)
            {
                while (button8.Text == button1.Text || button8.Text == button2.Text || button8.Text == button3.Text || button8.Text == button4.Text || button8.Text == button5.Text || button8.Text == button6.Text || button8.Text == button7.Text)
                    button8.Text = Convert.ToString(harf[rnd.Next(0, 29)]);
            }



        }


        private void button10_Click(object sender, EventArgs e) //BUL BUTONU
        {
            StreamReader oku, oku2; //Dosyamızı okuyacak.
            oku = File.OpenText("D:/Dosyalarım/CBÜ ALDIĞIM DERSLER/2.Sınıf 2.Dönem/Yazılım Yapımı/kelimeler.txt"); // Dosyayı açıyor.

            string sayma;
            int sayac = 0, i = 0, j;
            int arti = 0, harfsayac;
            bool _bool;
            string[] harf = new string[8];
            
            harf[0] = button1.Text; //Butonlardaki textleri diziye atıyor.
            harf[1] = button2.Text;
            harf[2] = button3.Text;
            harf[3] = button4.Text;
            harf[4] = button5.Text;
            harf[5] = button6.Text;
            harf[6] = button7.Text;
            harf[7] = button8.Text;

            harf[0] = button1.Text;
            while ((sayma = oku.ReadLine()) != null) // Satır boş olana kadar okusun. Dizimizin limitini belirliyoruz. Kaç kelime var öğreniyoruz.
            {
                sayac++;
            }
            oku.Close();
            oku2 = File.OpenText("D:/Dosyalarım/CBÜ ALDIĞIM DERSLER/2.Sınıf 2.Dönem/Yazılım Yapımı/kelimeler.txt"); // Dosyayı açıyor.
            string[] kelimeler = new string[sayac]; //Kelimeleri koyacağımız diziyi oluşturuyorum. Boyutu Kelimeler kadar.
            i = 0;
            while (oku2.EndOfStream != true)//Txt dosyamızdeki kelimeleri diziye aktarıyoruz.
            {
                kelimeler[i] = oku2.ReadLine();
                i++;
            }
            oku2.Close();
            
            //EKRANA YAZDIRMA KISMI
            for(i=0; i<sayac; i++)
            {
                arti = 0;
                harfsayac = 0;
                harfsayac = kelimeler[i].Length;
                
                if(harfsayac == 3)  //3 HARFLİ SAYILAR İÇİN EKRANA YAZDIRMA
                {
                    for(j=0; j<8; j++)
                    {
                        _bool = false;
                        _bool = kelimeler[i].Contains(harf[j]);
                        if (_bool == true)
                            arti++;
                    }
                    if (arti >= 2)
                        listBox1.Items.Add(kelimeler[i]);
                }

                if (harfsayac == 4)  //4 HARFLİ SAYILAR İÇİN EKRANA YAZDIRMA
                {
                    for (j = 0; j < 8; j++)
                    {
                        _bool = false;
                        _bool = kelimeler[i].Contains(harf[j]);
                        if (_bool == true)
                            arti++;
                    }
                    if (arti >= 3)
                        listBox1.Items.Add(kelimeler[i]);
                }

                if (harfsayac == 5)  //5 HARFLİ SAYILAR İÇİN EKRANA YAZDIRMA
                {
                    for (j = 0; j < 8; j++)
                    {
                        _bool = false;
                        _bool = kelimeler[i].Contains(harf[j]);
                        if (_bool == true)
                            arti++;
                    }
                    if (arti >= 4)
                        listBox1.Items.Add(kelimeler[i]);
                }

                if (harfsayac == 6)  //6 HARFLİ SAYILAR İÇİN EKRANA YAZDIRMA
                {
                    for (j = 0; j < 8; j++)
                    {
                        _bool = false;
                        _bool = kelimeler[i].Contains(harf[j]);
                        if (_bool == true)
                            arti++;
                    }
                    if (arti >= 5)
                        listBox1.Items.Add(kelimeler[i]);
                }

                if (harfsayac == 7)  //7 HARFLİ SAYILAR İÇİN EKRANA YAZDIRMA
                {
                    for (j = 0; j < 8; j++)
                    {
                        _bool = false;
                        _bool = kelimeler[i].Contains(harf[j]);
                        if (_bool == true)
                            arti++;
                    }
                    if (arti >= 6)
                        listBox1.Items.Add(kelimeler[i]);
                }

                if (harfsayac == 8)  //8 HARFLİ SAYILAR İÇİN EKRANA YAZDIRMA
                {
                    for (j = 0; j < 8; j++)
                    {
                        _bool = false;
                        _bool = kelimeler[i].Contains(harf[j]);
                        if (_bool == true)
                            arti++;
                    }
                    if (arti >= 7)
                        listBox1.Items.Add(kelimeler[i]);
                }

                if (harfsayac == 9)  //9 HARFLİ SAYILAR İÇİN EKRANA YAZDIRMA
                {
                    for (j = 0; j < 8; j++)
                    {
                        _bool = false;
                        _bool = kelimeler[i].Contains(harf[j]);
                        if (_bool == true)
                            arti++;
                    }
                    if (arti >= 8)
                        listBox1.Items.Add(kelimeler[i]);
                }
            }

            button9.Visible = true;
            button10.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            button9.Visible = false;
            button10.Visible = true;
        }
    }
}
