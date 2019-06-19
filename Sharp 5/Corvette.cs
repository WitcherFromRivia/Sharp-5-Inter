using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_5
{
    class Corvette : Sailboat
    {
        private string stuff;
        public string Stuff { get => stuff; set => stuff = value; }
        public Corvette(string name, int heigth, int length, int weigth, int age, double speed, int amount_ship,string stuff)
            : base(name, heigth, length, weigth, age, speed,amount_ship)
        {
            Stuff=stuff;
        }
        public Corvette()
        {
        }
        public void Print_Corvette()
        {
            Console.WriteLine("\nStuff: " + Stuff);
        }
        public void Edit_Corvette()
        {
            Console.Clear();
            Console.WriteLine("Change the field about the stuff:\n");
            Stuff = Console.ReadLine();
        }

    }
}

