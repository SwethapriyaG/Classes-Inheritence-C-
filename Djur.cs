using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Inheritence
{
    class Djur
    {
        public int ålder { get; set; } 
        public virtual void Eat() // Virtual metod kan använda i annan klass
        {
            Console.WriteLine("Djur kan äta mat!");
        }
        public virtual void Sleep()
        {
            Console.WriteLine("Djur kan sova!");
        }
    }
}
