namespace FactoryMethod;

public class Developer: IInterviewer
{
    public void AskQuestions()
    {
        System.Console.WriteLine("Asking about design patterns!");
    }
}