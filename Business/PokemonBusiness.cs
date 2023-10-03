using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using domain;
using Business;

namespace business
{
    //Clase para crear metodos de acceso a datos para los pokemons
    public class PokemonBusiness
    {
        //Método que lee los registro de la base de datos y los convierte en objetos
        public List<Pokemon> list()
        {
            List<Pokemon> list = new List<Pokemon>();
            DataAccess data = new DataAccess();

            try
            {
                data.SetQuery("SELECT P.Id, Numero, Nombre, P.Descripcion, UrlImagen, E.Id, E.Descripcion Tipo, D.Descripcion Debilidad FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE E.Id = P.IdTipo AND D.Id = P.IdDebilidad");
                data.execRead();

                //Mientras haya un registro va a leer fila por fila lo que encuentre en al base de datos
                //En cada vuelta crea una nueva instacia de pokemon (transfomar la lista en objetos)
                while (data.Reader.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)data.Reader["Id"];
                    aux.Number = (int)data.Reader["Numero"];
                    aux.Name = (string)data.Reader["Nombre"];
                    aux.Description = (string)data.Reader["Descripcion"];
                    aux.UrlImage = (string)data.Reader["UrlImagen"];
                    aux.Tipo = new Element();
                    aux.Tipo.Description = (string)data.Reader["Tipo"];
                    aux.Debilidad = new Element();
                    aux.Debilidad.Description = (string)data.Reader["Debilidad"];

                    list.Add(aux);
                }

                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.CloseConn();
            }
        }
    }
}
