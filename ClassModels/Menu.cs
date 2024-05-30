namespace ClassModels
{
    public class Menu
    {
        private readonly Calculator _calculator;
        public Menu()
        {
            _calculator = new Calculator();
        }
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

        public void MenuChoice1()
        {
            Console.Clear();
            _calculator.AddOutput();
            Console.WriteLine("Tryck enter för att återgå till meny");
            Console.ReadKey();
            Console.Clear();
        }

        public void MenuChoice2()
        {
            Console.Clear();
            _calculator.SubtractOutput();
            Console.WriteLine("Tryck enter för att återgå till meny");
            Console.ReadKey();
            Console.Clear();
        }

        public void MenuChoice3()
        {
            Console.Clear();
            _calculator.DivideOutput();
            Console.WriteLine("Tryck enter för att återgå till meny");
            Console.ReadKey();
            Console.Clear();
        }

        public void MenuChoice4()
        {
            Console.Clear();
            _calculator.MultiplyOutput();
            Console.WriteLine("Tryck enter för att återgå till meny");
            Console.ReadKey();
            Console.Clear();
        }

        public void MenuChoice5()
        {
            Console.Clear();
            _calculator.ShowOldCalculations();
            Console.WriteLine("Tryck enter för att återgå till meny");
            Console.ReadKey();
            Console.Clear();
        }

        public static void PrintMenuChoices()
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
