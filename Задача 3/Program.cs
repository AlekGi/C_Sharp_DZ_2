// Задача 3: 
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.WriteLine("Введите целое число от 10 до 99");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9 && number < 100){
    int a = number / 10;
    int b = number % 10;
    if (a > b){
        Console.WriteLine($"Первая цифра {a} больше второй цифры {b}");
    }
    if (b > a){
        Console.WriteLine($"Вторая цифра {b} больше второй цифры {a}");
    }
    if (a == b){
        Console.WriteLine($"Обе цифры равны {a}");
    }
}
if (number < 10 && number > 99)
Console.WriteLine($"Введено некоректное значение");
