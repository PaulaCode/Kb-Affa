using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Datos
{
    public class Connection
    {
        static string cadenaconexion = @"DATASOURCE  = PAULA; INITIAL CATALOG = KBAFFA; INTEGRATED SECURITY = TRUE";

        public static string CadenaConexion
        {
            get { return cadenaconexion; }
        }
    }
}
