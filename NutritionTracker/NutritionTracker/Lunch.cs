using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrition.NutritionTracker
{
    public class Lunch
    {
        private static Lunch instance;
        private List<Food> lunchFood = new List<Food>();
        private List<Drink> lunchDrink = new List<Drink>();
        
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
                foreach (Food food in lunchFood)
                {
                    totalcalories += food.Calories;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalgrams += food.Grams;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalprotein += food.Protein;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalcarbs += food.Carbs;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalfat += food.Fat;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalvitaminD += food.VitaminD;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalzinc += food.Zinc;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totaliron += food.Iron;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalmagnesium += food.Magnesium;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalfolate += food.Folate;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalcalcium += food.Calcium;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalvitaminC += food.VitaminC;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalvitaminE += food.VitaminE;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totaliodine += food.Iodine;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalselenium += food.Selenium;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalpotassium += food.Potassium;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalbiotin += food.Biotin;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalcopper += food.Copper;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalvitaminB12 += food.VitaminB12;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalmanganese += food.Manganese;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalchromium += food.Chromium;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalvitaminA += food.VitaminA;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalvitaminK += food.VitaminK;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalvitaminB6 += food.VitaminB6;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalvitaminB2 += food.VitaminB2;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalvitaminB1 += food.VitaminB1;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalvitaminB3 += food.VitaminB3;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalfluoride += food.Fluoride;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalsodium += food.Sodium;
                }

                foreach (Drink drink in lunchDrink)
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
                foreach (Food food in lunchFood)
                {
                    totalsugar += food.Sugar;
                }

                foreach (Drink drink in lunchDrink)
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

        public static Lunch GetInstance()
        {
            if (instance == null)
            {
                instance = new Lunch();
            }
            return instance;
        }

        // Method to add a food to the pantry
        public void AddFood(Food food)
        {
            lunchFood.Add(food);
        }

        public void AddDrink(Drink drink)
        {
            lunchDrink.Add(drink);
        }
    }
}