using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Inheritence
{
    class Anka : Djur
    {
        private readonly Simma _djurswim;
        private readonly Promenad _djurwalk;
        public Anka(Simma djurswim, Promenad djurwalk) // construktor med perametorar 
        {
            _djurswim = djurswim;
            _djurwalk = djurwalk;
        }
        public void Swim() 
        {
            Simma djurswim = new Simma();
            _djurswim.Swim("Anka"); 
        }
        public void Walk()
        {
            Promenad djurwalk = new Promenad();
            _djurwalk.Walk("Anka"); //DjurActionWalk klass metod
        }
    }
}
