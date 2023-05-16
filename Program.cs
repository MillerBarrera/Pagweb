using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aerolinea_I_BELIVE_I_CAN_FLY;
using Aerolinea_I_BELIVE_I_CAN_FLY.Negocio;


namespace Aerolinea_I_BELIVE_I_CAN_FLY
{
  

    static class Program
    {
        

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
