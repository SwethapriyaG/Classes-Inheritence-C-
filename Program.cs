using System;

namespace Classes_Inheritence
{
    class Program
    {
        static void Main(string[] args)

        {
            Promenad djurwalk = new Promenad(); //declerar objekt froån pomenad klass
            Simma djurswim = new Simma(); //declerar objekt froån simma klass
            Person person = new Person(djurwalk); //declerar objekt froån person klass och passar objekt
            Console.WriteLine("MÄNNISKA");
            Console.WriteLine("*********");
            person.Eat(); // kallar metod 
            person.Sleep();
            person.Walk();
           
            Console.WriteLine("\n");

            Anka anka = new Anka(djurswim, djurwalk);//declerar objekt froån person klass och passar objekter
            Console.WriteLine("ANKA");
            Console.WriteLine("*****");
            anka.Eat();
            anka.Sleep();
            anka.Swim();
            anka.Walk();
            Console.WriteLine("\n");

            Fisk fisk = new Fisk(djurswim);
            Console.WriteLine("FISK");
            Console.WriteLine("****");
            fisk.Eat();
            fisk.Sleep();
            fisk.Swim();
            Console.WriteLine("\n");
            
            Hund hund = new Hund(djurwalk);
            Console.WriteLine("HUND");
            Console.WriteLine("****");
            hund.Eat();
            hund.Sleep();
            hund.Walk();

        }
    }
}
