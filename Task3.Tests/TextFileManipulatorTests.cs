using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3.Tests
{
    [TestFixture]
    public class TextFileManipulatorTests
    {
        [TestCase("File1.txt", "yep", ExpectedResult = 3)]
        [TestCase("File2.txt", "is", ExpectedResult = 3)]
        public int GetWordFrequency_PassedFilePathAndWord(string filePath, string word)
        {
            filePath = Directory.GetCurrentDirectory() + filePath;
            return TextFileManipulator.GetWordFrequency(filePath, word);
        }
    }
}
