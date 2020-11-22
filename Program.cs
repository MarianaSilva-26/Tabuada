using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        { 
         int numero; 

         Console.WriteLine("Tabuada do numero: ");
         numero = int.Parse(Console.ReadLine());
         Console.WriteLine(); 
         
        for (int a = 1; a <= 10; a++)
        {
        Console.WriteLine(numero + " * " + a + " = " + numero * a); 
        }   
        }
    }
}
