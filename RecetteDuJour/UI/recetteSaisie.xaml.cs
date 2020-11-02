using RecetteDuJour.metiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RecetteDuJour.UI
{
    /// <summary>
    /// Interaction logic for recette.xaml
    /// </summary>
    public partial class recetteSaisie : Window
    {
        private Recette rec;
        private readonly bool isEditMode = false;
        public recetteSaisie()
        {
            InitializeComponent();
            rec = new Recette();
        }

        public recetteSaisie(Recette r)
        {
            InitializeComponent();
            isEditMode = true;
            rec = r;
            this.title.Text = rec.Nom;
            this.ingredients.Text = rec.Ingredients;
            this.preparations.Text = rec.Preparation;

        }
        private void recupDonnees()

        {

            rec.Nom = this.title.Text;
            rec.Ingredients = this.ingredients.Text;
            rec.Preparation = this.preparations.Text;

            if (isEditMode == false)
            {
                RecetteAccess.InsertRecette(rec);
                //business.tabRecettes.Add(rec);
            }
            else
            {
                RecetteAccess.UpdateRecette(rec);
            }

        }
    }
}
