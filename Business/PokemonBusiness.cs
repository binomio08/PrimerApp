using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using domain;
using Business;
using System.Linq.Expressions;

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
                data.SetQuery("SELECT P.Id, Numero, Nombre, P.Descripcion, UrlImagen, E.Id, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE E.Id = P.IdTipo AND D.Id = P.IdDebilidad And P.Activo = 1");
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
                    if (!(data.Reader["UrlImagen"] is DBNull))
                        aux.UrlImage = (string)data.Reader["UrlImagen"];
                    aux.Type = new Element();
                    aux.Type.Id = (int)data.Reader["IdTipo"];
                    aux.Type.Description = (string)data.Reader["Tipo"];
                    aux.Weaknesess = new Element();
                    aux.Weaknesess.Id = (int)data.Reader["IdDebilidad"];
                    aux.Weaknesess.Description = (string)data.Reader["Debilidad"];

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

        public void create(Pokemon newPokemon)
        {
            DataAccess data = new DataAccess();

            try
            {
                data.SetQuery("insert into POKEMONS (Numero, Nombre, Descripcion, Activo, IdTipo, IdDebilidad, UrlImagen) values (@Numero, @Nombre, @Descripcion, 1, @idTipo, @idDebilidad, @urlImagen)");
                data.setParameter("@Numero", newPokemon.Number);
                data.setParameter("@Nombre", newPokemon.Name);
                data.setParameter("@Descripcion", newPokemon.Description);
                data.setParameter("@urlImagen", newPokemon.UrlImage);
                data.setParameter("@idTipo", newPokemon.Type.Id);
                data.setParameter("@idDebilidad", newPokemon.Weaknesess.Id);
                data.exeNoQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                data.CloseConn();
            }
        }

        public void modify(Pokemon poke)
        {
            DataAccess data = new DataAccess();

            try
            {
                data.SetQuery("update POKEMONS set Numero = @numero, Nombre = @nombre, Descripcion = @desc, UrlImagen = @img, IdTipo = @idTipo, IdDebilidad = @idDebilidad where Id = @id");
                data.setParameter("@numero", poke.Number);
                data.setParameter("@nombre", poke.Name);
                data.setParameter("@desc", poke.Description);
                data.setParameter("@img", poke.UrlImage);
                data.setParameter("@idTipo", poke.Type.Id);
                data.setParameter("@idDebilidad", poke.Weaknesess.Id);
                data.setParameter("@id", poke.Id);
                data.exeNoQuery();
            }
            catch (Exception EX)
            {

                throw EX;
            }
            finally
            { 
                data.CloseConn();
            }
        }
        public void delete(int id)
        {

            try
            {
                DataAccess data = new DataAccess();
                data.SetQuery("DELETE from POKEMONS where Id = @id");
                data.setParameter("@id", id);
                data.exeNoQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void disablePokemon(int id)
        {
            try
            {
                DataAccess data = new DataAccess();
                data.SetQuery("UPDATE POKEMONS set Activo = 0 where id = @id");
                data.setParameter("@id", id);
                data.exeNoQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Pokemon> filter(string field, string range, string filter)
        {
            List<Pokemon> list = new List<Pokemon>();
            DataAccess data = new DataAccess();
            try
            {
                string query = "SELECT P.Id, Numero, Nombre, P.Descripcion, UrlImagen, E.Id, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE E.Id = P.IdTipo AND D.Id = P.IdDebilidad And P.Activo = 1 AND ";
                switch (field)
                {
                    case "Number":
                        switch (range)
                        {
                            case "Greater than":
                                query += "Numero >" + filter;
                                break;
                            case "Less than":
                                query += "Numero <" + filter;
                                break;
                            default:
                                query += "Numero =" + filter;
                                break;
                        }
                        break;

                    case "Name":
                        switch (range)
                        {
                            case "Starts with":
                                query += "Nombre like '" + filter + "%' ";
                                break;
                            case "Ends with":
                                query += "Nombre like '%" + filter + "'";
                                break;
                            default:
                                query += "Nombre like '%" + filter + "%'";
                                break;
                        }
                        break;

                    default:
                        switch (range)
                        {
                            case "Starts with":
                                query += "P.Descripcion like '" + filter + "%'";
                                break;
                            case "Ends with":
                                query += "P.Descripcion like '% " + filter + "'";
                                break;
                            default:
                                query += "P.Descripcion like '%" + filter + "%'";
                                break;
                        }
                        break;
                }

                data.SetQuery(query);
                data.execRead();
                while (data.Reader.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)data.Reader["Id"];
                    aux.Number = (int)data.Reader["Numero"];
                    aux.Name = (string)data.Reader["Nombre"];
                    aux.Description = (string)data.Reader["Descripcion"];
                    if (!(data.Reader["UrlImagen"] is DBNull))
                        aux.UrlImage = (string)data.Reader["UrlImagen"];
                    aux.Type = new Element();
                    aux.Type.Id = (int)data.Reader["IdTipo"];
                    aux.Type.Description = (string)data.Reader["Tipo"];
                    aux.Weaknesess = new Element();
                    aux.Weaknesess.Id = (int)data.Reader["IdDebilidad"];
                    aux.Weaknesess.Description = (string)data.Reader["Debilidad"];

                    list.Add(aux);
                }

                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
