// Задача 4: 
// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

// Console.WriteLine("Введите натуральное число");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 0 && number < 100){
//     int [] array = new int [2];
// for (int i = 0; i < array.Length; i++ ){
//     array[0] = number / 10;
//     array[1] = number % 10;
//     Console.Write(array[i] + ", ");
// }
// }
// if (number > 99 && number < 1000){
//     int [] array = new int [3];
// for (int i = 0; i < array.Length; i++ ){
//     array[0] = number / 100;
//     array[1] = number % 10;
//     array[2] = number % 10

//     Console.Write(array[i] + ", ");
// }
// }


Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10){
    Console.WriteLine(number);
}
else{
    while (number > 0){
        int result = number % 10;
        number /= 10;
        if (number > 0){
            Console.Write(result + ",");
        }
        else{
        Console.WriteLine(result);
        }
    }
}

// Пытался все через массивы сделать, но получалось очень громоздко и не понимаю, как сделать динамический массив, чтобы не продумывать каждый раз новое значение массива.
// Развернуть обратно цифры (числа) не получилось