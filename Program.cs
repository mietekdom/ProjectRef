using System;

namespace ProjectRef
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
