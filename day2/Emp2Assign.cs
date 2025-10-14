//only get, no set
namespace Emp2Assign
{
    internal class Program
    {
        static void Main1()
        {
            Employee o1 = new Employee();
            Employee o2 = new Employee();
            Employee o3 = new Employee();
            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);
        }
    }
    public class Employee
    {

        string name; //-> no blank names should be allowed
        int empNo; //-> must be greater than 0
        decimal basic;// -> must be between some range
        short deptNo;// -> must be > 0
        static int lastEmpNo = 0;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                    name = value;
                else
                    Console.WriteLine("Invalid Name");
            }
        }
        public int EmpNo
        {
            get { return empNo; }

        }
        public decimal Basic
        {
            get { return basic; }
            set
            {
                if (value < 10000 || value > 100000)
                    Console.WriteLine("Invalid Basic");
                else
                    basic = value;

            }
        }
        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Invalid EmpNo");
            }
        }
        public decimal GetNetSalary()
        {
            return Basic * 2;
        }
        public Employee(string Name = "default", decimal Basic = 10000, short DeptNo = 1)
        {
            this.empNo = ++lastEmpNo;  //property - set
            this.Name = Name;
            //this.basic = Basic; //variable -- dont use this - validations are not called
            this.Basic = Basic; //property - use this - validations are called
            this.DeptNo = DeptNo;
        }
    }

}

//property accessor
namespace EmployeeExample3
{
    internal class Program
    {
        static void Main2()
        {
            Employee employee = new Employee();
            //employee.EmpNo = 10;

        }
    }
    public class Employee
    {

        string name; //-> no blank names should be allowed
        int empNo; //-> must be greater than 0
        decimal basic;// -> must be between some range
        short deptNo;// -> must be > 0
        static int lastEmpNo = 0;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                    name = value;
                else
                    Console.WriteLine("Invalid Name");
            }
        }
        public int EmpNo
        {
            get { return empNo; }

            //property accessor
            //any one of set / get can be given a lesser access
            //you can only reduce access, not increase it
            private set
            {
                if (value > 0)
                    empNo = value;
                else
                    Console.WriteLine("Invalid EmpNo");
            }
        }
        public decimal Basic
        {
            get { return basic; }
            set
            {
                if (value < 10000 || value > 100000)
                    Console.WriteLine("Invalid Basic");
                else
                    basic = value;

            }
        }
        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Invalid EmpNo");
            }
        }
        public decimal GetNetSalary()
        {
            return Basic * 2;
        }
        public Employee(int EmpNo = 1, string Name = "default", decimal Basic = 10000, short DeptNo = 1)
        {
            this.EmpNo = ++lastEmpNo;  //property - set
            //this.empNo = EmpNo; //variable -- do not use this --- validations are not called
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }
    }
}

//readonly --- with auto property
namespace EmployeeExample4
{
    internal class Program
    {
        static void Main1()
        {
            Employee employee = new Employee();
            //employee.EmpNo = 1;

        }
    }
    public class Employee
    {

        string name; //-> no blank names should be allowed
        decimal basic;// -> must be between some range
        short deptNo;// -> must be > 0
        static int lastEmpNo = 0;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                    name = value;
                else
                    Console.WriteLine("Invalid Name");
            }
        }
        public int EmpNo
        {
            get;
        }
        public decimal Basic
        {
            get { return basic; }
            set
            {
                if (value < 10000 || value > 100000)
                    Console.WriteLine("Invalid Basic");
                else
                    basic = value;

            }
        }
        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Invalid EmpNo");
            }
        }
        public decimal GetNetSalary()
        {

            return Basic * 2;
        }
        public Employee(int EmpNo = 1, string Name = "default", decimal Basic = 10000, short DeptNo = 1)
        {
            this.EmpNo = ++lastEmpNo;  //property - set
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }
    }
}
