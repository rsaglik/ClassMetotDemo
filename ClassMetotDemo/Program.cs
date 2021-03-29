using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer
            {
                CustomerID = 1001,
                FirstName = "Ahmet",
                LastName = "ÇetinKaya",
                BirthDate = new DateTime(1995,5,5),
                IdentificationNumber = "13265465498",
                PhoneNumber = "111 111 1111"
            };
            Customer customer2 = new Customer
            {
                CustomerID = 1002,
                FirstName = "Ünal",
                LastName = "Gündüz",
                BirthDate = new DateTime(1993, 1, 15),
                IdentificationNumber = "12345678912",
                PhoneNumber = "2222 222 2222"
            };
            Customer customer3 = new Customer
            {
                CustomerID = 1002,
                FirstName = "Ayşe",
                LastName = "Gül",
                BirthDate = new DateTime(1998, 9, 29),
                IdentificationNumber = "13253213133",
                PhoneNumber = "333 333 3333"
            };

            CustomerManager customerManager = new CustomerManager();
            //Müşteri ekleniyor
            customerManager.Add(customer1);

            //Müşteri 2 güncelleniyor
            customerManager.Update(customer2);

            //Müşteriler listeleniyor
            customerManager.List(customer1, customer2, customer3);


        }
    }
}
