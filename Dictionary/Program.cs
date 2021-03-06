using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //IDictionary<int, string> numberNames = new Dictionary<int, string>();
            //numberNames.Add(1, "One"); //adding a key/value using the Add() method
            //numberNames.Add(2, "Two");
            //numberNames.Add(3, "Three");


            MyDictionary<int, string> employeeName = new MyDictionary<int, string>();
            employeeName.Add(1, "Burcu");
            employeeName.Add(2, "Berk");
          
            employeeName.Show();
            Console.ReadKey();
        }
    }
}
