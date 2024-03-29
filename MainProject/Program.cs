﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace MainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> nameList = new List<string>();
            nameList.Add("anA");
            nameList.Add("elena");
            nameList.Add("MARIA");
            nameList.Add("cRisTiAn");

            //FirstExercise
            foreach (var nume in nameList)
                Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nume.ToLower()));

            //SecondExercise
            List<char> vowelList = new List<char> { 'a', 'e', 'i', 'o', 'u' };

            foreach (var nume in nameList)
            {
                if (vowelList.Contains(nume[0]))
                    Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nume.ToLower()));
            }

            foreach (var nume in nameList)
            {
                if (!nume.StartsWith("a") && !nume.StartsWith("e") && !nume.StartsWith("i") && !nume.StartsWith("o") && !nume.StartsWith("u"))
                    Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nume.ToLower()));
            }

            Car car = new Car("Hyundai", "Tucson", "First Registration", "2019", 30000);
            Console.WriteLine(car);
            Console.ReadLine();
        }
    }
}
