using System;
using System.Linq;
using System.Collections.Generic;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int sizeMagazine = int.Parse(Console.ReadLine());

            Stack<int> bullets = new(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> locks = new(Console.ReadLine().Split().Select(int.Parse));

            int priceIntelegence = int.Parse(Console.ReadLine());

            int countOfBullets = 0;
            while (bullets.Any() && locks.Any())
            {
                int bullet = bullets.Pop();
                countOfBullets++;

                if (bullet > locks.Peek())
                {
                    Console.WriteLine("Ping!");
                }
                else
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }

                if (countOfBullets % sizeMagazine == 0 && bullets.Any())
                {
                    Console.WriteLine("Reloading!");
                }
                             
            }
            if (locks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${priceIntelegence - countOfBullets * priceOfBullet}");
            }
        }
    }
}
