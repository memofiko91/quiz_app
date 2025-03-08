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
    public Question(string questionText, int correctAnswerIdx)
    {
        this.questionText = questionText;
        this.possibleAnswers = new List<string>();
        this.correctAnswerIdx = correctAnswerIdx;
    }
    
    
    // gibt Frage + Antwortmöglichkeiten aus, ließt Antwort von Konsole ein, checkt diese und gibt true/false zurück
    public bool askQuestion()
    {
        Console.WriteLine(questionText);
        foreach (string answer in possibleAnswers)
        {
            Console.WriteLine(possibleAnswers.IndexOf(answer) + ". " + answer);
        }
        Console.WriteLine();
        Console.WriteLine("Wähle deine Antwort und gib die Zahl in die Konsole ein.");

        int index = int.Parse(Console.ReadLine());

        if (index != correctAnswerIdx)
        {
            return false;
        }
        
        return true;
    }


}             