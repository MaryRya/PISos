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
                command.CommandText = "SELECT id_miss, data, pet_name, pet_category, pet_gender, locality, birthday, breed, id_user, photo.photo FROM [ads_missing], [photo_miss], [photo] where photo_miss.id_lost = ads_missing.id_miss and photo_miss.id_photo = photo.id_photo";

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
                        pet.Photo = reader.GetString(9);

                        result.Add(pet);
                    }

                }
            }

            return result;
        }

        public List<PetInfo2> GetFindPets()
        {
            var result1 = new List<PetInfo2>();
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT id_find, pets_gender, data, locality, pet_category, discription, phone, id_user, photo.photo FROM [ads_finding], [photo_find], [photo] where photo_find.id_finds = ads_finding.id_find and photo_find.id_photo = photo.id_photo";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PetInfo2 pet = new PetInfo2();

                        pet.Id = reader.GetInt64(0);
                        pet.Gender = reader.GetString(1);
                        pet.Date = reader.GetDateTime(2);
                        pet.Locality = reader.GetString(3);
                        pet.Category = reader.GetString(4);                                             
                        pet.Discription = reader.GetString(5);
                        pet.Phone = reader.GetString(6);
                        pet.UserId = reader.GetInt64(7);
                        pet.Photo = reader.GetString(8);

                        result1.Add(pet);
                    }

                }
            }

            return result1;
        }

        public List<MyPet> GetMyPets()
        {
            var result1 = new List<MyPet>();
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT pet_id, id_user, pet_name, pet_gender, locality, pet_category, birthday, breed, fio_user FROM [pets]";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MyPet pet = new MyPet();

                        pet.Id = reader.GetInt64(0);
                        pet.UserId = reader.GetInt64(1);
                        pet.PetName = reader.GetString(2);
                        pet.Gender = reader.GetString(3);
                        pet.Locality = reader.GetString(4);
                        pet.Category = reader.GetString(5);
                        pet.Birthday = reader.GetDateTime(6);
                        pet.Breed = reader.GetString(7);
                        pet.FIO = reader.GetString(8);

                        result1.Add(pet);
                    }

                }
            }

            return result1;
        }

        public UserInfo GetUser(string login, string password)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT id_user, login, password, name, phone, id_rol FROM [user] WHERE password = @password and login=@login";
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@login", login);              
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
