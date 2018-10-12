using System;

namespace TimerUnitTest_14_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter time as, D:HH:MM:SS");
                SetTimer timer = new SetTimer(Console.ReadLine());
                timer.TimerCount();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Incorrect format. Please format as D:H:M:S using colons(:).");
            }

            Console.ReadLine();
        }
    }
}
