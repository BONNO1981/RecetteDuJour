using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetteDuJour.metiers
{
    public class Recette
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Image { get; set; }      
        public string Categorie { get; set; }
        public int NbPersonne { get; set; }
        public string Ingredients { get; set; }
        public string Preparation { get; set; }
       

        public Recette( string Nom, string Image, string Categorie, int NbPersonne,string Ingredients,string Preparation)
        {
            this.Nom = Nom;
            this.Image = Image;
            this.Categorie = Categorie;
            this.NbPersonne = NbPersonne;
            this.Ingredients = Ingredients;
            this.Preparation = Preparation;
        }

        public Recette()
        {
        }
    }
}
