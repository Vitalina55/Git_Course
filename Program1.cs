using System;

namespace project_Vitalina
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int[] myArray = new int[5];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Write element of index " + i + ":  ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Current array: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }

            int max = myArray[0];
            int min = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > max)
                    max = myArray[i];
                if (myArray[i] < min)
                    min = myArray[i];
            }

            Console.WriteLine("\nMax in array is " + max);
            Console.WriteLine("Min in array is " + min);
            Console.ReadLine();
		}
	}
}
