public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity (string name, string description)
    {
        _name = name;
        _description = description;        
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine($"you have completed another {_duration} seconds of the {_name}");
    }

    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        List<string> symbols = new List<string> { "|", "/", "-", "\\" };

        while (DateTime.Now < endTime)
        {
            foreach (string symbol in symbols)
            {
                Console.Write(symbol);
                Thread.Sleep(5);
                Console.Write("\b \b");

                if (DateTime.Now >= endTime)
                    break;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}