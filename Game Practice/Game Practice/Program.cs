using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Character Aege = new Character("Aege", 60, 1, 0);
            Character poisonButterfly = new Character("Poison Butterfly", 15, 3, 0);

            Console.WriteLine("Aege now has " + Aege.GetExp() + " experience!");

            Console.ReadKey();
        }
    
    }
}
