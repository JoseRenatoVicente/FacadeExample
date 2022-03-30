using System;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\t\t\t\t __________________________________________________");
            Console.WriteLine("\t\t\t\t\t|+++++++++++++++++| Formas Geométricas |+++++++++++++|");
            Console.WriteLine("\t\t\t\t\t|1| - Desenhar Paralelogramos                        |");
            Console.WriteLine("\t\t\t\t\t|2| - Desenhar Todas as Formas                       |");
            Console.WriteLine("\t\t\t\t\t|3| - Desenhar Paralelogramos e suas propriedades    |");
            Console.Write("\t\t\t\t\t|__________________________________________________|\n" +
                          "\t\t\t\t\t|Opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {

                case "1":
                    Console.Clear();
                    Facade.DesenharParelogramos();
                    break;

                case "2":
                    Console.Clear();
                    Facade.DesenharTodasFormas();
                    break;

                case "3":
                    Console.Clear();
                    Facade.DesenharParelogramosPropriedades();
                    break;
            }
        }
    }
}
