using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace TimeLog
{
    class Program
    {
        static void Main(string[] args)
        {

            //Directory.CreateDirectory("TimeLogFile.txt");
            //var timeLog = @"NewTimeLog.txt";

            var timeLogFile = "TimeLogFile.txt";
            //File.Create(TimeLogFile);

            Console.WriteLine("Logging Time In ten Seconds Intervals In A Descending order\n");

            Stack<string> time = new Stack<string>();

            //Logging 5 times and pushing to a stack
            for (int i = 0; i < 5; i++)
            {
                time.Push(DateTime.Now.ToString("hh:mm:ss"));
                Console.WriteLine(time.Peek());
                Thread.Sleep(10000);
            }

            Console.WriteLine("\n***************************\n");

            //Showing from a stack Last-In-First-Out(LIFO) and appending to a file
            foreach (var second in time)
            {
                Console.WriteLine(second);
                File.AppendAllLines(timeLogFile, new String[] { second.ToString() });

    
            }
        }
    }
}