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

        void Zadacha43()
        {
            Console.WriteLine("Введите значение b1");
            double b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение k1");
            double k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение b2");
            double b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение k2");
            double k2 = Convert.ToInt32(Console.ReadLine());

            double X = 0;
            double Y = 0;
            if (k1 == k2) Console.WriteLine("прямые не пересекаются - параллельны");
            else
            {
                X = Math.Round(((b2-b1)/(k1-k2)), 1);
                Y = Math.Round((X*k2 + b2), 1);
                Console.WriteLine($"точка пересечения прямых находиться по координатам {(X, Y)}");
            }
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
        
        
        //Zadacha41();
        Zadacha43();
    }
}