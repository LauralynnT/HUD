using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sleep Deprived College Student Presents...");
            Console.WriteLine("Typical RPG HUD Simulator 2023!");
            Console.WriteLine("------------------------------------------");

            int score;
            int health;
            int lives;
            float multiplier;

            score = 0;
            health = 100;
            lives = 3;
            multiplier = 1.0f;


            Console.WriteLine("Score Multiplier: " + multiplier + " | Score: " + score*multiplier);
            Console.WriteLine("Health: " + health + " | Lives: " + lives);
            Console.WriteLine("----------");

            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Player Takes 25 dmg");

            health -= 25;

            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("----------");
            Console.WriteLine("Score Multiplier: " + multiplier + " | Score: " + score * multiplier);
            Console.WriteLine("Health: " + health + " | Lives: " + lives);
            Console.WriteLine("----------");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("Player takes 50dmg");
            Console.WriteLine("Player kills 2 enemies");
            Console.WriteLine("Player gets 100pts");

            health -= 50;
            score += 100;

            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("----------");
            Console.WriteLine("Score Multiplier: " + multiplier + " | Score: " + score * multiplier);
            Console.WriteLine("Health: " + health + " | Lives: " + lives);
            Console.WriteLine("----------");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("Player kills 3 enemies");
            Console.WriteLine("Player gets 150pts");
            Console.WriteLine("5 enemies killed: score multiplier increased");
            Console.WriteLine("Player takes 25dmg");
            Console.WriteLine("Player died");

            health -= 25;
            multiplier += 0.25f;
            score += 150;
            lives -= 1;

            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("----------");
            Console.WriteLine("Score Multiplier: " + multiplier + " | Score: " + score * multiplier);
            Console.WriteLine("Health: " + health + " | Lives: " + lives);
            Console.WriteLine("----------");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("Player respawns");
            Console.ReadKey();
            Console.WriteLine("");
            health += 100;

            Console.WriteLine("Player takes 75dmg");
            Console.WriteLine("Player kills 1 enemy");
            Console.WriteLine("Player gets 50pts");

            health -= 75;
            score += 50;

            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("----------");
            Console.WriteLine("Score Multiplier: " + multiplier + " | Score: " + score * multiplier);
            Console.WriteLine("Health: " + health + " | Lives: " + lives);
            Console.WriteLine("----------");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("Player picks up health kit");
            Console.WriteLine("Player gains 50hp");

            health += 50;

            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("----------");
            Console.WriteLine("Score Multiplier: " + multiplier + " | Score: " + score * multiplier);
            Console.WriteLine("Health: " + health + " | Lives: " + lives);
            Console.WriteLine("----------");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("Player kills 2 enemies");
            Console.WriteLine("Player gets 100pts");
            Console.WriteLine("Player takes 25dmg");

            health -= 25;
            score += 100;

            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("----------");
            Console.WriteLine("Score Multiplier: " + multiplier + " | Score: " + score * multiplier);
            Console.WriteLine("Health: " + health + " | Lives: " + lives);
            Console.WriteLine("----------");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("Player takes 25dmg");
            Console.WriteLine("Player kills 2 enemies");
            Console.WriteLine("Player gets 100pts");
            Console.WriteLine("10 enemies killed: score multiplier increased");
            Console.WriteLine("Level Completed.");

            health -= 25;
            score += 100;
            multiplier += 0.25f;

            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("----------");
            Console.WriteLine("Score Multiplier: " + multiplier + " | Score: " + score * multiplier);
            Console.WriteLine("Health: " + health + " | Lives: " + lives);
            Console.WriteLine("----------");
            Console.ReadKey();
            Console.WriteLine("");
        }
    }
}
