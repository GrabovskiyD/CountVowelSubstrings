using System;

namespace CountVowelSubstrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string word = "cuaieuouac";
            Console.WriteLine(CountVowelSubstrings(word));
        }

        public static int CountVowelSubstrings(string word)
        {
            #region The solution with a dictionary
            //int result = 0;
            //int i = 0;
            //Dictionary<char, int> vowels = new();
            //while(word.Length - i >= 5)
            //{
            //    for(int j = i; j < word.Length; j++)
            //    {
            //        if ("aeiou".Contains(word[j]))
            //        {
            //            if (!vowels.ContainsKey(word[j]))
            //            {
            //                vowels.Add(word[j], 1);
            //            }
            //            else
            //            {
            //                vowels[word[j]]++;
            //            }
            //            if(vowels.Count == 5)
            //            {
            //                result++;
            //            }
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    vowels = new();
            //    i++;
            //}
            //return result;
            #endregion
            #region The solution with a HashSet
            //int result = 0;
            //int i = 0;
            //HashSet<char> vowels = new();
            //while (word.Length - i >= 5)
            //{
            //    for (int j = i; j < word.Length; j++)
            //    {
            //        if ("aeiou".Contains(word[j]))
            //        {
            //            if (!vowels.Contains(word[j]))
            //            {
            //                vowels.Add(word[j]);
            //            }
            //            if (vowels.Count == 5)
            //            {
            //                result++;
            //            }
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    vowels = new();
            //    i++;
            //}
            //return result;
            #endregion
            #region The solution with a StringBuilder
            int result = 0;
            int i = 0;
            System.Text.StringBuilder vowels = new();
            while (word.Length - i >= 5)
            {
                for (int j = i; j < word.Length; j++)
                {
                    if ("aeiou".Contains(word[j]))
                    {
                        if (!vowels.ToString().Contains(word[j]))
                        {
                            vowels.Append(word[j]);
                        }
                        if (vowels.Length == 5)
                        {
                            result++;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                vowels = new();
                i++;
            }
            return result;
            #endregion
        }
    }
}