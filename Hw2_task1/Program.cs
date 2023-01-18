Console.Clear();
Console.WriteLine("Ввод номера недели от 1 до 7");

int dayNumber = new Random().Next(1, 8);
string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };


if (dayNumber > 5) Console.WriteLine($"{dayNumber}-й день недели - это {Days[dayNumber - 1]}. Выходной день!");
else Console.WriteLine($"{dayNumber}-й день недели - это {Days[dayNumber - 1]}. Рабочий день!");

