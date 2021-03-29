using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("\nMüşteri Bilgisi Ekleniyor...");            
            Console.WriteLine($"Adı : {customer.FirstName}, Soyadı : {customer.LastName}, Doğum Tarihi : {customer.BirthDate.ToString("dd MMMM yyyy")}");
            Console.WriteLine("Müşteri Bilgisi Eklendi....\n");
            Console.WriteLine("___________________________________________________________________________");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("\nMüşteri Bilgisi Güncelleniyor...\n");
            Console.WriteLine($"Adı : {customer.FirstName}, Soyadı : {customer.LastName}, Doğum Tarihi : {customer.BirthDate.ToString("dd MMMM yyyy")}");
            Console.WriteLine("Müşteri Bilgisi Güncellendi....\n");
            Console.WriteLine("___________________________________________________________________________");
        }

        public void List(params Customer[] customers)
        {
            Console.WriteLine("\nMüşteriler Listeleniyor...\n");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Adı : {customer.FirstName}, Soyadı : {customer.LastName}, Doğum Tarihi : {customer.BirthDate.ToString("dd MMMM yyyy")}");
            }
            Console.WriteLine("Müşteriler Listelendi....\n");
            Console.WriteLine("___________________________________________________________________________");
        }
    }
}
