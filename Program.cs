using System;
using System.Collections.Generic;

namespace pig_laitn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a sentence to be translated to pig latin");
            string sentence = Console.ReadLine().ToLower();
            string translated = Translator(sentence);

            
            Console.WriteLine(translated);
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
            int pos = -1;
            char ch;

            List<string> translated = new List<string>();

            foreach (string word in sentence.Split(' '))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    ch = word[i];

                    if (IsVowel(ch))
                    {
                        pos = i;

                        break;
                    }
                }

                if (pos == 0)
                {
                    translated.Add(word + "way");
                }
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