﻿using System;

namespace T04Ejercicio19
{
    class Program
    {
        static void Main()
        {
            for (int x = 1; x <= 100; x++)
            {
                if (((x % 2) == 0) && ((x % 3) == 0))
                {
                    Console.WriteLine(x);
                }

            }
        }
    }
}