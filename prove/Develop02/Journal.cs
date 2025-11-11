
//
// ──────────────────────────────────────────────────────────────
//   CLASS: Journal
//   PURPOSE: Manages collection of entries and handles file I/O
// ──────────────────────────────────────────────────────────────
//
class Journal
{
    public List<Entry> _entryList = new List<Entry>();

    public string _fileLocation=null;

    public void displayEntries()
    {
        foreach (Entry entry in _entryList)
        {
            entry.Display();
        }
    }

    public void SaveFile()
    {
        if (_fileLocation == null) return;

        using (StreamWriter outputFile = new StreamWriter(_fileLocation))
        {
            foreach (Entry entry in _entryList)
            {
                outputFile.WriteLine(entry.EntryData());
            }
        }
    }
    
    public void ReadFile()
    {
        string[] lines = File.ReadAllLines(_fileLocation);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry newEntry = new Entry();
            newEntry.FillEntry(date, prompt, response);

            _entryList.Add(newEntry);
        }
    }
}
