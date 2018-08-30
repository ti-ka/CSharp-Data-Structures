using System;
using System.Linq;

namespace dotnet
{
    public class SortArrays
    {

        public static void Test() {
            print(insertionSort(new int[] { 3, 2, 6, 4 } ));
            Console.WriteLine(binarySearch(new int[] { 1, 2, 3, 4, 5, 6, 8, 19 }, 4));
            Console.WriteLine(binarySearch(new int[] { 1, 2, 3, 4, 5, 6, 8, 19 }, 1));
            Console.WriteLine(binarySearch(new int[] { 1, 2, 3, 4, 5, 6, 8, 19 }, 8));
            Console.WriteLine(binarySearch(new int[] { 1, 2, 3, 4, 5, 6, 8, 19 }, 19));
        }

        public static void print(int[] arr) {
            Console.WriteLine(string.Join(", ", arr));
        }

        public static int[] insertionSort(int[] arr) {

            // We can start from index 1 because it has no 
            // previous value to test with.
            for(int i = 1; i < arr.Length; i++) {

                var marker = i;
                while (marker > 0) {
                    
                    if (arr[marker - 1] <= arr[marker])
                        break;
                        
                    swap(arr, marker - 1, marker);
                    marker--;
                }
               
            }

            return arr;
        }
    
        public static int binarySearch(int[] arr, int search) {
            return binarySearch(arr, search, 0, arr.Length - 1);
        }

        public static int binarySearch(int[] arr, int search, int leftIndex, int rightIndex) {
            if (rightIndex < leftIndex) {
                return -1;
            }
            int mid = leftIndex + (rightIndex - leftIndex) / 2;
            if (search == arr[mid]) {
                return mid;
            }  else if (search < arr[mid]) {
                return binarySearch(arr, search, leftIndex, mid - 1);
            } else {
                return binarySearch(arr, search,  mid + 1, rightIndex);
            }
        }

        public static void swap(int[] arr, int i, int j) {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}