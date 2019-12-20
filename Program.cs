﻿using System;
using System.Linq;
using System.Threading.Tasks;

namespace Generalized_Async_Return_Types
{
    class Program
    {
        /* public static void Main()
         {
             Console.WriteLine(ShowTodaysInfo().Result);
             Console.WriteLine("Press any key to exist.");
             Console.ReadKey();
         }
         private static async Task<string> ShowTodaysInfo()
         {
             string ret = $"Today is {DateTime.Today:D}\n" +
                          "Today's hours of leisure: " +
                          $"{await GetLeisureHours()}";
             return ret;
         }
         static async Task<int> GetLeisureHours()
         {
             // Task.FromResult is a placeholder for actual work that returns a string.  
             var today = await Task.FromResult<string>(DateTime.Now.DayOfWeek.ToString());
             // The method then can process the result in some way.  
             int leisureHours;
             if (today.First() == 'S')
                 leisureHours = 16;
             else
                 leisureHours = 5;
             return leisureHours;
         }
         */
        //example 2
        public static void Main()
        {
            Console.WriteLine(ShowTodaysInfo().Result);
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
        private static async Task<string> ShowTodaysInfo()
        {
            var infoTask = GetLeisureHours();
            // You can do other work that does not rely on integerTask before awaiting.
            string ret = $"Today is {DateTime.Today:D}\n" +
                         "Today's hours of leisure: " +
                         $"{await infoTask}";
            return ret;
        }
        static async Task<int> GetLeisureHours()
        {
            // Task.FromResult is a placeholder for actual work that returns a string.  
            var today = await Task.FromResult<string>(DateTime.Now.DayOfWeek.ToString());
            // The method then can process the result in some way.  
            int leisureHours;
            if (today.First() == 'S')
                leisureHours = 16;
            else
                leisureHours = 5;
            return leisureHours;
        }

    }
}
