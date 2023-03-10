using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Inheritence
{
    class Hund : Djur
    {
        private readonly Promenad djurwalk;

        public Hund(Promenad djuraction) // Konstruktor med DjurActionWalk objekt som parameter
        {
            djurwalk = djuraction;
        }
        public void Walk() 
        {
            Promenad djurwalk = new Promenad();
            djurwalk.Walk("Hund"); //DjurActionWalk klass metod
        }
    }
}
