public class Journal 

{ 
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry( Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        } 
    }

    public void SaveToFile()
    {
        Console.Write("What is the filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._answerText}");
            }
        }
    }

    public void LoadFromFile()
    {
        Console.Write("What is the filename: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _entries.Clear();
            foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._answerText = parts[2];
            AddEntry(entry);            
        }
    }
}