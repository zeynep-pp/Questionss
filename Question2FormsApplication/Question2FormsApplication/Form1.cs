using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question2FormsApplication
{
    public partial class Form1 : Form
    {
        //Oyun değişkenleri
        int playerTurn = 1; // oyunda sıranın şu an kimde olduğunu gösterir.
        int objectCount = 10;
        string player1Name = "Computer";
        string player2Name = "Emre";
        PictureBox obj;
        public Form1()
        {
            InitializeGame();
            InitializeComponent();
            // Başlangıçta oyun değişkenlerinin değerlerini etiketlere yazdırıyoruz.
            labelPlayer1.Text = player1Name;
            labelPlayer2.Text = player2Name;
            labelObjects.Text = objectCount.ToString();
            labelPlayer1Score.Text = "0";
            labelPlayer2Score.Text = "0";
        
        }

        private void labelPlayer1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            //Kullanıcının tek seferde alabileceği obje sayısını numericUpdDownTake arayüz öğesi ile alıyoruz.
            int selectedCount = (int)numericUpDownTake.Value;

            // Seçilen nesne sayısı uygun değilse hata mesajı ver
            if (selectedCount < 1 || selectedCount > 2)
            {
                MessageBox.Show("Geçersiz nesne sayısı, 1 veya 2 seçin.");
                return;
            }

            //Seçilen nesne sayısı, toplan nesne sayısında büyük olamaz.
            if (selectedCount > objectCount)
            {
                MessageBox.Show("Yeterli sayıda nesne alınmalıdır!", "  Error");
                return;
            }

            //Seçilen nesne sayısı, 0 veya negatif sayı olamaz.
            if (selectedCount <= 0)
            {
                MessageBox.Show("En az 1 nesne almalısınız!", "  Error");
                return;
            }

            //Seçilen nesne sayısını toplam nesne sayısından çıkarıyoruz.
            for (int i = objectCount; i > objectCount - selectedCount; i--)
            {
                PictureBox obj = this.Controls.Find("pictureBox" + i.ToString(), true).FirstOrDefault() as PictureBox;
                if (obj != null)
                {
                    obj.Image = Properties.Resources.fruit_taken;
                    obj.Visible = false; // Nesne alındığı için görünmez yapıyoruz
                }
            }

            //Seçilen nesne sayısını toplam nesne sayısından çıkarıyoruz.
            objectCount = objectCount - selectedCount;

            //Seçilen nesne sayısına göre, sırayla oyuncuların puanlarını artırıyoruz.
            if (playerTurn == 1)
            {
                int currentScore = int.Parse(labelPlayer1Score.Text);
                labelPlayer1Score.Text = (currentScore + selectedCount).ToString();
            }
            else
            {
                int currentScore = int.Parse(labelPlayer2Score.Text);
                labelPlayer2Score.Text = (currentScore + selectedCount).ToString();
            }

            //Nesne sayısını ekrana yazdırıyoruz.
            labelObjects.Text = objectCount.ToString();

            //Oyunun bitip bitmediğini kontrol ediyoruz.
            if (objectCount == 0)
            {
                //Kazananı mesaj kutusunda gösteriyoruz.
                string winnerName = "";
                if (playerTurn == 1)
                {
                    winnerName = player2Name;
                    MessageBox.Show(player1Name + " wins!", "Game Over");
                }
                else
                {
                    winnerName = player1Name;
                    MessageBox.Show(player2Name + " wins!", "Game Over");
                }

                //Oyunu yeniden başlatıyoruz.
                labelObjects.Text = objectCount.ToString();
                labelPlayer1Score.Text = "0";
                labelPlayer2Score.Text = "0";
                playerTurn = 1;
                return;
            }

            //Sırayı diğer oyuncuya geçiriyoruz.
            if (playerTurn == 1)
            {
                playerTurn = 2;
                ComputerTurn();
            }
            else
            {
                playerTurn = 1;
            }


            // Sıranın kimde olduğunu ekranda gösteriyoruz*/
            labelTurn.Text = "Turn: " + ((playerTurn == 1) ? player1Name : player2Name);


        }


    

    private void ComputerTurn()
    {
        int selectedCount = 0;
        // Bilgisayarın hamlesi
        // Rastgele 1 veya 2 nesne alacak şekilde ayarlıyoruz.
        Random rnd = new Random();
        selectedCount = rnd.Next(1, 3);

        //Seçilen nesne sayısı, toplan nesne sayısında büyük olamaz.
        if (selectedCount > objectCount)
        {
            selectedCount = objectCount;
        }

        //Seçilen nesne sayısını toplam nesne sayısından çıkarıyoruz.
        for (int i = objectCount; i > objectCount - selectedCount; i--)
        {
            PictureBox obj = this.Controls.Find("pictureBox" + i.ToString(), true).FirstOrDefault() as PictureBox;
            if (obj != null)
            {
                obj.Image = Properties.Resources.fruit_taken;
                obj.Visible = false; // Nesne alındığı için görünmez yapıyoruz
            }
        }

        //Seçilen nesne sayısını toplam nesne sayısından çıkarıyoruz.
        objectCount = objectCount - selectedCount;

        //Seçilen nesne sayısına göre, bilgisayarın puanını artırıyoruz.
        int currentScore = int.Parse(labelPlayer1Score.Text);
        labelPlayer1Score.Text = (currentScore + selectedCount).ToString();

        //Nesne sayısını ekrana yazdırıyoruz.
        labelObjects.Text = objectCount.ToString();

        //Oyunun bitip bitmediğini kontrol ediyoruz.
        if (objectCount == 0)
        {
            string winnerName = player1Name;
            // Kazananı mesaj kutusunda gösteriyoruz
            MessageBox.Show(player1Name + " wins!", "Game Over");

            //Oyunu yeniden başlatıyoruz.
            labelObjects.Text = objectCount.ToString();
            labelPlayer1Score.Text = "0";
            labelPlayer2Score.Text = "0";
            playerTurn = 1;
            return;
        }

        //Sırayı diğer oyuncuya geçiriyoruz.
        playerTurn = 2;
    }




        private void InitializeGame()
        {
            // Nesneleri ekrana yerleştiriyoruz
            int x = 50;
            for (int i = 1; i <= objectCount; i++)
            {
                obj = new PictureBox();
                obj.Name = "pictureBox" + i.ToString();
                obj.Image = Properties.Resources.fruit_taken;
                obj.SizeMode = PictureBoxSizeMode.StretchImage;
                obj.Size = new Size(50, 50);
                obj.Location = new Point(x, 100);
                this.Controls.Add(obj);
                x += 60; // Nesnelerin yatay konumunu ayarlıyoruz
                obj.Visible = true;
            }

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
