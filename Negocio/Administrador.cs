using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea_I_BELIVE_I_CAN_FLY;

namespace Aerolinea_I_BELIVE_I_CAN_FLY.Negocio
{
    class Administrador:Personas
    {
        public long telefono;
        public short pass2;
        public Acceso miacceso;
        public VentasDiarias misventas;
        public Administrador()
        {
            nombre = "a";
            ide = 1;
            pass2 = 1;
            telefono = 0;
           
            miacceso = new Acceso(nombre, ide);
            misventas = new VentasDiarias();
        }
        public short PW2
        {
            set { pass2 = value; }
            get { return  pass2; }
        }
        public VentasDiarias VTD
        {
            set { misventas = value; }
            get { return misventas; }
        }
        public void cambiardia()
        {
            misventas = null;
            misventas = new VentasDiarias();
        }
        public Acceso MIA
        {
            set { miacceso = value; }
            get { return miacceso; }
        }
    }
}
