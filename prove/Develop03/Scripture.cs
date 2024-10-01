using System;

    class Scripture {
        private Reference _reference;
        
        private List<Word> _words;
        

    public Scripture(string book, int chapter, int verse, string text)
        {
            _reference = new Reference(book, chapter, verse);
            _words = new List<Word>();
            string[] splitText = text.Split(' ');
            foreach (string word in splitText)
            {
                _words.Add(new Word(word));
            }
            
        }
    
        public void HideRandomWords(int numberToHide, string text) {
            // Word word = new Word(text);
            // Console.WriteLine(text);
            // Console.Write(_words.Count);
            List<string> visibleWords = new List<string>();
            
            foreach (var word1 in text){
                Console.WriteLine(word1);
            }
            Random random = new Random();
            int index1 = random.Next(_words.Count);
            int index2 = random.Next(_words.Count);
            int index3 = random.Next(_words.Count);
            int index4 = random.Next(_words.Count);
            int index5 = random.Next(_words.Count);
            Console.WriteLine($"{index1}, {index2}, {index3}, {index4}, {index5}");
            // foreach(Word word1 in _words)
            // {
            //     Console.WriteLine(word1);
            // }
             
        }
        public string GetDisplayText(){
              
             return _words.Count.ToString();
            
        }
    // public bool IsCompletelyHidden(){

    // }
}
