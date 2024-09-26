using System.ComponentModel;

public class Journal {
    public List<Entry> _entries = new List<Entry>();
    

    // add a new entry
    public void AddEntry(string prompt,  string response, string date){
        Entry newEntry = new Entry();
        newEntry._date = date;
        newEntry._promptText = prompt;
        newEntry._entryText = response;
        _entries.Add(newEntry);
    }
    // display all entries
    public void DisplayAll(){
        foreach (Entry enty in _entries){
            enty.DisplayEntry();   
            
        }
    }
    // save to file


    // Load from a file
}