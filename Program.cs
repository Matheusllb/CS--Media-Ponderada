using System;
using System.Globalization;

namespace CsE20
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXERCÍCIO 20
            Console.Write("Média ponderada\n\nQuantos casos deseja calcular? ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme três notas (1 2 3):\n");

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Caso ({i})");
                string[] valores = Console.ReadLine().Split(' ');
                double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double c = double.Parse(valores[2], CultureInfo.InvariantCulture);
                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.WriteLine("\nFim do Progrma!\n");
        }
    }
}
