using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harry_pottah_PP_Oppgave
{
    internal class App
    {
        public character currentUser;
        public void Run()
        {
            characterCreator();
            mainMenu();
        }

        private void characterCreator()
        {
            Console.WriteLine("Welcome to Hogwarts, what is your name?");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What house do you wanna be in?");
            Console.WriteLine("1. Gryffindor");
            Console.WriteLine("2. Slytherin");
            Console.WriteLine("3. Hufflepuff");
            Console.WriteLine("4. Ravenclaw");
            string houseNumber = Console.ReadLine();
            string house = "";

            switch (houseNumber)
            {
                case "1":
                    house = "Gryffindor";
                    break;
                case "2":
                    house = "Slytherin";
                    break;
                case "3":
                    house = "Hufflepuff";
                    break;
                case "4":
                    house = "Ravenclaw";
                    break;
            }

            currentUser = new character(name, house);

        }

        private void mainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Hello {currentUser.Name}, what would you like to do?");
                Console.WriteLine("1. Character Summary");
                Console.WriteLine("2. Shop");
                Console.WriteLine("3. Do Magic");
                Console.WriteLine("4. Open SpellBook");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        currentUser.Introduce();
                        break;
                    case "2":
                        var shop = new Shop();
                        shop.DisplayMenu(currentUser);
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Cast your Spell!!");
                        string spell = Console.ReadLine();
                        currentUser.CastSpell(spell);
                        break;
                    case "4":
                        spellBook();
                        break;
                }   
            }
        }
        private void spellBook()
        {
            Console.Clear();
            Console.WriteLine("Spells:");
            Console.WriteLine("fireball");
            Console.WriteLine("vicious mockery");
            Console.WriteLine("chain lightning");
            Console.WriteLine("metamorph");
            Console.ReadKey();
        }
    }
}
