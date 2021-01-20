using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customer1 = new Customers();
            customer1.Id = 220391;
            customer1.Name = "Melek Nur Gül";
            customer1.KimlikNo = 34154785139;
            customer1.City = "Edirne";

            Customers customer2 = new Customers();
            customer2.Id = 280912;
            customer2.Name = "Ali Konar";
            customer2.KimlikNo = 74185296315;
            customer2.City = "Giresun";

            Customers customer3 = new Customers();
            customer3.Id = 140285;
            customer3.Name = "Nursel Konar";
            customer3.KimlikNo = 84125741254;
            customer3.City = "Bolu";

            Customers customer4 = new Customers();
            customer4.Id = 280281;
            customer4.Name = "Kenan Konar";
            customer4.KimlikNo = 95175345841;
            customer4.City = "Giresun";

            Customers customer5 = new Customers();
            customer5.Id = 610610;
            customer5.Name = "Ali Furkan Zehir";
            customer5.KimlikNo = 65414785423;
            customer5.City = "Trabzon";

            Customers customer6 = new Customers();
            customer6.Id = 510512;
            customer6.Name = "Meyra Sare Özata";
            customer6.KimlikNo = 51515151519;
            customer6.City = "Niğde";

            Customers[] musteriler = new Customers[] { customer1, customer2, customer3, customer4 };

            //foreach (Customers customers in musteriler)
            //{
            //    Console.WriteLine(customers.Id);
            //    Console.WriteLine(customers.Name);
            //    Console.WriteLine(customers.KimlikNo);
            //    Console.WriteLine(customers.City);
            //}

           

            CustomerManager Manegment = new CustomerManager();
            
            
            
            Manegment.List(musteriler);
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");


            Console.WriteLine("________________");
            Manegment.Add(customer5);
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");

            Console.WriteLine("________________");
            Manegment.Remove(customer6);






            
         

            
        }
    }
}
