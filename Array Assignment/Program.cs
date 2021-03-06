using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        string[] colors = { "Red", "Blue", "Yellow", "Green" };   //array of colors
        Console.WriteLine("Please choose 0-3 for your color");   //asking for user input
        int num = int.Parse(Console.ReadLine());      //reading user input
        if (num > 3 || num < 0)
        {
            Console.WriteLine("Index does not exist");     //will return error if num isn't on index
        }
        else
        {
            Console.WriteLine("color is: " + colors[num]);   //returning user input as array answer
        }

        int[] numArray = { 1, 3, 5, 7, 9 };
        Console.WriteLine("Please choose 0-4 for your number");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine("value is: " + numArray[input]);

        List<string> intList = new List<string>();
        intList.Add("Triangle");
        intList.Add("Circle");
        intList.Add("Square");
        Console.WriteLine("Please choose 0-2 for a shape");
        int answer = int.Parse(Console.ReadLine());
        Console.WriteLine("shape is:" + intList[answer]);
        Console.Read();
    }
}

