using System;

namespace Problems{
	
    public class Program{
		
        static void Main(string[] args){
			Program p = new Program();
            Console.WriteLine(p.Prefix("Hello World!"));
        }
		
		public string Prefix(string input){
			if (input == null)
				return null;
			int words = 0 , Length = input.Length;
			bool newWord = true;
			for ( int i = 0; i < Length; i++){
				if (input[i] != ' ' && newWord){
					words++;
					newWord = false;
				}else if (input[i] == ' ') 
					newWord = true;
				}
			string result = Length + "," + words + ":" + input;
			return result;
		}
    }
}
