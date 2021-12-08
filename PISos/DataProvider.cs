using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISos.Db
{
    public class DataProvider : IDisposable
    {
        SqlConnection _connection;

        public DataProvider()
        {
            string connectionString =
                System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }

        ~DataProvider()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public List<PetInfo> GetLostPets()
        {
            var result = new List<PetInfo>();
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT id_miss, data, pet_name, pet_category, pet_gender, locality, birthday, breed, id_user FROM [ads_missing]";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PetInfo pet = new PetInfo();

                        pet.Id = reader.GetInt64(0);
                        pet.Date = reader.GetDateTime(1);
                        pet.Name = reader.GetString(2);
                        pet.Category = reader.GetString(3);
                        pet.Gender = reader.GetString(4);
                        pet.Locality = reader.GetString(5);
                        pet.Birthday = reader.GetDateTime(6);
                        pet.Breed = reader.GetString(7);
                        pet.UserId = reader.GetInt64(8);

                        result.Add(pet);
                    }

                }
            }

            return result;
        }

        public UserInfo GetUser(string login, string password)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT id_user, login, password, name, phone, id_rol FROM [user] WHERE password = @password";
                command.Parameters.AddWithValue("@password", password);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return null;
                    }

                    UserInfo user = new UserInfo();

                    user.Id = reader.GetInt64(0);
                    user.Login = reader.GetString(1);
                    user.Password = reader.GetString(2);
                    user.Name = reader.GetString(3);
                    user.Phone = reader.GetString(4);
                    user.Role = (UserRoleType)reader.GetInt64(5);

                    return user;
                }
            }
        }

        private void Dispose(bool disposing)
        {
            if (_connection != null)
            {
                _connection.Dispose();
                _connection = null;
            }
        }
    }
}
