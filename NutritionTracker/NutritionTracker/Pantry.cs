using Nutrition.NutritionTracker;
using System.Collections.Generic;

namespace NutritionTracker
{
    // Define a class to manage the list of eaten foods (pantry) using the Singleton pattern
    public class Pantry
    {
        private static Pantry instance;
        private List<Food> foods = new List<Food>();
        private List<Drink> drinks = new List<Drink>();

        // Private constructor to prevent instantiation from outside
        private Pantry() { }

        // Public static method to get the singleton instance
        public static Pantry GetInstance()
        {
            if (instance == null)
            {
                instance = new Pantry();
            }
            return instance;
        }

        // Method to add a food to the pantry
        public void AddFood(Food food)
        {
            foods.Add(food);
        }

        public void AddDrink(Drink drink)
        {
            drinks.Add(drink);
        }

    }
}
