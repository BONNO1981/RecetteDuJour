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
            recette fenetre = new recette();
            fenetre.Show() ;     
        }

        private void menuViandes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            recette fenetre = new recette();
            fenetre.Show();
        }

        private void menuChevres_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            recette fenetre = new recette();
            fenetre.Show();
        }

        private void menuFruitsMer_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            recette fenetre = new recette();
            fenetre.Show();
        }
    }
}
