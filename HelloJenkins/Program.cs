﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace HelloJenkins
{
    public class Program
    {
        public static void Main(string[] args)
        {
			int x;
            Console.WriteLine("Hello Jenkins!");
            JArray array = new JArray();
            array.Add("Manual text");
            array.Add(new DateTime(2000, 5, 23));
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.ReadLine();
        }

        public static bool Test()
        {
            return true;
        }
    }

}
