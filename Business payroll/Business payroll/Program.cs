using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business_Payroll
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("******Business pay roll by developer Ben de Rijk******");
            Console.WriteLine("This application will calculate the users weekly wages based on annual slary and hours worked");

            Console.WriteLine("Welcome to the staff paroll system");



            Console.WriteLine("Enter number 1 to display your Salary or number 2 to display your Wages:");
            int userInput = int.Parse(Console.ReadLine());


            Salary Employee1 = new Salary();
            
            Console.WriteLine($"Your weekly salary is:",Employee1.CalculateWeeklySalary());

         




            Console.ReadLine();
        }






        class Salary
        {
            //Private properties for the Salarys annual and weekly type.
            double annualSalary, weeklySalary;




            //Getters and setters
            public double AnnualSalary
            {
                get { return annualSalary; }
                set { annualSalary = 80000; }
            }



            //Method to calculate the Weekly Salary
            public double CalculateWeeklySalary()
            {

            return annualSalary / 52;

            }




            //Constructor which displays Annual Salary
            public Salary()
            {
                Console.WriteLine("Your salary is set at $80,000 per year...");
            }

            class Wages
            {
                //Setting the properties for class wages
                double hourlyRate;
                int numberOfHours;
                double weeklyWages;

                //Get and Set for Num of hours
                public int NumberOfHours
                {
                    get { return numberOfHours; }
                    set { numberOfHours = value; }
                }

                 

            }


        }
    }
}