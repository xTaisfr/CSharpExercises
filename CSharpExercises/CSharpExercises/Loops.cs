namespace CSharpExercises
{
    public class Loops
    {
        ///<summary>
        /// 1) Write a program to count how many numbers between 1 and 100 
        /// are divisible by 3 with no remainder. 
        /// Display the count on the console.
        ///</summary>
        public void Exercise1()
        {
            int count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine($"There are {count} numbers divisible by 3 between 1 and 100.");
        }

        ///<summary>
        /// 2) Write a program and continuously ask the user to enter a number or "ok" to exit. 
        /// Calculate the sum of all the previously entered numbers and display it on the console.
        ///</summary>
        public void Exercise2()
        {
            var numbersSum = 0;

            while (true)
            {
                Console.WriteLine("enter a number or \"ok\" to exit");
                var input = Console.ReadLine();

                if (input?.ToLower() == "ok")
                    break;

                if (input != null)
                    numbersSum += int.Parse(input);
            }

            Console.WriteLine($"\nSum of all numbers is: {numbersSum}");
        }

        ///<summary>
        /// 3) Write a program and ask the user to enter a number. 
        /// Compute the factorial of the number and print it on the console. 
        /// For example, if the user enters 5, 
        /// the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        ///</summary>
        public void Exercise3()
        {
            long fatorial = 1;

            Console.WriteLine("Enter a number: ");
            var inputNumber = int.Parse(Console.ReadLine());

            for (int i = inputNumber; i > 1; i--)
            {
                fatorial *= i;
            }

            Console.WriteLine($"{inputNumber}! = {fatorial}.");
        }
    }
}
