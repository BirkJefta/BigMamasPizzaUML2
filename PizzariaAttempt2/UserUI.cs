using Pizzaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaAttempt2 {
    public class UserUI {
        public UserUI()
        {
            PizzaController.InitialMenu();
        }

        public void Run()
        {

            PizzaController pizzaController = new PizzaController();

            bool proceed = true;
            string numberEntered;
            List<string> menuList = new List<string>()
            {
                "1: Display pizza-menu",
                "2: Add pizza to menu",
                "3: Search pizza by number",
                "4: Search pizza by name",
                "5: Delete a pizza",
                "6: Quit program"
            };

            do
            {

                foreach (string menuChoice in menuList)
                {
                    Console.WriteLine(menuChoice);
                }
                Console.WriteLine("\n");
                Console.WriteLine("Enter number of option");
                numberEntered = Console.ReadKey().KeyChar.ToString();

                Console.WriteLine("\n");

                switch (numberEntered)
                {
                    case "1":
                        Console.WriteLine($"YOU PRESSED {numberEntered}, TO SEE MENU");
                        pizzaController.DisplayMenu();

                        
                        break;

                    case "2":
                        Console.WriteLine($"YOU PRESSED {numberEntered}, TO ADD A PIZZA TO MENU");
                        Console.WriteLine("");
                        Console.WriteLine($"The pizza {pizzaController.CreatePizza()} was added");
                        break;
                    case "3":
                        Console.WriteLine($"YOU PRESSED {numberEntered}, TO SEARCH BY NUMBER");
                        Console.WriteLine("");
                        Console.WriteLine("Here is the menu:");
                        pizzaController.DisplayMenu();
                        Console.WriteLine("");
                        Console.WriteLine("What is the number of the pizza you want to find?");
                        Console.WriteLine($"The pizza was: {pizzaController.SearchPizzaByNumber()}");
                        
                        break;
                    case "4":
                        Console.WriteLine($"YOU PRESSED {numberEntered}, TO SEARCH BY NAME");
                        Console.WriteLine("");
                        Console.WriteLine("Here is the menu:");
                        pizzaController.DisplayMenu();
                        Console.WriteLine("");
                        
                        pizzaController.SearchPizzaByName();


                        break;
                    case "5":
                        Console.WriteLine($"YOU PRESSED {numberEntered} TO REMOVE A PIZZA");
                        Console.WriteLine("\n");
                        Console.WriteLine("This is the current Menu");
                        Console.WriteLine("\n");
                        pizzaController.DisplayMenu();
                        Console.WriteLine("");
                        pizzaController.DeletePizza();
                        Console.WriteLine("");
                        Console.WriteLine("You succesfully deleted the pizza");
                        Console.WriteLine("The menu is now:");
                        pizzaController.DisplayMenu();
                       
                        break;
                    case "6":
                        Console.WriteLine($"YOU PRESSED {numberEntered}, TO QUIT");
                        Console.WriteLine("Are you sure");
                        Console.WriteLine("Press y for yes , otherwise press n for no");
                        ConsoleKeyInfo quit = Console.ReadKey();

                        if (quit.KeyChar == 'y' || quit.KeyChar == 'Y')
                        {
                            proceed = false;
                        }
                        Thread.Sleep(500);
                        Console.Beep();

                        break;
                    default:
                        Console.WriteLine("Wrong input, try again");
                        break;

                }
                Console.WriteLine("\n");
                if (proceed == true)
                {
                    Console.WriteLine("press enter to see menu again");
                    Console.ReadLine();
                }
            }while (proceed) ;
        }
    }
}
