namespace OverloadingHidingAndOverriding
{
    internal class Program
    {
        static void Main1()
        {
            DerivedClass o = new DerivedClass();
            //o.Display1(); //base
            //o.Display1("aa"); //derived

            o.Display2(); //derived
            o.Display3(); //derived

        }

        static void Main()
        {
            BaseClass o;
            o = new BaseClass();
            o.Display2(); //not virtual - early binding/compile time binding
                          //depends on how the ref has been declared
            o.Display3(); //virtual - late/runtime binding
                          //depends on how memory has been allocated

            Console.WriteLine();
            o = new DerivedClass();
            o.Display2(); //not virtual - early binding/compile time binding
                          //depends on how the ref has been declared
            o.Display3(); //virtual - late/runtime binding
                          //depends on how memory has been allocated

            Console.WriteLine();
            o = new SubDerivedClass();
            o.Display2(); //not virtual - early binding/compile time binding
                          //depends on how the ref has been declared
            o.Display3(); //virtual - late/runtime binding
                          //depends on how memory has been allocated

            Console.WriteLine();
            o = new SubSubDerivedClass();
            o.Display2(); //not virtual - early binding/compile time binding
                          //depends on how the ref has been declared
            o.Display3(); //virtual - late/runtime binding
                          //depends on how memory has been allocated

        }
    }
    public class BaseClass
    {
        public void Display1()
        {
            Console.WriteLine("base Display1");
        }
        public void Display2()
        {
            Console.WriteLine("base Display2");
        }
        public virtual void Display3()
        {
            Console.WriteLine("base Display3");
        }
    }
    public class DerivedClass : BaseClass
    {
        //overload the base class method
        //same func name, diff parameters
        //both methods are available thru object of derived class
        public void Display1(string s)
        {
            Console.WriteLine("derived Display1" + s);
        }

        //hiding
        //same func name, same parameters
        //only derived method is available thru object of derived class
        public new void Display2()
        {
            Console.WriteLine("derived Display2");
        }

        //overriding
        //same func name, same parameters
        //only derived method is available thru object of derived class
        public override void Display3()
        {
            Console.WriteLine("derived Display3");
        }
    }

    public class SubDerivedClass : DerivedClass
    {
        public  override sealed void Display3()
        {
            Console.WriteLine("subderived Display3");
        }
    }
    public class SubSubDerivedClass : SubDerivedClass
    {
        public new void Display3()
        {
            Console.WriteLine("subsubderived Display3");
        }
    }
}
/*
 Employee
   EmpNo,Basic...
   CalcNetSalary()


Manager : Employee

----------------------------------

1. Derived Class (Manager) can overload the base class(Employee) method

Manager : Employee
   CalcNetSalary(......) - same method name, diff parameters

Manager m = new Manager();
m.CalcNetSalary();  -- base class
m.CalcNetSalary(.....); -- derived class

2. Derived Class (Manager) can hide the base class(Employee) method

Manager : Employee
   CalcNetSalary() - same method name, same parameters


Manager m = new Manager();
m.CalcNetSalary(); -- derived class

ANY method can be hidden

3. Derived Class (Manager) can override the base class(Employee) method

Manager : Employee
   CalcNetSalary() - same method name, same parameters


Manager m = new Manager();
m.CalcNetSalary(); -- derived class

only a virtual method can be overridden
--------------------------------------------

virtual method
- late bound
- run time binding
- run time polymorphism
- method to call is decided at run time.

Employee e;
e = new Employee();
e.CalcNetSalary();  -- Employee

e = new Manager();
e.CalcNetSalary();  -- Manager


 */ 