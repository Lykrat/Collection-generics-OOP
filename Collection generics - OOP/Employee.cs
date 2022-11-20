using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_generics___OOP
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public Employee()
        {
            ID = 0;
            Name = "None";
            Gender = "None";
            Salary = 0;
        }
        public Employee(int _id,string _name,string _gender,int _salary)
        {
            ID = _id;
            Name = _name;
            Gender = _gender;
            Salary = _salary;
        }
    }
}
