namespace RotateArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 1, 2, 3, 4, 5 };
            int[] rotateArray = RotateArray(inputArray);

            Console.WriteLine(string.Join(", ", rotateArray));
        }

        public static int[] RotateArray(int[] array)
        {
            int[] rotateArray = new int[array.Length];

            rotateArray[array.Length - 1] = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                rotateArray[i] = array[i + 1];     
            }

            return rotateArray;
        }
    }
}
