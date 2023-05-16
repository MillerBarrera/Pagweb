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
    public partial class Form3 : Form
    {
        private int usuario;
        private Aerolinea miaerolinea;
        private Vuelos misvuelos;
        private short numerov;
        private string sillitas;


        public Form3(Aerolinea aux, int usu)
        {
            InitializeComponent();
            if (usu != 0)
            {
                panel3.Visible = false;
           
                {

                }
            }
            else
            {
                panel3.Visible = false;
            }
            

        }
    
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Enabled = true;
            textBox1.Visible = false;
            button1.Visible = false;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            numerov = 1;
            panel3.Visible = true;
            panel3.Enabled = false;
            label2.Text = "Bogota-COL";
            label4.Text = "BuenosAires-ARG";
            comboBox1.Text = "Todas";
            textBox1.Text = "$$";
            textBox2.Text = "";
            textBox3.Enabled = false;
            misvuelos.TLA = 14;
            if(misvuelos.TLA<180)
            {
                label14.Visible = true;

            }
            else
            {
                label15.Visible = true;

            }





        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            numerov = 2;
            panel3.Visible = true;
            panel3.Enabled = false;
            label2.Text = "Bogota-COL";
            label4.Text = "Madrid-MDR";
            comboBox1.Text = "Todas";
            textBox1.Text = "$$";
            textBox2.Text = "";
           
            textBox3.Enabled = false;
          

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            numerov = 3;
            panel3.Visible = true;
            panel3.Enabled = false;
            textBox3.Enabled = false;
            label2.Text = "Bogota-COL";
            label4.Text = "Paris-PRI";
            comboBox1.Text = "Todas";
            textBox1.Text = "$$";
            textBox2.Text = "";
           
            textBox3.Text = "Sale el 2 de Agosto a las 9 PM, compuerta 6";
            

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            numerov = 4;
            textBox3.Enabled = false;
            textBox3.Text = "Sale el 2 de Agosto a las 11 am, compuerta 6";
            panel3.Visible = true;
            panel3.Enabled = false;
            label2.Text = "Bogota-COL";
            label4.Text = "New York City-NTY";
            comboBox1.Text = "Todas";
            textBox1.Text = "$$";
            textBox2.Text = "";
         

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
