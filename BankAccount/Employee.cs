using BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankAccount
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public int GetAnnualSalary()
        {
            return Salary * 12;
        }

        public void GiveRaise(double percentage)
        {
            double increase = Salary * (percentage / 100);
            Salary = (int)(Salary + increase);
        }
    }
}
