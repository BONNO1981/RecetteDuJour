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
        }

        private void menuPoissons_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            recetteSaisie fenetre = new recetteSaisie();
            fenetre.Show() ;     
        }

        private void menuViandes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            recetteSaisie fenetre = new recetteSaisie();
            fenetre.Show();
        }

        private void menuChevres_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            recetteSaisie fenetre = new recetteSaisie();
            fenetre.Show();
        }

        private void menuFruitsMer_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Recette r = new Recette("Poisson frit", @"C:\Users\kiite\Pictures\Hang loose.png", "Poissons", 3, "possons machin tomates", "fait tout le machin rajoute le bidul et voila");
            recetteSaisie fenetre = new recetteSaisie(r);
            fenetre.Show() ;
        }
    }
}
