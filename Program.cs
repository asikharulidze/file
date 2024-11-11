namespace File;

using System;
using System.IO;

class Program
{
    static void Main()
    {

        string filePath = "lashas.txt";
        

        string content = "Love you";

        try
        {

            File.WriteAllText(filePath, content);

            Console.WriteLine("Lasha is happy.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lasha is angry: " + ex.Message);
        }
    }
}
