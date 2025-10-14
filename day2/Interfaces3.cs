namespace Interfaces3
{
    internal class Program
    {
        static void Main1()
        {
            Class1 o1 = new Class1();
            Class2 o2 = new Class2();

            IDbFunctions oIDb;

            oIDb = o1;
            oIDb.Insert();

            oIDb = o2;
            oIDb.Insert();

        }
        static void Main()
        {
            Class1 o1 = new Class1();
            Class2 o2 = new Class2();
            Class3 o3 = new Class3();

            InsertObject(o1);
            InsertObject(o2);
            InsertObject(o3);

        }
        static void InsertObject(IDbFunctions oIDb)//oIDb = o2
        //can receive an object of any class that implements IDbFunctions
        {
            oIDb.Insert();
        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }
    public class Class1 : IDbFunctions
    {
        public void Display()
        {
            Console.WriteLine("Display from class1");
        }
        public void Delete()
        {
            Console.WriteLine("Idb.Delete from class1");
        }

        public void Insert()
        {
            Console.WriteLine("Idb.Insert from class1");
        }
        public void Update()
        {
            Console.WriteLine("Idb.Update from class1");
        }
    }
    public class Class2 : IDbFunctions
    {
        public void Show()
        {
            Console.WriteLine("Show from class2");
        }
        public void Delete()
        {
            Console.WriteLine("Idb.Delete from class2");
        }

        public void Insert()
        {
            Console.WriteLine("Idb.Insert from class2");
        }
        public void Update()
        {
            Console.WriteLine("Idb.Update from class2");
        }
    }
    public class Class3 : IDbFunctions
    {
        public void Show()
        {
            Console.WriteLine("Show from class2");
        }
        public void Delete()
        {
            Console.WriteLine("Idb.Delete from class2");
        }

        public void Insert()
        {
            Console.WriteLine("Idb.Insert from class2");
        }
        public void Update()
        {
            Console.WriteLine("Idb.Update from class2");
        }
    }

}

//advantages of interfaces

//contract - class MUST implement all the interface methods
//similar code in entire project for all developers
//polymorphic code
//design patterns 
