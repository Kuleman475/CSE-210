using System;

    class Scripture {
        private Reference _reference;
        
        private List<Word> _words;
        private List<string> _text;

        private List<string> _text2;
        public List<int> _numbers;

    public Scripture(string book, int chapter, int verse, string text)
        {
            _reference = new Reference(book, chapter, verse);
            _words = new List<Word>();
            _text = new List<string>();
            // _numbers = new List<int>();
            string[] splitText = text.Split(' ');
            foreach (string word in splitText)
            {
                _words.Add(new Word(word));
                _text.Add(word);
            }
            _numbers = new List<int>();
        }
    
        public void HideRandomWords(int numberToHide) {

            
            Random random = new Random();
            int index1 = random.Next(_text.Count-1);
            int index2 = random.Next(_text.Count-1);
            int index3 = random.Next(_text.Count-1);
            int index4 = random.Next(_text.Count-1);
            int index5 = random.Next(_text.Count-1);
            // Console.Write($"{_text[index1]} {_text[index2]}"
            // + $"{_text[index3]} {_text[index4]} {_text[index5]}");
            _text2 = new List<string>();

            for (int i = 0; i <= numberToHide-1;) {
                if (_numbers.Contains(index1)){
                index1 = random.Next(_text.Count-1);
            }
                else {
                    _numbers.Add(index1);
                    i++;
                }
            } 
            Console.WriteLine(_numbers.Count);
            
            foreach(string word in _text)
            {
                
        _text2.Add(word + " ");
                    // int letter = _text[num].Length; 
                    //  string replaceWord = new string ('_', letter);
                    // _text2.Add(replaceWord + " ");
                    // }
                    // else{
                    //      
                    // }
            }
            for (int i = 0; i < _text.Count; i++) {
            if(_numbers.Contains(i)) {
                int letter = _text[i].Length; 
                     string replaceWord = new string ('_', letter);
            Console.Write(_text2[i].Replace(_text[i], replaceWord));
            }
            else {
            Console.Write(_text2[i]);

            }
        }
                // if(_numbers.Contains(index1)) {
                //     int letter = _text[index1].Length;       
                //     string replaceWord = new string ('_', letter);
                //     _text2.Add(replaceWord + " ");
                // }
                // else {
                   
                // }
            
           foreach(int num in _numbers){
            //     Console.Write(num +", ");
            
            }
            // for (int i = 0; i < _text.Count; i++) 
            //     {
            //     Console.Write(_text2[i].Replace(_text[10], "10"));
            //     }
        }



        public string GetDisplayText(){

            return _text.ToString();
            
        }
    // public bool IsCompletelyHidden(){

    // }
}
