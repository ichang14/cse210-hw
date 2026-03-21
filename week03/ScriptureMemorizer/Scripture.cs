public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture (Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(" ");

        foreach (string w in words)
            {
                Word word = new Word(w);
                _words.Add(word);
            }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide(); 
        }
           
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                {
                    return false;
                }
        }
        
        return true;    
    }
    
    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
            {
                result += word.GetDisplayText() + " ";
            }

        return result;
    }


}