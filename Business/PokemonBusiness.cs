using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using domain;

namespace AppPokemon
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
                //Configuro la dirreción de la base de datos
                conn.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                //Configuro el comando/Lectura
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select Id, Numero, Nombre, Descripcion, UrlImagen from POKEMONS";
                //Ejecuto cdm en la conexión (conn)
                cmd.Connection = conn;

                //Abro la conexión
                conn.Open();
                //Ejecuto la lectura
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
                    //Crea una lista de obajetos
                    list.Add(aux);
                }

                //Cierro la conexión
                conn.Close();
                //Devuelve la lista de objetos
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
