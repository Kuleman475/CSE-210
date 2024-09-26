using System;
// from DateTime in dateTime;
public class Entry {
    public string _date = DateTime.Now.ToString("MM/dd/yyyy");
    public string _promptText;
    public string _entryText;

    public void DisplayEntry(){
        Console.WriteLine($"Date:{_date} >>> Prompt: {_promptText}");
        // Console.WriteLine($"{_entryText}");
        _entryText = Console.ReadLine();
    }

}
