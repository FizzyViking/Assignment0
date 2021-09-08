using System;

namespace Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
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
