
// to enable the streamwriter

using System.IO;

using System.Collections.Generic;



public class Journal
{
    public List<Entry> _entries;

    // Initialize the List of entries by a constructor

    public Journal()
    {
        _entries = new List<Entry>();

    }

    public void AddEntry(Entry newEntry)
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

    public void SaveToFile(string file)
    {
        // to ensure file is automatically closed we use the following
        using (StreamWriter outputFile = new StreamWriter(file))

            //to iterate the list and write to file we do the following
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText},{entry._mood}");
            }
    }

    public void LoadToFile(string file)
    {
        // this code reads entire file at once and return array  of strings 

        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._entryText = parts[2];
            newEntry._promptText = parts[1];
            newEntry._mood = parts[3];

            _entries.Add(newEntry);
        }
    }
}