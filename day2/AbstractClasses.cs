namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abs1 obj = new Abs1(); //cannot be instantiated
            Der1 obj = new Der1 ();
            obj.Method1();
            obj.Method2();
        }
    }

    public abstract class Abs1
    {
        public void Method1()
        {
            Console.WriteLine("method 1");
        }
    }
    public class Der1 : Abs1
    {
        public void Method2()
        {
            Console.WriteLine("method 2");
        }
    }

    public abstract class Abs2
    {
        public void Method1()
        {
            Console.WriteLine("method 1");
        }
        public abstract void Display();
        public abstract void Show();
    }
    public class Der2 : Abs2
    {
        public override void Display()
        {
            Console.WriteLine("d");
        }

        public override void Show()
        {
            Console.WriteLine("s");
        }
    }

    public abstract class Der3 : Abs2
    {
        public override void Display()
        {
            Console.WriteLine("d");
        }
    }
    public class SubDer3 : Der3
    {
        public override void Show()
        {
            Console.WriteLine("s");
        }
    }
}
/*
                            ABSTRACT CLASS      SEALED CLASS
INHERITANCE                     YES                 NO
INSTANTIATION                   NO                  YES
 */

//TO DO - create a sealed class