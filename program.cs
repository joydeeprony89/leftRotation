using System;

namespace Array_Left_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splittedInput = input.Split(' ');
            if(splittedInput.Length == 2 )
            {
                int size = Convert.ToInt32(splittedInput[0]);
                int[] inputArray = new int[size];
                int noOfShifts  = Convert.ToInt32(splittedInput[1]);
                string[] strInputArray = Console.ReadLine().Split(' ');
                if(strInputArray.Length == size && noOfShifts <= size )
                {
                    inputArray = Array.ConvertAll(strInputArray, int.Parse);
                    int start = 0;
                    while(start < noOfShifts)
                    {
                        int temp = inputArray[noOfShifts];
                        int place = inputArray[start];
                        inputArray[start] = temp;
                        inputArray[noOfShifts] = place;
                        start = start + 1;
                    }
                    string result = string.Join(" ", inputArray);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
