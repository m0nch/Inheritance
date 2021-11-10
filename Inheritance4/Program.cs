using System;

// Inheritance.

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass(1, 2);

            Console.WriteLine(instance._baseNumber);
            Console.WriteLine(instance._derivedField);

            Console.ReadKey();
        }
    }


    class BaseClass
    {
        public int _baseNumber;

        // Default constractor.
        public BaseClass()
        {
        }

        // User constractor.
        public BaseClass(int number)
        {
            _baseNumber = number;
        }
    }


    class DerivedClass : BaseClass
    {
        public int _derivedField;

        // Default constructor
        public DerivedClass()
        {
        }

        // User constractor.
        //Calls the custom constructor of the base class and is not required 
        //to assign inherited values in the derived class constructor.
        public DerivedClass(int number1, int number2) : base(number1)
        {
            _derivedField = number2;
        }
     }
}
