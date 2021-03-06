﻿
using System;

namespace Code1
{
    class Program
    {
        static int bot, com;
        static int diff1, diff2;
        static void Main(string[] args)
        {
            int guessNum;
            Console.WriteLine("Enter a value between 0 and 100.");
            guessNum = Convert.ToInt32(Console.ReadLine());
            NumberGenerator();
            diff2 = guessNum - com;
            Console.WriteLine("Bot's prediction " + bot);
            Console.WriteLine("Your prediction " + guessNum);
            Console.WriteLine("Number " + com);
            Console.WriteLine("-----------------------------");
            
            if(diff2 > diff1)
            {
                Console.WriteLine("Your prediction is closer than Bots");
            }
            
            else if(diff2 == 0)
            {
                Console.WriteLine("Correct prediction !!!");
            }
            
            else if(diff1 > diff2)
            {
                Console.WriteLine("Bot's prediction is closer than Yours");
            }

            else if(diff1 == diff2)
            {
                Console.WriteLine("You made the same prediction with Bot");
            }
            
            Console.ReadKey();
        }
        
        static void NumberGenerator()
        {
            Random numGenCom = new Random();
            Random numGenBot = new Random();
            com = numGenCom.Next(0, 100);
            bot = numGenBot.Next(0, 100);
            diff1 = bot - com;
        }    
    }
}
