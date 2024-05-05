using System;
using System.IO;

public class Journal{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }    
    public void Add()
    {
        Entry entry = new Entry();
        _entries.Add(entry);
    }


    public void Save(string fileName)
    {
        using(var fileWriter = new StreamWriter(fileName))
        {
            fileWriter.WriteLine("Date,Prompt,Response");
            foreach(Entry e in _entries)
            {
                fileWriter.WriteLine($"{e._date},{e._prompt},{e._userResponse}");
            }
        }
        _entries.Clear();
    }
    public void Load(string fileName)
    {
        using(var fileReader = new StreamReader(fileName))
        {
            fileReader.ReadLine();
            while(!fileReader.EndOfStream)
            {
                var line = fileReader.ReadLine();
                var values = line.Split(',');
                Entry entry = new Entry(values[0],values[1],values[2]);
                _entries.Add(entry);
            }
        }
    }

    public void Display()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void RemoveLast()
    {
        if (_entries.Count != 0)
        {
        _entries.RemoveAt(_entries.Count-1);
        }
    }

}