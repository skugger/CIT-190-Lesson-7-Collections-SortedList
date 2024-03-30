using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace CIT_190_Lesson_7_Collections_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> TOSOfficers = new SortedList<string, string>()
            {
                {"Captain", "James T. Kirk"},
                {"First Officer", "Spock"},
                {"Cheif Medical Officer", "Leonard McCoy"},
                {"Cheif Engineer", "Montgomery Scott"},
                {"Communications Officer", "Nyota Uhura"},
            };

            Console.WriteLine("Bridge Officer Key/Value Pairs");
            foreach (KeyValuePair<string, string> kvp in TOSOfficers)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }

            Console.WriteLine();
            Console.WriteLine("Which bridge officer (value) would you like to add?");
            string officer = Console.ReadLine();
            Console.WriteLine("What role (key) does he/she fill?");
            string role = Console.ReadLine();

            if (TOSOfficers.ContainsValue(officer))
                Console.WriteLine($"{officer} already holds a bridge position.");
            else
            {
                if (TOSOfficers.ContainsKey(role))
                {
                    Console.WriteLine($"Only one officer can occupy the role of {role}.");
                }
                else
                {
                    TOSOfficers.Add(role, officer);
                    Console.WriteLine($"{officer} {role} was added to your list");
                    Console.WriteLine();
                }
            }
            foreach (KeyValuePair<string, string> kvp in TOSOfficers)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }
            Console.WriteLine();
            Console.WriteLine("Do you want to remove a bridge position? (y/n)");
            string decide = Console.ReadLine();

            if (decide == "y")
            {
                foreach (KeyValuePair<string, string> kvp in TOSOfficers)
                {
                    Console.WriteLine($"Key: {kvp.Key}");
                }
                Console.WriteLine();
                Console.WriteLine("Which would you like to remove?");
                string which = Console.ReadLine();
                TOSOfficers.Remove(which);
                Console.WriteLine($"{which} has been removed.");
                Console.WriteLine() ;
            }
            foreach (KeyValuePair<string, string> kvp in TOSOfficers)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }

        }
    }
}
