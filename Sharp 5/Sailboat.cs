using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_5
{
    class Sailboat : Steamer
    {
        private int amount_ship;
        public int Amount_ship { get => amount_ship; set => amount_ship = value; }

        public Sailboat(string name, int heigth, int length, int weigth, int age, double speed,int amount_ship)
            : base(name, heigth, length, weigth, age,speed)
        {
            Amount_ship=amount_ship;
        }
        public Sailboat()
        {
        }
        public void Print_Sailboat()
        {
            Console.WriteLine("\nAmount ships: " + Amount_ship);
        }
        public void Edit_Sailboat()
        {
            Console.Clear();
            Console.WriteLine("Change field about the number of ships:\n");
            Amount_ship = Convert.ToInt32(Console.ReadLine());
        }
    }
}
