﻿namespace CSharpExercises
{
    public class TextSolutions
    {
        /*1- Write a program and ask the user to enter a few numbers separated by a hyphen.
         Work out if the numbers are consecutive. 
        For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        display a message: "Consecutive"; otherwise, display "Not Consecutive".*/

        public void exercise1()
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }

        /*2- Write a program and ask the user to enter a few numbers separated by a hyphen.
         If the user simply presses Enter, without supplying an input, exit immediately; 
        otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.*/
        public void Exercise2()
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            var uniques = new List<int>();
            var includesDuplicates = false;
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                {
                    includesDuplicates = true;
                    break;
                }
            }

            if (includesDuplicates)
                Console.WriteLine("Duplicate");
        }

        /*3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
         A valid time should be between 00:00 and 23:59. 
        If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
        If the user doesn't provide any values, consider it as invalid time.*/
        public void Exercise3()
        {
            Console.Write("Enter time: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }
        }

        /*4- Write a program and ask the user to enter a few words separated by a space.
         Use the words to create a variable name with PascalCase. 
        For example, if the user types: "number of students", display "NumberOfStudents". 
        Make sure that the program is not dependent on the input. 
        So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".*/
        public void Exercise4()
        {
            Console.Write("Enter a few words: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);
        }

        /*5- Write a program and ask the user to enter an English word.
         Count the number of vowels (a, e, o, u, i) in the word. 
        So, if the user enters "inadequate", the program should display 6 on the console.*/
        public void Exercise5()
        {
            Console.Write("Enter a word: ");
            // Note the ToLower() here. This is used to count for both A and a. 
            var input = Console.ReadLine().ToLower();

            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsCount = 0;
            foreach (var character in input)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            Console.WriteLine(vowelsCount);
        }
    }
}
