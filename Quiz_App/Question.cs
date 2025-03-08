namespace Quiz_App;

public class Question
{

    // Text der Frage
    public string questionText { get; }
    
    // Collection die alle Antwortmöglichkeiten enthält
    public List<string> possibleAnswers { get; }
    
    // Index der richtigen Antwort in der possibleAnswers Liste
    private readonly int correctAnswerIdx;

    // Konstruktor initialisiert alle Eigenschaften
    public Question(string questionText, List<string> possibleAnswers, int correctAnswerIdx)
    {
        this.questionText = questionText;
        this.possibleAnswers = possibleAnswers;
        this.correctAnswerIdx = correctAnswerIdx;
    }
    
    
    // gibt Frage + Antwortmöglichkeiten aus, ließt Antwort von Konsole ein, checkt diese und gibt true/false zurück
    public bool askQuestions()
    {
        Console.WriteLine();
        Console.WriteLine(questionText);
        for (int i = 0; i < possibleAnswers.Count; i++)
        {
            Console.WriteLine($"{i}. {possibleAnswers[i]}");
        }
        
        int index = 0;
        bool validInput = false;
        
        do
        {
            try
            {
                Console.WriteLine("\nWähle deine Antwort und gib die Zahl in die Konsole ein:");
                string input = Console.ReadLine().Trim();
                index = int.Parse(input); // falls Eingabe kein int --> FormatException

                if (index < 0 || index >= possibleAnswers.Count)
                {
                    throw new ArgumentOutOfRangeException("Zahl "+ nameof(index), " nicht vorhanden!");
                }

                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Fehler: Ungültige Eingabe! Bitte gib eine gültige Zahl ein.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
        } while (!validInput); // Wiederholen, bis eine gültige Eingabe erfolgt

        return index == correctAnswerIdx;
    }
    
}             