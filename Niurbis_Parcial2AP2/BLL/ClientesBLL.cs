using Niurbis_Parcial2AP2.DAL;
using Niurbis_Parcial2AP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Niurbis_Parcial2AP2.BLL
{
    public class ClientesBLL
    {
        public static List<Clientes> GetClientes()
        {
            Contexto contexto = new Contexto();
            List<Clientes> clientes = new List<Clientes>();
            try
            {
                clientes = contexto.Clientes.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return clientes;
        }
    }
}
