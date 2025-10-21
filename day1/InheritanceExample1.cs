namespace InheritanceExample1
{
    internal class Program
    {
        static void Main()
        {
            DerivedClass o = new DerivedClass();
            
        }
    }
    public class BaseClass //: Object
    {
        public int i;
    }
    public class DerivedClass : BaseClass 
    {
        public int j;
    }


}
