using System;

namespace Homework
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Turkish turkish1 = new Turkish("Ilkay", "Oktay" , 32);
            Azerbaijani azerbaijanii1 = new Azerbaijani(" Abbas" , "Abbasov" , 21);
            Englishman englishman1 = new Englishman(" Thomas" , "Edisson" , 99);
            Bulgarian bulgarian1 = new Bulgarian("Dmitrova" , "Ivanna" , 25);

            azerbaijanii1.Language();
            turkish1.Language();
            englishman1.Language();
            bulgarian1.Language();

        }
    }
}
