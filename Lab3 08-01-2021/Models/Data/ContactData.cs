using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Lab3_08_01_2021.Models.Domain;
using Microsoft.Extensions.Configuration;

namespace Lab3_08_01_2021.Models.Data
{
    public class ContactData
    {
        private IConfiguration _configuration;
        string connectionString;

        public ContactData(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");

        }

        public ContactData()
        {

        }

        public int InsertData(Contact contact)
        {
            //ira el codigo necesario para base de datos

            int resultToReturn;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("InsertMessage", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Name", contact.NameContact);
                command.Parameters.AddWithValue("@Email", contact.EmailContact);
                command.Parameters.AddWithValue("@Description", contact.InformationContact);
                //command.ExecuteNonQuery();

                resultToReturn = command.ExecuteNonQuery();
                connection.Close();
            }


            return resultToReturn;

        }


    }
}
