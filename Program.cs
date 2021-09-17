using System;

namespace sobrenome1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome , sobrenome ;
            Console.WriteLine("Qual seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Qual o seu sobrenome");
            sobrenome = Console.ReadLine();
            
            Console.WriteLine($"Nome completo: {nome} {sobrenome}");
            Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome} ");
        }
    }
}
