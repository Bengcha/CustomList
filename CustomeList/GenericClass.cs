using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomeList
{
    public class GenericClass<T> : IEnumerable<T>
    {
        int i;
        bool remove;
        T[] CustomArrayList;
       
        public string toString;

        public GenericClass()
        {
            CustomArrayList = new T[0];
            remove = true;
        }
        public void AddingObjectToList(T inputNewItem)
        {
            T[] addToColorList = new T[CustomArrayList.Length + 1];
            for (i = 0; i < CustomArrayList.Length; i++)
            {
                addToColorList[i] = CustomArrayList[i];
            }
            addToColorList[CustomArrayList.Length] = inputNewItem;
            CustomArrayList = addToColorList;
        }

        public void RemoveObjectFromList(T removeInputItem)
        {
            T[] removingFromArrayList = new T[CustomArrayList.Length -1];
            for (i = 0 ; i <= removingFromArrayList.Length; i++)
            {
                if (remove)
                {
                    if (CustomArrayList[i].Equals(removeInputItem))
                    {
                        remove = false;
                    }
                    else
                    {
                        removingFromArrayList[i] = CustomArrayList[i];
                    }
                }
                else 
                {
                    removingFromArrayList[i - 1] = CustomArrayList[i];
                }              
            }
            CustomArrayList = removingFromArrayList;
        }

        public void DisplayObjectInList()
        {
            foreach (T inputNewItem in CustomArrayList)
            {
                Console.WriteLine(inputNewItem);
            }
        }
        public override string ToString()
        {
            toString = "String:";
            for (i = 0; i < CustomArrayList.Length; i++)
            {
                toString = toString + " " + CustomArrayList[i];
            }
            return toString;
        }

        public static GenericClass<T> operator +(GenericClass<T> customList1, GenericClass<T> customList2)
        {
            GenericClass<T> AddArrayList = new GenericClass<T>();
            foreach (T item in customList1)
            {
                AddArrayList.AddingObjectToList(item);
            }
            foreach (T item in customList2)
            {
                AddArrayList.AddingObjectToList(item);
            }
            return AddArrayList;
        }
        public static GenericClass<T> operator -(GenericClass<T> customList1, GenericClass<T> customList2)
        {
            for (int i = 0; i < customList1.Count(); i++)
            {
                for(int i2 = 0; i2 < customList2.Count(); i2++)
                {
                    if (customList1.CustomArrayList[i].Equals(customList2.CustomArrayList[i2]))
                    {
                        customList1.RemoveObjectFromList(customList2.CustomArrayList[i2]);
                    }
                }
            }
            return customList1;
            //foreach (T item in customList1)
            //{
            //    SubtractArrayList.RemoveObjectFromList(item) ;
            //}
            //foreach (T item in customList2)
            //{
            //    SubtractArrayList.RemoveObjectFromList(item);
            //}
            //return SubtractArrayList;
        }



        public IEnumerator<T> GetEnumerator()
        {
            for (i = 0; i < CustomArrayList.Length; i++)
            {
                yield return CustomArrayList[i];          
            }     
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}


