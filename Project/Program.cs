internal class Program
{
    private static void Main(string[] args)
    {
        void Zadacha41()
        {
            Console.WriteLine("Введите количество элементов массива");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];

            FillArray(array);
            PrintArray(array);

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество элементов больше нуля равно {count}");
        }
    

        void FillArray(int[] array, int startNum = -100, int finishNum = 100)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(startNum, finishNum);
            }
        }

        void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        Zadacha41();



    }
        
}