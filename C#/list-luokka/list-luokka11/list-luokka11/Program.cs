using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_luokka11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                List<string> shoppinglist = new List<string>() {"egg", "milk", "choccy milk" };
            while (true)
            {
                Console.WriteLine("current shopping list:");
            for (int counter = 0; counter < shoppinglist.Count; counter++)
            {
                Console.WriteLine(shoppinglist[counter]);
            }
            Console.WriteLine();
            Console.WriteLine("enter command: ");
            const string change = "CHANGE INGREDIENTS";
            
            Console.WriteLine(change);
            const string add = "ADD ITEM";
            
            Console.WriteLine(add);
            const string leave = "LEAVE";
            Console.WriteLine(leave);
            
            string input = Console.ReadLine().ToUpper();
                switch (input)
                {
                    case leave:
                        System.Environment.Exit(0);
                        break;

                    case change:
                        Console.WriteLine("what item to change?");
                        string input2 = Console.ReadLine();
                        if (shoppinglist.Contains(input2))
                        {
                            Console.WriteLine("add item name");
                            shoppinglist[shoppinglist.IndexOf(input2)] = Console.ReadLine();
                        }
                        break;
                    case add:
                        Console.WriteLine("what item to add?");
                        string additem = Console.ReadLine();
                        shoppinglist.Add(additem);
                        break;

                }
                Console.Clear();
            }
        }
    }
}
