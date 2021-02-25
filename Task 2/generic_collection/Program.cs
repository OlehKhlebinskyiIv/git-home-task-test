using System;
using System.Collections.Generic;

namespace generic_collection
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("My List\n");

            MyList<int> MyFirstList = new MyList<int>();

            MyFirstList.Add(4);
            MyFirstList.Add(5);
            MyFirstList.Add(6);
            MyFirstList.Add(7);
            MyFirstList.Add(8);

            Console.WriteLine($"Count = {MyFirstList.Count()}");
            foreach (var item in MyFirstList)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine($"Contains = {MyFirstList.Contains(5)}");
            MyFirstList.Clear();
            Console.WriteLine("After Clear");
            Console.WriteLine($"Count = {MyFirstList.Count()}");

            foreach (var item in MyFirstList)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("End");
        }
    }
}