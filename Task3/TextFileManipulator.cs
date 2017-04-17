using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Task3
{
    public static class TextFileManipulator
    {
        public static int GetWordFrequency(string filePath, string word)
        {
            if (ReferenceEquals(filePath, null) || ReferenceEquals(word, null))
                throw new ArgumentNullException();

            string text = File.ReadAllText(filePath).ToUpperInvariant();

            return new Regex($@"(?i)\b{word}\b").Matches(text).Count;
        }
    }
}
