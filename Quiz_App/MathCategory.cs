namespace Quiz_App;

public class MathCategory : Category
{

    private string question1 = "Wie viele Seiten hat ein Fünfeck?";
    private string question2 = "Welche Zahl ist die kleinste Primzahl?";
    private string question3 = "Was beschreibt der Begriff \"Pi\" in der Mathematik?";

    private List<String> possibleAnswers1 = new List<String> { "4 Seiten", "5 Seiten", "6 Seiten" };
    private List<String> possibleAnswers2 = new List<String> { "1", "2", "3" };
    private List<String> possibleAnswers3 = new List<String> { "Die Anzahl der Ecken in einem Quadrat.", "Das Verhältnis der Fläche eines Kreises zum Quadrat seines Radius.", "Das Verhältnis des Durchmessers zum Umfang eines Kreises." };

public MathCategory() {
        questionList.Add(new Question(question1, possibleAnswers1, 1));
        questionList.Add(new Question(question2, possibleAnswers2, 1));
        questionList.Add(new Question(question3, possibleAnswers3, 2));
    }
}