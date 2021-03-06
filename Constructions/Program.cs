using System;

namespace Constructions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir class'i new lendiğinde çalışan blog

            Customer customer = new Customer {Id=1, City="izmir", FirstName="Can", LastName="Veli"};

            Customer customer2 = new Customer ( 2, "Bursa", "Ceren", "Akın");

        }
    }

    class Customer
    {
        public Customer()
        {
         
        }
        public Customer(int id, string firstname, string lastname, string city)
        {
            Id = Id;
            City = city;
            FirstName = firstname;
            LastName = lastname;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
