﻿namespace CSharpExercises
{
    public class Conditionals
    {
        ///<summary>
        /// 1) Write a program and ask the user to enter a number. The number should be between 1 to 10. 
        /// If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". 
        /// (This logic is used a lot in applications where values entered into input boxes need to be validated.)
        ///</summary>
        public void Exercise1()
        {
            Console.WriteLine("Enter a number between 1 to 10");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            string result = (inputNumber >= 1 && inputNumber <= 10) ? "Valid" : "Invalid";

            Console.WriteLine(result);
        }

        /// <summary>
        /// 2) Write a program which takes two numbers from the console and displays the maximum of the two.
        /// </summary>
        public void Exercise2()
        {
            Console.WriteLine("Enter a number");
            int inputNumber1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number");
            int inputNumber2 = Convert.ToInt32(Console.ReadLine());

            int result = (inputNumber1 > inputNumber2) ? inputNumber1 : inputNumber2;
            Console.WriteLine($"Max is {result}.");
        }
    }
}
