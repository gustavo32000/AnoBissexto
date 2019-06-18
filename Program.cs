using System;

namespace AnoBissexto
{
    class Program
    {
        static void Main(string[] args)
        {
        int ano;

          Console.WriteLine ("Digite um ano");
            ano = int.Parse(Console.ReadLine());

        if (ano % 4 != 0)
            Console.WriteLine ("O ano não é bissexto!");
        
        else 
            Console.WriteLine ("O ano é bissexto!");
        
          
        }
    }
}
