using System;

namespace Tankun01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tankun machine = new Tankun(2000, 500, 300, 300);

            while (true)
            {
                Console.WriteLine("\n======================");
                Console.WriteLine(" Coffee Machine Menu ");
                Console.WriteLine("======================");
                Console.WriteLine("1. Black Coffee");
                Console.WriteLine("2. Mocha");
                Console.WriteLine("3. Latte");
                Console.WriteLine("4. Chocolate");
                Console.WriteLine("5. Refill Stock");
                Console.WriteLine("6. Show Stock");
                Console.WriteLine("0. Exit");
                Console.Write("Select menu: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        machine.MakeDrink(300, 20, 0, 0, "Black Coffee");
                        break;

                    case "2":
                        machine.MakeDrink(300, 20, 0, 10, "Mocha");
                        break;

                    case "3":
                        machine.MakeDrink(300, 20, 10, 0, "Latte");
                        break;

                    case "4":
                        machine.MakeDrink(300, 0, 0, 20, "Chocolate");
                        break;

                    case "5":
                        Console.Write("Add water: ");
                        int w = int.Parse(Console.ReadLine());
                        Console.Write("Add coffee: ");
                        int c = int.Parse(Console.ReadLine());
                        Console.Write("Add milk: ");
                        int m = int.Parse(Console.ReadLine());
                        Console.Write("Add chocolate: ");
                        int ch = int.Parse(Console.ReadLine());
                        machine.Refill(w, c, m, ch);
                        break;

                    case "6":
                        machine.ShowStock();
                        break;

                    case "0":
                        Console.WriteLine("Exit program");
                        return;

                    default:
                        Console.WriteLine("Wrong input, try again");
                        break;
                }
            }
        }
    }
}
