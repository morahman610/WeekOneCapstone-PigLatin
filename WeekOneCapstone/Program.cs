using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOneCapstone
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();
            //TakeInput();
            Console.WriteLine(TakeInput());
        }

        static void Welcome()
        {
            Console.WriteLine("Hello! Welcome to the English to Pig Latin Translator!");

        }

        static string TakeInput()
        {
            Console.WriteLine("What would you like to translate?" );
            string englishWord = Console.ReadLine().ToLower();

            string firstLetter = englishWord.Substring(0, 1);

            if (firstLetter == "a" || firstLetter == "e" || firstLetter == "i" || firstLetter == "o" || firstLetter == "u" )
            {
                englishWord = englishWord + "way";
            }
            else
            {
                string vowels = "aeiou";
                for (int i = 0; i < englishWord.Length; i++)
                {
                    for (int j = 0; j < vowels.Length; j++)
                    {
                        if (englishWord[i] == vowels[j])
                        {
                            string pigLatin = englishWord.Substring(i, (englishWord.Length - i));
                            string firstPart = englishWord.Substring(0, i);
                            Console.WriteLine(pigLatin + firstPart + "ay");
                            break;

                        }

                    }

                }
            }

            return englishWord;
        }
    }
}
