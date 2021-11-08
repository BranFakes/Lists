using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lists");
            Console.WriteLine("(Inventory System)");
            Console.WriteLine("");

            string currentItem;
            string[] inventory1 = new string[10];
            // "[]" means an Array of strings. Will not be an Array without []
            // init
            //currentItem = "health potion";
            currentItem = "smokes";
            
            inventory1[0] = "";
            inventory1[1] = "";
            inventory1[2] = "";
            inventory1[3] = "";
            for (int i = 0; i <= inventory1.Length - 1; i++) // 0-9 (for 10 items)
            {
                inventory1[i] = "";
            }


            // Simulated/Pretend gameplay
            // player picks up "health potion
            inventory1[0] = "health potion"; 

            //player drops "health potion"






            Console.WriteLine("Lists");
            Console.WriteLine("(Inventory System)");
            Console.WriteLine("");

            List<string> inventory; // declaration
            inventory = new List<string>(); // instantiation -- no size?

            Console.WriteLine("Inventory size = " + inventory.Count);
            // picks up "health potion"
            inventory.Add("health potion"); // Could be a metheod
            Console.WriteLine("Inventory size = " + inventory.Count);
            inventory.Add("health potion");
            Console.WriteLine("Inventory size = " + inventory.Count);





            // show inventory?
            //Console.WriteLine(inventory);
            for (int i = 0; i <= inventory.Count - 1; i++) //0-?
            {
                //Console.WriteLine(inventory[i]);
                // OR
                Console.WriteLine(i + ": " + inventory[i]);



                //try the difference
            }
            foreach (string item in inventory)
            {
                Console.WriteLine(item);
            }

            inventory.Remove("health potion");

            Console.WriteLine("Inventory:");
            foreach (string item in inventory)
            {
                Console.WriteLine(item);
            }



            






            Console.ReadKey();
        }
    }
}
