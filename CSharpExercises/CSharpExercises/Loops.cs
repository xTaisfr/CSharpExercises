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

                if (input.ToLower() == "ok")
                    break;

                numbersSum += int.Parse(input);
            }

            Console.WriteLine($"\nResultado: {numbersSum}");
        }
    }
}
