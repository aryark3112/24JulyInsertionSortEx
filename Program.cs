using System;
namespace InsertionSort
{
    internal class Program
    {
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for(int i=1;i<n;i++)
            {
                int key = arr[i];
                int j = i - 1;
                while(j>=0 && arr[j]>key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] arr = { 7,4,5,2 };
            Console.WriteLine("Print Array without Sort");
            Print(arr);
            InsertionSort(arr);
            Console.WriteLine("After Insertion Sort");
            Print(arr);
            Console.ReadKey();
        }
    }
}
