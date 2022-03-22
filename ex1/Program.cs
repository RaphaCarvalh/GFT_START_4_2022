using System;

namespace ex1 
{
    class Program
    {
        static void Main(string[] args)
           {  
               
            int Inicial = 2;
            int Final = 13;
            
            
            for (int x = Inicial ; x <= Final ; x++)
            {
                //Se quiser imprimir os pares
                //if (x % 2 == 0)  //ou 
                if (x % 2 == 1) //Se quiser imprimir os impares
                {
                    Console.Write(x+" ");
                }
                   
            }
           }
    }
}
    

