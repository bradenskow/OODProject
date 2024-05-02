using Nutrition.NutritionTracker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionTracker
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void DailyCalProg_Click(object sender, EventArgs e)
        {
            int breakfastTotalCalories = Breakfast.GetInstance().totalcalories;
            int lunchTotalCalories = Lunch.GetInstance().totalcalories;
            int dinnerTotalCalories = Dinner.GetInstance().totalcalories;

            int totalDailyCalories = breakfastTotalCalories + lunchTotalCalories + dinnerTotalCalories;

            DailyCalProg.Value = totalDailyCalories;
        }

        

        private void ProteinProgressBar(object sender, EventArgs e)
        {
            int breakfastTotalProtein = Breakfast.GetInstance().totalprotein;
            int lunchtoTotalProtein = Lunch.GetInstance().totalprotein;
            int dinnerTotalProtein = Dinner.GetInstance().totalprotein;

            int totalDailyProtein = breakfastTotalProtein + lunchtoTotalProtein + dinnerTotalProtein;

            ProteinProg.Value = totalDailyProtein;
        }

        private void DailyCarbsProg(object sender, EventArgs e)
        {
            int breakfastTotalCarbs = Breakfast.GetInstance().totalcarbs;
            int lunchtoTotalCarbs = Lunch.GetInstance().totalcarbs;
            int dinnerTotalCarbs = Dinner.GetInstance().totalcarbs;

            int totalDailyCarbs = breakfastTotalCarbs + lunchtoTotalCarbs + dinnerTotalCarbs;

            CarbsProg.Value = totalDailyCarbs;
        }

        private void DailyFat_Click(object sender, EventArgs e)
        {
            int breakfastTotalFat = Breakfast.GetInstance().totalfat;
            int lunchtoTotalFat = Lunch.GetInstance().totalfat;
            int dinnerTotalFat = Dinner.GetInstance().totalfat;

            int totalDialyFat = breakfastTotalFat + lunchtoTotalFat + dinnerTotalFat;

            FatProg.Value = totalDialyFat;
        }

        private void BreakfastProgressBar(object sender, EventArgs e)
        {
            int breakfasttotalCalories = Breakfast.GetInstance().totalcalories;

            BreakfastProg.Value = breakfasttotalCalories;
        }

        private void LunchProg_Click(object sender, EventArgs e)
        {
            int lunchtotalCalories = Lunch.GetInstance().totalcalories;

            LunchProg.Value = lunchtotalCalories;    
        }

        private void DinnerProg_Click(object sender, EventArgs e)
        {
            int dinnertotalCalories = Dinner.GetInstance().totalcalories;

            DinnerProg.Value = dinnertotalCalories;
        }

        private void SnackProg_Click(object sender, EventArgs e)
        {
            int snacktotalCalories = Snack.GetInstance().totalcalories;

            SnackProg.Value = snacktotalCalories;
        }

        private void CaloriesProg_Click(object sender, EventArgs e)
        {
            
        }


        #region Add food from Meals to Pantry
        private void AddFoodBreakFast_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Food_Editor food_editor = new Food_Editor();
            
            food_editor.Show();
        }

        private void AddFoodLunch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Food_Editor food_editor = new Food_Editor();

            food_editor.Show();
        }

        private void AddFoodDinner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Food_Editor food_editor = new Food_Editor();

            food_editor.Show();
        }

        private void AddFoodSnack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Food_Editor food_editor = new Food_Editor();

            food_editor.Show();
        }

        #endregion

        #region Daily Micros


        private void VitaminDProg_Click(object sender, EventArgs e)
        {
            int breakfastVitaminD = Breakfast.GetInstance().totalvitaminD;
            int lunchVitaminD = Lunch.GetInstance().totalvitaminD;
            int dinnerVitaminD = Dinner.GetInstance().totalvitaminD;

            int totalDailyVitaminD = breakfastVitaminD + lunchVitaminD + dinnerVitaminD;

            VitaminDProg.Value = totalDailyVitaminD;
        }

        private void VitaminCProg_Click(object sender, EventArgs e)
        {
            int breakfastVitaminC = Breakfast.GetInstance().totalvitaminC;
            int lunchVitaminC = Lunch.GetInstance().totalvitaminC;
            int dinnerVitaminC = Dinner.GetInstance().totalvitaminC;

            int totalDailyVitaminC = breakfastVitaminC + lunchVitaminC + dinnerVitaminC;

            VitaminCProg.Value = totalDailyVitaminC;
        }

        private void VitaminEProg_Click(object sender, EventArgs e)
        {
            int breakfastVitaminE = Breakfast.GetInstance().totalvitaminE;
            int lunchVitaminE = Lunch.GetInstance().totalvitaminE;
            int dinnerVitaminE = Dinner.GetInstance().totalvitaminE;

            int totalDailyVitaminE = breakfastVitaminE + lunchVitaminE + dinnerVitaminE;

            VitaminEProg.Value = totalDailyVitaminE;
        }

        private void VitaminB12Prog_Click(object sender, EventArgs e)
        {
            int breakfastVitaminB12 = Breakfast.GetInstance().totalvitaminB12;
            int lunchVitaminB12 = Lunch.GetInstance().totalvitaminB12;
            int dinnerVitaminB12 = Dinner.GetInstance().totalvitaminB12;

            int totalDailyVitaminB12 = breakfastVitaminB12 + lunchVitaminB12 + dinnerVitaminB12;

            VitaminB12Prog.Value = totalDailyVitaminB12;
        }

        private void VitaminB6Prog_Click(object sender, EventArgs e)
        {
            int breakfastVitaminB6 = Breakfast.GetInstance().totalvitaminB6;
            int lunchVitaminB6 = Lunch.GetInstance().totalvitaminB6;
            int dinnerVitaminB6 = Dinner.GetInstance().totalvitaminB6;

            int totalDailyVitaminB6 = breakfastVitaminB6 + lunchVitaminB6 + dinnerVitaminB6;

            VitaminB6Prog.Value = totalDailyVitaminB6;
        }

        private void VitaminB3Prog_Click(object sender, EventArgs e)
        {
            int breakfastVitaminB3 = Breakfast.GetInstance().totalvitaminB3;
            int lunchVitaminB3 = Lunch.GetInstance().totalvitaminB3;
            int dinnerVitaminB3 = Dinner.GetInstance().totalvitaminB3;

            int totalDailyVitaminB3 = breakfastVitaminB3 + lunchVitaminB3 + dinnerVitaminB3;

            VitaminB3Prog.Value = totalDailyVitaminB3;
        }

        private void VitaminB2Prog_Click(object sender, EventArgs e)
        {
            int breakfastVitaminB2 = Breakfast.GetInstance().totalvitaminB2;
            int lunchVitaminB2 = Lunch.GetInstance().totalvitaminB2;
            int dinnerVitaminB2 = Dinner.GetInstance().totalvitaminB2;

            int totalDailyVitaminB2 = breakfastVitaminB2 + lunchVitaminB2 + dinnerVitaminB2;

            VitaminB2Prog.Value = totalDailyVitaminB2;
        }

        private void VitaminB1Prog_Click(object sender, EventArgs e)
        {
            int breakfastVitaminB1 = Breakfast.GetInstance().totalvitaminB1;
            int lunchVitaminB1 = Lunch.GetInstance().totalvitaminB1;
            int dinnerVitaminB1 = Dinner.GetInstance().totalvitaminB1;

            int totalDailyVitaminB1 = breakfastVitaminB1 + lunchVitaminB1 + dinnerVitaminB1;

            VitaminB1Prog.Value = totalDailyVitaminB1;
        }

        private void CopperProg_Click(object sender, EventArgs e)
        {
            int breakfastCopper = Breakfast.GetInstance().totalcopper;
            int lunchCopper = Lunch.GetInstance().totalcopper;
            int dinnerCopper = Dinner.GetInstance().totalcopper;

            int totalDailyCopper = breakfastCopper + lunchCopper + dinnerCopper;

            CopperProg.Value = totalDailyCopper;
        }

        private void IronProg_Click(object sender, EventArgs e)
        {
            int breakfastIron = Breakfast.GetInstance().totaliron;
            int lunchIron = Lunch.GetInstance().totaliron;
            int dinnerIron = Dinner.GetInstance().totaliron;

            int totalDialyIron = breakfastIron + lunchIron + dinnerIron;

            IronProg.Value = totalDialyIron;
        }

        private void PotassiumProg_Click(object sender, EventArgs e)
        {
            int breakfastPotassium = Breakfast.GetInstance().totalpotassium;
            int lunchPotassium = Lunch.GetInstance().totalpotassium;
            int dinnerPotassium = Dinner.GetInstance().totalpotassium;

            int totalDailyPotassium = breakfastPotassium + lunchPotassium + dinnerPotassium;

            PotassiumProg .Value = totalDailyPotassium;

        }

        private void IodineProg_Click(object sender, EventArgs e)
        {
            int breakfastIodine = Breakfast.GetInstance().totaliodine;
            int lunchIodine = Lunch.GetInstance().totaliodine;
            int dinnerIodine = Dinner.GetInstance().totaliodine;

            int totalDailyIodine = breakfastIodine + lunchIodine + dinnerIodine;

            IodineProg .Value = totalDailyIodine;
        }

        private void MagnesiumProg_Click(object sender, EventArgs e)
        {
            int breakfastMagnesium = Breakfast.GetInstance().totalmagnesium;
            int lunchMagnesium = Lunch.GetInstance().totalmagnesium;
            int dinnerMagnesium = Dinner.GetInstance().totalmagnesium;

            int totalDailyMagnesium = breakfastMagnesium + lunchMagnesium + dinnerMagnesium;

            MagnesiumProg.Value = totalDailyMagnesium;
        }

        private void FolateProg_Click(object sender, EventArgs e)
        {
            int breakfastFolate = Breakfast.GetInstance().totalfolate;
            int lunchFolate = Lunch.GetInstance().totalfolate;
            int dinnerFolate = Dinner.GetInstance().totalfolate;

            int totalDailyFolate = breakfastFolate + lunchFolate + dinnerFolate;

            FolateProg.Value = totalDailyFolate;
        }

        private void CalciumProg_Click(object sender, EventArgs e)
        {
            int breakfastCalcium = Breakfast.GetInstance().totalcalcium;
            int lunchCalcium = Lunch.GetInstance().totalcalcium;
            int dinnerCalcium = Dinner.GetInstance().totalcalcium;

            int totalDailyCalcium = breakfastCalcium + lunchCalcium + dinnerCalcium;

            CalciumProg.Value = totalDailyCalcium;  
        }

        private void FluorideProg_Click(object sender, EventArgs e)
        {
            int breakfastFluoride = Breakfast.GetInstance().totalfluoride;
            int lunchFluoride = Lunch.GetInstance().totalfluoride;
            int dinnerFluoride = Dinner.GetInstance().totalfluoride;

            int totalDailyFluoride = breakfastFluoride + lunchFluoride + dinnerFluoride;

            FluorideProg.Value = totalDailyFluoride;    
        }

        private void SodiumProg_Click(object sender, EventArgs e)
        {
            int breakfastSodium = Breakfast.GetInstance().totalsodium;
            int lunchSodium = Lunch.GetInstance().totalsodium;
            int dinnerSodium = Dinner.GetInstance().totalsodium;

            int totalDailySodium = breakfastSodium + lunchSodium + dinnerSodium;

            SodiumProg.Value = totalDailySodium;
        }

        private void SugarProg_Click(object sender, EventArgs e)
        {
            int breakfastSugar = Breakfast.GetInstance().totalsugar;
            int lunchSugar = Lunch.GetInstance().totalsugar;
            int dinnerSugar = Dinner.GetInstance().totalsugar;

            int totalDailySugar = breakfastSugar + lunchSugar + dinnerSugar;

            SugarProg.Value = totalDailySugar;
        }

        private void ChromiumProg_Click(object sender, EventArgs e)
        {
            int breakfastChromium = Breakfast.GetInstance().totalchromium;
            int lunchChromium = Lunch.GetInstance().totalchromium;
            int dinnerChromium = Dinner.GetInstance().totalchromium;

            int totalDailyChromium = breakfastChromium + lunchChromium + dinnerChromium;

            ChromiumProg.Value = totalDailyChromium;
        }

        private void ManganeseProg_Click(object sender, EventArgs e)
        {
            int breakfastManganese = Breakfast.GetInstance().totalmanganese;
            int lunchManganese = Lunch.GetInstance().totalmanganese;
            int dinnerManganese = Dinner.GetInstance().totalmanganese;  

            int totalDailyManganese = breakfastManganese + lunchManganese + dinnerManganese;

            ManganeseProg.Value = totalDailyManganese;  
        }

        private void BiotinProg_Click(object sender, EventArgs e)
        {
            int breakfastBiotin = Breakfast.GetInstance().totalbiotin;
            int lunchBiotin = Lunch.GetInstance().totalbiotin;
            int dinnerBiotin = Dinner.GetInstance().totalbiotin;

            int totalDailyBiotin = breakfastBiotin + lunchBiotin + dinnerBiotin;

            BiotinProg.Value = totalDailyBiotin;    
        }

        private void SeleniumProg_Click(object sender, EventArgs e)
        {
            int breakfastSelenium = Breakfast.GetInstance().totalselenium;
            int lunchSelenium = Lunch.GetInstance().totalselenium;
            int dinnerSelenium = Dinner.GetInstance().totalselenium;

            int totalDailySelenium = breakfastSelenium + lunchSelenium + dinnerSelenium;

            SeleniumProg.Value = totalDailySelenium;
        }

        private void ZincProg_Click(object sender, EventArgs e)
        {
            int breakfastZinc = Breakfast.GetInstance().totalzinc;
            int lunchZinc = Lunch.GetInstance().totalzinc;
            int dinnerZinc = Dinner.GetInstance().totalzinc;

            int totalDailyZinc = breakfastZinc + lunchZinc + dinnerZinc;

            ZincProg.Value = totalDailyZinc;
        }

        #endregion

        #region Labels

        private void TotalCal_Click(object sender, EventArgs e)
        {
            return;
        }

        private void DayProteinLabel(object sender, EventArgs e)
        {
            return;
        }

        private void CarbsLabel_Click(object sender, EventArgs e)
        {
            return;
        }

        private void FatLabel_Click(object sender, EventArgs e)
        {
            return;
        }

        private void BreakfastLabel_Click(object sender, EventArgs e)
        {
            return;
        }

        private void LunchLabel_Click(object sender, EventArgs e)
        {
            return;
        }

        private void DinnerLabel_Click(object sender, EventArgs e)
        {
            return;
        }

        private void SnackLabel_Click(object sender, EventArgs e)
        {
            return;
        }

        private void VitaminD_Click(object sender, EventArgs e)
        {
            return;
        }

        private void VitaminC_Click(object sender, EventArgs e)
        {
            return;
        }

        private void VitaminE_Click(object sender, EventArgs e)
        {
            return;
        }

        private void VitaminB12_Click(object sender, EventArgs e)
        {
            return;
        }

        private void VitaminB6_Click(object sender, EventArgs e)
        {
            return;
        }

        private void VitaminB3_Click(object sender, EventArgs e)
        {
            return;
        }

        private void VitaminB2_Click(object sender, EventArgs e)
        {
            return;
        }

        private void VitaminB1_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Copper_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Iron_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Potassium_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Iodine_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Magnesium_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Folate_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Calcium_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Fluoride_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Sodium_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Sugar_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Chromium_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Manganese_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Biotin_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Selenium_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Zinc_Click(object sender, EventArgs e)
        {
            return;
        }



        #endregion

        
    }

}
