using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class SavingsPlan

        /*
         * This class consists of necessary instance variables for calculations. 
         * It also consists of getters and setters as well as CalculateValue() method that does the necessary calculations.
         */
    {

        private double deposit;
        private int years;
        private double interestRate; 

        public double Deposit {
            get { return deposit; }
            set { deposit = value; }
        }

        public int Years {
            get { return years; }
            set { years = value; }
        }

        public double InterestRate {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public double CalculateValue() {
            double rate = interestRate / 12;
            int numOfMonths = years * 12;
            double balance = 0;

            for (int i = 1; i <= numOfMonths; i++) {
                double Earned = rate * balance;
                balance += Earned + deposit;
            }

            return balance;
        }
   
    }
}
