using NUnit.Framework;
using QuickSort;
using System.Linq;

namespace QuickSortTest
{
    class QuickSortTest
    {
        [Test]
        public void TestCase1()
        {
            int[] array = { 22, 77, 999, 99, 88, 55, 33, 11 };
            int[] arrayNotSorted = { 22, 77, 999, 99, 88, 55, 33, 11 };
            int[] arraySorted = { 11, 22, 33, 55, 77, 88, 99, 999 };

            QuckSortSolution.QuickSort(array);

            Assert.That(!Enumerable.SequenceEqual(array, arrayNotSorted), Is.True);
            Assert.That(Enumerable.SequenceEqual(array, arraySorted), Is.True);
        }

        [Test]
        public void TestCase3()
        {
            int[] array = { 3,6,4,8,1,5 };
            int[] arrayNotSorted = { 22, 77, 999, 99, 88, 55, 33, 11 };
            int[] arraySorted = { 1, 3, 4, 5, 6, 8 };

            QuckSortSolution.QuickSort(array);

            Assert.That(!Enumerable.SequenceEqual(array, arrayNotSorted), Is.True);
            Assert.That(Enumerable.SequenceEqual(array, arraySorted), Is.True);
        }



        [Test]
        public void TestCase2()
        {
            int[] array = { 22, 77, 999, 99, 88, 55, 33, 11 };
            int[] arrayNotSorted = { 22, 77, 999, 99, 88, 55, 33, 11 };
            int[] arraySorted = { 11, 22, 33, 55, 77, 88, 99, 999 };

            QuickSortSolution2.QuickSort(array);

            Assert.That(!Enumerable.SequenceEqual(array, arrayNotSorted), Is.True);
            Assert.That(Enumerable.SequenceEqual(array, arraySorted), Is.True);
        }

    }
}
