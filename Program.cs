using System;

namespace HoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("=+= Horário atual do Sistema =+=");
            Console.ResetColor();

            Console.WriteLine();

            DateTime horario = DateTime.Now;

            Console.WriteLine($"Hora do Sistema: {horario}");

            Console.WriteLine();

            Console.WriteLine("Pressione qualquer tecla para Finaliza...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
