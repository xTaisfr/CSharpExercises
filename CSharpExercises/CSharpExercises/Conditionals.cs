namespace CSharpExercises
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

        ///<summary>
        /// 3) Write a program and ask the user to enter the width and height of an image. 
        /// Then tell if the image is landscape or portrait.
        ///</summary>
        public void Exercise3()
        {
            Console.WriteLine("Enter the height of the image:");
            int inputHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width of the image:");
            int inputWidth = Convert.ToInt32(Console.ReadLine());

            var result = (inputHeight > inputWidth) ? ImageOrientation.Portrait : ImageOrientation.Landscape;

            Console.WriteLine(result);
        }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }

        ///<summary>
        /// 4) Your job is to write a program for a speed camera. For simplicity, 
        /// ignore the details such as camera, sensors, etc and focus purely on the logic. 
        /// Write a program that asks the user to enter the speed limit. 
        /// Once set, the program asks for the speed of a car. 
        /// If the user enters a value less than the speed limit, 
        /// program should display Ok on the console. 
        /// If the value is above the speed limit, 
        /// the program should calculate the number of demerit points. 
        /// For every 5km/hr above the speed limit, 
        /// 1 demerit points should be incurred and displayed on the console. 
        /// If the number of demerit points is above 12, the program should display License Suspended.
        ///</summary>
        public void Exercise4()
        {

        }
    }
}
