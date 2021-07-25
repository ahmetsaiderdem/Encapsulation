using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee("vithal", 23);
            employee emp2 = new employee(emp1);
            Console.WriteLine(emp2.Details);
            Console.ReadLine();
        }
    }

    class employee
    {
        private string name;
        private int age;

        public employee(employee emp)
        {
            name = emp.name;
            age = emp.age;

        }
        public employee(string name,int age)
        {
            this.name = name;
            this.age = age;

        }
        public string Details
        {
            get
            {
                return "the age of " + name + " is " + age.ToString();
            }
        }
    }

}
