internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        void FillArray(int[] collection)
        {
            int lenth = collection.Length;
            int index = 0;
            while (index < lenth)
            {
                collection[index] = int.Parse(Console.ReadLine()!);
                index++;
            }
        }

        Console.WriteLine("Выберете размерность. Введите 2 - 2D система  или 3 - 3D система");
        int n = int.Parse(Console.ReadLine()!);
        if (n == 3 || n == 2)
        {
            int[] array1 = new int[n];
            int[] array2 = new int[n];

            Console.WriteLine($"Вы выбрали {n}-ю значную систему исчесления");

            FillArray(array1);
            FillArray(array2);

            Console.WriteLine();


            int index = 0;
            double distance = 0;

            while (index < n)
            {
                distance = distance + (array2[index] - array1[index]) * (array2[index] - array1[index]);
                index++;
            }
            Console.WriteLine(Math.Sqrt(distance));
        }

        else Console.WriteLine("Ошибка при выборе системы");
    }
}

        /*
        Console.WriteLine("Введите координату х первой точки: ");
        int x1 = int.Parse( Console.ReadLine());
        Console.WriteLine("Введите координату у первой точки: ");
        int y1 = int.Parse( Console.ReadLine());
        Console.WriteLine("Введите координату z первой точки: ");
        int z1 = int.Parse( Console.ReadLine());
        Console.WriteLine("Введите координату x второй точки: ");
        int x2 = int.Parse( Console.ReadLine());
        Console.WriteLine("Введите координату y второй точки: ");
        int y2 = int.Parse( Console.ReadLine());
        Console.WriteLine("Введите координату z второй точки: ");
        int z2 = int.Parse( Console.ReadLine());

        double distance = Math.Sqrt((x2-x1) * (x2-x1) + (y2-y1) * (y2-y1) + (z2-z1) * (z2-z1));

        Console.WriteLine("Расстояние между точками в 3D пространстве = " + distance); */
