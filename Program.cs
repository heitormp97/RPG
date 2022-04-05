using System;
using Rpg.src.Entities;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 42, "Knight");
            Wizard wizard = new Wizard("Jennica", 42, "Wizard");
            Ninja ninja = new Ninja("Kagerou", 45, "Ninja", 5);

            Console.WriteLine("\n================================\n");

            Console.WriteLine(wizard);
            Console.WriteLine(knight);
            Console.WriteLine(ninja);

            Console.WriteLine("\n================================\n");

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(wizard.Ability(15));
            }

            Console.WriteLine("\n================================\n");
            
            Console.WriteLine(knight.Ability(3));
            Console.WriteLine(ninja.Ability(6));

            Console.WriteLine("\n================================\n");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(ninja.ThrowShuriken());
            }
            

            Console.WriteLine("\n================================\n");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(knight.LostHealth(500));
            }

            Console.WriteLine("\n================================\n");
        }
    }

}
