using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace Business
{
    public class DataAccess
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        public SqlDataReader Reader
        {
            get { return reader; }
        }

        public DataAccess()
        {
            conn = new SqlConnection("server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true");
            cmd = new SqlCommand();
        }

        public void SetQuery(string query)
        {
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
        }

        public void execRead()
        {
            cmd.Connection = conn;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CloseConn()
        {
            if (reader != null)
                reader.Close();
            conn.Close();
        }

        public void exeNoQuery()
        {
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery(); 
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void setParameter(string nombre, object valor)
        {
            cmd.Parameters.AddWithValue(nombre, valor);
        }
    }
}
