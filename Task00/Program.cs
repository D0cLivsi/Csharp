// Задача 0ю Напишите программу, которая на вход
// 1. принимает число  
// 2. выдаёт его квадрат (число
// умноженное на само себя).
// 3. вывод результата

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
//ВАРИАНТ1 int num = int.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
Console.WriteLine($"Квадрат числа {num} = {square}");

//Console.WriteLine("Квадрат числа" + num + "=" = square); - 2 вариант конкатенация
//от -2 147 483 648  до 2 147 483 647

