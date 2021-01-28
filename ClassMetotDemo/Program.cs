using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Costumer costumer1 = new Costumer();
            costumer1.Name = "Faruk";
            costumer1.SurName = "KURT";
            costumer1.Jop = "Mühendis";
            costumer1.Id = 1;


            Costumer costumer2 = new Costumer();
            costumer2.Name = "Osman";
            costumer2.SurName = "KAVA";
            costumer2.Jop = "Avukat";
            costumer2.Id = 2;

            Costumer costumer3 = new Costumer();
            costumer3.Name = "Ayşe";
            costumer3.SurName = "GÜL";
            costumer3.Jop = "Doktor";
            costumer3.Id = 3;

            CostumerManager musteriyoneticisi = new CostumerManager();
            musteriyoneticisi.Add(costumer1);
            Console.WriteLine("-----");
            musteriyoneticisi.List(costumer2);
            Console.WriteLine("-----");
            musteriyoneticisi.Delete(costumer3);

        }
    }
}
