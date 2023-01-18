Console.Clear();
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

void FillArray (int[] collection)
{
    int lenth = collection.Length;
    int index = 0;
    while (index < lenth)
    {
        collection[index] = int.Parse(Console.ReadLine());
        index ++;
    }
}
