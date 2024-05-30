using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassModels
{
    public class UserManager
    {
        public static int GetInput(string prompt)
        {
            Console.Write(prompt);
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    return number;
                }
                Console.Write("Ogiltig input. Försök igen: ");
            }
        }

        public static void ReadNumbers(out int x, out int y)
        {
            x = GetInput("Ange det första talet: ");
            y = GetInput("Ange det andra talet: ");
        }
    }
}
