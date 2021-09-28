using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaTeTiV01
{
    public partial class Form1 : Form
    {
        int player = 1;
        int[,] celdas = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        public Form1()
        {
            InitializeComponent();
        }

        public int winnerChek(int[,] celdas)
        {
            int contDiag1;
            for (int f = 0; f < celdas.GetLength(0); f++)//Analisis Horizontal
            {
                int cont = 0;
                for (int c = 0; c < celdas.GetLength(1); c++)
                {

                    if (celdas[f, c] == player) { cont++; }
                }
                if (cont == 3) { return player; }

            }
            for (int c = 0; c < celdas.GetLength(1); c++)//Analisis Vertical
            {
                int cont = 0;
                for (int f = 0; f < celdas.GetLength(0); f++)
                {

                    if (celdas[f, c] == player) { cont++; }
                }
                if (cont == 3) { return player; }

            }
            contDiag1 = 0;
            for (int c = 0; c < celdas.GetLength(0); c++)//Primera diagonal
            {

                if (celdas[c, c] == player) { contDiag1++; }

                if (contDiag1 == 3) { return player; }

            }
            contDiag1 = 0;
            for (int c = 0; c < celdas.GetLength(0); c++)//Segunda diagonal
            {

                if (celdas[c, Math.Abs(c - 2)] == player) { contDiag1++; }

                if (contDiag1 == 3) { return player; }

            }
            return 0;

        }
        public void playerClick(PictureBox box)
        {
            if (box.Image == null) { 
                fillMat(Convert.ToInt32(box.Tag));

                box.Image = System.Drawing.Image.FromFile($"C:\\Users\\Gregorio\\Desktop\\Programacios Imagenes\\Jugador{player}.png");
                if (winnerChek(celdas) > 0)
                {
                    MessageBox.Show($"El ganador es el Jugador {player}", "Resultado");                    
                }
                if (player == 1)
                {

                    player = 2;
                }
                else
                {
                    player = 1;

                }
                label2.Text = $"Jugador {player}";

             }
        }
        private void fillMat(int x)
        {
            switch (x)
            {
                case 1:
                    celdas[0, 0] = player;
                    break;
                case 2:
                    celdas[0, 1] = player;
                    break;
                case 3:
                    celdas[0, 2] = player;
                    break;
                case 4:
                    celdas[1, 0] = player;
                    break;
                case 5:
                    celdas[1, 1] = player;
                    break;
                case 6:
                    celdas[1, 2] = player;
                    break;
                case 7:
                    celdas[2, 0] = player;
                    break;
                case 8:
                    celdas[2, 1] = player;
                    break;
                case 9:
                    celdas[2, 2] = player;
                    break;

            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            playerClick((PictureBox)sender); ;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            playerClick(pictureBox2);

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            playerClick(pictureBox3);

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            playerClick(pictureBox5);

        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            playerClick(pictureBox6);

        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            playerClick(pictureBox7);

        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            playerClick(pictureBox8);

        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            playerClick(pictureBox9);

        }
        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            playerClick(pictureBox4);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();           
        }
    }
}
  
