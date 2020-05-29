using System;
using DinoDiner.Menu;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        public FlavorSelection()
        {
            InitializeComponent();
        }

        Sodasaurus soda { get; set; }

        public FlavorSelection(Sodasaurus sodasaurus)
        {
            soda = sodasaurus;
            InitializeComponent();
        }

        public void MakeCherry(object sender, RoutedEventArgs args)
        {
            soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.Cherry;
            NavigationService.Navigate(new DrinkSelection(soda));
        }
    }
}
