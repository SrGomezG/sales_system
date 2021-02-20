using System;

namespace Classess
{
    class Program
    {
        static void Main(string[] args)
        {
            //guys
            SalesMan sm1 = new SalesMan();
            sm1.Name = "Santiago Gomez";
            sm1.Age = 19;

            SalesMan sm2 = new SalesMan();
            sm2.Name = "Camilo Grisales";
            sm2.Age = 20;

            SalesMan sm3 = new SalesMan();
            sm3.Name = "Alejandro Preciado";
            sm3.Age = 19;

            //product
            Product p1 = new Product();
            p1.Name = "Peach";
            p1.Price = 1000f;

            Product p2 = new Product();
            p2.Name = "Apple";
            p2.Price = 800f;

            Product p3 = new Product();
            p3.Name = "Pineapple";
            p3.Price = 1200f;

            Sale s1 = new Sale();
            s1.Product = p1;
            s1.SalesMan = sm1;
            s1.Comments = "Delicious peach";

            Sale s2 = new Sale();
            s2.Product = p2;
            s2.SalesMan = sm2;
            s2.Comments = "Delicious apple";

            Sale s3 = new Sale();
            s3.Product = p3;
            s3.SalesMan = sm3;
            s3.Comments = "Delicious pineapple";

            System.Console.WriteLine("Total sales price: " + (s1.Product.Price + s2.Product.Price + s3.Product.Price));

        }
    }
}
