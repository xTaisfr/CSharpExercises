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
            int inputNumber = 0;

            Console.WriteLine("Enter a number: ");
            var input = Console.ReadLine();

            if (input != null)
                inputNumber = int.Parse(input);

            for (int i = inputNumber; i > 1; i--)
            {
                fatorial *= i;
            }

            Console.WriteLine($"{inputNumber}! = {fatorial}.");
        }

        ///<summary>
        /// 4) Write a program that picks a random number between 1 and 10. 
        /// Give the user 4 chances to guess the number. 
        /// If the user guesses the number, display “You won"; 
        /// otherwise, display “You lost". 
        /// (To make sure the program is behaving correctly, 
        /// you can display the secret number on the console first.)
        ///</summary>
        public void Exercise4()
        {
            var random = new Random();
            var input = 0;
            var numeroSorteio = random.Next(1, 10);

            //Console.WriteLine("Número da sorte é {0}", numeroSorteio);

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Digite o número da sorte:");

                input = Convert.ToInt32(Console.ReadLine());

                if (input == numeroSorteio)
                {
                    Console.WriteLine("Você acertou!!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Você errou :( \n");
                }
            }

            Console.WriteLine("O número sorteado foi: {0}", numeroSorteio);
        }

        ///<summary>
        /// 5) Write a program and ask the user to enter a series of numbers separated by comma. 
        /// Find the maximum of the numbers and display it on the console. 
        /// For example, if the user enters “5, 3, 8, 1, 4", the program should display 8
        ///</summary>
        public void Exercise5()
        {
            Console.Write("Enter commoa separated numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            // Assume the first number is the max 
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is " + max);
        }
    }
}
