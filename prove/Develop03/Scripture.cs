using System;

    class Scripture {
        private Reference _reference;
        
        private List<Word> _words;
        private List<string> _text;

        private List<string> _text2;
    public Scripture(string book, int chapter, int verse, string text)
        {
            _reference = new Reference(book, chapter, verse);
            _words = new List<Word>();
            _text = new List<string>();
            string[] splitText = text.Split(' ');
            foreach (string word in splitText)
            {
                _words.Add(new Word(word));
                _text.Add(word + " ");
            }
            
        }
    
        public void HideRandomWords(int numberToHide) {

            
            Random random = new Random();
            int index1 = random.Next(_text.Count);
            int index2 = random.Next(_text.Count);
            int index3 = random.Next(_text.Count);
            int index4 = random.Next(_text.Count);
            int index5 = random.Next(_text.Count);
            // Console.Write($"{_text[index1]} {_text[index2]}"
            // + $"{_text[index3]} {_text[index4]} {_text[index5]}");
            _text2 = new List<string>();
            foreach(string word in _text)
            {
                
                if(_text[index1] == word) {
                    foreach(char letter in word)
                        _text2.Add("_");
                }
                else {
                    _text2.Add(word);
                }
            }
            // Console.WriteLine(_text2);
            for (int i = 0; i < _text.Count; i++) 
                {
                Console.Write(_text2[i]);
                }
        }

        public string GetDisplayText(){

            return _text.ToString();
            
        }
    // public bool IsCompletelyHidden(){

    // }
}
