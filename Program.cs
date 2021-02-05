using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Ad = "Tesla Model X";
            product1.Fiyat = "100K";
            product1.Aciklama = "SUV";

            Product product2 = new Product();
            product2.Ad = "Tesla Model S";
            product2.Fiyat = "75K";
            product2.Aciklama = "Sedan";

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Ad);
                Console.WriteLine(product.Fiyat);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("--------------------------");
            }

            Console.WriteLine("---------METOTLAR-----------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            Console.ReadKey();
        }
    }
}
