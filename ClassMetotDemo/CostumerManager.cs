using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CostumerManager
    {
        public void Add(Costumer costumer)
        {
            Console.WriteLine("Eklenen Yeni müşteri: " + costumer.Name +"=> "+ costumer.Jop );
        }
        public void Delete(Costumer costumer)
        {
            Console.WriteLine(costumer.Name + " müşteri silindi");
        }
        public void List(Costumer costumer)
        {
            Console.WriteLine("Müşterinin  ID:" + costumer.Id);
            Console.WriteLine("Müşterinin  Adı:" + costumer.Name);
            Console.WriteLine("Müşterinin  Soyadı:" + costumer.SurName);
            Console.WriteLine("Müşterinin  Mesleği:" + costumer.Jop);
        }
    }
}
