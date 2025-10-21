namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class2 obj = new Class2();
            obj.Prop1 = 101;
            obj.Prop2 = "aaa";
            obj.Prop4 = "bbb";
            Console.WriteLine(obj.Prop4);
        }
    }
    public class Class2
    {
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
        public string Field1;

        private string prop2;
        public string Prop2
        {
            set
            {
                prop2 = value;
            }
            get
            {
                return prop2;
            }
        }
        //to do - create a read only property (only get)
        public string Prop3;

        //when there are no validations
        //auto/automatic property
        //compiler generates code for get/set
        //compiler generates private variable
        public string Prop4 { get; set; }

    }

}
