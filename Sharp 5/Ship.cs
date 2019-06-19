using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_5
{
    class Ship : Interface1
    {
        private string name;
        private double heigth;
        private double length;
        private double weigth;
        private int age;
        public string Name { get => name; set => name = value; }
        public double Heigth { get => heigth; set => heigth = value; }
        public double Length { get => length; set => length = value; }
        public double Weigth { get => weigth; set => weigth = value; }
        public int Age { get => age; set => age = value >= 18 && value <= 75 ? value : 18; }

        public Ship(string name, double heigth, double length, double weigth, int age)
        {
            Name = name;
            Heigth=heigth;
            Length=length;
            Weigth=weigth;
            Age = age;
        }

        public Ship()
        {
        }
        public void Print_Ship()
        {
            Console.WriteLine("\nName: " + Name + "\nHeigth: " + Heigth + "\nAge: " + Age + "\nLength: " + Length + "\nWeigth: " + Weigth);
        }

        public void Edit_Ship()
        {
            Console.Clear();
            Console.WriteLine("Change the name field:\n");
            Name = Console.ReadLine();
        }
    }
}
