using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 10;
            //int sayi2 = 30;
            //sayi1 = sayi2;
            //sayi2 = 65;

            //Console.WriteLine(sayi1);

            //int[] sayilar1 = new int[] { 10, 20, 30 };
            //int[] sayilar2 = new int[] { 100, 200, 300 };
            //sayilar1 = sayilar2;
            //sayilar2[0] = 999;
            //Console.WriteLine(sayilar1[0]);

            Person person = new Person();
            person.FirstName = "Serhat";

            Customer customer = new Customer();
            customer.FirstName = "Yaren";

            Employee employee = new Employee();
            employee.FirstName = "Baran";

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {

            Console.WriteLine(person.FirstName);
        }
    }
}
