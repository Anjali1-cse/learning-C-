namespace StaticMembers
{
    internal class Program
    {
        static void Main()
        {
            Class1 o1;
            o1 = new Class1();
            

            Class1.si = 1234;
            Class1.sDisplay();
            Class1.sProp1 = 10;

            o1.i = 100;
            o1.Display();

            Class1 o2 = new Class1();
            o2.i = 200;
            

            Console.WriteLine(o1.i);
            Console.WriteLine(o2.i);


        }
    }
    public class Class1
    {
        public int i;
        //static variable - single copy, shared data
        public static int si;

        public void Display()
        {
            Console.WriteLine(i);
            Console.WriteLine(si);

            Console.WriteLine("Display");
        }

        //static method - can be called directly as classname.methodname
        //no need to create an object of the class to call the method
        public static void sDisplay()
        {
            //Console.WriteLine(i); //error
            Console.WriteLine(si);
            Console.WriteLine("static Display");
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

        private static int sprop1;
        public static int sProp1
        {
            set
            {
                if (value <= 100)
                    sprop1 = value;
                else
                    Console.WriteLine("invalid value");
            }
            get
            {
                return sprop1;
            }
        }

        public Class1()
        {
            Console.WriteLine("cons");
        }

        //static constructor is implicitly private - cannot have an access specifier
        //static cons is implicitly called
        //static cons is parameterless - and therefore cannot be overloaded
        static Class1()
        {
            Console.WriteLine("static cons");
            si = 333;
            sProp1 = 12;
        }
    }
}
//why property - validations
//why static data - single copy
//why static property - single copy with validations

//why constructor? - to initialise data members
//why static constructor ?  to initialise static data members

//when does the static constructor get called? - when the class is initialised
// when is the class initialised? - when the first object is created
//                                  OR when a static member is accessed for the first time.


//to do - create a static class
//can only have static members
//cannot be instantiated
//cannot be used as a  base class
