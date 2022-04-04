// Created by: Johanna Liu
// Created on: Mar 2022
//
// This program does basic math

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function states user's address input.
        float A;
        float B;
        float height;
        float area;

        //Input
        Console.WriteLine("This program will calculate the area of a trapezoid.");
        Console.WriteLine("");
        Console.Write("Enter base A: ");
        A = float.Parse(Console.ReadLine());
        Console.Write("Enter base B: ");
        B = float.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        height = float.Parse(Console.ReadLine());

        //Process
        area = (((A + B) / 2) * height);

        //Output
        Console.WriteLine("");
        Console.WriteLine("The area is: " + (area.ToString("0.00") + " mm²."));

        Console.WriteLine("\nDone.");
    }
}