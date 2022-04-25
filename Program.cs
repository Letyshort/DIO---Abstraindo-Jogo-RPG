using System;
using Desafio___Abstraindo_um_Jogo_de_RPG.Entities;

namespace Desafio___Abstraindo_um_Jogo_de_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Hero wizard = new Wizard("Jenica", 23, "White Wizard");
            
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(wizard.Attack());
            

        }
    }
    
}