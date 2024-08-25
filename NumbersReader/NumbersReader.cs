using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader
{
    public class NumbersReader
    {
        public static string FormatingNumbers(int firstNumber, double secondNumber, double thirdNumber)
        {
            return string.Format("{0,-10:X} {1,-10:F2} {2,-10:F2}", firstNumber, secondNumber, thirdNumber);
        }
        static void Main(string[] args)
        {
            int firstNumber = 256;              
            double secondNumber = 183.4923444;    
            double thirdNumber = -910.272485;   

            
            Console.WriteLine(NumbersReader.FormatingNumbers(firstNumber, secondNumber, thirdNumber));
        }
    }
}
