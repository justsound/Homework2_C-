Console.WriteLine("Введите первое целое число ");
int number1 = int.Parse( Console.ReadLine());
Console.WriteLine("Введите второе целое число ");
int number2 = int.Parse( Console.ReadLine());
int square = number2 * number2;
if (number1 == number2*number2) Console.WriteLine("Является");
else if (number2 == number1*number1) Console.WriteLine("Является");
else Console.WriteLine("Не является");