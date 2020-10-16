using System;
using System.Linq;

namespace pig_laitn
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("please enter a word");
                string word = Console.ReadLine().ToLower();                                            
                int pos = -1;
                char ch;

                static Boolean isVowel(char ch)
                {
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    {
                        return true;
                    }
                    return false;
                }

                for (int i = 0; i < word.Length; i++)
                {
                    ch = word[i];

                    if (isVowel(ch))
                    {
                        pos = i;
                        break;
                    }
                }

                if (pos == 0)
                {
                    Console.WriteLine(word + "way");
                }
                else
                {
                    String a = word.Substring(pos);
                    String b = word.Substring(0, pos);
                    Console.WriteLine(a + b + "ay");
                

            }
        }
    }
 
}