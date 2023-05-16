using Aerolinea_I_BELIVE_I_CAN_FLY.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerolinea_I_BELIVE_I_CAN_FLY
{
    public partial class Login : Form
        
    {

        private bool usuario;
        private Aerolinea miaerolinea;
        private bool nousuario;
        public Login()
        {
            InitializeComponent();
            usuario = false;
            miaerolinea = new Aerolinea();
            nousuario = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "Administrador";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "Usuario";
            textBox3.Visible = false;
            label3.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            usuario = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
                try
                {
                nousuario = false;
                    long pass2 = 0;
                    string login = textBox1.Text;
                    long pass1 = long.Parse(textBox2.Text);
                    if (pass1 <= 0)

                    {
                        MessageBox.Show("Por favor el password no puede ser cero o menor a cero\n", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Text = "";
                        textBox3.Text = "";

                    }
                if (usuario == true)
                {
                    for (int i = 0; i < miaerolinea.MUS.Count; i++)
                    {
                        if (miaerolinea.MUS[i].MIA.LOG == login && miaerolinea.MUS[i].MIA.PW1 == pass1)

                        {


                            nousuario = true;
                            MessageBox.Show("Bienvenido al sistema señor usuario:", "Mensaje de Bienvenida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            Form mimenu = new Inicio(miaerolinea, -1);
                            mimenu.ShowDialog();

                        }
                    }
                }
                if (usuario == false)
                {
                  

                    pass2 = short.Parse(textBox3.Text);
                }
                if (pass1 <= 0 || pass2 <= 0)
                {
                    MessageBox.Show("Por favor alguno de los dos passwrods no es numerico o negativo intentelo de nuevo\n", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
               
                else
                {
                    if (miaerolinea.MID.MIA.LOG == login && miaerolinea.MID.MIA.PW1 == pass1 && miaerolinea.MID.PW2 == pass2)

                    {
                       
                        MessageBox.Show("Bienvenido al sistema señor administrador:", "Mensaje de Bienvenida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        nousuario = true;
                        if (miaerolinea.MID.ING == 0)
                        {
                            MessageBox.Show("Señor administrador es su primer ingreso y por lo cual debera cambiar el acceso:", "Mensaje de Bienvenida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            miaerolinea.MID.aumentar();
                            Form cambiarperfil = new Form2(miaerolinea, -1,0,1);
                            cambiarperfil.ShowDialog();
                            this.Dispose(true);

                        }
                        else
                        {
                            Form mimenu = new Inicio(miaerolinea, -1);
                            mimenu.ShowDialog();
                        }
                    }
                }
                if(nousuario==false)
                {
                    MessageBox.Show("Disculpe usted no hace parte del sistemas, lo sentimos; BYEE!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }









            catch (SystemException error)
            {
                if (usuario == false)
                
                {
                    MessageBox.Show("Por favor alguno de los dos passwrods no es numerico intentelo de nuevo\n" + error.Message, "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox2.Text = "";
                    textBox3.Text = "";
                }
                else
                {
                    MessageBox.Show("Por favor alguno de los dos passwrods no es numerico intentelo de nuevo\n" + error.Message, "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Text = "";

                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            

               
                Form cambiarperfil = new Form2(miaerolinea, 2,0,1);
                cambiarperfil.ShowDialog();
                checkBox1.Checked = false;
                
            
        }
    }
}
