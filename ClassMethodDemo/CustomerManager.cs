using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customers customer)
        {
            Console.WriteLine("MÜŞTERİ EKLENDİ. BİLGİLERİ;");
            Console.WriteLine("________________");
            Console.WriteLine("Müşteri Numarası: " + customer.Id);
            Console.WriteLine("Müşteri Adı Soyadı: " + customer.Name);
            Console.WriteLine("Müşteri T.C. Kimlik No: " + customer.KimlikNo);
            Console.WriteLine("Müşteri Adresi: " + customer.City);
            Console.WriteLine("________________");
        }
        public void Remove(Customers customer)
        {
            Console.WriteLine("MÜŞTERİ ARAMIZDAN AYRILDI. BİLGİLERİ;");
            Console.WriteLine("________________");
            Console.WriteLine("Müşteri Numarası: " + customer.Id);
            Console.WriteLine("Müşteri Adı Soyadı: " + customer.Name);
            Console.WriteLine("Müşteri T.C. Kimlik No: " + customer.KimlikNo);
            Console.WriteLine("Müşteri Adresi: " + customer.City);
            Console.WriteLine("________________");
        }
        public void List(Customers[] customer)
        {
            Console.WriteLine("MÜŞTERİLERİN LİSTESİ;");
            Console.WriteLine("_______________");
            foreach (Customers list in customer)
            {
                Console.WriteLine("________________");
                Console.WriteLine("Müşteri Numarası: "+list.Id);
                Console.WriteLine("Müşteri Adı Soyadı: "+list.Name);
                Console.WriteLine("Müşteri T.C. Kimlik No: "+list.KimlikNo);
                Console.WriteLine("Müşteri Adresi: "+list.City);
                Console.WriteLine("________________");
            }
        }
       
    }
}
