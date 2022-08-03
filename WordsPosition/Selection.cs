using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsPosition
{
    public class Selection
    {
        public static string GetPosition(string text)
        {
            Dictionary<int, string> WordList = new Dictionary<int, string>();
            char[] consonants = { 'й', 'Й', 'ц', 'Ц', 'к', 'К', 'н', 'Н', 'г', 'Г', 'ш', 'Ш', 'щ', 'Щ', 'з', 'З', 'х', 'Х', 'ъ', 'Ъ', 'ф', 'Ф', 'в', 'В', 'п', 'П', 'р', 'Р', 'л', 'Л', 'д', 'Д', 'ж', 'Ж', 'ч', 'Ч', 'с', 'С', 'м', 'М', 'т', 'Т', 'б', 'Б' };
            string[] words = text.ToLower().Split(new char[] { '-', '.', '?', '!', ')', '(', ',', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            char[] symbols;
            string result = "";
            for (int x = 0; x < words.Length; x++)
            {
                symbols = words[x].ToCharArray();
                for (int i = 0; i < symbols.Length-1; i++)
                {
                    int j = i + 1;
                        if (consonants.Contains(symbols[j]) == true) 
                        {
                            if (consonants.Contains(symbols[i]) == true)
                            {
                            {
                                WordList.Add((x + 1), words[x]);
                                i = symbols.Length;
                            }
                            }
                    }
                }

            }

            foreach (var word in WordList)
            {
                result = result + word.Value + " " + word.Key + ", ";
            }
                result = result.Substring(0, result.Length - 2);
                return result;
        }
    }
}
