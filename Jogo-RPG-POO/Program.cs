using Jogo_RPG_POO.src.Entities;
using System;

namespace Jogo_RPG_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero Knight = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White wizard");

            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
        }
    }
}
