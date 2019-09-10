using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN1_CLASS
{
    public class Employee
    {
        private string bank;
        private string ird;
        private double pay;
        private int hrs;
        private string name;
        private int age;

        public string Bank { get { return bank; } set { bank = value; } }
        public string Ird { get { return ird; } set { ird = value; } }
        public double Pay { get { return pay; } set { pay = value; } }
        public int Hrs { get { return hrs; } set { hrs = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }

        public Employee()
        {

        }
        public Employee(string _bank, string _ird, double _pay, int _hrs, string _name, int _age)
        {
            Bank = _bank;
            Ird = _ird;
            Pay = _pay;
            Hrs = _hrs;
            Name = _name;
            Age = _age;
        }
        public string EmployeeDtls()
        {
            return $"Full Name: {Name}\nAge: {Age}\nIRD Number: {Ird}\nBank: {Bank}\nAnnual Salary: {Pay}\nHours worked in a week: {Hrs}";

        }


    }
}
