using System;
using RecetteDuJour.UI;
using RecetteDuJour.metiers;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RecetteDuJour
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {


            InitializeComponent();

            RecetteAccess.GetRecette();
            this.poissoncategorie.ItemsSource = Business.GetByCategorie("Poissons");
            this.viandecategorie.ItemsSource = Business.GetByCategorie("Viande");
            this.fruitdemercategorie.ItemsSource = Business.GetByCategorie("Fruits de mers");
            this.chevrecategorie.ItemsSource = Business.GetByCategorie("Chèvre");

        }

        private void menuFruitsMer_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Recette r = new Recette("Poisson frit", @"C:\Users\kiite\Pictures\Hang loose.png", "Poissons", 3, "possons machin tomates", "fait tout le machin rajoute le bidul et voila");
            recetteSaisie fenetre = new recetteSaisie(r);
            fenetre.Show() ;
        }

    

        private void poissoncategorie_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            Recette item = poissoncategorie.SelectedItem as Recette;

            recetteSaisie fenetre = new recetteSaisie(item);
            fenetre.Show();
        }

        private void viandecategorie_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Recette item = viandecategorie.SelectedItem as Recette;

            recetteSaisie fenetre = new recetteSaisie(item);
            fenetre.Show();
        }

        private void chevrecategorie_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Recette item = chevrecategorie.SelectedItem as Recette;

            recetteSaisie fenetre = new recetteSaisie(item);
            fenetre.Show();
        }

        private void fruitdemercategorie_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Recette item = fruitdemercategorie.SelectedItem as Recette;

            recetteSaisie fenetre = new recetteSaisie(item);
            fenetre.Show();
        }

        private void poissoncategorie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
