public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity() : base("Listing Activity" , "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are your personal strengths?");
        _prompts.Add("Who are people that you have helped this week?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        _count = 0;
        GetRandomPrompt();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);        
        List<string> items = GetListFromUser();
        _count = items.Count;
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {       
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            items.Add(input);
        }

        return items;
    }
}