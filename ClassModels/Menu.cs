namespace ClassModels
{
    public class Menu
    {
        public void TheMenu()
        {           
            while (true)
            {
                PrintMenuChoices();

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        MenuChoice1(); //Addition
                        break;
                    case "2":
                        MenuChoice2(); //Subtraktion
                        break;
                    case "3":
                        MenuChoice3(); //Divition
                        break;
                    case "4":
                        MenuChoice4(); //Multiplikation
                        break;
                    case "5":
                        MenuChoice5(); //Se gamla uträkningar
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        public static void MenuChoice1()
        {
            Console.Clear();
            Calculator.AddOutput();
            Console.WriteLine("Tryck enter för att återgå till meny");
            Console.ReadKey();
            Console.Clear();
        }

        private static void MenuChoice2()
        {
            Console.Clear();
            Calculator.SubtractOutput();
            Console.WriteLine("Tryck enter för att återgå till meny");
            Console.ReadKey();
            Console.Clear();
        }

        private static void MenuChoice3()
        {
            Console.Clear();
            Calculator.DivideOutput();
            Console.WriteLine("Tryck enter för att återgå till meny");
            Console.ReadKey();
            Console.Clear();
        }

        private static void MenuChoice4()
        {
            Console.Clear();
            Calculator.MultiplyOutput();
            Console.WriteLine("Tryck enter för att återgå till meny");
            Console.ReadKey();
            Console.Clear();
        }

        private static void MenuChoice5()
        {
            Console.Clear();
            Calculator.ShowOldCalculations();
            Console.WriteLine("Tryck enter för att återgå till meny");
            Console.ReadKey();
            Console.Clear();
        }

        private static void PrintMenuChoices()
        {
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Dividera");
            Console.WriteLine("4. Multiplicera");
            Console.WriteLine("5. Visa gamla uträkningar");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
        }
        public static void Start()
        {
            Menu menu = new Menu();
            menu.TheMenu();
        }
    }
}
