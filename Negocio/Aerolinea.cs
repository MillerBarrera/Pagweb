using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Aerolinea_I_BELIVE_I_CAN_FLY;

namespace Aerolinea_I_BELIVE_I_CAN_FLY.Negocio
{
    public class Aerolinea
    {
        private long NIT = 88888;
        private string NOMBRE = "I belive i can fly";
        private double total;
        private short dia;
        public List<Usuarios> misusuarios;
        private List<Vuelos> mivuelos;
        internal Administrador miadmin;
    
        public Aerolinea ()
        {
            total = 0;
            dia = 0;
            mivuelos = new List<Vuelos>();
            misusuarios = new List<Usuarios>();
            miadmin = new Administrador();



        }
        public List<Usuarios> MUS
        {
            set { misusuarios = value; }
            get { return misusuarios; }
        }

        public double TOT
        {
            set { total = value;  }
            get { return total; }
        }
   

        internal Administrador MID
        {
            set { miadmin = value; }
            get { return miadmin; }
        }
        public bool buscarusu(long id)
        {
            bool sw = false;
            for (int i = 0; i < misusuarios.Count; i++)
            {
                if (misusuarios[i].ID == id)
                {
                    sw = true;
                    break;

                }
              
            }
            return sw;
        }
        public void regusu(Usuarios nuevo)
        {
            misusuarios.Add(nuevo);
        }
        public void elimiusu(Usuarios eliminado)

        {
            misusuarios.Remove(eliminado);
        }


       public int buscarpos(long id)
        {
            int i;
                for(i=0; i<misusuarios.Count; i++)
            {
                if (misusuarios[i].ID == id)
                    break;
            }
            return i;
        }
    
        public int buscarvuelo(long codigo)
        {
            int i;
            for (i = 0; i < mivuelos.Count; i++)
            {

            }
            return i;
        }
      
        public double DIA
        {
      
            get { return dia; }
        }
        public void aumentar(double pago)
        {
            total += pago;
        }
        public void pasar(double pago)
        {
            dia += 1;
        }
    }
}
