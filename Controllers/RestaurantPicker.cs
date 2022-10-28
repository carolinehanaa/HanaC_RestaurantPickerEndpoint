/*Caroline Hana
10-27-2022
Restaurant picker - will pick a random restaurant for u
Peer review -Nicolas Acosta The code works fine I choose all fastfood, deseert and the resaurant they all work out.The code look nice on the eyes easy to read Great job.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HanaC_RestaurantPickerEndpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPicker : ControllerBase
    {
        [HttpGet]
        [Route("picker/{answer}")]
        public string picker(string answer)
        {
            Random rnd = new Random();
            


            string[] fastfood = { "McDonalds", "Chick-Fil-A", "Taco Bell", "Wendy's", "Burger King", "Subway", "Domino's", "Chipotle", "Sonic", "Panera Bread" };
            string[] restaurant = { "Olive Garden", "The Cheesecake Factory", "Texas Roadhouse", "P.F. Chang's China Bistro", "Red Lobster", "Outback Steakhouse", "Buffalo Wild Wings", "Red Robin", "Denny's", "Chili's" };
            string[] dessert = { "Baskin-Robbins", "Dairy Queen", "Kona Ice", "Cold Stone Creamery", "Ben & Jerry's", "Rita's Italian Ice", "Menchie's Frozen Yogurt", "The Häagen-Dazs Shoppe", "Crumbl Cookies", "Krispy Kreme" };

            int fastfoodIndex = rnd.Next(fastfood.Length);
            int restaurantIndex = rnd.Next(restaurant.Length);
            int dessertIndex = rnd.Next(dessert.Length);

            if (answer == "fastfood")
            {
                return $"Fast Food place choosen: {fastfood[fastfoodIndex]}";
            }
            else if (answer == "restaurant")
            {
                return $"Restaurant place choosen: {restaurant[restaurantIndex]}";
            }
            else 
            {
                return $"Dessert place choosen: {dessert[dessertIndex]} ";

            }

        }
    }
}