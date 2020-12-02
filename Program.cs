using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Assignment_Day1
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Amol", 6465, 11);
            Employee o2 = new Employee("Amol", 111465);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();

            Console.WriteLine(o1.EmpNo + " " + o1.Name + " " + o1.GetNetSalary()+ " " + o1.DeptNo);
            Console.WriteLine(o2.EmpNo + " " + o2.Name + " " + o2.GetNetSalary() + " " + o2.DeptNo);
            Console.WriteLine(o3.EmpNo + " " + o3.Name + " " + o3.GetNetSalary() + " " + o3.DeptNo);
            Console.WriteLine(o4.EmpNo + " " + o4.Name + " " + o4.GetNetSalary() + " " + o4.DeptNo);
            Console.ReadLine();


            
        }
    }

    class Employee 
    {
        
        private string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        static int newEmpNo;
        private int empNo;
        public int EmpNo
        {
            private set { empNo = value; }
            get { return empNo; }
        }

        private decimal basic;
        public decimal Basic
        {
            set 
            { 
                if(value>4000 && value<10000)
                    basic = value;
                else
                    Console.WriteLine("Invalid basic");
            }
            get { return basic; }
        }

        private short deptNo;
        public short DeptNo
        {
            set { deptNo = value; }
            get { return deptNo; }
        }

        public Employee(string Name = "DotNet", decimal basic = 5000, short DeptNo=10)
        {
            this.Name = Name;
            this.empNo = ++newEmpNo;
            this.basic = basic;
            this.deptNo = DeptNo;
        }

        private decimal netSal;
        public decimal GetNetSalary() 
        {
            netSal = Basic + Basic;
            return netSal;
        }
        
    }
}
