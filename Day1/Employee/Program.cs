using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main()
        {

            Employee o1 = new Employee("mahesh",123456,10);

            Console.WriteLine("empname:" +o1 );
            Console.ReadLine();


           

            Employee o2 = new Employee("rahul", 34567, 20);
            Console.WriteLine(o2);
            Console.ReadLine();

        }

        public class Employee
        {
            string empName;
            int empNo;
            decimal Basic;
            short DeptNo;



            public Employee(string empName, decimal Basic, short DeptNo)
            {

                this.empName = empName;
                this.Basic = Basic;
                this.DeptNo = DeptNo;


            }

            public Employee(string empName, decimal Basic)
            {

                this.empName = empName;
                this.Basic= Basic;
                


            }

            public Employee(string empName)
            {
                this.empName = empName;

            }

            public Employee()
            {
                    

            }

        }


        void Display()
        {

            
            Console.ReadLine();

        }

    }

    

    

}
