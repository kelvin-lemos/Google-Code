using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8_Exercício_8
{
    internal class Program
    {
        static string ObterRadical(string verbo)
        {
            return verbo.Substring(0, verbo.Length - 2);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um verbo regular (termina com 'ar'): ");
            string verbo = Console.ReadLine();


        }
    }
}
