using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter Name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter surName: ");
            //string surName = Console.ReadLine();
            //Console.Write("Enter DepartName: ");
            //string DepartName = Console.ReadLine();
            //Console.Write("Enter Sales: ");
            //double sales = double.Parse(Console.ReadLine());
            ////Object
            //Employee obj = new Employee(name, surName, DepartName, sales);

            //obj.getName();
            //obj.getSurName();
            //Console.WriteLine(obj.setName());
            //Console.WriteLine(obj.setSurname());


            Employee[] employees = new Employee[2];
            


            for (int i = 0; i < employees.Length; i++)
            {
                Console.Write($"Enter the name of employee {i+1}:");
                string emp_name = Console.ReadLine();
                employees[i] = new Employee();
                employees[i].setName(emp_name);

                Console.Write($"Enter the surname of employee {i + 1}:");
                string emp_surname = Console.ReadLine();
                employees[i].setSurname(emp_surname);

                Console.Write($"Enter the department char of employee {i + 1}:");
                char emp_dept_name = char.Parse(Console.ReadLine());
                employees[i].setDepartName(emp_dept_name);

                Console.Write($"Enter the sales of employee {i + 1}:");
                double emp_sales = double.Parse(Console.ReadLine());
                employees[i].setSales(emp_sales);

            }
            Console.WriteLine();
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Name:{employee.getName()}");
                Console.WriteLine($"Surname:{employee.getSurName()}");
                Console.WriteLine($"Department:{employee.getDepartName()}");
                Console.WriteLine($"Salary:{employee.calcSalary()}");
            }


            Console.ReadKey();
        }
    }
}
