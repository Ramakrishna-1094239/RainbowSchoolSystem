﻿using System;
using System.IO;

namespace RainbowSchoolSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            int Number1;

            String Name = string.Empty;
            String Class_Section = string.Empty;
            Console.WriteLine("Please enter the ID");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Name");
            Name = Console.ReadLine();
           // int Result;
            //Result = Number1 + Number2;
            //Console.WriteLine("Sum of two Numbers:" + Result.ToString());
            Console.ReadLine();


            //Console.WriteLine("Hello World!");

            //int Id = 0;
            //String Name = string.Empty;
            //String Class_Section = string.Empty;

            ////Pass the filepath and filename to the StreamWriter 
            //StreamWriter stw = new StreamWriter("C:\\GII\\FSD_Training\\RainbowSchoolSystem\\TeacherData.txt");

            ////Write a line of text
            //Console.WriteLine("Welcome to Rainbow ");

            ////Write a line of text
            //Console.WriteLine("Please enter the following Details");

            ////Write a line of text
            //Console.WriteLine("Please enter the ID");
            //Id = Convert.ToInt32(Console.ReadLine());

            ////Write a line of text
            //Console.WriteLine("Please enter the Name");

            ////Write a line of text
            //Console.WriteLine("Please enter the Class and Section");


            ////Write a second line of text
            //stw.WriteLine("From the StreamWriter class");
            ////Close the file
            //stw.Close();

        }

        //public void WriteToFile()
        //{
        //    try
        //    {
        //        int Id=0;
        //        String Name=string.Empty;
        //        String Class_Section = string.Empty;

        //        //Pass the filepath and filename to the StreamWriter 
        //        StreamWriter stw = new StreamWriter("C:\\GII\\FSD_Training\\RainbowSchoolSystem\\TeacherData.txt");

        //        //Write a line of text
        //        stw.WriteLine("Welcome to Rainbow ");

        //        //Write a line of text
        //        stw.WriteLine("Please enter the following Details");

        //        //Write a line of text
        //        stw.WriteLine("Please enter the ID");
        //        Id = Convert.ToInt32(Console.ReadLine());

        //        //Write a line of text
        //        stw.WriteLine("Please enter the Name");

        //        //Write a line of text
        //        stw.WriteLine("Please enter the Class and Section");


        //        //Write a second line of text
        //        stw.WriteLine("From the StreamWriter class");
        //        //Close the file
        //        stw.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Exception: " + e.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Executing finally block.");
        //    }
        //}


    }

    
}