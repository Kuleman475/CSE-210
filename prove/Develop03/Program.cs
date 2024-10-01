using System;

    string text = "And now it came to pass that all this was done in Mormon, yea, by the waters of Mormon, in the forest \r\n"
     + "that was near the waters of Mormon; yea, the place of Mormon, the waters of Mormon, the forest of Mormon, how beautiful \r\n"
     + "are they to the eyes of them who there came to the knowledge of their Redeemer; yea, and how blessed are they, for \r\n"
     + "they shall sing to his praise forever. ";
    Word word = new Word(text);
    Reference reference = new Reference("Mosiah ", 18, 30);
    Scripture scripture = new Scripture("Mosiah ", 18, 30, text);
    scripture.GetDisplayText();
    // Console.Write(reference.GetDisplayText());
    // Console.Write(word.GetDisplayText());
    // scripture.HideRandomWords(5, text);
