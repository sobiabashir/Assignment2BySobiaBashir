namespace Assignment2BySobiaBashir
{
    internal class Scheduler
    {
        private const int WeeksInYear = 52;
        private const int WeekendsFrequency = 2;
        private const int NightShiftsFrequency = 4;

        public void GenerateSchedule()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Weekends");
                Console.WriteLine("2. Nights");
                Console.WriteLine("3. Exit");
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Weekends schedule:");
                            PrintSchedule(GetWeekendsSchedule());
                            break;
                        case 2:
                            Console.WriteLine("Night shifts schedule:");
                            PrintSchedule(GetNightShiftsSchedule());
                            break;
                        case 3:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please enter a valid choice.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                Console.WriteLine();
            }
        }

        private int[] GetWeekendsSchedule()
        {
            int count = WeeksInYear / (WeekendsFrequency * 2);
            int[] weekendsSchedule = new int[count];
            for (int i = 0, week = 2; i < count; i++, week += WeekendsFrequency * 2)
            {
                weekendsSchedule[i] = week;
            }
            return weekendsSchedule;
        }

        private int[] GetNightShiftsSchedule()
        {
            int count = WeeksInYear / NightShiftsFrequency;
            int[] nightShiftsSchedule = new int[count];
            for (int i = 0, week = 1; i < count; i++, week += NightShiftsFrequency)
            {
                nightShiftsSchedule[i] = week;
            }
            return nightShiftsSchedule;
        }

        private void PrintSchedule(int[] schedule)
        {
            foreach (var week in schedule)
            {
                Console.Write(week + " ");
            }
            Console.WriteLine();
        }
    }
}