using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

//
// ──────────────────────────────────────────────────────────────
//   CLASS: Journal
//   PURPOSE: Manages collection of entries and handles file I/O
// ──────────────────────────────────────────────────────────────
//
class Journal
{
    public List<Entry> _entryList = new List<Entry>();
    public string _fileLocation = null;

    public void displayEntries()
    {
        foreach (Entry entry in _entryList)
        {
            entry.Display();
        }
    }

    public void SaveFile()
    {
        if (string.IsNullOrEmpty(_fileLocation)) return;

        // Write CSV header then each entry's CSV line
        using (StreamWriter outputFile = new StreamWriter(_fileLocation))
        {
            outputFile.WriteLine("Date,Prompt,Response");
            foreach (Entry entry in _entryList)
            {
                outputFile.WriteLine(entry.EntryData());
            }
        }
    }

    public void ReadFile()
    {
        if (string.IsNullOrEmpty(_fileLocation)) return;
        if (!File.Exists(_fileLocation)) return;

        string[] lines = File.ReadAllLines(_fileLocation);

        _entryList.Clear();


        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            if (string.IsNullOrWhiteSpace(line)) continue;

            List<string> parts = ParseCsvLine(line);

            // Expect at least 3 parts (Date, Prompt, Response)
            if (parts.Count < 3) continue;

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry newEntry = new Entry();
            newEntry.FillEntry(date, prompt, response);

            _entryList.Add(newEntry);
        }
    }

    // Robust CSV parser for a single line.
    // Handles quoted fields, double-quote escapes, commas inside quotes.
    private static List<string> ParseCsvLine(string line)
    {
        List<string> fields = new List<string>();
        if (line == null) return fields;

        StringBuilder field = new StringBuilder();
        bool inQuotes = false;
        int len = line.Length;

        for (int i = 0; i < len; i++)
        {
            char c = line[i];

            if (inQuotes)
            {
                if (c == '"')
                {
                    // If next char is also quote -> escaped quote
                    if (i + 1 < len && line[i + 1] == '"')
                    {
                        field.Append('"');
                        i++; // skip next quote
                    }
                    else
                    {
                        // end of quoted field
                        inQuotes = false;
                    }
                }
                else
                {
                    field.Append(c);
                }
            }
            else
            {
                if (c == '"')
                {
                    inQuotes = true;
                }
                else if (c == ',')
                {
                    fields.Add(field.ToString());
                    field.Clear();
                }
                else
                {
                    field.Append(c);
                }
            }
        }

        // add last field
        fields.Add(field.ToString());

        return fields;
    }
}
