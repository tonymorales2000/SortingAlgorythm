using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class QuckSortSolution
    {
        public static void QuickSort(int [] array)
        {
            System.Diagnostics.Debug.WriteLine("");
            for (var i = 0; i < array.Count(); i++)
            {
                System.Diagnostics.Debug.Write("|" + array[i]);
            }
            System.Diagnostics.Debug.WriteLine("");
            QuickSort(array, 0, array.Length - 1);
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if(left >= right)
            {
                return;
            }

            int pivot = array[(left + right) / 2];//array[left];//
            //System.Diagnostics.Debug.WriteLine(" -------------- pivot = " + pivot + " " + " left:" + left + " right:"+right  + " pivot index: " + (left + right) / 2);
            int partionPoint  = Partition(array, left, right, pivot);
            //System.Diagnostics.Debug.WriteLine("--PARTITION POINT " + partionPoint);
            System.Diagnostics.Debug.WriteLine("AA Sort from left:" + left + " right:" + (partionPoint - 1));
            QuickSort(array, left, partionPoint - 1); // left side
            System.Diagnostics.Debug.WriteLine("BB Sort from left:" + partionPoint + " right:" + right);
            QuickSort(array, partionPoint, right); // right side
        }

        private static int Partition(int[] array, int left, int right, int pivot)
        {
            System.Diagnostics.Debug.WriteLine("Pivot : " + pivot);
            //System.Diagnostics.Debug.WriteLine("Partition Moving " + left + " and " + right);
            while (left <= right) // moving 
            {
                //System.Diagnostics.Debug.WriteLine("--Moving " + left + " and " + right);
                int leftValue = array[left];
                //System.Diagnostics.Debug.WriteLine("--LeftValue " + leftValue + " < " + pivot);
                while (leftValue < pivot) // while number on the left are less than the pivot then keep moving to the right
                {
                    left++;
                    leftValue = array[left];
                    //System.Diagnostics.Debug.WriteLine("--Left Moving " + left + " and " + right);
                    //System.Diagnostics.Debug.WriteLine("--LeftValue " + leftValue + " < " + pivot);
                }

                int rightValue = array[right];
                //System.Diagnostics.Debug.WriteLine("--RightValue " + rightValue + " > " + pivot);
                while (rightValue > pivot) // while number on the right are greater than the pivot then keep moving to the left
                {
                    right--;
                    rightValue = array[right];
                    //System.Diagnostics.Debug.WriteLine("--Right Moving " + left + " and " + right);
                    //System.Diagnostics.Debug.WriteLine("--RightValue " + rightValue + " > " + pivot);
                }

                if(left <= right)
                {
                    System.Diagnostics.Debug.WriteLine("Swapping " + array[left] + " and " + array[right]);
                    Swap(array, left, right);
                    left++;
                    right--;


                    for (var i=0; i < array.Count(); i++)
                    {
                        System.Diagnostics.Debug.Write( "|" + array[i]);
                    }
                    System.Diagnostics.Debug.WriteLine("");
                }
            }
            return left;
        }

        private static void Swap(int[] array, int left, int right)
        {
            int tmp = array[left];
            array[left] = array[right];
            array[right] = tmp;
        }
    }
}
