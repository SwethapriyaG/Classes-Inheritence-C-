using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Inheritence
{
    class Fisk : Djur
    {
        private readonly Simma djurswim;

        public Fisk(Simma djuraction) // Konstruktor med DjurActionSwim objekt som parameter
        {
            djurswim = djuraction;
        }
        public void Swim()
        {
            djurswim.Swim("Fisk"); //DjurActionSwim klass metod
        }
    }
}
