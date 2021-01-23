using System;

namespace ConstrutorYapisi
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person() { Id=1, FirstName="Baran", LastName="Yıldız", City="Antalya"};

            Person person1 = new Person(2,"Yaren", "Yıldız", "Antalya");

            Console.WriteLine(person.FirstName);
            Console.WriteLine(person1.FirstName);

        }
    }

    class Person
    {
        public Person()
        {
                
        }

        public Person(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
