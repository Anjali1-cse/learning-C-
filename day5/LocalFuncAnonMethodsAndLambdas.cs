namespace AnonMethodsAndLambdas
{
    internal class Program
    {
        static void Main1()
        {
            int i = 100;
            //anon methods - dont have a name
            //can only be called with a delegate
            Action o1 = delegate()
            {
                i++; //anon method can access local variable declared in the outer func
                Console.WriteLine("anon method called");
            };
            o1();
            Console.WriteLine(i);

            Func<int,int,int> o2 = delegate(int a, int b)
            {
                return a + b; 
            };
            Console.WriteLine(o2(1,2));
        }
       

        static void Main()
        {
            Func<int, int> o1 = GetDouble;
            Console.WriteLine(o1(10));

            Func<int, int> o2 = delegate(int a)
            {
                return a * 2;
            };
            Console.WriteLine(o2(10));
            Func<int, int> o3 = a => a * 2;
            Console.WriteLine(o3(10));

            Func<string> o4 = () => DateTime.Now.ToLongTimeString();
            Console.WriteLine(o4());

            Func<int, int, int> o5 = (a, b) => a + b;
            Console.WriteLine(o5(1,2));


            Func<int, bool> o6 = a => a % 2 == 0;
            Console.WriteLine(o6(1));

            Predicate<Employee> o7 = obj => obj.Basic > 10000;
            Employee obj = new Employee { EmpNo = 1, Name = "a", Basic = 20000, DeptNo = 10 };
            Console.WriteLine(o7(obj));

            Action o8 = () => Console.WriteLine("Display called");
            o8();

            Action<string, int> o9 = (s,i) => Console.WriteLine("Display called" + s + i);
            o9("a", 1);
        }

        static bool IsBasicGreaterThan10000(Employee obj)
        {
            if (obj.Basic > 10000)
                return true;
            else
                return false;
        }
        static string GetTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
        static int GetDouble(int a)
        {
            return a * 2;
        }
    }
   

    public class Class1
    {
        public void Display()
        {
            int i = 100;
            DoSomething();

            //local func - func declared inside a func
            //local func is only available in the outer func
            //implicitly private
            //cannot be overloaded
            void DoSomething()
            {
                //local func can access local variables declared
                //            in the outer function
                i++;
            }
        }
        public void Show()
        {

        }

    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }

    }
}
