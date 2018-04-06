using AccesoDatos.SQLAccess.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.SQLAccess
{
    public static class SqlConexion
    {
        public static IList<ContactVm> GetContacts()
        {
            string connectionString =
               "Data Source=(local);Initial Catalog=Contacts;"
               + "User ID=dbuser;Password=dbuser";

            IList<ContactVm> lista = new List<ContactVm>();
            // Provide the query string with a parameter placeholder.
             string queryString =
                "SELECT id, name, age from dbo.contact "
                    + "WHERE age > @ageParam "
                    + "ORDER BY id ASC;";

            // Specify the parameter value.
            int ageParam = 18;

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@ageParam", ageParam);

                // Open the connection in a try/catch block. 
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ContactVm contact = new ContactVm();
                        contact.Id = (int)reader[0];
                        contact.Nombre = (string)reader[1];
                        contact.Edad = (int)reader[2];
                        lista.Add(contact);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                  //  Console.WriteLine(ex.Message);
                }
               // Console.ReadLine();
            }
            return lista;
        }
    }
}
