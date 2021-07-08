using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = { 4, 5, 6, 3, 7, 2, 3 };
            Console.WriteLine( LinearSearch(A, 66));


           
        }

        public static int LinearSearch(int [] A , int key )
        {
            int index=0;
            while(index< A.Length)
            {
                if (key == A[index])
                    return key;
                index++;
            }
            return -1;
        }
    }
}
