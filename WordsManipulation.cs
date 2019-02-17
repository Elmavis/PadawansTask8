using System.Text;
using System;
using System.Collections.Generic;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        private static bool IsDelim(char ch)
        {
            char[] delims = { '.', ',', '!', '?', '-', ':', ';', ' ' };

            for (int i = 0; i < delims.Length; i++)
                if (ch == delims[i])
                    return true;

            return false;
        }

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
                if (Char.IsLower(arr[i]))
                    tempWord += arr[i];
                else if (IsDelim(arr[i]))
                {
                    if (!l.Contains(tempWord))
                    {
                        result += tempWord;
                        l.Add(tempWord);
                    }

                    result += arr[i];
                    tempWord = "";
                }
                else
                    throw new ArgumentException();
            }

            text = result;
        }
    }
}