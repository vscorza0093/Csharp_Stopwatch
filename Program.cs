using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to simple Stop Watch\n");
            Console.WriteLine("What do you wish?\n");
            Console.WriteLine("S to count in seconds");
            Console.WriteLine("M to count in Minutes");
            Console.WriteLine("Any key to quit application");

            string firstResponse = Console.ReadLine().ToLower();

            Console.WriteLine(firstResponse);

            switch (firstResponse)
            {
                case "s": break;
                case "m": break;
                default:                 
                    Console.WriteLine("Application terminated");
                    Thread.Sleep(1500);
                    System.Environment.Exit(1);
                    break;
            }

            Console.WriteLine("----------");
            Console.WriteLine("1 - From zero to number");
            Console.WriteLine("2 - From number to zero");
            Console.WriteLine("Any key to quit application");

            string secondResponse = Console.ReadLine();
            Console.WriteLine("Insert a value:");
            int timeValue = int.Parse(Console.ReadLine());
            PreStart(timeValue, firstResponse, secondResponse);
        }
        static void PreStart(int timeValue, string timeModifier, string functionModifier)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(800);
            Console.WriteLine("Set...");
            Thread.Sleep(800);
            Console.WriteLine("Go!");
            Thread.Sleep(600);
            switch (functionModifier)
            {
                case "1":
                    ProgressiveStopWatch(timeValue, timeModifier);
                    break;
                case "2":
                    RegressiveStopWatch(timeValue, timeModifier);
                    break;
            }
        }
        static void ProgressiveStopWatch(int finalTime, string timeModifier)
        {
            switch (timeModifier)
            {
                case "m": finalTime *= 60; break;
                default: break;
            }
            int currentTime = 0;

            while (currentTime <= finalTime)
            {
                Console.Clear();
                Console.WriteLine($"{currentTime}");
                currentTime++;
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finished\n");
            Thread.Sleep(1500);
            Menu();
        }
        static void RegressiveStopWatch(int startTime, string timeModifier)
        {
            int currentTime = 0;
            switch (timeModifier)
            {
                case "m": currentTime = startTime * 60; break;
                default: currentTime = startTime; break;
            }

            int finalTime = 0;

            while (finalTime <= currentTime)
            {
                Console.Clear();
                Console.WriteLine($"{currentTime}");
                currentTime--;
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finished\n");
            Thread.Sleep(1500);
            Menu();
        }
    }   
}