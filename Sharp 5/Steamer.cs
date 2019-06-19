using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_5
{
    class Steamer : Ship
    {
        private double speed;
        public double Speed { get => speed; set => speed = value; }

        public Steamer(string name, int heigth, int length, int weigth, int age, double speed)
            : base(name, heigth, length, weigth, age)
        {
            Speed=speed;
        }
        public Steamer()
        {
        }
        public void Print_Steamer()
        {
            Console.WriteLine("\nSpeed: " + Speed);
        }
        public void Edit_Steamer()
        {
            Console.Clear();
            Console.WriteLine("Change field of speed:\n");
            Speed = Convert.ToInt32(Console.ReadLine());
        }
    }
}
