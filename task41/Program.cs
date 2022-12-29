// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// ------------------- START ------------------------

// РЕШЕНИЕ №1 - с объявлением массива ---------------------

Console.Clear();
System.Console.WriteLine("Количество чисел: "); // Так как в задаче есть переменная М, логично предположить что количество чисел задается заранее.
int M = int.Parse(Console.ReadLine());
int FindPolCount(int countNum)
{
    int count = 0; // счетчик положительных чисел
    int[] arr = new int[M]; //объявляем массив, куда складываем введенные пользователем числа
    for (int i = 0; i < M; i++)   // заполняем массив
    {
        System.Console.WriteLine("Введите число: ");
        arr[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < arr.Length; i++) // подсчитываем количество положительных чисел
    {
        if (arr[i] > 0) count++;
    }
    return count;
}
System.Console.WriteLine($"Количество положительных чисел в массиве: {FindPolCount(M)}");


// РЕШЕНИЕ №2 - без объявления массива(в задаче не сказано про использование массива в принципе) -----
// Console.Clear();
// System.Console.WriteLine("Количество чисел: ");
// int M = int.Parse(Console.ReadLine());

// int FindPolCount(int countNum)
// {
//     int count = 0; // счетчик положительных чисел
//     int bufer = 0; // буферная переменная, для временного хранения числа от пользователя
//     for (int i = 0; i < countNum; i++)
//     {
//         System.Console.WriteLine("Введите число: ");
//         bufer = int.Parse(Console.ReadLine());
//         if (bufer > 0) count++;
//     }
//     return count;
// }

// System.Console.WriteLine($"Количество положительных чисел: {FindPolCount(M)}");
// -------------------  END  ------------------------