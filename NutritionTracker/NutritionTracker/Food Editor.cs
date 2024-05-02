using Nutrition.NutritionTracker;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionTracker
{
    public partial class Food_Editor : Form
    {

        private string meal;

        private Food food = new Food();
        private Drink drink = new Drink();

        public Food_Editor()
        {
            InitializeComponent();
        }

        public Food_Editor(string Meal)
        {
            InitializeComponent();
            this.meal = Meal;
        }


        #region TextBoxes

        private void foodNameTextbox(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string foodName = textBox.Text;

            food.Name = foodName;
        }

        private void manufacturerTextbox(object sender, EventArgs e)
        {
            
        }

        private void ManufacturerTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            string manufacturerName = textbox.Text;

            food.Manufacturer = manufacturerName; 
        }

        private void caloriesTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string caloriesText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(caloriesText, out int calories))
            {
                // Update the calories property of the Food object
                food.Calories = calories;
            }
        }

        private void proteinTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string proteinText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(proteinText, out int protein))
            {
                // Update the protein property of the Food object
                food.Protein = protein;
            }
        }

        private void fatTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string fatText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(fatText, out int fat))
            {
                // Update the fat property of the Food object 
                food.Fat = fat;
            }
        }

        private void carbsTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string carbsText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(carbsText, out int carbs))
            {
                // Update the carbs property of the Food object 
                food.Carbs = carbs;
            }
        }

        private void vitaminDTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string vitaminDText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(vitaminDText, out int vitaminD))
            {
                // Update the vitaminD property of the Food object
                food.VitaminD = vitaminD;
            }
        }

        private void vitaminCTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string vitaminCText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(vitaminCText, out int vitaminC))
            {
                // Update the vitaminC property of the Food object
                food.VitaminC = vitaminC;
            }
        }

        private void vitaminETextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string vitaminEText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(vitaminEText, out int vitaminE))
            {
                // Update the vitaminE property of the Food object
                food.VitaminE = vitaminE;
            }
        }

        private void vitaminB12Textbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string VitaminB12Text = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(VitaminB12Text, out int vitaminB12))
            {
                // Update the vitaminB12 property of the Food object
                food.VitaminB12 = vitaminB12;
            }
        }

        private void vitaminB6Textbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string vitaminB6Text = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(vitaminB6Text, out int vitaminB6))
            {
                // Update the vitaminB6 property of the Food object
                food.VitaminB6 = vitaminB6;
            }
        }

        private void vitaminB3Textbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string VitaminB3Text = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(VitaminB3Text, out int vitaminB3))
            {
                // Update the vitaminB3 property of the Food object
                food.VitaminB3 = vitaminB3;
            }
        }

        private void vitaminB2Textbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string VitaminB2Text = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(VitaminB2Text, out int vitaminB2))
            {
                // Update the vitaminB2 property of the Food object
                food.VitaminB2 = vitaminB2;
            }
        }

        private void vitaminB1Textbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string vitaminB1Text = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(vitaminB1Text, out int vitaminB1))
            {
                // Update the vitaminB1 property of the Food object
                food.VitaminB1 = vitaminB1;
            }
        }

        private void copperTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string CopperText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(CopperText, out int copper))
            {
                // Update the copper property of the Food object
                food.Copper = copper;
            }
        }

        private void ironTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string IronText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(IronText, out int iron))
            {
                // Update the iron property of the Food object
                food.Iron = iron;
            }
        }

        private void potassiumTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string PotassiumText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(PotassiumText, out int potassium))
            {
                // Update the potassium property of the Food object
                food.Potassium = potassium;
            }
        }

        private void iodineTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string IodineText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(IodineText, out int iodine))
            {
                // Update the iodine property of the Food object
                food.Iodine = iodine;
            }
        }

        private void magnesiumTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string MagnesiumText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(MagnesiumText, out int magnesium))
            {
                // Update the magnesium property of the Food object
                food.Magnesium = magnesium;
            }
        }

        private void folateTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string FolateText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(FolateText, out int folate))
            {
                // Update the folate property of the Food object
                food.Folate = folate;
            }
        }

        private void calciumTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string CalciumText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(CalciumText, out int calcium))
            {
                // Update the calcium property of the Food object
                food.Calcium = calcium;
            }
        }

        private void fluorideTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string FluorideText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(FluorideText, out int fluoride))
            {
                // Update the fluoride property of the Food object
                food.Fluoride = fluoride;
            }
        }

        private void sodiumTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string SodiumText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(SodiumText, out int sodium))
            {
                // Update the sodium property of the Food object
                food.Sodium = sodium;
            }
        }

        private void sugarTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string SugarText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(SugarText, out int sugar))
            {
                // Update the sugar property of the Food object
                food.Sugar = sugar;
            }
        }

        private void chromiumTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string ChromiumText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(ChromiumText, out int chromium))
            {
                // Update the chromium property of the Food object
                food.Chromium = chromium;
            }
        }

        private void manganeseTexbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string ManganeseText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(ManganeseText, out int manganese))
            {
                // Update the manganese property of the Food object
                food.Manganese = manganese;
            }
        }

        private void biotinTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string BiotinText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(BiotinText, out int biotin))
            {
                // Update the biotin property of the Food object
                food.Biotin = biotin;
            }
        }

        private void seleniumTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string SeleniumText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(SeleniumText, out int selenium))
            {
                // Update the selenium property of the Food object
                food.Selenium = selenium;
            }
        }

        private void zincTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string ZincText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(ZincText, out int zinc))
            {
                // Update the zinc property of the Food object
                food.Zinc = zinc;
            }
        }
        private void SaveFoodButton_Click(object sender, EventArgs e)
        {
            Pantry.GetInstance().AddFood(food);
            food = new Food();
            //ClearTextBoxes();
        }

        #endregion


        private void addRecipe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void BackToMain_Click(object sender, EventArgs e)
        {

            Breakfast.GetInstance().AddFood(food);
            Breakfast.GetInstance().AddDrink(drink);

            Lunch.GetInstance().AddFood(food);
            Lunch.GetInstance().AddDrink(drink);

            Dinner.GetInstance().AddFood(food);
            Dinner.GetInstance().AddDrink(drink);

            Snack.GetInstance().AddFood(food);
            Snack.GetInstance().AddDrink(drink);

            this.Close();


        }


        #region Labels

        public void foodNameLabel(object sender, EventArgs e)
        {
            return;
        }

        private void manufacturerLabel(object sender, EventArgs e)
        {
            return;
        }

        private void CaloriesLabel_Click(object sender, EventArgs e)
        {
            return;
        }
        

        private void ProteinLabel_Click(object sender, EventArgs e)
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

        private void Sugar_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Sodium_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Fluoride_Click(object sender, EventArgs e)
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

        private void Copper_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Biotin_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Potassium_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Selenium_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Iodine_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Calcium_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Folate_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Magnesium_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Iron_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Zinc_Click(object sender, EventArgs e)
        {
            return;
        }

        private void VitaminB3_Click(object sender, EventArgs e)
        {
            return;
        }

        private void VitaminB1_Click(object sender, EventArgs e)
        {
            return;
        }

        private void VitaminB2_Click(object sender, EventArgs e)
        {
            return;
        }

        private void VitaminB6_Click(object sender, EventArgs e)
        {
            return;
        }

        private void VitaminB12_Click(object sender, EventArgs e)
        {
            return;
        }

        private void VitaminE_Click(object sender, EventArgs e)
        {
            return;
        }

        private void VitaminC_Click(object sender, EventArgs e)
        {
            return;
        }

        private void VitaminD_Click(object sender, EventArgs e)
        {
            return;
        }

        #endregion

       
    }
}
