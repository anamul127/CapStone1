using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone1PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter sentence to be translated to Pig Latin");
                string sentence = Console.ReadLine().ToLower();
                string vowels = "AEIOUaeiou";
                string[] space = sentence.Split(' ');

                



                    if (sentence[0] == 'a' || sentence[0] == 'e' || sentence[0] == 'i' || sentence[0] == 'o' || sentence[0] == 'u' || sentence[0] == 'A' || sentence[0] == 'E' || sentence[0] == 'I' || sentence[0] == 'O' || sentence[0] == 'U')
                    {
                        Console.WriteLine(sentence + "way");
                    }

                    else
                    {
                        for (int i = 0; i < sentence.Length; i++)
                        {
                            for (int j = 0; j < vowels.Length; j++)
                            {
                                if (sentence[i] == vowels[j])
                                {
                                    string newWord = sentence.Substring(i, sentence.Length - i);
                                    string start = sentence.Substring(0, i);
                                    Console.WriteLine(newWord + start + "ay");
                                    i = sentence.Length;
                                    j = vowels.Length;
                                }
                            }
                        }
                    }
                
            }
        }
    }
}
