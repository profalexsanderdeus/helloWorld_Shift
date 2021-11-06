using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeFilme,sala,hora,data;

            Console.WriteLine("Insira o nome do filme:");
            nomeFilme = Console.ReadLine();

            Console.WriteLine("Insira a sala:");
            sala = Console.ReadLine();

            Console.WriteLine("Qual o horário do filme");
            hora = Console.ReadLine();

            Console.WriteLine("Data:");
            data = Console.ReadLine();

            Console.WriteLine("Seu ingresso para o filme {0}, sala {1} no dia {2} às {3}",
                nomeFilme,sala,data,hora);
        }
    }
}