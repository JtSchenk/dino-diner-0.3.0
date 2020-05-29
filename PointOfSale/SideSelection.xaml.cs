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
        public SideSelection()
        {
            InitializeComponent();
        }

        public Side Side { get; set; }

        public SideSelection(Side side)
        {
            Side = side;
            InitializeComponent();
        }

        private void SelectSide(Side side)
        {
            if(DataContext is Order order)
            {
                order.Add(side);
                this.Side = side;
            }
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if(Side != null)
            {
                this.Side.Size = size;
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        public void AddFryceritops(object sender, RoutedEventArgs arg)
        {
            SelectSide(new Fryceritops());
        }

        public void AddMacAndCheese(object sender, RoutedEventArgs args)
        {
            SelectSide(new MeteorMacAndCheese());
        }

        public void AddMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            SelectSide(new MezzorellaSticks());
        }

        public void AddTriceritots(object sender, RoutedEventArgs args)
        {
            SelectSide(new Triceritots());
        }

        protected void OnSelectSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        protected void OnSelectMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        protected void OnSelectLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

    }
}
