using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Employee
    {
        public int id;
        public String name;
        public float salary;
        public Employee(int i, String n, float s)
        {
            id = i;
            name = n;
            salary = s;
        }
        public void display()
        {
            Console.Write(id + " " + name + " " + salary+"\n");
        }
    }
}

