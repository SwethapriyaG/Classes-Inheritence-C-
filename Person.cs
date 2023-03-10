using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Inheritence
{
    class Person : Djur
    {
        private readonly Promenad djurwalk;

        public Person(Promenad djuraction) // Konstruktor med DjurActionWalk objekt som parameter
        {
            djurwalk = djuraction;
        }
        public override void Eat() // När man har overring metod, kan man använda base klass metod 
        {
            Console.WriteLine("Människa kan äta!"); //override Superklass metod
        }
        public override void Sleep() //override Superklass metod
        {
            Console.WriteLine("Människa kan sova!");
        }

        public void Walk()
        {
            Promenad djurwalk = new Promenad();
            djurwalk.Walk("Människa"); //DjurActionWalk klass metod
        }
        
    }
}
