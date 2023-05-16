using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Aerolinea_I_BELIVE_I_CAN_FLY.Negocio
{
    public class Fecha
    {
        private short dia=0;
        private short anhio=0;
        private short mes;
        private Fecha minacimiento;
        private Fecha miactual;
        public Fecha()
        {
       
          
        }
      public Fecha MIN
        {
            set { minacimiento = value; }
            get { return minacimiento; }
        }

        public Fecha MIA
        {
            set { miactual = value; }
            get { return miactual; }

        }
        public short ME
        {
            set { mes = value; }
            get { return mes; }

        }
        public short DI
        {
            set { dia = value; }
            get { return dia; }

        }
        public short ANI
        {
            set { anhio = value; }
            get { return anhio; }

        }
    }
}