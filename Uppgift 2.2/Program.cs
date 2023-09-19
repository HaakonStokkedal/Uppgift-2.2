using System;

namespace Uppgift_2._2
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Elin och Alma hoppade på i en längdhoppstävling men Elin hoppade längst.");
            Console.WriteLine("Hur långt hoppade Elin? (i meter)");
            string elinText = Console.ReadLine();
            Console.WriteLine("Hur långt hoppade Alma? (i meter)");
            string almaText = Console.ReadLine();
            double elin = double.Parse(elinText);
            double alma = double.Parse(almaText);
            double elinLängre = elin - alma;
            Console.WriteLine("Elin hoppade " + elinLängre + " meter längre än Alma.,");

            Console.ReadKey();
        }
    }
}