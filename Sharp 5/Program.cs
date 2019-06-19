using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_5
{
    class Program
    {
        delegate void Method();
        static void Edit(Corvette corvette)
        {
            int selection = 0;
            Console.WriteLine("Choose menu: (1 - Name | 2 - Speed | 3 - Amount ships | 4 - Stuff)\n");
            selection = Convert.ToInt32(Console.ReadLine());
            Method edit;
            switch (selection)
            {
                case 1:
                    edit = corvette.Edit_Ship;
                    edit();
                    break;
                case 2:
                    edit = corvette.Edit_Steamer;
                    edit();
                    break;
                case 3:
                    edit = corvette.Edit_Sailboat;
                    edit();
                    break;
                case 4:
                    edit =corvette.Edit_Corvette;
                    edit();
                    break;
                default:
                    Console.WriteLine("Error input");
                    break;
            }
        }
        static void Print(Corvette corvette)
        {
            Console.Clear();
            Method pointer;
            pointer = corvette.Print_Ship;
            pointer += corvette.Print_Steamer;
            pointer += corvette.Print_Sailboat;
            pointer += corvette.Print_Corvette;
            pointer();
        }
        static void Main(string[] args)
        {
            int selection = 0;
            Corvette corvette = new Corvette("Svetlana", 24,15,36,2,45.6,4, "Wood");

            Print(corvette);

        Link:
            Console.WriteLine("\nDo you want to edit infornation? (Yes - 1 | Exit - 2)");
            selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    Edit(corvette);
                    Print(corvette);
                    goto Link;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nError input!");
                    goto Link;
            }
            Console.ReadKey();
        }
    }
    }

