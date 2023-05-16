using Aerolinea_I_BELIVE_I_CAN_FLY.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerolinea_I_BELIVE_I_CAN_FLY
{
    public partial class Inicio : Form
    {
        private Aerolinea miaerolinea;
        private int usuario;
        public short actuali = 0;

        public Inicio(Aerolinea aux, int usu)
        {
            InitializeComponent();
            miaerolinea = aux;
            usuario = usu;
            if (usuario != -1)
            {
                button3.Visible = false;
                label2.Visible = false;
                button2.Visible = false;
                label4.Visible = false;
                button5.Visible = false;
                label1.Visible = false;
                button1.Visible = false;
                label3.Visible = false;
                button12.Visible = true;
                label12.Visible = true;



            }
            else
            {
                button2.Visible = false;
                label4.Visible = false;
                label2.Visible = false;
                button3.Visible = false;
                label11.Visible = false;
                button11.Visible = false;
                label6.Visible = false;
                button6.Visible = false;
                label7.Visible = true;
                button7.Visible = true;
                label9.Visible = false;
                button9.Visible = false;
                label8.Visible = false;
                button8.Visible = false;
            }
        }
      
        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {


        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
           
            Form cambiarperfil = new Form2(miaerolinea, usuario,0,9);
            cambiarperfil.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form cambiarperfil = new Form3(miaerolinea, -1);
            cambiarperfil.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form cambiarperfil = new Form3(miaerolinea, 0);
            cambiarperfil.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form adquirirt = new Form6(miaerolinea);
            adquirirt.ShowDialog();
        }
    }
}
