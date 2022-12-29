using _29122022_Homework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Homework
{
    internal class Azerbaijani:Human
    {
        

        public Azerbaijani(string name, string surname ,byte age) : base(name, surname ,age)
        {
            
        }
        public override void Language()
        {
            Console.WriteLine("Salam Aleykum - Azerbaijan language");
        }
    }
}
