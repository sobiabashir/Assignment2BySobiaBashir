using Assignment1BySobiaBashir;

namespace Assignment2BySobiaBashir
{
    internal class StringOperations
    {
        private string dataFromIser;
        private void ReadString()
        {
            Console.WriteLine("Enter the paragraph or string which you want to manipulate or calculate the length ? ");
            dataFromIser = Console.ReadLine();
        }

        public int StringLength()
        {
            return dataFromIser.Length;
        }
        public string ConvertToUpperCase(string input)
        {
            input = dataFromIser.ToUpper();
            return input;

        }

        public void DisplayStringInfo()
        {
            int sizeOfString = StringLength();

            string upperCase = ConvertToUpperCase(dataFromIser);

            Console.WriteLine(sizeOfString);
            Console.WriteLine(upperCase);

        }

        public void PredictMyDay()
        {
            Console.WriteLine("*****************Welcome to my predicted day*****************");
            Console.WriteLine("Enter a number between 1 and 7:");
            string enterDay = Console.ReadLine();
            int day = int.Parse(enterDay);
            switch (day)
            {
                case 1:
                    Console.WriteLine("Keep calm on Mondays! You can fall apart!");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Tuesdays and Wednesdays break your heart!");
                    break;
                case 4:
                    Console.WriteLine("Thursday is your lucky day, don't wait for Friday!");
                    break;
                case 5:
                    Console.WriteLine("Friday, you are in love!");
                    break;
                case 6:
                    Console.WriteLine("Saturday, do nothing and do plenty of it!");
                    break;
                case 7:
                    Console.WriteLine("And Sunday always comes too soon!");
                    break;
                default:
                    Console.WriteLine("No day? A good day but it doesn't exist!");
                    break;
            }

        }
        public void Start()
        {
            ReadString();
            DisplayStringInfo();
            bool round;
            do
            {
                Console.WriteLine();
                PredictMyDay();
                Console.WriteLine();
                Console.WriteLine("Do you want to continue y/n");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                char inputChar = keyInfo.KeyChar;
                if (inputChar == 'y'||inputChar=='Y')
                    round = true;
                if (inputChar == 'n' || inputChar == 'N')
                {
                    round = false;
                    break;
                }
            } while(true);

        }
    }
}