using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harry_pottah_PP_Oppgave
{
    internal class character
    {
        public string Name {  get; set; }
        public string House { get; set; }
        public int Money { get; set; }
        public List<Item> Inventory { get; set; }

        public character (string name, string house)
        {
            Name = name;
            House = house;
            Money = 100;
            Inventory = new List<Item>();
        }

        public void Introduce()
        {
            Console.Clear();
            // string items = Inventory.Count > 0 ? string.Join(", ", Inventory) : "no items";

            Console.WriteLine($"Hey, my name is {Name}, My house is {House}");
            Console.WriteLine("My items:");
            foreach (var item in Inventory)
            {
                Console.WriteLine($"{item.Name}");
            }
            Console.ReadKey(true);

        }

        public void AddItem(Item item)
        { 
         Inventory.Add(item);
        }

        public void CastSpell(string spell)
        {
            Console.Clear();
            switch (spell.ToLower())
            {
               case "fireball":
                    Console.WriteLine("You hurl a giant fireball. The classroom is now in shambles and on fire");
                    Console.ReadKey();
                    break;
               case "vicious mockery":
                    Console.WriteLine("You say the most hurfull words know to man. All of your classmates is affected by it and are now crying ");

                    Console.ReadKey();
                    break;
                case "chain lightning":
                    Console.WriteLine("A bright chain of Lightning appears from your wand. It killed everyone in the classroom, you should consider what you've done");
                    Console.ReadKey();
                    break;
                case "metamorph":
                    TransformIntoRandomCreature();
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("unknown spell ");
                    Console.ReadKey();
                    break;
            }
            
        }

        private void TransformIntoRandomCreature()
        {
            List<string> creatures = new List<string> { "An Ogre ", "A Goblin ", "A Rock ", "A Slug ", "A Fox ", "Jhon Cena " };
            Random random = new Random();
            int index = random.Next(creatures.Count);
            string randomCreature = creatures[index];
            Console.WriteLine($"You turned into {randomCreature}! ");
        }

    }
}
