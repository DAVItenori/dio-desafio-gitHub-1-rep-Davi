using System;

namespace Projeto_GLF
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jenica", 23, "White Wizard"); 

            Console.WriteLine(wizard.Attack(7));
             Console.WriteLine(hero.Attack());
            
        }
    }
}
