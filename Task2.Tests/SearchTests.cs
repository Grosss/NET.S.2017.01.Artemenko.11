using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Tests
{
    public class CustomIntComparer : IComparer<int>
    {
        public int Compare(int lhs, int rhs)
        {
            return lhs - rhs;
        }
    }

    public class CustomDoubleComparer : IComparer<double>
    {
        public int Compare(double lhs, double rhs)
        {
            if (lhs - rhs == 0)
                return 0;
            else if (lhs - rhs < 0)
                return -1;
            else return 1;
        }
    }

    [TestFixture]
    public class SearchTests
    {        
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 7, ExpectedResult = 7)]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 11, ExpectedResult = null)]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5, ExpectedResult = 5)]
        public int? BinarySearch_PassedArrayOfIntegersAndValue_ExpectedPositiveTest(int[] array, int value)
        {
            return Search.BinarySearch(array, value);
        }

        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 7, ExpectedResult = 7)]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 11, ExpectedResult = null)]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5, ExpectedResult = 5)]
        public int? BinarySearch_PassedArrayOfIntegersAndValueAndComparer_ExpectedPositiveTest(int[] array, int value)
        {
            var comparer = new CustomIntComparer();
            return Search.BinarySearch(array, value, comparer);
        }

        [TestCase(new double[] { 1.3, 4.6, 12.4, 16.34, 18.356, 24.34, 32.4, 33.5 }, 2, 5, 24.34, ExpectedResult = 5)]
        [TestCase(new double[] { 1.3, 4.6, 12.4, 16.34, 18.356, 24.34, 32.4, 33.5 }, 1, 5, 33.5, ExpectedResult = null)]
        [TestCase(new double[] { 1.3, 4.6, 12.4, 16.34, 18.356, 24.34, 32.4, 33.5 }, 0, 4, 4.6, ExpectedResult = 1)]
        public int? BinarySearch_PassedArrayOfDoublesIndexLengthAndValue_ExpectedPositiveTest(double[] array, int index, int length, double value)
        {
            return Search.BinarySearch(array, index, length, value);
        }

        [TestCase(new double[] { 1.3, 4.6, 12.4, 16.34, 18.356, 24.34, 32.4, 33.5 }, 2, 5, 24.34, ExpectedResult = 5)]
        [TestCase(new double[] { 1.3, 4.6, 12.4, 16.34, 18.356, 24.34, 32.4, 33.5 }, 1, 5, 33.5, ExpectedResult = null)]
        [TestCase(new double[] { 1.3, 4.6, 12.4, 16.34, 18.356, 24.34, 32.4, 33.5 }, 0, 4, 4.6, ExpectedResult = 1)]
        public int? BinarySearch_PassedArrayOfDoublesIndexLengthAndValueAndComparer_ExpectedPositiveTest(double[] array, int index, int length, double value)
        {
            var comparer = new CustomDoubleComparer();
            return Search.BinarySearch(array, index, length, value, comparer);
        }


    }
}
