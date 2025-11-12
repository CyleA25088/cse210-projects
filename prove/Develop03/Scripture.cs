class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordsArray = text.Split(' ');
        
        _words = new List<Word>();

        foreach (string wordText in wordsArray)
        {
            _words.Add(new Word(wordText));
        }

    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();

        // Get all indexes of words that are still visible
        List<int> visibleIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndexes.Add(i);
            }
        }

        count = Math.Min(count, visibleIndexes.Count);

        for (int i = 0; i < count; i++)
        {
            int randomIndex = random.Next(visibleIndexes.Count);
            _words[visibleIndexes[randomIndex]].Hide();

            // Remove the index so we don’t pick it again
            visibleIndexes.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayText()
    {
        string outString = _reference.GetDisplayText();

        string wordsText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
    
        return $"{outString} {wordsText}";
    }
    
    public bool IsCompleteHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }

        return true;
    }
}