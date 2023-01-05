using System;
using System.Reflection;

namespace ProjectRef
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Display(object obj)
            {
                Type objType = obj.GetType();
                var properties = objType.GetProperties();

                foreach (var property in properties)
                {
                    var propValue = property.GetValue(obj);
                    Console.WriteLine($"{property.Name}: {propValue}");
                }
            }
            Adress adress = new Adress()
            {
                City = "Kraków",
                PostalCOde = "31-456",
                Street = "Grodzka 34"
            };

            Person person = new Person()
            {
                FirstName = "John",
                LastName = "McClane",
                Adress = adress
            };

            Console.WriteLine("Person:");
            Display(person);
            Console.WriteLine("Adress:");
            Display(adress);
        }
    }
}
