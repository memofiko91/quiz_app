namespace Quiz_App;

public abstract class Category
{
    // Sammlung von Quizfragen
    protected List<Question> questionList = new List<Question>();


    public void askCategoryQuestions()
    {
        int countCorrect = 0;
        foreach (Question q in questionList)
        {
            if (q.askQuestions())
            {
                countCorrect++;
            }
        }
        Console.WriteLine("\nQuiz beendet. Richtige Antworten: " + countCorrect);
    }
    
}