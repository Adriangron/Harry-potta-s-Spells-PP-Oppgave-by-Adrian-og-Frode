using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harry_pottah_PP_Oppgave
{
    internal class Shop
    {
        public List<Item> Pets { get; set; }
        public List<Item> Wands { get; set; }

        public Shop()
        {
            Pets = new List<Item>()
            {
                new Item("Snowy", 50, "Owl"),
                new Item("Gray", 70, "Cat"),
                new Item("Hubert", 30, "Goat")

            };
            Wands = new List<Item>() { 
                new Item("Fire Wand", 40, "Wand"),
                new Item("Dubstep Wand", 50, "Wand"),
                new Item("Ultra Wand", 60, "Wand"),
            };
        }
        public void DisplayMenu(character user)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Shop! Buy something c:");
            Console.WriteLine("1. Pets ");
            Console.WriteLine("2. Wands ");

            string userInput = Console.ReadLine();

            switch (userInput) {
                case "1":
                    displayItems(Pets, user);
                    break;
                case "2":
                    displayItems(Wands, user);
                    break;
            }
        }

        public void displayItems(List<Item> items, character user)
        {
            for (int i = 0; i < items.Count; i++) { 
                Console.WriteLine($"{i + 1}.{items[i].Name} \t {items[i].Type} \t cost {items[i].Cost}");
            }
            string userInputstr = Console.ReadLine();
            int userInput = Convert.ToInt32(userInputstr);

            if (items[userInput - 1].Cost <= user.Money)
            {
                user.Inventory.Add(items[userInput - 1]);
                Console.Clear();
                Console.WriteLine($"You bought {items[userInput - 1].Name}");
                Console.ReadKey(true);
            } else
            {
                Console.Clear();
                Console.WriteLine("Insufficient funds..");
                Console.ReadKey(true);
            }

        }
    }
}
