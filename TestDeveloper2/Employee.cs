using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDeveloper2
{
    public abstract class Employee
    {
        public string FirstNameMyProperty  { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SalaryPerHour { get; set; }
    }

    public int Salary(int hoursWorked);
}
