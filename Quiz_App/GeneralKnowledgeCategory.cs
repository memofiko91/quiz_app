namespace Quiz_App;

public class GeneralKnowledgeCategory : Category
{
    
    private string question1 = "Von wem stammt das Werk 'Faust'";
    private string question2 = "Welcher Planet ist der größte im Sonnensystem?";
    private string question3 = "Wie heißt die Hauptstadt von Finnland?";
    
    private List<string> possibleAnswers1 = new List<string> {"Johann Wolfgang von Goethe", "Friedrich Schiller", "Thomas Mann"};
    private List<string> possibleAnswers2 = new List<string> {"Uranus", "Merkur", "Jupiter"};
    private List<string> possibleAnswers3 = new List<string> {"Tallinn", "Helsinki","Espoo"};
    
    
    public GeneralKnowledgeCategory()
    {
        questionList.Add(new Question(question1, possibleAnswers1, 0));
        questionList.Add(new Question(question2, possibleAnswers2, 2));
        questionList.Add(new Question(question3, possibleAnswers3, 1));
    }
}