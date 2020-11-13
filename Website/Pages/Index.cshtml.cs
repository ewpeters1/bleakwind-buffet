/*
 * Elliot Peters
 * Index.cshtml.cs
 * Creates backing code for the main index HTML page
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Identity;
using System.Security.Policy;

namespace Website.Pages
{
    [BindProperties(SupportsGet = true)]
    public class IndexModel : PageModel
    {
        /// <summary>
        /// Search terms 
        /// </summary>A
        public string SearchTerms { get; set; }

        /// <summary>
        /// Minimum filter for IMDB
        /// </summary>
        public double? PriceMin { get; set; }

        /// <summary>
        /// Maximum filter for IMDB
        /// </summary>
        public double? PriceMax { get; set; }

        /// <summary>
        /// Minimum filter for calories
        /// </summary>
        public int? CaloriesMin { get; set; }

        /// <summary>
        /// Maximum filter for calories
        /// </summary>
        public int? CaloriesMax { get; set; }

        /// <summary>
        /// Menuu item types from search/ checkboxes
        /// </summary>
        public string[] ItemTypeResults{ get; set; } = new string[0];


        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// Menu that we are editing with search
        /// </summary>
        public IEnumerable<IOrderItem> Menus { get; set; } = Menu.All;

        /// <summary>
        /// Object for entree menu items
        /// </summary>
        public IEnumerable<IOrderItem> Entrees
        {
            get
            {
                return Menu.Entrees();
            }
        }

        /// <summary>
        /// Object for side menu items
        /// </summary>
        public IEnumerable<IOrderItem> Sides
        {
            get
            {
                return Menu.Sides();
            }
        }

        /// <summary>
        /// Object for drink menu items
        /// </summary>
        public IEnumerable<IOrderItem> Drinks
        {
            get
            {
                return Menu.Drinks();
            }
        }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Refreshes the page nd search items
        /// </summary>
        public void OnGet()
        {
            Menus = Menu.All;
            //using linq
            if (SearchTerms != null)
            {
                Menus = Menus.Where(menu => menu.ToString() != null && menu.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase) || menu.Description.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
            }
            if (ItemTypeResults != null && ItemTypeResults.Length != 0)
            {
                Menus = Menus.Where(menu =>
                {
                    foreach (String item in ItemTypeResults)
                    {
                        if (item == "Entree" && menu is Entree)
                        {
                            return true;
                        }
                        if (item == "Side" && menu is Side)
                        {
                            return true;
                        }
                        if (item == "Drink"  && menu is Drink)
                        {
                            return true;
                        }
                    }
                    return false;
                });
            } 

            //filter by calories
            if(CaloriesMin != null && CaloriesMax != null)
            {
                Menus = Menus.Where(menu => menu.Calories >= CaloriesMin && menu.Calories <= CaloriesMax);
            }
            else if (CaloriesMin != null)
            {
                Menus = Menus.Where(menu => menu.Calories >= CaloriesMin);
            }
            else if (CaloriesMax != null)
            {
                Menus = Menus.Where(menu => menu.Calories <= CaloriesMax);
            }
            else
            {
                Menus = Menu.FilterByCalories(Menus, CaloriesMin, CaloriesMax);
            }
            //filter by price
            if (PriceMin != null && PriceMax != null)
            {
                Menus = Menus.Where(menu => menu.Price >= PriceMin && menu.Price <= PriceMax);
            }
            else if (PriceMin != null)
            {
                Menus = Menus.Where(menu => menu.Price >= PriceMin);
            }
            else if (PriceMax != null)
            {
                Menus = Menus.Where(menu => menu.Price <= PriceMax);
            }
            else
            {
                Menus = Menu.FilterByPrice(Menus, PriceMin, PriceMax);
            }
        }
    }
}
