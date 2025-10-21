namespace ConstructorsInInheritance
{
    internal class Program
    {
        static void Main()
        {
            //DerivedClass o = new DerivedClass();
            DerivedClass o2 = new DerivedClass(30,40);
        }

        //b p, d p
        //b np, d p

    }
    public class BaseClass
    {
        public int i;
        public BaseClass()
        {
            Console.WriteLine("base class no param cons");
            i = 10;
        }
        public BaseClass(int i)
        {
            Console.WriteLine("base class int cons");
            this.i = i;
        }
    }
    public class DerivedClass : BaseClass
    {
        public int j;
        public DerivedClass()
        {
            Console.WriteLine("derived class no param cons");
            j = 20;
        }
        public DerivedClass(int i, int j) : base(i)
        {
            Console.WriteLine("derived class int,int cons");
            this.j = j;
        }
    }
}
