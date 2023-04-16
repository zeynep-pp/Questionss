using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question1FormsApplication
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label2.Text = " Öğrenci Numarası: " + Form1.studentNumber;
            label3.Text = "";
            string mystring = Form1.studentNumber;
            string lastTwo = "";
            if (mystring.Length >= 2)
            {
                 lastTwo = mystring.Substring(mystring.Length - 2);
            }
            if (lastTwo.Length > 0)
            {
                if (lastTwo.Equals("56"))
                {
                    label3.Text = "Şehir Bilgisi: Siirt \n" +
                                  "Yüzölçümü: 11.003 km² Nüfus: 243.435(1990)\n" +
                                  "İl Trafik No: 56. \n" +
                                  "GEZİLECEK YERLER.\n" +
                                  "Cami ve Türbeler Ulu Cami: Çinili Minare olarak anılan Ulu Caminin minaresi, tipik Selçuklu mimarisini yansıtmaktadır.\n Siirt'te Veysel Karani Hz. Türbesi ve İbrahim Hakkı Hz. Türbesi bulunmaktadır.";

                    PictureBox obj = this.Controls.Find("pictureBox1", true).FirstOrDefault() as PictureBox;
                    if (obj != null)
                    {
                        obj.Image = Properties.Resources.siirt;
                        obj.Visible = true; // Siirt resmi 
                    }
                }
                else
                {
                    label3.Text = "Son iki rakamı 56 olmayan bir öğrenci numarası girdiniz.";
                }           
            }
            else{
                label3.Text = "Son iki rakamı 56 olmayan bir öğrenci numarası girdiniz.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 back = new Form1();
            back.Show();
        }
    }
}
