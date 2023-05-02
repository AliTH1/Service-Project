using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task280423.Services.Interfaces.RestaurantInterface;

namespace Task280423.Services.Implementations.Restaurant
{
    internal class RestaurantServices : IRestaurantService
    {
        List<Models.Restaurant> restaurants = new List<Models.Restaurant>();

        public void Create(int id, string name)
        {
            Models.Restaurant restaurant = new Models.Restaurant(id, name);
            restaurant.Name = name;
            restaurants.Add(restaurant);
        }

        public void Delete(string name)
        {
            foreach (Models.Restaurant item in restaurants)
            {
                if (item.Name == name)
                {
                    restaurants.Remove(item);
                }
            }
        }

        public Models.Restaurant GetById(int id)
        {
            return restaurants.Find(x => x.Id == id);
            //foreach (Models.Restaurant item in restaurants)
            //{
            //    if (item.Id == id)
            //    {
            //        return item;
            //    }
            //}
            //return null;
        }
    }
}