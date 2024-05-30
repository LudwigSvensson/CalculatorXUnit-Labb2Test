using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassModels
{
    public class Calculator
    {

        private List<string> calculationHistory = new List<string>();
        
        public int Divide(int x, int y)
        {
            return x / y;
           
        }
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Multiply(int x, int y)
        {
            return  x * y;

        }
        public int Subtract(int x, int y)
        {
            return  x - y;
        }

        public void DivideOutput()
        {
            UserManager.ReadNumbers(out int x, out int y);
            int result = Divide(x, y);
            PrintResult("/", x, y, result);
        }

        public void AddOutput()
        {
            UserManager.ReadNumbers(out int x, out int y);
            var result = Add(x, y);
            PrintResult("+", x, y, result);
        }

        public void MultiplyOutput() 
        {
            UserManager.ReadNumbers(out int x, out int y);
            int result = Multiply(x,y);
            PrintResult("*", x, y, result);
        }

       
        public void SubtractOutput()
        {
            UserManager.ReadNumbers(out int x, out int y);
            int result = Subtract(x,y);
            PrintResult("-", x, y, result);
        }

        public void PrintResult(string operation, int x, int y, int result)
        {
            string calculation = $"{x} {operation} {y} = {result}";
            Console.WriteLine(calculation);
            calculationHistory.Add(calculation);//Lägger till en uträkning i listan för gjorda uträkningar
        }    
        
        public void ShowOldCalculations()
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
