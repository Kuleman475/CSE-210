using System;
using System.Reflection.Metadata;
using System.Transactions;

string text = "And now it came to pass that all this was done in Mormon, yea, by the waters of Mormon, in the forest \r\n"
     + "that was near the waters of Mormon; yea, the place of Mormon, the waters of Mormon, the forest of Mormon, how beautiful \r\n"
     + "are they to the eyes of them who there came to the knowledge of their Redeemer; yea, and how blessed are they, for \r\n"
     + "they shall sing to his praise forever. ";
    Word word = new Word(text);
    Reference reference = new Reference("Mosiah ", 18, 30);
    Scripture scripture = new Scripture("Mosiah ", 18, 30, text);
    Console.Clear();
    Console.Write(reference.GetDisplayText());
    Console.Write(word.GetDisplayText());

    // Console.ReadKey();
    Console.WriteLine();
    Console.Write("Press enter to continue or type 'quit' to quit:  ");
    string userInput = Console.ReadLine();

    while (userInput != "quit") {
        if (Console.ReadKey().Key == ConsoleKey.Enter){
            Console.Clear();
            scripture.HideRandomWords(5);
            }

    }
    if (userInput == "quit"){
        Console.WriteLine("GOODBYE!");
    }
