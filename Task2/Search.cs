using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class Search
    {
        public static int? BinarySearch<T>(T[] array, T value)
        {
            if (ReferenceEquals(array, null))
                throw new ArgumentNullException();

            return Find(array, 0, array.Length, value, Comparer<T>.Default);
        }
        
        public static int? BinarySearch<T>(T[] array, T value, IComparer<T> comparer)
        {
            if (ReferenceEquals(array, null))
                throw new ArgumentNullException();

            return Find(array, 0, array.Length, value, comparer);
        }       

        public static int? BinarySearch<T>(T[] array, int index, int length, T value)
        {
            if (ReferenceEquals(array, null))
                throw new ArgumentNullException();

            if (index < 0 || length < 0)
                throw new ArgumentOutOfRangeException();

            if (index + length > array.Length)
                throw new ArgumentException();

            return Find(array, index, length, value, Comparer<T>.Default);
        }

        public static int? BinarySearch<T>(T[] array, int index, int length, T value, IComparer<T> comparer)
        {
            if (ReferenceEquals(array, null))
                throw new ArgumentNullException();

            if (index < 0 || length < 0)
                throw new ArgumentOutOfRangeException();

            if (index + length > array.Length)
                throw new ArgumentException();

            return Find(array, index, length, value, Comparer<T>.Default);
        }

        #region Private methods

        private static int? Find<T>(T[] array, int index, int length, T value, IComparer<T> comparer)
        {
            if (array.Length == 0)
                throw new ArgumentException();            

            int leftIndex = index, rightIndex = index + length - 1, middle = 0;

            while (leftIndex <= rightIndex)
            {
                middle = (leftIndex + rightIndex) / 2;

                if (comparer.Compare(value, array[middle]) == 0)
                    return middle;
                else if (comparer.Compare(value, array[middle]) < 0)
                    rightIndex = middle - 1;
                else
                    leftIndex = middle + 1;
            }

            return null;
        }

        #endregion
    }
}
