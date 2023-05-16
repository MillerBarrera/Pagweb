using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aerolinea_I_BELIVE_I_CAN_FLY.Negocio
{
    public class Usuarios:Personas
    {
        private string correo;
        public string telefono;
        private short edad;
        private Fecha minacimiento;
        private Fecha miactual;
        private Acceso miacceso;

        public Usuarios()
        {
            telefono = "";
            correo = "";
            edad = 0;
            minacimiento = new Fecha();
            miactual = new Fecha();
            miacceso = new Acceso(nombre, ide);
        }
       

         

        
        public string COR
        {
            set { correo = value; }
            get { return correo; }

        }
        public string TEL
        {
            set { telefono = value; }
            get { return telefono; }

        }
        public short EDA
        {
            set { edad = value; }
            get { return edad; }

        }
        public Acceso MIA
        {
            set { miacceso = value; }
            get { return miacceso; }
        }
    }
}
