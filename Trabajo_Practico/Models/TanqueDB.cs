using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico.Models
{
    internal class TanqueDB
    {

        private string conexion = "Data Source=Nico_Desktop;Initial Catalog=terciario;user=root;password=Malg123;";

        public List<Tanque> getTanque()
        {
            List<Tanque> tanque = new List<Tanque>();

            string query = "select * from tanque";

            using (SqlConnection connection = new SqlConnection(query, conexion))
            {

            }
        }
    }
}
