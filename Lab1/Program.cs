using System;
namespace CSlabPrograms
{
    class P1
    {
        void Addition()
        {
            int[] arr = new int[10];
            int sum = 0;
            Console.WriteLine("Enter the values in array:\n");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of array values: " + sum);
        }
        void Average()
        {
            float[] arr = new float[10];
            float sum = 0;
            float avg = 0;
            Console.WriteLine("Enter the values in array:\n");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + arr[i];
            }
            avg = sum / 10;
            Console.WriteLine("Average of array values: " + avg);
        }
        void Largest()
        {
            int[] arr = new int[10];
            int l = 0;
            Console.WriteLine("Enter the values in array:\n");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                l = arr[i];
                if (arr[i] > l)
                {
                    l = arr[i];
                }
            }
            Console.WriteLine("Largest value in array: " + l);
        }
        void EvenOdd()
        {
            int[] arr = new int[10];
            int n = 0;
            int n2 = 0;
            Console.WriteLine("Enter the values in array:\n");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    n++;
                }
                else
                {
                    n2++;
                }
            }
            Console.WriteLine("Even values in array: " + n);
            Console.WriteLine("Odd values in array: " + n2);
        }
        void Reverse()
        {
            int[] arr = new int[10];
            int temp = 0;
            int n = 0;
            Console.WriteLine("Enter the values in array:\n");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            temp = arr[9];
            for (int i = 9; i > 0; i--)
            {
                arr[i] = arr[n];
                n++;
            }
            arr[0] = temp;
            Console.WriteLine("Reverse of this array: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr[i]);
            }
        }
        void MultiplySpecfic()
        {
            int[] arr = new int[10];
            int n;
            Console.WriteLine("Enter the values in array:\n");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the Factor:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                arr[i] = arr[i] * n;
            }
            Console.WriteLine("After multiplying array with factor: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr[i]);
            }
        }
        void FindIndex()
        {
            int[] arr = new int[10];
            int n;
            int temp = 0;
            Console.WriteLine("Enter the values in array:\n");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the value to find index:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] == n)
                    temp = i;
            }
            if (temp != 0)
                Console.WriteLine("Index of this value in array: " + temp);
            else
            {
                Console.WriteLine("This value is not in this array");
            }
        }
        void SecondSmallest()
        {
            int[] arr = new int[10];
            int n;
            Console.WriteLine("Enter the values in array:\n");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        arr[i + 1] = arr[i];
                    }
                }
            }
            n = arr[8];
            Console.WriteLine("Second smallest element: " + n);
        }
        void RemoveDuplicate()
        {
            int[] arr = new int[10];
            int[] arr1 = new int[10];
            int temp = 0;
            Console.WriteLine("Enter the values in array:\n");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (arr[i] != arr[j])
                    {
                        arr1[i] = arr[i];
                        temp++;
                    }
                }
            }
            Console.WriteLine("Distinct values in array: ");
            for (int i = 0; i < temp; i++)
            {
                Console.Write(arr1[i] + " ");
            }

        }
        void DistinctValuesInArray()
        {
            int[] arr = new int[10];
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int temp = 0;
            Console.WriteLine("Enter the values in array:\n");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the values in array:\n");
            for (int i = 0; i < 10; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (arr[i] == arr1[j])
                    {
                        arr2[i] = arr[i];
                        temp++;
                    }
                }
            }
            Console.WriteLine("Distinct values in array: ");
            for (int i = 0; i < temp; i++)
            {
                Console.Write(arr2[i] + " ");

            }
        }
        public static void Main(String[] args)
        {
            P1 obj = new P1();
            obj.Addition();
            obj.Average();
            obj.EvenOdd();
            obj.Largest();
            obj.Reverse();
            obj.RemoveDuplicate();
            obj.MultiplySpecfic();
            obj.FindIndex();
            obj.SecondSmallest();
            obj.DistinctValuesInArray();
            Console.ReadKey();
        }
    }
}


