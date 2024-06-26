﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaAttempt2 {
    public class UserUI {
        private PizzaController _pizzaController;
        private OrderController _orderController;
        public UserUI()
        {
            PizzaController.InitialMenu();
            _orderController = new OrderController();
            _pizzaController = new PizzaController();
        }

        public void Run()
        {

            

            bool proceed = true;
            string numberEntered;
            List<string> menuList = new List<string>()
            {
                "1: Display pizza-menu",
                "2: Create a new order",
                "3: Add pizza to menu",
                "4: Search pizza by number",
                "5: Search pizza by name",
                "6: Delete a pizza",
                "7: Quit program"
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
                        _pizzaController.DisplayMenu();
                        break;
                    case "2":
                        bool done = false;
                        
                            Console.WriteLine($"YOU PRESSED {numberEntered}, TO ADD A NEW PIZZA TO YOUR ORDER");
                            Console.WriteLine("");
                            string name = _orderController.customerName();
                        while (done == false)
                        {
                            
                            _pizzaController.DisplayMenu();
                            Console.WriteLine("");
                            Console.WriteLine($"{name},Please enter the number of the Pizza you want to add");
                            _orderController.AddPizzaToOrder(_pizzaController.SearchPizzaByNumber());
                            Console.WriteLine("Pizza was added to the order");
                            Console.WriteLine("");
                            Console.WriteLine($"Order For {name}:");
                            _orderController.OrderedPizzas();
                            Console.WriteLine();
                            Console.WriteLine("");
                            Console.WriteLine("Do you want to add more pizzas?");
                            Console.WriteLine("Press y for yes");
                            string answer = Console.ReadLine().ToLower();
                            if (answer != "y")
                            {
                                done = true;
                                _orderController.clearOrderList();
                            }
                            
                            
                        }
                        break;

                    case "3":
                        Console.WriteLine($"YOU PRESSED {numberEntered}, TO ADD A PIZZA TO MENU");
                        Console.WriteLine("");
                        Console.WriteLine($"The pizza {_pizzaController.CreatePizza()} was added");
                        break;
                    case "4":
                        Console.WriteLine($"YOU PRESSED {numberEntered}, TO SEARCH BY NUMBER");
                        Console.WriteLine("");
                        Console.WriteLine("Here is the menu:");
                        _pizzaController.DisplayMenu();
                        Console.WriteLine("");
                        Console.WriteLine("What is the number of the pizza you want to find?");
                        Console.WriteLine($"The pizza was: {_pizzaController.SearchPizzaByNumber()}");
                        
                        break;
                    case "5":
                        Console.WriteLine($"YOU PRESSED {numberEntered}, TO SEARCH BY NAME");
                        Console.WriteLine("");
                        Console.WriteLine("Here is the menu:");
                        _pizzaController.DisplayMenu();
                        Console.WriteLine("");
                        
                        _pizzaController.SearchPizzaByName();


                        break;
                    case "6":
                        Console.WriteLine($"YOU PRESSED {numberEntered} TO REMOVE A PIZZA");
                        Console.WriteLine("\n");
                        Console.WriteLine("This is the current Menu");
                        Console.WriteLine("\n");
                        _pizzaController.DisplayMenu();
                        Console.WriteLine("");
                        _pizzaController.DeletePizza();
                        Console.WriteLine("");
                        Console.WriteLine("You succesfully deleted the pizza");
                        Console.WriteLine("The menu is now:");
                        _pizzaController.DisplayMenu();
                       
                        break;
                    case "7":
                        Console.WriteLine($"YOU PRESSED {numberEntered}, TO QUIT");
                        Console.WriteLine("Are you sure");
                        Console.WriteLine("Press y for yes , otherwise press n for no");
                        ConsoleKeyInfo quit = Console.ReadKey();

                        if (quit.KeyChar == 'y' || quit.KeyChar == 'Y')
                        {
                            Console.Beep();
                            proceed = false;
                        }
                        Thread.Sleep(500);
                        

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
