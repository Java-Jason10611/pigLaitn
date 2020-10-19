using System;
using System.Collections.Generic;

namespace pig_laitn
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepTranslating = true;
            Console.WriteLine("please enter a sentence to be translated to pig latin");
            while (keepTranslating)
            {
                string sentence = Console.ReadLine().ToLower();
               
                if (sentence.Length <= 0)
                {
                    Console.WriteLine("Please actually enter word or sentence");
                    continue;
                }

                string translated = Translator(sentence);
                Console.WriteLine(translated);

                Console.WriteLine("Would you like to translate another sentence");
                string userInput = Console.ReadLine();
                if (userInput.Equals("yes", StringComparison.OrdinalIgnoreCase) || userInput.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    keepTranslating = true;
                }
                else
                {
                    Console.WriteLine("anksthay orfay eckingchay outway  ymay anslatortray");
                    keepTranslating = false;
                }
            }
        }
         static Boolean IsVowel(char ch)
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    return true;
                }
                return false;
            }

        private static string Translator(string sentence)
        {       
  
            List<string> translated = new List<string>();

            foreach (string word in sentence.Split(' '))
            {  
                bool hasNumber = false;
                int pos = -1;
                char ch;
               
                // checks for a number
                foreach (char chLoop in word)
                {
                    if (Char.IsDigit(chLoop))
                    {
                        hasNumber = true;
                     
                    }
                }
               
                //sets position of the vowel
                for (int i = 0; i < word.Length; i++)
                {
                    ch = word[i]; 
                   
                    if (IsVowel(ch))
                    {
                        pos = i;

                        break;
                    }
                }
                
                //keeps word from getting translated if it has a number
                if (hasNumber == true)
                {
                    translated.Add(word);
                }

                //translates words tha start with a vowel
                else if (pos == 0)
                {
                    translated.Add(word + "way");
                }

                //weird fringe case protection
                else if (word.Length == 2 && pos == -1 )
                {
                    String a = word.Substring(0);
                    String b = word.Substring(2);
                    translated.Add(a + b + "ay");
                }

                //translates words that dont start with a vowel
                else
                {
                    String a = word.Substring(pos);
                    String b = word.Substring(0, pos);
                    translated.Add(a + b + "ay");
                }
                
            }
            return string.Join(" ", translated);

        }
    }

}