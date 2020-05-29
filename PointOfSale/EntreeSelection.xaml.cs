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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// Initialize Entree Form
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets Entree
        /// </summary>
        /// <param name="entree"></param>
        public EntreeSelection(Entree entree)
        {
            Entree = entree;
            InitializeComponent();
        }

        /// <summary>
        /// Get and set for Entree
        /// </summary>
        public Entree Entree { get; set; }

        /// <summary>
        /// Selects Entree that was clicked and adds to order
        /// </summary>
        /// <param name="entree"></param>
        private void SelectEntree(Entree entree)
        {
            if(DataContext is Order order)
            {
                order.Add(entree);
                this.Entree = entree;
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Adds Brontowurst to current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddBrontowurst(object sender, RoutedEventArgs args)
        {
            SelectEntree(new Brontowurst());
        }

        /// <summary>
        /// Adds DinoNuggets to current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddDinoNuggets(object sender, RoutedEventArgs args)
        {
            SelectEntree(new DinoNuggets());
        }

        /// <summary>
        /// Adds Steakosaurus to current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            SelectEntree(new SteakosaurusBurger());
        }

        /// <summary>
        /// Adds TRexKingBurger to current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddTRexKingBurger(object sender, RoutedEventArgs args)
        {
            SelectEntree(new TRexKingBurger());
        }

        /// <summary>
        /// Adds Wings to current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddPterodactylWings(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PterodactylWings());
        }

        /// <summary>
        /// Adds PBJ to current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddPBJ(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PrehistoricPBJ());
        }

        /// <summary>
        /// Adds VelociWrap to current order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddVelociWrap(object sender, RoutedEventArgs args)
        {
            SelectEntree(new VelociWrap());
        }

    }
}
