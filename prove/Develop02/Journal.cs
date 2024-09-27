using System.ComponentModel;
using System.IO;
using static System.IO.StreamWriter;

public class Journal {
    public List<Entry> _entries = new List<Entry>();
    
    // add a new entry
    public void AddEntry(string prompt,  string response, string date){
        Entry entry = new Entry();
        entry._date = date;
        entry._entryText = response;
        entry._promptText = prompt;
        _entries.Add(entry);
    }

    // display all entries
    public void DisplayAll(){
        foreach (Entry enty in _entries){
            enty.DisplayEntry();   
        }
    }    

    // save to file
    public void SaveFile(){
    Console.Write("Enter Filename: ");
    string userFile = Console.ReadLine();
       

    string fileName = $"C:\\Users\\chris\\OneDrive\\Desktop\\BYU-Idaho Classes\\CSE 210\\CSE-210\\prove\\Develop02\\{userFile}";
       
        using (StreamWriter outputFile = new StreamWriter(fileName))
    {
    // You can add text to the file with the WriteLine method
    foreach (Entry entries in _entries) {
            outputFile.WriteLine($"{entries._date}, {entries._entryText}, {entries._promptText}");  
        }
    }
    }

    // Load from a file
    public void LoadFile() {
    Console.Write("Enter Filename: ");
    string userFile = Console.ReadLine();
    string fileName = $"C:\\Users\\chris\\OneDrive\\Desktop\\BYU-Idaho Classes\\CSE 210\\CSE-210\\prove\\Develop02\\{userFile}";
    using (StreamReader outputFile = new StreamReader(fileName))
    {
    // You can add text to the file with the WriteLine method
    string[] lines = System.IO.File.ReadAllLines(fileName);
    Entry entry = new Entry();
    foreach (string line in lines)
    {
    string[] parts = line.Split(", ");
    List<Entry> entrie = new List<Entry>();
    string _date = parts[0];
    string _entryText = parts[1];
    string _promptText = parts[2];
    Console.WriteLine($"{_date}, {_entryText}, {_promptText}");
    entry._date = _date;
    entry._entryText = _entryText;
    entry._promptText = _promptText;
    _entries.Add(entry);
    }
    }
    }
}
