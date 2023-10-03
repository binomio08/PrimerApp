using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain;

namespace Business
{
    public class ElementBusiness
    {
        public List<Element> list()
        {
			List<Element> list = new List<Element>();
			DataAccess data = new DataAccess();
			try
			{
				data.SetQuery("SELECT Id, Descripcion FROM ELEMENTOS");
				data.execRead();

				while (data.Reader.Read())
				{
					Element aux = new Element();
					aux.Id = (int)data.Reader["Id"];
					aux.Description = (string)data.Reader["Descripcion"];

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
