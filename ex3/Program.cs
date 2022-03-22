using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ex3.src;

namespace ex3 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            conta = new conta();
            ct.setnumero();
            p1.settitular();
            p1.setsaldo();
 
            // exibir os valores na tela. 
            Console.WriteLine(SaldoTT());
            Console.WriteLine(rendimento2());
            Console.WriteLine(rendimento3());
 
            // Pular duas linhas
            Console.WriteLine("Tecle enter pra sair");
            Console.ReadLine();
 
        }
    }
}