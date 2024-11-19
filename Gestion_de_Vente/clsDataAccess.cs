using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Gestion_de_Vente
{
    class clsDataAccess
    {
        public SqlConnection conn = null;
        string connectionString = "Data Source = DESKTOP-EHNA8UK; Initial Catalog = EXERCICE_LISAS; User Id = sa; Password = victoire; Encrypt = false ";

        public bool OpenConnection() 
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                return true;

            }
            catch (Exception ex)
            {
                return false;

            }

        }

         public void CloseConnection()
        {
            if( conn!= null)
            {
                conn.Close();
            }
        }
    }
}

