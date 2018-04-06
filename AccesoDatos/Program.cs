using AccesoDatos.SQLAccess;
using AccesoDatos.SQLAccess.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            GetSqlContacts();

            Console.ReadKey();
        }

        private static void GetSqlContacts()
        {
            IList<ContactVm> contactos = SqlConexion.GetContacts();

            foreach (ContactVm contact in contactos)
            {
                Console.WriteLine(contact.ToString());
            }
        }
    }
}
