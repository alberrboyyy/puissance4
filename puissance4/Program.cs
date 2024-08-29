using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puissance4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            char chrAnswer = 'x';
            int intX = 0;
            int intY = 0;

            //Code
            Console.Clear();
            Console.WriteLine("        ╔═════════════════════════════════════════╗\n" +
                              "        ║    Bienvenue dans le jeu Puissance 4    ║\n" +
                              "        ║        Realisé par Albert Braimi        ║\n" +
                              "        ╚═════════════════════════════════════════╝\n");


            Console.WriteLine("Merci d'entrer le nombre de lignes");
            Console.Write("La valeur doit être plus grande que ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("5");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" et plus petite que ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("13");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Votre valeur : ");

            while (true)
            {
                bool isSuccess = int.TryParse(Console.ReadLine(), out intX);
                if (isSuccess && intX > 5 && intX < 13)
                { 
                    break;
                }
                else
                {
                    Console.WriteLine("Votre vaeur n'est pas un nombre ! Merci de réessayer !");
                }
            }

            //code inaccessible
            Console.WriteLine("Merci d'entrer le nombre de colonnes");
            Console.Write("La valeur doit être plus grande que ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("6");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" et plus petite que ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("16");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Votre valeur : ");
            intX = Convert.ToInt32(Console.ReadLine());

        }
    }
}
