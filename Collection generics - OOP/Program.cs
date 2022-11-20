using System;
using System.Collections.Generic;

//Emil SUT22

namespace Collection_generics___OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(101,"Emil","m",235);
            Employee employee2 = new Employee(102, "Lucas", "m", 3);
            Employee employee3 = new Employee(103, "Isak", "m",23000);
            Employee employee4 = new Employee(104, "Jenny", "f", 33000);
            Employee employee5 = new Employee(105, "Leo", "m", 59000);

            //Part 1

            Stack<Employee> stack1 = new Stack<Employee>();
            stack1.Push(employee1);
            stack1.Push(employee2);
            stack1.Push(employee3);
            stack1.Push(employee4);
            stack1.Push(employee5);

            foreach(Employee item in stack1)
            {
                Console.WriteLine("{0} - {1} - {2} - {3}",item.ID,item.Name,item.Gender,item.Salary);
                Console.WriteLine("Number of items left in stack: {0}",stack1.Count);
            }
            Console.WriteLine("---------------------------------");

            while (stack1.Count > 0)
            {
                Employee empDelete=stack1.Pop();
                Console.WriteLine("{0} - {1} - {2} - {3}", empDelete.ID, empDelete.Name, empDelete.Gender, empDelete.Salary);
                Console.WriteLine("Number of items left in stack: {0}", stack1.Count);
            }
            Console.WriteLine("---------------------------------");

            stack1.Push(employee1);
            stack1.Push(employee2);
            stack1.Push(employee3);
            stack1.Push(employee4);
            stack1.Push(employee5);

            for(int i = 0; i < 2; i++)
            {
                Employee emp = stack1.Peek();
                Console.WriteLine("{0} - {1} - {2} - {3}", emp.ID, emp.Name, emp.Gender, emp.Salary);
                Console.WriteLine("Number of items left in stack: {0}", stack1.Count);
            }
            Console.WriteLine("---------------------------------");
            if (stack1.Contains(employee3))
            {
                Console.WriteLine("Emp3 is in stack");
            }
            else
            {
                Console.WriteLine("Emp3 is not in stack");
            }

            //Part2
            Console.WriteLine("---------------------------------");
            List<Employee> list1 = new List<Employee>();
            list1.Add(employee1);
            list1.Add(employee2);
            list1.Add(employee3);
            list1.Add(employee4);
            list1.Add(employee5);

            if (list1.Contains(employee2))
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Empolyee2 object does not exist in the list");
            }
            Console.WriteLine("");

            Employee maleemp = list1.Find(x => x.Gender == "m");
            Console.WriteLine("The first Male in the list is : ID:{0}, Name:{1}, Gender:{2}, Salary:{3}",maleemp.ID,maleemp.Name,maleemp.Gender,maleemp.Salary);
            Console.WriteLine("");

            List<Employee> malelist1=list1.FindAll(x=>x.Gender == "m");
            foreach(Employee item in malelist1)
            {
                Console.WriteLine("ID:{0}, Name:{1}, Gender:{2}, Salary:{3}", item.ID, item.Name, item.Gender, item.Salary);
            }
        }
    }
}
