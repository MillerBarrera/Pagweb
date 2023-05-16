
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea_I_BELIVE_I_CAN_FLY.Negocio
{
    public class VentasDiarias
    {
        public long ventas;
        private double costo;
        public double argentina;
        public double newyork;
        public double paris;
        public double madrid;
        public double clase1;
        public double clase2;
        public double clase3;
        public double asientos;
        public double asientosocupados;


        public VentasDiarias()
        {
            ventas = 0;
            clase1 = 100000;
            clase2 = 300000;
            clase3 = 50000;
            costo = 0;
        
        }
        public long VEN
        {
            set { ventas = value; }
            get { return ventas; }
        }
        public double COS
        {
           
            get { return costo; }
        }
        public void calcularcostoarg()
        {
            argentina = 200 * 681;
        }
        public void calcularcostomad()
        {
            madrid = 200 * 8007;
        }
        public void calcularcostonw()
        {
            newyork = 200 * 4009;
        }
        public void calcularcostoparis()
        {
            paris = 200 * 8633;
        }
        public double ARG
        {

            get { return argentina; }
        }
        public double MAD
        {

            get { return madrid; }
        }
        public double NEW
        {

            get { return newyork; }

        }
        public double PAR
        {

            get { return paris; }
        }
        public double CL1
        {

            get { return clase1; }
        }
        public double CL2
        {

            get { return clase2; }
        }
        public double CL3
        {

            get { return clase3; }
        }
    }
}
