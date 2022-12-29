using _29122022_Homework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Turkish:Human
    {
        
        public Turkish(string name, string surname, byte age) : base(name, surname, age) { }
         
        public override void Language()
        {
            Console.WriteLine("Merhaba - Turkish Language");
        }
    }
}
