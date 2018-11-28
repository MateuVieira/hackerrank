using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        int I = 0;
        double D = 0;
        string S = " ";

        // Read and save an integer, double, and String to your variables.
        I = int.Parse(System.Console.ReadLine());
        D = double.Parse(System.Console.ReadLine());
        S = System.Console.ReadLine();
        // Print the sum of both integer variables on a new line.
        
        // Print the sum of the double variables on a new line.
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.

        System.Console.WriteLine(i+I);
        System.Console.WriteLine("{0:F1}", d+D);
        System.Console.WriteLine(s+S);


    }
}