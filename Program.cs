/*
 * Ankit Bombwal
 * Program uses a Store class to generate and manage multiple stores and inventories.
 * 10th homework project for college class
 */
namespace HW10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creation of Store Objects
            Store s1 = new Store();
            Store s2 = new Store(4, true);
            Store s3 = new Store(3, false);

            // Setting Easy Inventory
            s1.setInventoryEasy();
            Console.WriteLine();
            s3.setInventoryEasy();
            Console.WriteLine();

            // Setting Normal Inventory
            s2.setInventory();
            Console.WriteLine();

            // Outputting all three stores
            s1.storeDetails();
            Console.WriteLine();
            s2.storeDetails();
            Console.WriteLine();
            s3.storeDetails();
            Console.WriteLine();
        }
    }

    class Store
    {
        static int storeCounter;
        string[] Inventory;
        int storeID;
        bool isOpen;

        // Default Constructor
        public Store()
        {
            storeID = storeCounter++;
            isOpen = true;
            Inventory = new string[3];
        }

        // Parameter Constructor
        public Store(int stores, bool open)
        {
            storeID = storeCounter++;
            isOpen = open;
            Inventory = new string[stores];
        }

        // Sets the value of Inventory to user input
        public void setInventory()
        {
            Console.WriteLine("Setting Custom Inventory...");
            for (int i = 0; i < Inventory.Length; i++)
            {
                Console.Write("Set item {0}: ", i + 1);
                Inventory[i] = Console.ReadLine();
            }
        }

        // sets the value of Inventory to default values
        public void setInventoryEasy()
        {
            Console.WriteLine("Setting default Inventory...");
            Inventory[0] = "Shoes";
            Inventory[1] = "Shirts";
            Inventory[2] = "Pants";
        }

        // Prints out the store details
        public void storeDetails()
        {
            Console.WriteLine("Store {0} is has the following items in inventory: ", storeID+1);
            foreach(string item in Inventory)
            {
                Console.WriteLine(item);
            }

            if (isOpen)
            {
                Console.WriteLine("Store {0} is currently Open!", storeID+1);
            }
            else
            {
                Console.WriteLine("Store {0} is currently Closed!", storeID+1);
            }
        }
    }
}