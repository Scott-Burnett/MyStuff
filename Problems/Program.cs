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
			for ( int i = 0; i < Length; i++)
				if (input[i] == ' ')
					words++;
			if (Length > 1) 
				words ++;
			string result = Length + "," + words + ":" + input;
			return result;
		}
    }
}
