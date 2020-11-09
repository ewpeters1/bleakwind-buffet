/*
 * Author: Elliot Peters
 * Title: Menu.cs
 * Purpose: Used to implement menu
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data
{

    /// <summary>
    /// A public static class that represents the menu of the resturant.
    /// </summary>
    public static class Menu
    {

        /// <summary>
        /// Gets the possible Order Item types
        /// </summary>
        public static string[] Items
        {
            get => new string[]
            {
            "Entree",
            "Side",
            "Drink",
            };
        }

        /// <summary>
        /// An IEnumerable<IOrderItem> that returns all the entrees.
        /// </summary>
        /// <returns>A list of the all the available entree options</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entree = new List<IOrderItem>();
            entree.Add(new BriarheartBurger());
            entree.Add(new DoubleDraugr());
            entree.Add(new GardenOrcOmlette());
            entree.Add(new PhillyPoacher());
            entree.Add(new SmokehouseSkeleton());
            entree.Add(new ThalmorTriple());
            entree.Add(new ThugsTbone());
            return entree;
        }

        /// <summary>
        /// An IEnumerable<IOrderItem> that returns all the sides.
        /// </summary>
        /// <returns>A list of the all side options</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> side = new List<IOrderItem>();

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                side.Add(new DragonbornWaffleFries()
                {
                    Size = s
                });

                side.Add(new FriedMiraak()
                {
                    Size = s
                });

                side.Add(new MadOtarGrits()
                {
                    Size = s
                });

                side.Add(new VokunSalad()
                {
                    Size = s
                });
            }

            return side;
        }

        /// <summary>
        /// Returns the full menu
        /// </summary>
        public static IEnumerable<IOrderItem> All { get { return FullMenu(); } }

        /// <summary>
        /// An IEnumerable<IOrderItem> that returns all the drinks.
        /// </summary>
        /// <returns>A list of the drink options</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drink = new List<IOrderItem>();

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                drink.Add(new AretinoAppleJuice()
                {
                    Size = s
                });

                drink.Add(new CandlehearthCoffee()
                {
                    Size = s,
                    Decaf = true
                });

                drink.Add(new CandlehearthCoffee()
                {
                    Size = s
                });

                drink.Add(new MarkarthMilk()
                {
                    Size = s
                });

                drink.Add(new WarriorWater()
                {
                    Size = s
                });

                foreach (SodaFlavor sf in Enum.GetValues(typeof(SodaFlavor)))
                {
                    drink.Add(new SailorSoda()
                    {
                        Size = s,
                        Flavor = sf
                    });
                }

            }
            return drink;
        }

        /// <summary>
        /// An IEnumerable<IOrderItem> that returns the full menu.
        /// </summary>
        /// <returns>A list of the full menu</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();
            IEnumerable<IOrderItem> entree = Entrees();
            menu.AddRange(entree);

            IEnumerable<IOrderItem> side = Sides();
            menu.AddRange(side);

            IEnumerable<IOrderItem> drink = Drinks();
            menu.AddRange(drink);

            return menu;
        }

        /// <summary>
        /// Basic search function to find something by name
        /// </summary>
        /// <param name="s">The string being searched for</param>
        /// <returns>the list containing the string wanted</returns>
        public static IEnumerable<IOrderItem> Search(string s)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            // null check
            if (s == null) return All;

            //setting to lower case. easiest way to read regardless of case
            string lowerCaseSearch = s.ToLower();
            //making item to set each item in the menu to lower case in the for loop
            string lowerCaseMenu;

            foreach (IOrderItem item in All)
            {
                lowerCaseMenu = item.ToString().ToLower();
                if (lowerCaseMenu.Contains(lowerCaseSearch))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// This function filters a list based on category
        /// </summary>
        /// <param name="list">The list being filtered</param>
        /// <param name="types">a collection of strings that contain the types that the user wants to see</param>
        /// <returns>the list containing the results wanted</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> list, IEnumerable<string> types)
        {
            //null check
            if (types == null || types.Count() == 0) return list;

            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in list)
            {
                //filtering by entree
                if (item is Entree && types.Contains("Entree"))
                {
                    results.Add(item);
                }
                //filtering by side
                else if (item is Side && types.Contains("Side"))
                {
                    results.Add(item);
                }
                //filtering bu drink
                else if (item is Drink && types.Contains("Drink"))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Function to filter a list using a price search
        /// </summary>
        /// <param name="list">Items to be searched through</param>
        /// <param name="min">min price</param>
        /// <param name="max">max price</param>
        /// <returns>list containg the items wanted</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> list, double? min, double? max)
        {
            //null check
            if (min == null && max == null) return list;

            List<IOrderItem> results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in list)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in list)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            // Both specified
            foreach (IOrderItem item in list)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// This function filters the search results by calories, basing it from user input.
        /// </summary>
        /// <param name="items">The list to be searched</param>
        /// <param name="min">Min calorie value</param>
        /// <param name="max">Max calorie value</param>
        /// <returns>list containg the items wanted</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            //null check
            if (min == null && max == null) return items;

            List<IOrderItem> results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // Both specified
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
