using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Caj.Ejemplo.Web.Model;

namespace Caj.Ejemplo.Web.Datos
{
    public class ClienteData
    {
        public List<Cliente> CargaClientes()
        {
            var lstClientes = new List<Cliente>();
            
            try
            {
                
                var db = DatabaseFactory.CreateDatabase("SQLStringConn");

                using (IDataReader dataReader = db.ExecuteReader(CommandType.Text, "SELECT * FROM cmiProcesos"))
                {
                    while (dataReader.Read())
                    {
                        lstClientes.Add(new Cliente()
                        {
                            idCliente = Convert.ToInt32(dataReader["idProceso"]),
                            Nombre = Convert.ToString(dataReader["nombreProceso"]),
                            Tipo = Convert.ToString(dataReader["claseAvance"])
                            
                        });
                    }
                }
            }
            catch (Exception exp)
            {
                throw new ApplicationException(exp.Message, exp);
            }

            return lstClientes;
        }

    }
}
