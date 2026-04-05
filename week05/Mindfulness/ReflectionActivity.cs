public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectionActivity() : base("Reflection Activity" , "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");

        _questions.Add("Why was this meaningful to you?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What did you learn about yourself?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        ShowSpinner(5);
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    public string GetRandomQuestion()
    {
        Random randomQuestion = new Random();
        int index = randomQuestion.Next(_questions.Count);
        string question = _questions[index];
        return question;
    }

    public void DisplayPrompt()
    {            
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);        
    }

    public void DisplayQuestions()
    {   
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);
            ShowSpinner(5);
        }
    }
}