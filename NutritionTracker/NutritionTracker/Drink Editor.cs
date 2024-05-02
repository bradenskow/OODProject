using Nutrition.NutritionTracker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionTracker
{
    public partial class Drink_Editor : Form
    {
        public Drink_Editor()
        {
            InitializeComponent();
        }

        private Drink drink = new Drink();

        private void foodNameTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string drinkName = textBox.Text;

            drink.Name = drinkName;
        }

        private void manufacturerTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            string manufacturerName = textbox.Text;

            drink.Manufacturer = manufacturerName;
        }

        private void caloriesTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string caloriesText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(caloriesText, out int calories))
            {
                // Update the calories property of the Food object
                drink.Calories = calories;
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
                drink.Protein = protein;
            }
        }

        private void fatTextbox_TextChange(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string fatText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(fatText, out int fat))
            {
                // Update the fat property of the Food object
                drink.Fat = fat;
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
                drink.Carbs = carbs;
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
                drink.VitaminD = vitaminD;
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
                drink.VitaminC = vitaminC;
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
                drink.VitaminE = vitaminE;
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
                drink.VitaminB12 = vitaminB12;
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
                drink.VitaminB6 = vitaminB6;
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
                drink.VitaminB3 = vitaminB3;
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
                drink.VitaminB2 = vitaminB2;
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
                drink.VitaminB1 = vitaminB1;
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
                drink.Copper = copper;
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
                drink.Iron = iron;
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
                drink.Potassium = potassium;
            }
        }

        private void iodineTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string IodineText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(IodineText, out int Iodine))
            {
                // Update the iodine property of the Food object
                drink.Iodine = Iodine;
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
                drink.Magnesium = magnesium;
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
                drink.Folate = folate;
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
                drink.Calcium = calcium;
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
                drink.Fluoride = fluoride;
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
                drink.Sodium = sodium;
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
                drink.Sugar = sugar;
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
                drink.Chromium = chromium;
            }
        }

        private void manganeseTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string ManganeseText = textBox.Text;

            // Parse the text into an integer
            if (int.TryParse(ManganeseText, out int manganese))
            {
                // Update the manganese property of the Food object
                drink.Manganese = manganese;
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
                drink.Biotin = biotin;
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
                drink.Selenium = selenium;
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
                drink.Zinc = zinc;
            }
        }

        private void SaveDrinkButton_Click_1(object sender, EventArgs e)
        {
            Pantry.GetInstance().AddDrink(drink);
            drink = new Drink();
            //ClearTextBoxes();
        }
    }
}
