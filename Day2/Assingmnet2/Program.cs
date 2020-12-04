using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingmnet2
{
    class Program
    {
        static void Main()
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee("mahesh");
            Employee e3 = new Employee("mahesh", 500000);
            Employee e4 = new Employee("", 50000, 12);
            Employee e5 = new Employee("", 50000, 12);
            Employee e6 = new Employee("", 50000, 12);


            Console.WriteLine(e1.EmpNumber + " " + e1.EmpName + " " + e1.DeptNumber);
            Console.WriteLine(e2.EmpNumber);
            Console.WriteLine(e3.EmpNumber);
            Console.WriteLine(e4.EmpNumber);
            Console.WriteLine(e5.EmpNumber);
            Console.WriteLine(e6.EmpNumber);

        }
    }

    class Employee
    {


        string Name;
        static int empno = 0; // auto generated
        int EmpNo;
        decimal Basic;
        public decimal DA, HRA, Gross_Salary;
        short DeptNo;






        // Name
        public string EmpName
        {
            set
            {
                if (value != null)
                {
                    Name = value;
                }
                else
                {
                    //throw new ArgumentException("value");

                    Console.WriteLine("Name should not be empty");
                    Console.WriteLine("u hve enterd wrong Name");

                }
            }

            get
            {
                return Name;
            }
        }

        //EmpNo
        // auto increment EmpNo

        //  readonly using private
        public int EmpNumber
        {


            get
            {
                return EmpNo;
            }

            // only one get/set can be access given
            //reduce access not increase it 
            //public 
            //protected internal
            //internal / protected 
            // private
        }


        // Basic
        public decimal BasicSalary
        {
            set
            {
                if ((5000 <= value) && (100000 >= value))
                {
                    Basic = value;
                }
            }
            get
            {
                return Basic;
            }

        }

        //Dept
        public short DeptNumber
        {
            set
            {
                if (value > 0)
                {
                    DeptNo = value;
                }
                else
                {
                    Console.WriteLine("u hve enterd wrong dept number");
                }
            }
            get
            {
                return DeptNo;



            }
        }

    }
}






