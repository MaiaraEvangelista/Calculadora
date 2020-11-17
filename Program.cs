using System;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja ver a taboada de qual numero? ");
            int resposta = int.Parse(Console.ReadLine());

            int resultado;

            for (int contador = 10; contador >= 0; contador --)
            {
               // Console.WriteLine(contador);
              //  System.Threading.Thread.Sleep(50);
              resultado = resposta * contador;
              Console.WriteLine($"{resposta} * {contador} = {resposta * contador}");
            }
        }
    }
}
