using System.Text;
using System;
using System.Collections.Generic;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        public static void RemoveDuplicateWords(ref string text)
        {
            if (text == null)
                throw new ArgumentNullException();
            if (text.Length == 0)
                throw new ArgumentException();

            List<string> l = new List<string>();
            string result = "";
            char[] arr = text.ToCharArray();
            string tempWord = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(arr[i]))
                    tempWord += arr[i];
                else 
                {
                    if (!l.Contains(tempWord))
                    {
                        result += tempWord;
                        l.Add(tempWord);
                    }

                    result += arr[i];
                    tempWord = "";
                }
            }

            text = result;
        }
    }
}