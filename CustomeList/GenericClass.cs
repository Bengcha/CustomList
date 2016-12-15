﻿using System;
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
        public T[] CustomArrayList;
        string toString;
        int count;
        int capacity;
       
        public GenericClass()
        {
            CustomArrayList = new T[0];
            remove = true;
            capacity = 100;
        }
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = CustomArrayList.Count();
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = CustomArrayList.Count();
            }
        }

        public void AddingObjectToList(T inputNewItem)
        {
            T[] addToColorList = new T[CustomArrayList.Count() + 1];
            for (i = 0; i < CustomArrayList.Count(); i++)
            {
                addToColorList[i] = CustomArrayList[i];                
            }
            addToColorList[CustomArrayList.Count()] = inputNewItem;
            CustomArrayList = addToColorList;
            count++;
            capacity--;       
        }

        public void RemoveObjectFromList(T removeInputItem)
        {
            T[] removingFromArrayList = new T[CustomArrayList.Count() -1];
            for (i = 0 ; i <= removingFromArrayList.Count(); i++)
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
            count--;
            capacity++;
        }
  
        public void DisplayObjectInList()
        {
            foreach (T inputNewItem in CustomArrayList)
            {
                Console.WriteLine(inputNewItem);
                count++;
            }
        }

        public override string ToString()
        {
            toString = "String:";
            for (i = 0; i < CustomArrayList.Count(); i++)
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
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (i = 0; i < CustomArrayList.Count(); i++)
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


