using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea_I_BELIVE_I_CAN_FLY.Negocio
{
    public class Acceso
    {
        private string login;
        private long password;
        private string telefono;
        public Acceso (string nom, long id)
        {
            login = nom;
            password =  id    ;
          
        }
        public string LOG
        {
            set { login = value; }  
            get { return login; }

        }
   
        public long PW1
        {
            set { password= value; }
            get { return password; }

        }
    

    }
}
