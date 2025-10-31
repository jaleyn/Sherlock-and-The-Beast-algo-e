using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'decentNumber' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void decentNumber(int n)
    {
        int fives = n;

        
        while (fives % 3 != 0)
        {
            fives -= 5;
        }

        if (fives < 0)
        {
            Console.WriteLine("-1");
        }
        else
        {
            for (int i = 0; i < fives; i++)
                Console.Write("5");

            
            for (int i = 0; i < n - fives; i++)
                Console.Write("3");

            Console.WriteLine();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Result.decentNumber(n);
        }
    }
}
}
