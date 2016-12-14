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
            T[] removingFromArrayList = new T[CustomArrayList.Length - 1];
            for (i = 0; i <= removingFromArrayList.Length; i++)
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


        public void RemovingObject(T removeInputItem)
        {
            for (i = 0; i < CustomArrayList.Length; i++)
            {
                if (CustomArrayList[i].Equals(removeInputItem))
                {
                    RemoveObjectFromList(removeInputItem);
                }
            }


        }

        public void DisplayObjectInColorList()
        {
            foreach (T inputNewItem in CustomArrayList)
            {
                Console.WriteLine(inputNewItem);
            }
        }

        public void DisplayerObjectInClotheList()
        {
            foreach (T inputNewItem1 in CustomArrayList)
            {
                Console.WriteLine(inputNewItem1);
            }
        }


        public string ArrayListToString()
        {
            toString = "Object String:";
            for (i = 0; i < CustomArrayList.Length; i++)
            {
                toString = toString + " " + CustomArrayList[i];
            }

            return toString;

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


