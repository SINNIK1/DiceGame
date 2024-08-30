using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playernum;
            int enemynum;

            int playerpoints = 0;
            int enemypoints = 0;

            Random random = new Random();
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("Press any key to roll the Dice ");

                Console.ReadKey();

                playernum = random.Next(1, 7);

                Console.WriteLine("you rolled a " + playernum);

                Console.WriteLine("...");

                System.Threading.Thread.Sleep(1000);

                enemynum = random.Next(1, 7);

                Console.WriteLine("enemy rolled a " + enemynum);

                if (playernum > enemynum) { playerpoints++; Console.WriteLine("Player Wins the Round"); }
                else if (enemynum > enemypoints) { enemypoints++; Console.WriteLine("Enemy wins the Round"); }
                else { Console.WriteLine("Draw"); }

                Console.WriteLine("The Score is Now - Player:" + playerpoints + ". Enemy: " + enemypoints + ".");
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
