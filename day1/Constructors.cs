namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj;
            obj = new Class1();
            Console.WriteLine(obj.Prop1);
            Console.WriteLine(obj.Prop2);

            Console.WriteLine();

            Class1 obj2 = new Class1(10,20);
            Console.WriteLine(obj2.Prop1);
            Console.WriteLine(obj2.Prop2);
            obj = null;
            obj2 = null;


        }
    }
    public class Class1
    {
        //public Class1()
        //{
        //    Prop1 = 1;
        //    Prop2 = 2;
        //    Console.WriteLine("no param cons called");
        //}
        //public Class1(int Prop1, int Prop2)
        //{
        //    this.Prop1 = Prop1;
        //    this.Prop2 = Prop2;
        //    Console.WriteLine("int cons called");
        //}

        public Class1(int Prop1=1, int Prop2=2)
        {
            this.Prop1 = Prop1;
            this.Prop2 = Prop2;
            Console.WriteLine("cons called");
        }
        private int prop1;
        public int Prop1
        {
            set
            {
                if (value <= 100)
                    prop1 = value;
                else
                    Console.WriteLine("invalid value");
            }
            get
            {
                return prop1;
            }
        }
        public int Prop2 { get; set; }

        //destructor -- DONT WRITE THIS
        ~Class1()
        {
            Console.WriteLine("des called");   
        }
    }
}
