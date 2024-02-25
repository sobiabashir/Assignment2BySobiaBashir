using System;

namespace Assignment2BySobiaBashir
{
	internal class TemperatureConvertor
	{
		private int firstValueToTemperatureConv;
        private int lastValueToTemperatureConv;
        private void ReadRange()
        {
            Console.WriteLine("From what number you want to calculate temperature conversion ? ");
            string rangeStart = Console.ReadLine();
            firstValueToTemperatureConv = int.Parse(rangeStart);
            Console.WriteLine("To what number you want to calculate temperature conversion ? ");
            string rangeEnd = Console.ReadLine();
            lastValueToTemperatureConv = int.Parse(rangeEnd);

        }

        public void CalculateFornhietFromCelcius()
        {
            
            int iteration = 1;
            double coCelcius = firstValueToTemperatureConv;
            while (coCelcius <= lastValueToTemperatureConv)
            {
                double forenheit = (9.0 / 5.0) * coCelcius + 32.0;
                Console.WriteLine($"Celcius : {coCelcius} " + $"Fornheit : {forenheit} ");
                if (iteration % 20 == 0)
                {
                    Console.WriteLine("Firt 20 inputs data has been printed.Do you want to print more data ?");
                    Console.WriteLine("Press y/Y(yes) or n/N(no)");

                    ConsoleKeyInfo keyInfo = Console.ReadKey();

                    // Get the character from the key pressed
                    char inputChar = keyInfo.KeyChar;

                    if (inputChar == 'y' || inputChar == 'Y')
                    {
                        iteration = 1;
                        continue;
                    }
                    if (inputChar == 'n' || inputChar == 'N')
                    {
                        break;
                    }
                }
                coCelcius++;
                iteration++;
            }
        }
        public void Start()
        {
            ReadRange();
            CalculateFornhietFromCelcius();
        }

    }
}
