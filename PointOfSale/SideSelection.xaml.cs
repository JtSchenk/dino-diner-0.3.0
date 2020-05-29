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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// Initialize
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get and set for side
        /// </summary>
        public Side Side { get; set; }

        /// <summary>
        /// Constructor as (side) parameter
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            Side = side;
            InitializeComponent();
        }

        /// <summary>
        /// Side that will be added to order
        /// </summary>
        /// <param name="side"></param>
        private void SelectSide(Side side)
        {
            if(DataContext is Order order)
            {
                order.Add(side);
                this.Side = side;
            }
        }

        /// <summary>
        /// Sets the size of the side.
        /// </summary>
        /// <param name="size"></param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if(Side != null)
            {
                this.Side.Size = size;
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// Adds Fryceritops
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        public void AddFryceritops(object sender, RoutedEventArgs arg)
        {
            SelectSide(new Fryceritops());
        }

        /// <summary>
        /// Adds Mac and Cheese
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddMacAndCheese(object sender, RoutedEventArgs args)
        {
            SelectSide(new MeteorMacAndCheese());
        }

        /// <summary>
        /// Adds Mezzorella Sticks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            SelectSide(new MezzorellaSticks());
        }

        /// <summary>
        /// Adds Triceritots
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddTriceritots(object sender, RoutedEventArgs args)
        {
            SelectSide(new Triceritots());
        }

        /// <summary>
        /// Selects Small for the side.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        /// <summary>
        /// Selects medium for the side.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// Selects large for the side.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

    }
}
