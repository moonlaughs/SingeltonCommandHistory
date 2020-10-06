using System;
using System.Collections.Generic;

namespace CommandHistory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CommandHistory obj = CommandHistory.getInstance();

            string myInput = Console.ReadLine();
            obj.AddToList(myInput);
            string myInput1 = Console.ReadLine();
            obj.AddToList(myInput1);

            //Console.WriteLine("=============added");

            //foreach (var item in obj.MyCommandHistoryList)
            //{
            //    Console.WriteLine(item);
            //}

            string myInput2 = Console.ReadLine();
            obj.RemoveFromList(myInput2);

            //Console.WriteLine("=================removed");
            //foreach (var item in obj.MyCommandHistoryList)
            //{
            //    Console.WriteLine(item);
            //}



            //bool _continue = true;
            //while (_continue == true)
            //{
            //    string myInput = Console.ReadLine();
            //    //obj.MyCommandHistoryList.Add(myInput);
            //    Console.WriteLine("Wanna continue?");
            //    string _answer = Console.ReadLine();
            //    //obj.MyCommandHistoryList.Add(_answer);
            //    if (_answer == "no")
            //        _continue = false;
            //}

            //foreach (var item in obj.MyCommandHistoryList)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
