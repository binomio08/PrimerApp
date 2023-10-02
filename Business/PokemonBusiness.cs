using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using domain;

namespace business
{
    //Clase para crear metodos de acceso a datos para los pokemons
    public class PokemonBusiness
    {
        //Método que lee los registro de la base de datos y los convierte en objetos
        public List<Pokemon> list()
        {
            //Este método crea y devuelve una lista
            List<Pokemon> list = new List<Pokemon>();
            //Objetos para conectarme a la base de datos y realizar acciones.
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            try
            {
                conn.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT P.Id, Numero, Nombre, P.Descripcion, UrlImagen, E.Id, E.Descripcion Tipo, D.Descripcion Debilidad FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE E.Id = P.IdTipo AND D.Id = P.IdDebilidad";
                cmd.Connection = conn;

                conn.Open();
                reader = cmd.ExecuteReader();

                //Mientras haya un registro va a leer fila por fila lo que encuentre en al base de datos
                while (reader.Read())
                {
                    // En cada vuelta crea una nueva instacia de pokemon (transfomar la lista en objetos)
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)reader["Id"];
                    aux.Number = (int)reader["Numero"];
                    aux.Name = (string)reader["Nombre"];
                    aux.Description = (string)reader["Descripcion"];
                    aux.UrlImage = (string)reader["UrlImagen"];
                    aux.Tipo = new Element();
                    aux.Tipo.Description = (string)reader["Tipo"];
                    aux.Debilidad = new Element();
                    aux.Debilidad.Description = (string)reader["Debilidad"];

                    list.Add(aux);
                }

                conn.Close();
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
