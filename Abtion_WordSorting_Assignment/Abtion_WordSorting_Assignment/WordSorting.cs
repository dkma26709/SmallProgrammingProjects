using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtion_WordSorting_Assignment
{
    public class WordSorting
    {
        // List of vowels to check against
        List<char> wordLetterList = new List<char>() {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        // string to be appended in AddWordend()
        public string WordEnder { get; set; } = "ay";



        // V1


        // If the word starts with a consonant, move ot two the end of the word and add the "wordEnder" string to the ned of the word
        // happy would become apphay (given the "WordEnder="ay")
        public string OneConsonantSortV1(string word)
        {
            List<char> letters = word.ToCharArray().ToList();

            if (!wordLetterList.Contains(letters[0]))
            {
                char TempLetter = letters[0];
                letters.RemoveAt(0);
                letters.Add(TempLetter);
            }

            return AddWordEnd(String.Concat(letters));
        }

        private string AddWordEnd(string word)
        {
            return word + WordEnder;
        }

        //Essentialy the same as the OneConsonantSortV1-method, with the alteration that the letters are only moved if the two first letters are consonants
        public string TwoConsonantSort(string word)
        {
            List<char> letters = word.ToCharArray().ToList();

            if (!wordLetterList.Contains(letters[0]) && !wordLetterList.Contains(letters[1]))
            {
                char TempLetter_1 = letters[0];
                char TempLetter_2 = letters[1];
                letters.RemoveRange(0, 2);
                letters.Add(TempLetter_1);
                letters.Add(TempLetter_2);
            }

            return AddWordEnd(String.Concat(letters));
        }

        // V2

        
        // a shorter more concise version of the V1 using the built in methods for chars and string in place of making a list.
        public string OneConsonantSortV2(string word)
        {
            if (!wordLetterList.Contains(word[0]))
                word = String.Concat(word.Append(word[0])).Substring(1);

            return AddWordEnd(String.Concat(word));
        }

        // Generalized version of prior mehtods
        public string ConsonantSort(int nrOfConsonantsToCheck, string word)
        {
            List<char> TempListofLetters = new List<char>();

            for (int i = 0; i < nrOfConsonantsToCheck; i++)
            {
                if (!wordLetterList.Contains(word[i]))
                {
                    TempListofLetters.Add(word[i]);
                }
            }

            if (TempListofLetters.Count == nrOfConsonantsToCheck)
            {
                word = word.Substring(nrOfConsonantsToCheck);

                for (int i = 0; i < nrOfConsonantsToCheck; i++)
                {
                    word = String.Concat(word.Append(TempListofLetters[i]));
                }
            }
            return AddWordEnd(word);
        }

    }
}
