using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int credits = 1000;
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show($"Comienza la partida. Se le cargaron {credits} creditos", "Bienvenido!");
            Creds.Text = credits.ToString();


        }      

        private void button1_Click(object sender, EventArgs e)
        {
             

            Random rnd = new Random();

            int slot1 = rnd.Next(1, 5); //Obtengo un numero al azar del 1 al 6
            int slot2 = rnd.Next(1,5); //Obtengo un numero al azar del 1 al 6
            int slot3 = rnd.Next(1, 5);
            int shot = Convert.ToInt32(numericUpDown2.Value);
            
            credits=credits - shot;
            Creds.Text = credits.ToString();     
            shot = shot*SlotsMultiplyer(slot1, slot2, slot3);
            credits = credits + shot;
            rollSlots();
            //Impresion de resultado final
            pictureBox1.Image = System.Drawing.Image.FromFile($"C:\\Users\\Gregorio\\Desktop\\Programacios Imagenes\\Fruta{slot1}.png");
            pictureBox2.Image = System.Drawing.Image.FromFile($"C:\\Users\\Gregorio\\Desktop\\Programacios Imagenes\\Fruta{slot2}.png");
            pictureBox3.Image = System.Drawing.Image.FromFile($"C:\\Users\\Gregorio\\Desktop\\Programacios Imagenes\\Fruta{slot3}.png");
           // pictureBox4.Image = System.Drawing.Image.FromFile($"C:\\Users\\Gregorio\\Desktop\\Programacios Imagenes\\Fruta{slot4}.png");
            Creds.Text = credits.ToString();
            linkLabel1.Text = shot.ToString();

        }  
        private int SlotsMultiplyer(int slot1, int slot2, int slot3)
        {
            int multiplyer = 0;
            if (slot1 == slot2 && slot2 == slot3) { multiplyer = multiplyer + 4*(slot1+1); }
            else {
                if (slot1 == slot2 || slot2 == slot3)
                {
                    {
                        if (slot1 == slot2) { multiplyer = multiplyer + 2*(slot1+1); }

                        if (slot2 == slot3 ) { multiplyer = multiplyer + 2*(slot2 + 1); }                     
                    }
                   

                }  
            }
            return multiplyer;
        }
        private void rollSlots()
        {
            Random rnd = new Random();
            int vueltas = rnd.Next(15, 30);
            for (int i = 1; i < vueltas; i++)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile($"C:\\Users\\Gregorio\\Desktop\\Programacios Imagenes\\Fruta{rnd.Next(1, 5)}.png");
                pictureBox2.Image = System.Drawing.Image.FromFile($"C:\\Users\\Gregorio\\Desktop\\Programacios Imagenes\\Fruta{rnd.Next(1, 5)}.png");
                pictureBox3.Image = System.Drawing.Image.FromFile($"C:\\Users\\Gregorio\\Desktop\\Programacios Imagenes\\Fruta{rnd.Next(1, 5)}.png");
               // pictureBox4.Image = System.Drawing.Image.FromFile($"C:\\Users\\Gregorio\\Desktop\\Programacios Imagenes\\Fruta{rnd.Next(1, 5)}.png");
                this.Refresh(); //Se usa la funcion refresh para que actualice el formulario.
                Thread.Sleep(42);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Creds_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
