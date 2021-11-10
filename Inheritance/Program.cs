using System;

// Inheritance. 

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();

            Console.WriteLine(instance.publicField);
            instance.Show();

            Console.ReadKey();
        }
    }
    
    class BaseClass
    {
        public string publicField = "BaseClass.publicField";
        private string privateField = "BaseClass.privateField";
        protected string protectedField = "BaseClass.protectedField";
        
        public void Show()
        {
            Console.WriteLine(privateField);
        }
    }

    class DerivedClass : BaseClass
    {
        // Constructor
        public DerivedClass()
        {
            publicField = "DerivedClass.publicField";
            protectedField = "DerivedClass.protectedField";            
        }
    }
}
