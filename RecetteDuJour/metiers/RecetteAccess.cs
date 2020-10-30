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

                        business.reparations.Add(rp);

                    }
                }

                command.Connection.Close();
            }
        }
        public static bool InsertReparation(reparationPhone r)
        {
            string sql = "INSERT INTO reparation(id, Nom, Prenom, ModelPhone, Mobile,Email, DateRecu, Description, Statut, PrixReparation) " +
                "VALUES(@id, @Nom, @Prenom, @ModelPhone, @Mobile,@Email, @DateRecu, @Description, @Statut, @PrixReparation)";
            using (MySqlCommand cmd = new MySqlCommand(sql, connection))
            {
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@id", null);
                cmd.Parameters.AddWithValue("@Nom", r.Nom);
                cmd.Parameters.AddWithValue("@Prenom", r.Prenom);
                cmd.Parameters.AddWithValue("@ModelPhone", r.ModelPhone);
                cmd.Parameters.AddWithValue("@Mobile", r.Mobile);
                cmd.Parameters.AddWithValue("@Email", r.Email);
                cmd.Parameters.AddWithValue("@DateRecu", r.DateRecu);
                cmd.Parameters.AddWithValue("@Description", r.Description);
                cmd.Parameters.AddWithValue("@Statut", r.Statut);
                cmd.Parameters.AddWithValue("@PrixReparation", r.PrixReparation);

                bool result = cmd.ExecuteNonQuery() == 1;
                cmd.Connection.Close();
                return result;
            }

        }
        public static bool UpdateReparation(reparationPhone r)
        {
            string sql = "UPDATE reparation SET Nom=@Nom, Prenom=@Prenom, ModelPhone=@ModelPhone, Mobile=@Mobile, Email=@Email, DateRecu=@DateRecu,Description=@Description, Statut=@Statut, PrixReparation=@PrixReparation" +
                " Where id=@id";

            using (MySqlCommand cmd = new MySqlCommand(sql, connection))
            {
                cmd.Connection.Open();

                cmd.Parameters.AddWithValue("@id", r.Id);
                cmd.Parameters.AddWithValue("@Nom", r.Nom);
                cmd.Parameters.AddWithValue("@Prenom", r.Prenom);
                cmd.Parameters.AddWithValue("@ModelPhone", r.ModelPhone);
                cmd.Parameters.AddWithValue("@Mobile", r.Mobile);
                cmd.Parameters.AddWithValue("@Email", r.Email);
                cmd.Parameters.AddWithValue("@DateRecu", r.DateRecu);
                cmd.Parameters.AddWithValue("@Description", r.Description);
                cmd.Parameters.AddWithValue("@Statut", r.Statut);
                cmd.Parameters.AddWithValue("@PrixReparation", r.PrixReparation);

                bool result = cmd.ExecuteNonQuery() == 1;
                cmd.Connection.Close();
                return result;
            }
        }
    }
}
