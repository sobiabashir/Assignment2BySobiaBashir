using System.Text;

namespace Assignment2BySobiaBashir
{
    internal class MathsOperation
    {
        public void Calculate()
        {
            bool exit = false;
            while (!exit)
            {
                
                Console.Write("Enter starting number: ");
                int start = int.Parse(Console.ReadLine());

                Console.Write("Enter ending number: ");
                int end = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("****************************************************************************");
                Console.WriteLine();
                Console.WriteLine($"Sum of numbers from {start} to {end}: {SumNumbers(start, end)}");

                Console.WriteLine();
                Console.WriteLine("****************************************************************************");
                Console.WriteLine();
                Console.WriteLine("Even numbers within the range:");

                Console.WriteLine();
                Console.WriteLine("****************************************************************************");
                Console.WriteLine();
                PrintEvenNumbers(start, end);

                Console.WriteLine();
                Console.WriteLine("****************************************************************************");
                Console.WriteLine();
                Console.WriteLine("Odd numbers within the range:");
                PrintOddNumbers(start, end);

                Console.WriteLine();
                Console.WriteLine("****************************************************************************");
                Console.WriteLine();
                Console.WriteLine("Square roots of numbers within the range:");
                CalculateSquareRoot(start, end);

                exit = ExitCalculation();
            }
        }

        private int SumNumbers(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }

        private void PrintEvenNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        private void PrintOddNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        private void CalculateSquareRoot(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                for (int j = i; j <= end; j++)
                {
                    Console.Write(Math.Sqrt(j) + " ");
                }
                Console.WriteLine();
            }
        }

        private bool ExitCalculation()
        {
            Console.WriteLine("Do you want to continue y/n");
            Console.WriteLine();
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            bool val= true;
            char inputChar = keyInfo.KeyChar;
            if (inputChar == 'y' || inputChar == 'Y')
                val = false;
            if (inputChar == 'n' || inputChar == 'N')
                val = true;

            return val;
        }
    }

   
}