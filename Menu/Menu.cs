/*
 * Menu.cs
 * Author: Jacob Schenkelberg
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu
{
    public class Menu
    {

        public List<Menu> AvailableMenuItems
        {
            get
            {
                List<Menu> menu = new List<Menu>();
                menu.Add(new Brontowurst());
                menu.Add(new DinoNuggets());
                menu.Add(new PrehistoricPBJ());
                menu.Add(new PterodactylWings());
                menu.Add(new SteakosaurusBurger());
                menu.Add(new TRexKingBurger());
                menu.Add(new VelociWrap());
                menu.Add(new Fryceritops());
                menu.Add(new MeteorMacAndCheese());
                menu.Add(new MezzorellaSticks());
                menu.Add(new Triceritots());
                menu.Add(new JurassicJava());
                menu.Add(new Sodasaurus());
                menu.Add(new Tyrannotea());
                menu.Add(new Water());
                menu.Add(new CretaceousCombo(new Brontowurst()));
                menu.Add(new CretaceousCombo(new DinoNuggets()));
                menu.Add(new CretaceousCombo(new PrehistoricPBJ()));
                menu.Add(new CretaceousCombo(new PterodactylWings()));
                menu.Add(new CretaceousCombo(new SteakosaurusBurger()));
                menu.Add(new CretaceousCombo(new TRexKingBurger()));
                menu.Add(new CretaceousCombo(new VelociWrap()));
                return menu;
            }
        }

        List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> availableEntrees = new List<IMenuItem>();
                availableEntrees.Add(new Brontowurst());
                availableEntrees.Add(new DinoNuggets());
                availableEntrees.Add(new PrehistoricPBJ());
                availableEntrees.Add(new PterodactylWings());
                availableEntrees.Add(new SteakosaurusBurger());
                availableEntrees.Add(new TRexKingBurger());
                availableEntrees.Add(new VelociWrap());
                return availableEntrees;
            }
        }

        List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> availSides = new List<IMenuItem>();
                availSides.Add(new Fryceritops());
                availSides.Add(new MeteorMacAndCheese());
                availSides.Add(new MezzorellaSticks());
                availSides.Add(new Triceritots());
                return availSides;
            }
        }

        List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> availDrinks = new List<IMenuItem>();
                availDrinks.Add(new JurassicJava());
                availDrinks.Add(new Sodasaurus());
                availDrinks.Add(new Tyrannotea());
                availDrinks.Add(new Water());
                return availDrinks;
            }
        }

        List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> availCombos = new List<IMenuItem>();
                availCombos.Add(new CretaceousCombo(new Brontowurst()));
                availCombos.Add(new CretaceousCombo(new DinoNuggets()));
                availCombos.Add(new CretaceousCombo(new PrehistoricPBJ()));
                availCombos.Add(new CretaceousCombo(new PterodactylWings()));
                availCombos.Add(new CretaceousCombo(new SteakosaurusBurger()));
                availCombos.Add(new CretaceousCombo(new TRexKingBurger()));
                availCombos.Add(new CretaceousCombo(new VelociWrap()));
                return availCombos;

            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (IMenuItem menuItem in AvailableMenuItems)
            {
                sb.Append(menuItem.ToString());
                sb.Append("\n");
            }
            return sb.ToString();
        }

    }
}
