using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetteDuJour.metiers
{
        class RecetteAccess
    {
        private static MySqlConnection connection;

        static RecetteAccess()
        {
            String connString = "Server=localhost;Database=recette;userid=root;Pwd=";
            connection = new MySqlConnection(connString);
        }
        public static void GetAllRecette()
        {

            // on prepare la requête
            String sql = "SELECT * FROM kaikai";
            using (MySqlCommand command = new MySqlCommand(sql, connection))
            {
                command.Connection.Open();
                // On exécute la requête
                using (DbDataReader dbReader = command.ExecuteReader())
                {
                    while (dbReader.Read())
                    {
                        int Id = dbReader.GetInt32(0);
                        string Nom = dbReader.GetString(1);
                        string Image = dbReader.GetString(2);
                        string Categorie = dbReader.GetString(3);
                        int NbPersonne = dbReader.GetInt32(4);
                        string Ingredients = dbReader.GetString(5);
                        string Preparation = dbReader.GetString(6);

                        Recette rp = new Recette(Nom, Image, Categorie, NbPersonne, Ingredients, Preparation);
                        rp.Id = id;

                        Business.Recettes.Add(rp);

                    }
                }

                command.Connection.Close();
            }
        }
        public static bool InsertRecette(Recette r)
        {
            string sql = "INSERT INTO recette(id, Nom, Image, Categorie, NbPersonne, Ingredients, Preparation) " +
                "VALUES(@id, @Nom, @Image, @Categorie, @NbPersonne,@Ingredients, @Preparation)";
            using (MySqlCommand cmd = new MySqlCommand(sql, connection))
            {
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@id", null);
                cmd.Parameters.AddWithValue("@Nom", r.Nom);
                cmd.Parameters.AddWithValue("@Image", r.Image);
                cmd.Parameters.AddWithValue("@Categorie", r.Categorie);
                cmd.Parameters.AddWithValue("@NbPersonne", r.NbPersonne);
                cmd.Parameters.AddWithValue("@Ingredients", r.Ingredients);
                cmd.Parameters.AddWithValue("@Preparation", r.Preparation);
                bool result = cmd.ExecuteNonQuery() == 1;
                cmd.Connection.Close();
                return result;
            }

        }
        public static bool UpdateRecette(Recette r)
        {
            string sql = "UPDATE kaikai SET Nom=@Nom, Image=@Image, Categorie=@Categorie, NbPersonne=@NbPersonne, Ingredients=@Ingredients, Preparation=@Preparation" +
                " Where id=@id";

            using (MySqlCommand cmd = new MySqlCommand(sql, connection))
            {
                cmd.Connection.Open();

                cmd.Parameters.AddWithValue("@id", r.Id);
                cmd.Parameters.AddWithValue("@Nom", r.Nom);
                cmd.Parameters.AddWithValue("@Image", r.Image);
                cmd.Parameters.AddWithValue("@Categorie", r.Categorie);
                cmd.Parameters.AddWithValue("@NbPersonne", r.NbPersonne);
                cmd.Parameters.AddWithValue("@Ingredients", r.Ingredients);
                cmd.Parameters.AddWithValue("@Preparation", r.Preparation);

                bool result = cmd.ExecuteNonQuery() == 1;
                cmd.Connection.Close();
                return result;
            }
        }
    }
}
