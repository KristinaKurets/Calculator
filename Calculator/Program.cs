using Calculator.Interfaces;
using Calculator.Models;
using Calculator.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I'm the smartest calculator-child!");
            while (true)
            {
                Console.WriteLine("Do you want me to solve your example? press y/n, please");
                string chose = Console.ReadLine();
                if(chose!="y")
                {
                    Console.WriteLine("Ok, bye!");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Enter your mathematical expression(I have only +, -, *, /, ^ buttons):");
                    var action = new Actions();
                    action.Processing();
                }
            }
        }
    }
}
