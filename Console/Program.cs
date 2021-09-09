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
            System.Console.WriteLine("Enter a year: ");
            int input = int.Parse(System.Console.ReadLine());

            if (IsLeapYear(input)) {
                System.Console.WriteLine("yay");
            } else System.Console.WriteLine("nay");
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
