using Game_rpg.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 23, "Knight");
           Hero Wizard = new Hero("Jenica",23,"White Wizard");

            Console.WriteLine(Wizard.Attack());
            Console.WriteLine(Arus.Attack(1));
        }
    } 
} 
