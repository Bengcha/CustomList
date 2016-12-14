using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CustomeList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GenericClass<string> genericColorList = new GenericClass<string>();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Adding new Object to Color List");
            Console.ResetColor();
            genericColorList.AddingObjectToList("Red");
            genericColorList.AddingObjectToList("Blue");
            genericColorList.AddingObjectToList("White");
            genericColorList.AddingObjectToList("Yellow");
            genericColorList.AddingObjectToList("Green");
            genericColorList.AddingObjectToList("Pink");
            genericColorList.AddingObjectToList("Black \n");
            genericColorList.DisplayObjectInColorList();

            GenericClass<string> genericClotheList = new GenericClass<string>();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Adding new Object to Clothe List");
            Console.ResetColor();
            genericClotheList.AddingObjectToList("T-Shirt");
            genericClotheList.AddingObjectToList("Jacket");
            genericClotheList.AddingObjectToList("Hoodie");
            genericClotheList.AddingObjectToList("Jean");
            genericClotheList.AddingObjectToList("Sweater");
            genericClotheList.AddingObjectToList("Boot");
            genericClotheList.AddingObjectToList("Shoe");
            genericClotheList.DisplayerObjectInClotheList();
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Removing a Object(Blue) from Color List");
            Console.ResetColor();
            genericColorList.RemoveObjectFromList("Blue");
            genericColorList.DisplayObjectInColorList();
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nFrom Clothe List to String");
            Console.ResetColor();
            string toClotheString = genericClotheList.ArrayListToString();
            string toColorString = genericColorList.ArrayListToString();
            Console.WriteLine(toClotheString+ "\n" + toColorString);
            Console.ReadLine();

            GenericClass<string> colorClothe = new GenericClass<string>();
            foreach (string CC in colorClothe)
            {
                Console.WriteLine(CC);
                Console.ReadLine();
            }

        }
    }
}
