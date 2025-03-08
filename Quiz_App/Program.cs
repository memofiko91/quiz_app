namespace Quiz_App
{

    internal class Program
    {

        public static void Main(string[] args)
        {
            
            showMenu();
            
        }

        public static void showMenu()
        {
            bool exit = false;
            Category category;
            
            Console.WriteLine("\n--- WILLKOMMEN IN DER QUIZ APP ---\n");

            while (!exit)
            {

                Console.WriteLine(
                    "\nWähle eine Option:\na) Mathe-Quiz starten\nb) Allgemeinwissen-Quiz starten\nx) Beenden");

                string option = Console.ReadLine().Trim();
                Console.WriteLine();

                if (option == "a")
                {
                    category = new MathCategory();
                    category.askCategoryQuestions();
                }
                else if (option == "b")
                {
                    category = new GeneralKnowledgeCategory();
                    category.askCategoryQuestions();
                }
                else if (option == "x") exit = true;
                else Console.WriteLine("Falsche Eingabe!\n ");
            }

            Console.WriteLine("Quiz App wird beendet. Bye!");
            Environment.Exit(0);
            
        }
        
        
    }
    
  
    
}

