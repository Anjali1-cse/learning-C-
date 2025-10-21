using System.Xml.Linq;

namespace EmpExpection
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Employee emp = new Employee();

                Console.Write("Enter Name: ");
                emp.Name = Console.ReadLine();

                Console.Write("Enter Basic Salary: ");
                emp.Basic = decimal.Parse(Console.ReadLine());

                Console.Write("Enter Department Number: ");
                emp.Deptno = short.Parse(Console.ReadLine());

               
                Console.WriteLine("\nEmployee Details:");
                Console.WriteLine($"Name: {emp.Name}");
                Console.WriteLine($"Basic Salary: {emp.Basic}");
                Console.WriteLine($"Dept No: {emp.Deptno}");
                Console.WriteLine($"Net Salary: {emp.GetNetSalary(emp.Basic)}");
            }
            catch (InvalidPropsException ex)
            {
                Console.WriteLine("Validation Error: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input Format Error: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }
        }
    }


}
    
    public class InvalidPropsException : ApplicationException
    {
        public InvalidPropsException(string message) : base(message)
        {
        }
    }

    public class Employee
    {
        public string name;
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value) || !value.All(char.IsLetter))
                {
                    throw new InvalidPropsException("invaild name");
                }
                else
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }
        public int id;
        public int Id
        {
            set
            {
                if (value > 0)
                    id = value;
                else
                    throw new InvalidPropsException("invaild Id");

            }
            get
            {
                return id;
            }
        }
        public decimal basic;
        public decimal Basic
        {
            set
            {
                if (value > 10000)
                    basic = value;
                else
                    throw new InvalidPropsException("invaild basic");

            }
            get
            {
                return basic;
            }
        }
        public short deptno;
        public short Deptno
        {
            set
            {
                if (value > 0)
                    deptno = value;
                else
                    throw new InvalidPropsException("invaild Deptno");
            }
            get
            {
                return deptno;
            }
        }
        public decimal GetNetSalary(decimal basic)
        {
            decimal deduct = 1000;
            decimal salary = (basic - deduct);
            return salary;
        }
     }