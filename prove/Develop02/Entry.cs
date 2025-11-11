
//
// ──────────────────────────────────────────────────────────────
//   CLASS: Entry
//   PURPOSE: Stores a single journal entry with date, prompt, and response
// ──────────────────────────────────────────────────────────────
//
class Entry
{
    string _date;
    string _prompt;
    string _response;

    public void FillEntry(string prompt)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd");
        _prompt = prompt;

        Console.WriteLine(prompt);
        Console.Write("> ");
        string input = Console.ReadLine() ?? "";

        // sanitize input: remove newlines, carriage returns, and trim spaces
        input = input.Replace("\r", "").Replace("\n", "").Trim();

        _response = input;
    }

    public void FillEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }

    public string EntryData()
    {
        return $"{_date}#{_prompt}#{_response}";
    }
}
