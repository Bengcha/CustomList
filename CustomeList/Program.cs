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
            Console.WriteLine("Custom Color List");
            Console.ResetColor();
            genericColorList.AddingObjectToList("Red");
            genericColorList.AddingObjectToList("Blue");
            genericColorList.AddingObjectToList("White");
            genericColorList.AddingObjectToList("Yellow");
            genericColorList.AddingObjectToList("Green");
            genericColorList.AddingObjectToList("Pink");
            genericColorList.AddingObjectToList("Black");
            genericColorList.Count();          
            genericColorList.DisplayObjectInList();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Count Object in List: {0}", genericColorList.Count());
            Console.ResetColor();

            //genericColorList.Count();
            Console.ReadLine();

            GenericClass<string> genericClotheList = new GenericClass<string>();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Custom Clothe List");
            Console.ResetColor();
            genericClotheList.AddingObjectToList("T-Shirt");
            genericClotheList.AddingObjectToList("Jacket");
            genericClotheList.AddingObjectToList("Hoodie");
            genericClotheList.AddingObjectToList("Jean");
            genericClotheList.AddingObjectToList("Sweater");
            genericClotheList.AddingObjectToList("Boot");
            genericClotheList.AddingObjectToList("Shoe");
            genericClotheList.DisplayObjectInList();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Count Object in List: {0}", genericColorList.Count());
            Console.ResetColor();
            //genericClotheList.CountProperty();
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Removing a Object(Blue) from Lists");
            Console.ResetColor();
            genericColorList.RemoveObjectFromList("Blue");
            genericColorList.DisplayObjectInList();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Count Object in List: {0}", genericColorList.Count());
            Console.ResetColor();
            //genericColorList.CountProperty();
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Adding new Object(Blue) to List");
            Console.ResetColor();
            genericColorList.AddingObjectToList("Blue");
            genericColorList.DisplayObjectInList();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Count Object in List: {0}", genericColorList.Count());
            Console.ResetColor();

            //genericColorList.CountProperty();
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.WriteLine("\nList to String with Override Method");
            Console.ResetColor();
            string toColorString = genericColorList.ToString();
            Console.WriteLine(toColorString);
            Console.ReadLine();

            GenericClass<string> OverLoadPlusOperator = new GenericClass<string>();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Adding Two Array Lists with + Operator");
            Console.ResetColor();
            OverLoadPlusOperator = genericColorList + genericClotheList;
            OverLoadPlusOperator.DisplayObjectInList();
            Console.ReadLine();

            GenericClass<string> OverLoadMinusOperator = new GenericClass<string>();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Subtracting One list with - Operator");
            Console.ResetColor();
            OverLoadMinusOperator = (genericColorList - genericClotheList);
            OverLoadMinusOperator.DisplayObjectInList();
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Zip Two Custom List");
            Console.ResetColor();
            var zipArray = genericColorList.Zip(genericClotheList, (a, b) => (a +" "+ b));
            foreach (string Object in zipArray)
            {
                Console.WriteLine(Object);
            }


            //operatorPlus.AddingObjectToList(1);
            //operatorPlus.AddingObjectToList(100);
            //operatorPlus.AddingObjectToList(1000);
            //operatorPlus.AddingObjectToList(10000);
            //operatorPlus.AddingObjectToList(100000);

            Console.ReadLine();

            //GenericClass<string> colorClothe = new GenericClass<string>();
            //foreach (string CC in colorClothe)
            //{
            //    Console.WriteLine(CC);
            //    Console.ReadLine();
            //}

        }
    }
}
