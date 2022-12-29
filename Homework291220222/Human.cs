using System;
using System.Collections.Generic;
using System.Text;

namespace _29122022_Homework
{
    internal abstract class Human
    {
        
        public string Name ;
        public string Surname;
        public int Age;

        public Human(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public string GetInfo(string fullname)
        {
            return $"Name: {this.Name} Surname:{this.Surname}";
        }
        public abstract void Language();
    }
}
