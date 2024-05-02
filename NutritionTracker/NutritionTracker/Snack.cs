using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrition.NutritionTracker
{
    public class Snack
    {
        private static Snack instance;
        private List<Food> snackFoods = new List<Food>();
        private List<Drink> snackDrinks = new List<Drink>();
        internal int totalcalories = 0;

        private int totalCalories
        {
            get
            {
                int totalcalories = 0;
                foreach (Food food in snackFoods)
                {
                    totalcalories += food.Calories;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalcalories += drink.Calories;
                }
                return totalcalories;
            }

        }

        private int totalGrams
        {
            get
            {
                int totalgrams = 0;
                foreach (Food food in snackFoods)
                {
                    totalgrams += food.Grams;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalgrams += drink.Grams;
                }
                return totalgrams;
            }
        }

        private int totalProtein
        {
            get
            {
                int totalprotein = 0;
                foreach (Food food in snackFoods)
                {
                    totalprotein += food.Protein;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalprotein += drink.Protein;
                }
                return totalprotein;
            }
        }

        private int totalCarbs
        {
            get
            {
                int totalcarbs
                    = 0;
                foreach (Food food in snackFoods)
                {
                    totalcarbs += food.Carbs;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalcarbs += drink.Carbs;
                }
                return totalcarbs;
            }
        }

        private int totalFat
        {
            get
            {
                int totalfat = 0;
                foreach (Food food in snackFoods)
                {
                    totalfat += food.Fat;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalfat += drink.Fat;
                }
                return totalfat;
            }
        }

        private int totalVitaminD
        {
            get
            {
                int totalvitaminD = 0;
                foreach (Food food in snackFoods)
                {
                    totalvitaminD += food.VitaminD;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalvitaminD += drink.VitaminD;
                }
                return totalvitaminD;
            }
        }

        private int totalZinc
        {
            get
            {
                int totalzinc = 0;
                foreach (Food food in snackFoods)
                {
                    totalzinc += food.Zinc;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalzinc += drink.Zinc;
                }
                return totalzinc;
            }
        }

        private int totalIron
        {
            get
            {
                int totaliron = 0;
                foreach (Food food in snackFoods)
                {
                    totaliron += food.Iron;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totaliron += drink.Iron;
                }
                return totaliron;
            }
        }

        private int totalMagnesium
        {
            get
            {
                int totalmagnesium = 0;
                foreach (Food food in snackFoods)
                {
                    totalmagnesium += food.Magnesium;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalmagnesium += drink.Magnesium;
                }
                return totalmagnesium;
            }
        }

        private int totalFolate
        {
            get
            {
                int totalfolate = 0;
                foreach (Food food in snackFoods)
                {
                    totalfolate += food.Folate;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalfolate += drink.Folate;
                }
                return totalfolate;
            }
        }

        private int totalCalcium
        {
            get
            {
                int totalcalcium = 0;
                foreach (Food food in snackFoods)
                {
                    totalcalcium += food.Calcium;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalcalcium += drink.Calcium;
                }
                return totalcalcium;
            }
        }

        private int totalVitaminC
        {
            get
            {
                int totalvitaminC = 0;
                foreach (Food food in snackFoods)
                {
                    totalvitaminC += food.VitaminC;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalvitaminC += drink.VitaminC;
                }
                return totalvitaminC;
            }
        }

        private int totalVitaminE
        {
            get
            {
                int totalvitaminE = 0;
                foreach (Food food in snackFoods)
                {
                    totalvitaminE += food.VitaminE;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalvitaminE += drink.VitaminE;
                }
                return totalvitaminE;
            }
        }

        private int totalIodine
        {
            get
            {
                int totaliodine = 0;
                foreach (Food food in snackFoods)
                {
                    totaliodine += food.Iodine;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totaliodine += drink.Iodine;
                }
                return totaliodine;
            }
        }

        private int totalSelenium
        {
            get
            {
                int totalselenium = 0;
                foreach (Food food in snackFoods)
                {
                    totalselenium += food.Selenium;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalselenium += drink.Selenium;
                }
                return totalselenium;
            }
        }

        private int totalPotassium
        {
            get
            {
                int totalpotassium = 0;
                foreach (Food food in snackFoods)
                {
                    totalpotassium += food.Potassium;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalpotassium += drink.Potassium;
                }
                return totalpotassium;
            }
        }

        private int totalBiotin
        {
            get
            {
                int totalbiotin = 0;
                foreach (Food food in snackFoods)
                {
                    totalbiotin += food.Biotin;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalbiotin += drink.Biotin;
                }
                return totalbiotin;
            }
        }

        private int totalCopper
        {
            get
            {
                int totalcopper = 0;
                foreach (Food food in snackFoods)
                {
                    totalcopper += food.Copper;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalcopper += drink.Copper;
                }
                return totalcopper;
            }
        }

        private int totalVitaminB12
        {
            get
            {
                int totalvitaminB12 = 0;
                foreach (Food food in snackFoods)
                {
                    totalvitaminB12 += food.VitaminB12;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalvitaminB12 += drink.VitaminB12;
                }
                return totalvitaminB12;
            }
        }

        private int totalManganese
        {
            get
            {
                int totalmanganese = 0;
                foreach (Food food in snackFoods)
                {
                    totalmanganese += food.Manganese;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalmanganese += drink.Manganese;
                }
                return totalmanganese;
            }
        }

        private int totalChromium
        {
            get
            {
                int totalchromium = 0;
                foreach (Food food in snackFoods)
                {
                    totalchromium += food.Chromium;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalchromium += drink.Chromium;
                }
                return totalchromium;
            }
        }

        private int totalVitaminA
        {
            get
            {
                int totalvitaminA = 0;
                foreach (Food food in snackFoods)
                {
                    totalvitaminA += food.VitaminA;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalvitaminA += drink.VitaminA;
                }
                return totalvitaminA;
            }
        }

        private int totalVitaminK
        {
            get
            {
                int totalvitaminK = 0;
                foreach (Food food in snackFoods)
                {
                    totalvitaminK += food.VitaminK;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalvitaminK += drink.VitaminK;
                }
                return totalvitaminK;
            }
        }

        private int totalVitaminB6
        {
            get
            {
                int totalvitaminB6 = 0;
                foreach (Food food in snackFoods)
                {
                    totalvitaminB6 += food.VitaminB6;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalvitaminB6 += drink.VitaminB6;
                }
                return totalvitaminB6;
            }
        }

        private int totalVitaminB2
        {
            get
            {
                int totalvitaminB2 = 0;
                foreach (Food food in snackFoods)
                {
                    totalvitaminB2 += food.VitaminB2;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalvitaminB2 += drink.VitaminB2;
                }
                return totalvitaminB2;
            }
        }

        private int totalVitaminB1
        {
            get
            {
                int totalvitaminB1 = 0;
                foreach (Food food in snackFoods)
                {
                    totalvitaminB1 += food.VitaminB1;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalvitaminB1 += drink.VitaminB1;
                }
                return totalvitaminB1;
            }
        }

        private int totalVitaminB3
        {
            get
            {
                int totalvitaminB3 = 0;
                foreach (Food food in snackFoods)
                {
                    totalvitaminB3 += food.VitaminB3;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalvitaminB3 += drink.VitaminB3;
                }
                return totalvitaminB3;
            }
        }

        private int totalFluoride
        {
            get
            {
                int totalfluoride = 0;
                foreach (Food food in snackFoods)
                {
                    totalfluoride += food.Fluoride;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalfluoride += drink.Fluoride;
                }
                return totalfluoride;
            }
        }

        private int totalSodium
        {
            get
            {
                int totalsodium = 0;
                foreach (Food food in snackFoods)
                {
                    totalsodium += food.Sodium;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalsodium += drink.Sodium;
                }
                return totalsodium;
            }
        }

        private int totalSugar
        {
            get
            {
                int totalsugar = 0;
                foreach (Food food in snackFoods)
                {
                    totalsugar += food.Sugar;
                }

                foreach (Drink drink in snackDrinks)
                {
                    totalsugar += drink.Sugar;
                }
                return totalsugar;
            }
        }

        public void editFood(string name, string manufacturer, int calories, int grams, int protein, int carbs, int fat, int vitaminD, int zinc, int iron, int magnesium, int folate, int calcium, int vitaminC, int vitaminE, int iodine, int selenium, int potassium, int biotin, int copper, int vitaminB12, int manganese, int chromium, int vitaminA, int vitaminK, int vitaminB6, int vitaminB2, int vitaminB1, int vitaminB3, int fluoride, int sodium, int sugar)
        {
            throw new NotImplementedException();
        }

        public static Snack GetInstance()
        {
            if (instance == null)
            {
                instance = new Snack();
            }
            return instance;
        }

        // Method to add a food to the pantry
        public void AddFood(Food food)
        {
            snackFoods.Add(food);
        }

        public void AddDrink(Drink drink)
        {
            snackDrinks.Add(drink);
        }
    }
}
