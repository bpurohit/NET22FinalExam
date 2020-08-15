using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace NET22FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyCollection<int> intCollection = new MyCollection<int>();
           
            intCollection.AddItem(1, 1);
            intCollection.AddItem(2, 2);
            intCollection.AddItem(3, 3);
            intCollection.AddItem(4, 4);
            intCollection.AddItem(5, 5);

            foreach (var item in intCollection)
            {
                Console.WriteLine(item);
            }

        }
    }

    class MyCollection<T> : Collection<T>
    {
        List<T> list = new List<T>();
        public  void AddItem(int index, T item)
        {
            list.Add(item);
        }

        public T GetItem(int index)
        {
            return list[index];
        }
        //protected List<T> SortItem()
        //{
        //    return list.Sort((x, y) => y.CompareTo(x));
        //}
    }
}
