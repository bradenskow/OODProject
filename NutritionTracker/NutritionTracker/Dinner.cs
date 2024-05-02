using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrition.NutritionTracker
{
    public class Dinner
    {
        private static Dinner instance;
        private List<Food> dinnerFood = new List<Food>();
        private List<Drink> dinnerDrink = new List<Drink>();
        internal int totalcalories = 0;
        internal int totalprotein = 0;
        internal int totalcarbs = 0;
        internal int totalfat = 0;
        internal int totalvitaminD = 0;
        internal int totalzinc = 0;
        internal int totaliron = 0;
        internal int totalmagnesium = 0;
        internal int totalfolate = 0;
        internal int totalcalcium = 0;
        internal int totalvitaminC = 0;
        internal int totalvitaminE = 0;
        internal int totaliodine = 0;
        internal int totalselenium = 0;
        internal int totalpotassium = 0;
        internal int totalbiotin = 0;
        internal int totalcopper = 0;
        internal int totalvitaminB12 = 0;
        internal int totalmanganese = 0;
        internal int totalchromium = 0;
        internal int totalvitaminA = 0;
        internal int totalvitaminK = 0;
        internal int totalvitaminB6 = 0;
        internal int totalvitaminB2 = 0;
        internal int totalvitaminB1 = 0;
        internal int totalvitaminB3 = 0;
        internal int totalfluoride = 0;
        internal int totalsodium = 0;
        internal int totalsugar = 0;

        private int totalCalories
        {
            get
            {
                int totalcalories = 0;
                foreach (Food food in dinnerFood)
                {
                    totalcalories += food.Calories;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalgrams += food.Grams;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalprotein += food.Protein;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalcarbs += food.Carbs;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalfat += food.Fat;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalvitaminD += food.VitaminD;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalzinc += food.Zinc;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totaliron += food.Iron;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalmagnesium += food.Magnesium;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalfolate += food.Folate;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalcalcium += food.Calcium;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalvitaminC += food.VitaminC;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalvitaminE += food.VitaminE;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totaliodine += food.Iodine;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalselenium += food.Selenium;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalpotassium += food.Potassium;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalbiotin += food.Biotin;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalcopper += food.Copper;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalvitaminB12 += food.VitaminB12;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalmanganese += food.Manganese;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalchromium += food.Chromium;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalvitaminA += food.VitaminA;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalvitaminK += food.VitaminK;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalvitaminB6 += food.VitaminB6;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalvitaminB2 += food.VitaminB2;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalvitaminB1 += food.VitaminB1;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalvitaminB3 += food.VitaminB3;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalfluoride += food.Fluoride;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalsodium += food.Sodium;
                }

                foreach (Drink drink in dinnerDrink)
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
                foreach (Food food in dinnerFood)
                {
                    totalsugar += food.Sugar;
                }

                foreach (Drink drink in dinnerDrink)
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

        public static Dinner GetInstance()
        {
            if (instance == null)
            {
                instance = new Dinner();
            }
            return instance;
        }

        // Method to add a food to the pantry
        public void AddFood(Food food)
        {
            dinnerFood.Add(food);
        }

        public void AddDrink(Drink drink)
        {
            dinnerDrink.Add(drink);
        }
    }
}