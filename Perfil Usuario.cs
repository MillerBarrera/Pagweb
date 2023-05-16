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
    public partial class Form2 : Form
    {
        private Aerolinea miaerolinea;
        private long telefono;
        private int usuario;
        private int posibleusu;
        private int actualizar;

        private Usuarios miusuario;

        public Form2(Aerolinea aux, int pusu, int op, int act)
        {
            InitializeComponent();
            miaerolinea = aux;
            telefono = 0;

            posibleusu = pusu;
            miusuario = new Usuarios();
            if (op == 1)
            {
                label10.Visible = false;
                pictureBox3.Visible = false;
            }
            if (pusu == -1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                label4.Visible = false;
                textBox1.Visible = false;
                panel1.Visible = false;
                label9.Visible = true;
                button1.Visible = false;
                button2.Visible = true;
                label3.Visible = true;
                textBox2.Visible = true;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;


            }
            else
            {
                panel2.Visible = false;
                pictureBox1.Enabled = false;
                label3.Visible = false;
                textBox2.Visible = false;
                label1.Text = "Login/Nombre";
            }
            if (act == 9)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                label4.Visible = false;
                textBox1.Visible = false;
                panel1.Visible = false;
                panel2.Visible = true;
                label9.Visible = true;
                button1.Visible = false;
                button2.Visible = true;
                label3.Visible = true;
                textBox2.Visible = true;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label3.Visible = false;
                textBox2.Visible = false;
                actualizar = 9;
            }

           
            }
        
    


            

        

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                long ide = 0;
                try
                {

                    ide = long.Parse(textBox1.Text);
                    if (ide <= 0)
                    {
                        MessageBox.Show("0Por favor la identificacion de un vendedor debe ser diferente a 0 ni tampoco negativa", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                    }
                    else
                    {
                        if (miaerolinea.buscarusu(ide) == true)
                        {
                            MessageBox.Show("Por favor el vendedor ya existe ", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBox1.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("El vendedor es nuevo, ingrese los demas datos ", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            panel2.Visible = true;
                            pictureBox1.Enabled = true;
                            miusuario.ID = ide;
                        }


                    }
                }
                catch (SystemException error)
                {
                    MessageBox.Show("12Por favor la identificacion de un vendedor debe ser numerica", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (actualizar != 9)
            {
                try
                {
                    long pass2n = 0;

                    string loginn = textBox3.Text;

                    long pass1n = long.Parse(textBox4.Text);

                    pass2n = short.Parse(textBox2.Text);
                    telefono = long.Parse(textBox6.Text);


                    if (pass1n <= 0 || pass2n <= 0 || telefono <= 0)
                    {
                        MessageBox.Show("Por favor alguno de los dos passwrods y/o el telefono, no es numerico o negativo intentelo de nuevo\n", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Text = "";
                        textBox4.Text = "";
                        textBox6.Text = "";
                    }
                    else
                    {


                        if (miaerolinea.MID.MIA.LOG != loginn && miaerolinea.MID.MIA.PW1 != pass1n && miaerolinea.MID.PW2 != pass2n)
                        {
                            MessageBox.Show("Se actualizo correctamente, felicidades\n", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            miaerolinea.MID.MIA.LOG = loginn;
                            miaerolinea.MID.MIA.PW1 = pass1n;
                            miaerolinea.MID.MIA.PW1 = pass2n;
                            miaerolinea.MID.aumentar();
                            Form mimenu = new Inicio(miaerolinea, -1);
                            mimenu.ShowDialog();
                            Application.Exit();

                        }
                        else
                        {
                            MessageBox.Show("Por favor los passwords y/o login son los mismos\n", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            textBox2.Text = "";
                            textBox4.Text = "";

                            textBox6.Text = "";

                        }

                    }
                }
                catch (SystemException error)
                {


                    MessageBox.Show("Por favor alguno de los dos passwrods no es numerico intentelo de nuevo\n" + error.Message, "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox2.Text = "";
                    textBox4.Text = "";

                }
            }
            else
            {
                try
                {
                  

                    string loginn = textBox3.Text;

                    long pass1n = long.Parse(textBox4.Text);

                    telefono = long.Parse(textBox6.Text);


                    if (pass1n <= 0 || telefono <= 0)
                    {
                        MessageBox.Show("Por favor alguno de los dos passwrods y/o el telefono, no es numerico o negativo intentelo de nuevo\n", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Text = "";
                        textBox4.Text = "";
                        textBox6.Text = "";
                    }
                    else
                    {


                        if (miaerolinea.MID.MIA.LOG != loginn && miaerolinea.MID.MIA.PW1 != pass1n)
                        {
                            MessageBox.Show("Se actualizo correctamente, felicidades\n", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            miaerolinea.MID.MIA.LOG = loginn;
                            miaerolinea.MID.MIA.PW1 = pass1n;
                         
                            miaerolinea.MID.aumentar();
                            Form mimenu = new Inicio(miaerolinea, -1);
                            mimenu.ShowDialog();
                            Application.Exit();

                        }
                        else
                        {
                            MessageBox.Show("Por favor los passwords y/o login son los mismos\n", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            textBox2.Text = "";
                            textBox4.Text = "";

                            textBox6.Text = "";

                        }

                    }
                }
                catch (SystemException error)
                {


                    MessageBox.Show("Por favor alguno de los dos passwrods no es numerico intentelo de nuevo\n" + error.Message, "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox2.Text = "";
                    textBox4.Text = "";
                }
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (actualizar != 9)
            {
                {
                    try
                    {
                        long pass2 = 0;
                        string login = textBox3.Text;
                        long pass1 = long.Parse(textBox4.Text);
                        pass2 = short.Parse(textBox2.Text);


                        if (pass1 <= 0 || pass2 <= 0)
                        {
                            MessageBox.Show("13Por favor alguno de los dos passwrods no es numerico o negativo intentelo de nuevo\n", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox2.Text = "";
                            textBox4.Text = "";
                        }

                        if (miaerolinea.MID.MIA.LOG == login && miaerolinea.MID.MIA.PW1 == pass1 && miaerolinea.MID.PW2 == pass2)

                        {

                            MessageBox.Show("Señor Administrador puede cambiar sus acceso", "MENSAJE DE INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            textBox5.Visible = true;
                            textBox6.Visible = true;

                            label5.Visible = true;
                            label6.Visible = true;

                            button2.Visible = false;
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            label1.Text = "Nuevo Login";
                            label2.Text = "Nuevo PassWord";
                            label3.Text = "Nuevo Segundo PassWord";



                        }
                        else
                        {
                            MessageBox.Show("Su acceso no es valido", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                        }
                    }



                    catch (SystemException error)
                    {


                        MessageBox.Show("14Por favor alguno de los dos passwrods no es numerico intentelo de nuevo\n" + error.Message, "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBox2.Text = "";
                        textBox4.Text = "";

                    }
                }
            }
            else
            {
                try
                {

                    string login = textBox3.Text;
                    long pass1 = long.Parse(textBox4.Text);



                    if (pass1 <= 0)
                    {
                        MessageBox.Show("1Por favor alguno de los dos passwrods no es numerico o negativo intentelo de nuevo\n", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Text = "";
                        textBox4.Text = "";
                    }
                    for (int i = 0; i < miaerolinea.MUS.Count; i++)
                    {
                        if (miaerolinea.MUS[i].MIA.LOG == login && miaerolinea.MUS[i].MIA.PW1 == pass1)

                        {

                            MessageBox.Show("Señor usuario puede cambiar sus acceso", "MENSAJE DE INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            textBox5.Visible = true;
                            textBox6.Visible = true;

                            label5.Visible = true;
                            label6.Visible = true;

                            button2.Visible = false;
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            label1.Text = "Nuevo Login";
                            label2.Text = "Nuevo PassWord";




                        }
                        else
                        {
                            MessageBox.Show("88Su acceso no es valido", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                        }





                    }
                }
                catch (SystemException error)
                {


                    MessageBox.Show("3Por favor alguno de los dos passwrods no es numerico intentelo de nuevo\n" + error.Message, "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox2.Text = "";
                    textBox4.Text = "";

                }
            }
        
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (actualizar != 9)
            {

                if (textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "" || textBox7.Text == "")
                {
                    MessageBox.Show("Algunos datos del usuario falta, corrigalos", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    DialogResult res = MessageBox.Show("Esta seguro que estos datos son los correctos?", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {

                        miusuario.MIA.LOG = textBox3.Text;
                        miusuario.MIA.PW1 = miusuario.ID;
                        miusuario.TEL = textBox6.Text;
                        miusuario.COR = textBox5.Text;

                        miaerolinea.regusu(miusuario);
                        MessageBox.Show("Se registro correctamente", "MENSAJE DE FELICIDADES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose(true);








                    }

                }
            }
        }
       
}
}
           
            
        