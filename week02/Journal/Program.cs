using System;

class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        
        int option = 0 ;


        while( option != 5 )
        {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("Please select one of the following choices: ");
        option =int.Parse(Console.ReadLine());

        if(option == 1)
        {   
            string promp = promptGenerator.GetRandomPrompt();
            Console.WriteLine(promp);
            string answer = Console.ReadLine();
            string date = DateTime.Now.ToShortDateString();
            Entry entry = new Entry();
            entry._date = date;
            entry._promptText = promp;
            entry._answerText = answer;
            journal.AddEntry(entry);
        }

        else if (option == 2)
        {
            journal.DisplayAll();
        }
        
        else if (option == 3)
            {
                journal.LoadFromFile();
            }

        else if (option == 4)
            {
                journal.SaveToFile();
            }

        

        }
    }

    
}