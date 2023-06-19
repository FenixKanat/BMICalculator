// BMICalculator.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    //Fenix Kanat
    /*The BMI Class consists of necessary getters and setters as well as CalculateBMI() method that does the calculation of BMI AND
     * GETBMICategory() that will check which BMI Category the user belongs to depending on their values using the method CalculateWeight().
     * ConverFeetAndInchesToInches() is doing exactly that. Converts feet and inches to inches. 
    */
    class BMICalculator
    {
        private double weight;
        private double height;
        private UnitTypes unitType;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public UnitTypes UnitType
        {
            get { return unitType; }
            set { unitType = value; }
        }

        public double CalculateBMI()
        {
            if (height <= 0)
                throw new InvalidOperationException("Height must be greater than zero.");

            if (weight <= 0)
                throw new InvalidOperationException("Weight must be greater than zero.");

            double bmi;

            switch (unitType)
            {
                case UnitTypes.Metric:
                    bmi = weight / (height * height);
                    break;
                case UnitTypes.Imperial:
                    bmi = (weight / (height * height)) * 703;
                    break;
                default:
                    throw new InvalidOperationException("Invalid unit type.");
            }

            return bmi;
        }

        public string GetBMICategory()
        {
            double bmi = CalculateBMI();

            if (bmi < 18.5)
                return $"Underweight (Normal weight: {CalculateWeight(18.5):0.0} - {CalculateWeight(24.9):0.0})";
            else if (bmi < 25)
                return $"Normal weight (Normal weight: {CalculateWeight(18.5):0.0} - {CalculateWeight(24.9):0.0})";
            else if (bmi < 30)
                return $"Overweight (Normal weight: {CalculateWeight(18.5):0.0} - {CalculateWeight(24.9):0.0})";
            else if (bmi < 35)
                return $"Obese (Class I) (Normal weight: {CalculateWeight(18.5):0.0} - {CalculateWeight(24.9):0.0})";
            else if (bmi < 40)
                return $"Obese (Class II) (Normal weight: {CalculateWeight(18.5):0.0} - {CalculateWeight(24.9):0.0})";
            else
                return $"Obese (Class III) (Normal weight: {CalculateWeight(18.5):0.0} - {CalculateWeight(24.9):0.0})";
        }

        public double CalculateWeight(double bmiValue)
        {
            if (height <= 0)
                throw new InvalidOperationException("Height must be greater than zero.");

            double weight = bmiValue * (height * height);

            return weight;
        }

        public double ConvertFeetAndInchesToInches(double feet, double inches)
        {
            if (feet < 0 || inches < 0)
                throw new InvalidOperationException("Feet and inches values must be greater than or equal to zero.");

            double heightInInches = (feet * 12) + inches;
            return heightInInches;
        }
    }
}

