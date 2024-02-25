using Assignment2BySobiaBashir;
using System.Xml.Serialization;

namespace Assignment1BySobiaBashir
{
    namespace ConsoleApps
    {
        class Program
        {
            static void DisplayManu()
            {
                Console.Clear();
                Console.WriteLine(" ********************************************************************");
                Console.WriteLine();             
                Console.WriteLine(" ************************* Main manu ********************************");
                Console.WriteLine();
                Console.WriteLine(" ********************************************************************");

                Console.WriteLine("Select one of the following option");
                Console.WriteLine("Select 1 for F to C convertor:");
                Console.WriteLine("Select 2 for C to F convertor:");
                Console.WriteLine("Select 3 for String:");
                Console.WriteLine("Select 4 for Math Oprations:");
                Console.WriteLine("Select 5 for Schedular:");
                Console.WriteLine("Select 0 for Exit :");
                Console.WriteLine();
            }
            static void Main(string[] args)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("*********************** Assignment # 2 by Sobia Bashir **************");
               
                int choice;
                do
                {
                    DisplayManu();
                    
                    choice = Input.ReadIntegerConsole(" Enter your choice :  ");
                    if ((choice==0)|| (choice == 1)|| (choice == 2) || (choice == 3) || (choice == 4) || (choice == 5))
                    {
                        switch(choice)
                        {
                            case 1:
                                TemperatureConvertor temperatureConvertorObj=  new TemperatureConvertor();
                                temperatureConvertorObj.Start();
                                break;
                            case 2:
                                TempCelciusFromF tempCelciusFromFObj= new TempCelciusFromF();
                                tempCelciusFromFObj.Start();
                                break;
                            case 3:
                                StringOperations stringOperationsObj=new StringOperations();
                                stringOperationsObj.Start();
                                break;
                            case 4:
                                MathsOperation calculator = new MathsOperation();
                                calculator.Calculate();
                                break;
                            case 5:
                                Scheduler schedulerObj = new Scheduler();
                                schedulerObj.GenerateSchedule();
                                break;
                            case 0:
                                break;


                        }


                    }
                    else 
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please select only number from 0 ,1 or 2 for proceeding");
                    }



                } while (choice != 0);



            }
        }
    }
}