using System;
using System.Windows.Forms;

namespace BMICalculator
{

    /*This class consists of bindings between the logical classes such as BMICalculator.cs and SavingsPlan.cs and
     * Some other UI adjustments. The videos for Assignment3 were used as guides, were very helpfull! 
     */
    public partial class MainForm : Form
    {
        private BMICalculator Calc = new BMICalculator();
        private SavingsPlan savings = new SavingsPlan();

        private string name = string.Empty;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Text += " Fenix Kanat";
            labelBMI1.Text = string.Empty;
            labelBMI2.Text = string.Empty;
            labelNormalBMI.Text = "Normal Weight";
            rbtnMetric.Checked = true;

            FutureValueLbl11.Text = string.Empty;
            FutureValueLbl22.Text = string.Empty;

        }

        private void updateHeightText()
        {
            if (rbtnMetric.Checked)
            {
                labelHeight.Text = "Height (cm)";
            }
            else
            {
                labelHeight.Text = "Height (ft, in)";
            }
        }

        private void updateWeightText()
        {
            if (rbtnMetric.Checked)
            {
                labelWeight.Text = "Weight (kg)";
            }
            else
            {
                labelWeight.Text = "Weight (lbs)";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ok = readInput();
            if (ok)
            {
                double bmi;

                if (rbtnMetric.Checked)
                {
                    Calc.UnitType = UnitTypes.Metric;
                    bmi = Calc.CalculateBMI();
                }
                else
                {
                    Calc.UnitType = UnitTypes.Imperial;
                    bmi = Calc.CalculateBMI();
                }

                labelBMI1.Text = bmi.ToString("0.00");

                string category = Calc.GetBMICategory();
                labelBMI2.Text = category;

                labelNormalBMI.Text = $"Normal BMI Range: 18.5 - 24.9";

            }
        }

        private bool readInput()
        {
            readName();
            bool height = readHeight();
            bool weight = readWeight();

            return height && weight;
        }

        private bool readInputSavings() {

            bool deposit = readDeposit();
            bool years = readYears();

            return deposit && years;
        }

        private void readName()
        {
            name = textName.Text.Trim();
            groupBoxResults.Text = string.IsNullOrEmpty(name) ? "No name" : name;
        }

        private bool readDeposit() {
            double deposit = 0.0;
            bool ok = double.TryParse(SavingPlantxtbx1.Text, out deposit);

            if (!ok) {
                MessageBox.Show("The deposit value is invalid.");
                return false; 
            }

            return ok;
        }

        private bool readYears()
        {
            int years = 0;
            bool ok = int.TryParse(SavingPlantxtbx2.Text, out years);

            if (!ok)
            {
                MessageBox.Show("The years value is invalid.");
                return false;
            }

            return ok;
        }
        private bool readHeight()
        {
            double height = 0.0;
            bool ok = double.TryParse(textcmft.Text, out height);

            if (!ok)
            {
                MessageBox.Show("The height value is invalid");
                return false;
            }

            if (rbtnImperial.Checked)
            {
                double inch = 0.0;
                ok = double.TryParse(textinch.Text, out inch);

                if (!ok)
                {
                    MessageBox.Show("The inch value is invalid");
                    return false;
                }

                height = Calc.ConvertFeetAndInchesToInches(height, inch);
            }

            Calc.Height = height;
            return true;
        }

        private bool readWeight()
        {
            double weight = 0.0;
            bool ok = double.TryParse(textBoxkg.Text, out weight);

            if (!ok)
            {
                MessageBox.Show("The weight value is invalid");
                return false;
            }

            Calc.Weight = weight;
            return true;
        }

        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            updateHeightText();
            updateWeightText();
        }

        private void rbtnImperial_CheckedChanged(object sender, EventArgs e)
        {
            updateHeightText();
            updateWeightText();
        }

        private void labelBMI1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            bool ok = readInputSavings();

            if (ok)
            {
                savings.Deposit = double.Parse(SavingPlantxtbx1.Text);
                savings.Years = int.Parse(SavingPlantxtbx2.Text);
                savings.InterestRate = 0.10; 

                double save = savings.CalculateValue();
                FutureValueLbl22.Text = save.ToString("0.00");

                double amountPaid = savings.Deposit * savings.Years * 12;
                FutureValueLbl11.Text = amountPaid.ToString("0.00");
            }
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
