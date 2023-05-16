using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aerolinea_I_BELIVE_I_CAN_FLY.Negocio
{
    public class Vuelos
    {


        Random rnd = new Random();
        public double TotalPARG;
        public double TotalPNYW;
        public short TotalPPARIS;
        public double TotalPMAR;
        public double Numerodevuelo;
             



        public double ARGcodigo;
        public double NYWcodigo;
        public double PARIScodigo;
        public double MADRIDcodigo;
     

        public Vuelos()
        {
            Numerodevuelo = 0;
            ARGcodigo = rnd.Next(1, 10);
            NYWcodigo = rnd.Next(1, 10);
            PARIScodigo = rnd.Next(1, 10);
            MADRIDcodigo = rnd.Next(1, 10);
           
    }
        public double NDV
        {
            set { value = Numerodevuelo; }
            get { return Numerodevuelo; }
        }
        public double ARC
        {
            set { value = ARGcodigo; }
            get { return ARGcodigo; }
        }
        public double TLP
        {
           
            get { return TotalPNYW; }
        }
        public short TLN
        {
            set { value = TotalPPARIS; }
            get { return TotalPPARIS; }
        }
        public double TLM
        {
            set { value = TotalPMAR; }
            get { return TotalPMAR; }
        }

        public double TLA
        {
            set { value = TotalPARG; }
            get { return TotalPARG; }
        }
        public double NYC
        {
            set { value = NYWcodigo; }
            get { return NYWcodigo; }
        }
        public double PAC
        {
            set { value = PARIScodigo; }
            get { return PARIScodigo; }
        }
        public double MAC
        {
            set { value = MADRIDcodigo; }
            get { return MADRIDcodigo; }
        }
      

    }
}
