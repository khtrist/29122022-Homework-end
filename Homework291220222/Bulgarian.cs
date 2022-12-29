using _29122022_Homework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Homework
{
    internal class Bulgarian:Human
    {
       

        public Bulgarian(string name, string surname, byte age  ) : base(name, surname ,age)
        {
            
        }
        public override void Language()
        {
            Console.WriteLine("Здравейте - Bulgarian Language");
        }
    }
}
