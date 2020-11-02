using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetteDuJour.metiers
{
    public class Business
    {
        public static ObservableCollection<Recette> Recettes { get; set; }

        static Business()
        {
            Recettes = new ObservableCollection<Recette>();
        }

        public static ObservableCollection<Recette> GetByCategorie(string cat)
        {
            ObservableCollection<Recette> result = new ObservableCollection<Recette>();

            foreach(Recette r in Recettes)
            {
                if(cat == r.Categorie) {
                    result.Add(r);
                }
            }
            return result;
        }

                


    }

    
}
