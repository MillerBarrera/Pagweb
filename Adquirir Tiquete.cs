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
    public partial class Form6 : Form
    {
        private short numerov;
        private Vuelos misvuelos;
        private VentasDiarias misv;
        private long economica;
        private long ejecutiva;
        private long primeraclase;
        private Aerolinea miaerolinea;

        public Form6(Aerolinea aux)
        {
            InitializeComponent();
            economica = 150000;
            ejecutiva = 300000;
            primeraclase = 500000;
            miaerolinea = aux;
            panel3.Visible = false;





        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numerov == 1)
            { switch (comboBox1.SelectedIndex)
                {
                    case 0:
                      
             break;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            numerov = 1;
            panel3.Visible = true;
            if(misvuelos.TLA<180)
            {

            }
       
          
      
          
    }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            numerov = 2;
            panel3.Visible = true;
            
           
  
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            numerov = 3;
          
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            numerov = 4;
        
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
