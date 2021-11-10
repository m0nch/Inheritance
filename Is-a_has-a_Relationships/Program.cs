using System;

namespace Is_a_has_a_Relationships
{
    //is-a
    //If your class inherits from the other class, it is an "IS-A" relationship.
    public class Manager:Employee //manager IS-A employee
    {
        public Manager(int id, string name, Address address) : base(id, name, address)
        {

        }
    }
    //has-a
    //If the class is passed to the other class in the constructor this is a "HAS-A" relationship.
    public class Address
    {
        public string _state, _city, _addressLine;
        public Address(string state, string city, string addressLine)
        {
            _state = state;
            _city = city;
            _addressLine = addressLine;
        }
    }
    public class Employee
    {
        public int _id;
        public string _name;
        public Address _address;//Employee HAS-A Address  
        public Employee(int id, string name, Address address)
        {
            _id = id;
            _name = name;
            _address = address;
        }
        //public Employee()
        //{

        //}
        public void display()
        {
            Console.WriteLine($"id: {_id}, Name: {_name}, Address: {_address._state}, {_address._city}, {_address._addressLine}");
        }
    }
    public class Test
    {
        public static void Main(string[] args)
        {
            Address a1 = new Address("Yerevan", "Yerevan", "Abovyan 23-23");
            Employee e1 = new Employee(1, "Armen", a1);
            e1.display();

            Address a2 = new Address("Vayotc Dzor", "Eghegnadzor", "Saryan 6-5");
            Manager m1 = new Manager(2, "Sargis", a2);
            m1.display();

            Console.ReadKey();
        }
    }
}
