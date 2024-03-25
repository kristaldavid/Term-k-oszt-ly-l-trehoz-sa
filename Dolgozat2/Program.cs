using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\adat\doli.csv");

        foreach (string line in lines)
        {
            string[] values = line.Split(';');

            foreach (string value in values)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();
        }
    }
}

