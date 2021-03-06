using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, float, enum, boolean -->value types
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;
            sayi2 = 100;

            Console.WriteLine("sayi1: " + sayi1 + " " + sayi2);


            //arrays, class, interface... --> reference types

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;  // 101   102 sayilar1= 102 
            sayilar2[0] = 1000;

            Console.WriteLine("Sayılar1[0]" + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Ali";

            person2 = person1;  // person1 refe no person2'e aktarılır. Değer eşitlemesi değil, adres eşitlemesi yapılır
            person1.FirstName = "Mert";

            Console.WriteLine(person2.FirstName);



            Customer customer = new Customer();
            customer.FirstName = "Burcu";
            customer.CreditCardNumber = "3534546557567";
            Person person3 = customer;


            //Console.WriteLine(person3.FirstName);
            Console.WriteLine(((Customer)person3).CreditCardNumber);


            Employee employee = new Employee();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customer);
        }


        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string Surname { get; set; }
        }
        //base class : Person
        class Customer : Person
        {
            public string CreditCardNumber { get; set; }
        }
        class Employee : Person
        {
            public int EmployeeNumber { get; set; }
        }

        class ProjectManager
        {
            public void Add(Person person) // person olunca person ile ilgili olanları alıyor
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}