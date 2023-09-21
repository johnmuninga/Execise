using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        //Attributes field
        string name;
        string surname;
        string departName;
        double sales;

        //Construtor

        public Employee()
        {
        }

        public string getName()
        {
            return name;
        }
        public string getSurName()
        {
            return surname;
        }
        public string getDepartName()
        {
            return departName;
        }


        public void setName(string name)
        {
            this.name = Char.ToUpper(name[0]).ToString() + name.Substring(1).ToLower();
        }
        public void setSurname(string surname)
        {
            this.surname = surname.ToUpper();
        }

        public void setDepartName(char dept)
        {
            if (dept == 'E')
            {
                this.departName = "Electronics";
            }
            else if (dept == 'H')
            {
                this.departName = "Hardware";
            }
            else if (dept == 'S')
            {
                this.departName = "Sportswear";
            }
            else
            {
                Console.WriteLine("Wrong Parameter Given !");
            }
        }
        public void setSales(double sales)
        {
            if (sales < 2000)
            {
                this.sales = 2000;

            }
            else
            {
                this.sales = sales;
            }
        }
        public double calcSalary()
        {
            double salary = 3000;

            if (departName == "Hardware")
            {
                salary += sales * 0.02;
            }
            else if (departName == "Electronics")
            {
                salary += sales * 0.035;
            }
            else
            {
                salary += sales * 0.045;
            }

            return salary;
        }
    }

}
