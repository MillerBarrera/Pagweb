using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea_I_BELIVE_I_CAN_FLY.Negocio
{
    public class Personas
    {

        protected long ide;
        protected string nombre;
        protected short ingreso;
        public Personas()
        {
            ide = 0;
            nombre = "";
            ingreso = 0;



        }
        public short ING
        {
            set { ingreso = value; }
            get { return ingreso; }


        }
        public long ID
        {
            set { ide = value; }
            get { return ide; }

         }
      
        public string NOM
        {
            set { nombre = value; }
            get { return nombre; }


        }
        public void aumentar ()
        {
            ingreso++;

        }


    }
}
