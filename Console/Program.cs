using System;

namespace Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.UserInput();
        }

        public void UserInput() {
            int input = 0;
            bool error = false;
            System.Console.WriteLine("Enter a year: ");

            try
            {
                input = int.Parse(System.Console.ReadLine());
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message + "\nPlease enter a number from 1582 and up");
                error = true;
            }

            if (!error) {
                if (input >= 1582) {
                    if (IsLeapYear(input)) {
                        System.Console.WriteLine("yay");
                    } else System.Console.WriteLine("nay");
                } 
                else System.Console.WriteLine("Please enter a number from 1582 and up");
            }
        }

        public bool IsLeapYear(int year) {
            
            if (year % 400 == 0) {
                return true;
            }

            if (year % 100 == 0) {
                return false;
            }

            if (year % 4 == 0) {
                return true;
            }
            return false;
        }
    }
}
