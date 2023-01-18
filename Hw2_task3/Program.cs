Console.Clear();
Console.WriteLine("Ввод номера четверти от 1 до 4: ");

int num = new Random().Next(1, 5);

if (num == 1) Console.WriteLine($"Для {num}-й четверти координаты точки должны быть заданы в диапазоне x > 0, y > 0");
else if (num == 2) Console.WriteLine($"Для {num}-й четверти координаты точки должны быть заданы в диапазоне x > 0, y < 0");
else if (num == 3) Console.WriteLine($"Для {num}-й четверти координаты точки должны быть заданы в диапазоне x < 0, y < 0");
else Console.WriteLine($"Для {num}-й четверти координаты точки должны быть заданы в диапазоне x < 0, y > 0");

  