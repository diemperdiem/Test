using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDeveloper2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // You can use console and debug for test your functions
            // When you finish open "Test Explorer" and press "Run All" for review your functions


            // Exercise 1
            // Happy Number
            // Write an algorithm to determine if a number is "happy".
            // A happy number is a number defined by the following process: 
            // Starting with any positive integer, 
            //replace the number
            // by the sum of the squares of its digits, and repeat the process until the number equals 1(where it will stay), 
            // or it loops endlessly in a cycle which does not include 1 (avoid an endless loop by exiting once the sum of squares equals 4).
            // Those numbers for which this process ends in 1 are happy numbers.
            // Example: 
            // Input: 19
            // Output: true
            // Explanation: 
            // 1^2 + 9^2 = 82
            // 8^2 + 2^2 = 68
            // 6^2 + 8^2 = 100
            // 1^2 + 0^2 + 0^2 = 1
            // Example: 
            // Input: 15
            // Output: false
            // Explanation: 
            // 1^2 + 5^2 = 26
            // 2^2 + 6^2 = 40
            // 4^2 + 0^2 = 16
            // 1^2 + 6^2 = 37
            // 3^2 + 7^2 = 58
            // 5^2 + 8^2 = 89
            // 8^2 + 9^2 = 145
            // 1^2 + 4^2 + 5^2 = 42
            // 4^2 + 2^2 = 20
            // 2^2 + 0^2 = 4    -- Exit here
            // 4^2 = 16         -- Otherwise you enter an endless loop


            // Exercise 2
            // A company has 2 types of employees: local and external.
            // Emplyees get paid weekly
            // External employees get an extra 50% per hour for extra hours
            // Local employees get an extra 30% per hour for extra hours and after 12 extra hours they get 60% (over base salary) for each extra hour past 12 hours
            // Local employees work 48 hours a week
            // External employees weekly 40 hours a week
            // The total salary is the base salary plus extra hours.
            // Design an abstract class Employee that will be inherited by LocalEmployee and ExternalEmployee. 

            // Add these properties:
            // string FirstName
            // string MiddleName (note, middle name allows nulls, but first and last don't)
            // string LastName
            // int SalaryPerHour

            // Add the following READ ONLY PROPERTIES IN EMPLOYEE CLASS (you can add more if needed):
            // string FullName
            // int HoursPerWeek

            // Add these methods:
            // int Salary(int hoursWorked) (note, use default rounding)
            // int ExtraSalary(int hoursWorked)

            // Finally finish the GetAverageSalaryPerHour method, it will receive a collection of Employees and return average salary per hour for the requested employee type (local, external or both, use default rounding)



            var respuesta = HappyNumber(15);
            string asd = "";

        }

        public static bool HappyNumber(int num)
        {
            bool Resp = false;

            if (num < 1)
            {
                return Resp = false;
            }

            double suma = 0;
            double newNumber = 0;
            var NumberParse = num.ToString().ToArray();

            while (true)
            {
                if (suma == 0)
                {
                    foreach (var item in NumberParse)
                    {
                        int NumaSumar = int.Parse(item.ToString());
                        suma += Math.Pow(NumaSumar, 2);
                    }
                }
                else
                {
                    var suma2 = suma.ToString().ToArray();
                    suma = 0;
                    foreach (var item in suma2)
                    {
                        int NumaSumar = int.Parse(item.ToString());
                        suma += Math.Pow(NumaSumar, 2);
                    }
                }
                

                if (suma == 1)
                {
                    return Resp = true;
                }
                else if (suma == 4)
                {
                    return Resp = false;
                }
            }

            return Resp;
        }

        //Implementation of classes

        public static List<Employee> GetAverageSalaryPerHour(List<Employee> ListaEmpleados) 
        {

        
        }

    }
}
