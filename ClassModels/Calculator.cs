using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassModels
{
    public class Calculator
    {

        private static List<string> calculationHistory = new List<string>();
        
        public static int Divide(int x, int y)
        {
            int result = x / y;
            return result;
        }
        public static int Add(int x, int y)
        {
            int result = x + y;
            return result;
        }
        public static int Multiply(int x, int y)
        {
            int result = x * y;
            return result;
        }
        public static int Subtract(int x, int y)
        {
            int result = x - y;
            return result;
        }

        public static void DivideOutput()
        {
            UserManager.ReadNumbers(out int x, out int y);
            int result = Divide(x, y);
            PrintResult("*", x, y, result);
        }

        public static void AddOutput()
        {
            UserManager.ReadNumbers(out int x, out int y);
            var result = Add(x, y);
            PrintResult("+", x, y, result);
        }

        public static void MultiplyOutput() 
        {
            UserManager.ReadNumbers(out int x, out int y);
            int result = Multiply(x,y);
            PrintResult("*", x, y, result);
        }

       
        public static void SubtractOutput()
        {
            UserManager.ReadNumbers(out int x, out int y);
            int result = Subtract(x,y);
            PrintResult("-", x, y, result);
        }

        public static void PrintResult(string operation, int x, int y, int result)
        {
            string calculation = $"{x} {operation} {y} = {result}";
            SaveCalculation(calculation);
        }

        private static void SaveCalculation(string calculation)
        {
            Console.WriteLine(calculation);
            calculationHistory.Add(calculation);
        }
        public static void ShowOldCalculations()
        {
            if(calculationHistory.Count == 0)
            {
                Console.WriteLine("Inga tidigare beräkningar");
            }
            else
            {
                Console.WriteLine("Tidigare Beräkningar:");
                foreach(var calculation in calculationHistory)
                {
                    Console.WriteLine($"--- {calculation} ---");
                }
            }
        }
    }
}
