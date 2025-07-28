namespace MethodParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 3, 10, 7, 8, 1, 2, 5, 9, 6 };
            //Console.WriteLine(GetMin(numbers));

            //int[] sorted = SortArray(numbers);
            //for (int i = 0; i < sorted.Length; i++)
            //{
            //    Console.WriteLine(sorted[i]);
            //}
            Console.WriteLine(GetPower(5,3));
            Console.WriteLine(GetPower(8));

        }

        public static int GetMin(int[] numbers)
        {
            int min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;

        }
        public static int[] SortArray( int[] numbers)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j + 1] < numbers[j])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }

                }
            }

            return numbers;



        }
        public static int GetPower(int number, int power = 2)
        {
            int result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;

        }


    }


}
