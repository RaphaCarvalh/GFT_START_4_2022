using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ex2.src;

namespace ex2 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            
            pessoa p1 = new pessoa();
            p1.setNome("Jorge Metias");
            p1.setendereco("estrada merioodinal");
            p1.settelefone(21769855);
 
            // exibir os valores na tela. 
            Console.WriteLine("Nome.: " + p1.getNome());
            Console.WriteLine("Endereco.: " + p1.getendereco());
            Console.WriteLine("Tel:. " + p1.gettelefone());
 
            // Pular duas linhas
            Console.WriteLine("Tecle enter pra sair");
            Console.ReadLine();
 
        }
    }
}