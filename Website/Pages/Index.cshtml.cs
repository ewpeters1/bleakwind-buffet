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
        /// Refreshes page on gets! lol
        /// </summary>
        public void OnGet()
        {
            Menus = Menu.Search(SearchTerms);
            Menus = Menu.FilterByCategory(Menus, ItemTypeResults);
            Menus = Menu.FilterByPrice(Menus, PriceMin, PriceMax);
            Menus = Menu.FilterByCalories(Menus, CaloriesMin, CaloriesMax);
        }
    }
}
