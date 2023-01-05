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

                    var propType = propValue.GetType();

                    if (propType.IsPrimitive || propType == typeof(string))
                    {
                        var displayPropertiesAttribute = property.GetCustomAttribute<DisplayAtributeProperties>();

                        if (displayPropertiesAttribute != null)
                        {
                            Console.WriteLine($"{displayPropertiesAttribute.DisplayName}: {propValue}");
                        }
                        else
                        {
                            Console.WriteLine($"{property.Name}: {propValue}");
                        }

                        
                    }
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
