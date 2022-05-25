using System;

using rpg.src.Entities;

using static System.Console;

namespace RPG
{
    class Program
    {


        static void Main()
        {
            Knight Arus = new Knight("arus", 23, "knight", 100, 50);
            Hero Oponnent = new Hero("ares", 99, "Devil",1000,1000 );
            Wizard Mage = new Wizard("Jennica", 23, "White Wizard", 35, 150 );
            Ninja Ninja = new Ninja("Wedge", 23, "Ninja",25, 175 );
            BWizard BWizard = new BWizard("topapa", 23, "Black Wizard", 20, 200);

          Write($@"
          {Arus.Attack(31)}");
          Write($@"
          {Mage.Attack(31)}");
          Write($@"
          {Ninja.Attack(31)}");
          Write($@"
          {BWizard.Attack(31)}");
        }

        

    }

}