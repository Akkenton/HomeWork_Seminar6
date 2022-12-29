// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// ВНИМАНИЕ. Обработчик входящих параметров при паралельных прямых, или прямых, лежащих друг на друге
// писать не стал. В связи с этим возможен вывод (не число, не число)

// ------------------- START ------------------------
int EnterNum(string message) // метод для ввода числа пользователем
{
    System.Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void FindCenter(float b1, float b2, float k1, float k2, out float coordX, out float coordY) // вычисляем координаты точки пересечения
{
    coordX = (b2 - b1) / (k1 - k2);
    coordY = k1 * coordX + b1;
}

Console.Clear();
float b1 = EnterNum("Введите b1: ");
float k1 = EnterNum("Введите k1: ");
float b2 = EnterNum("Введите b2: ");
float k2 = EnterNum("Введите k2: ");

FindCenter(b1, b2, k1, k2, out float coordX, out float coordY);

System.Console.WriteLine($"Точка пересечения прямой: ({coordX},{coordY})");

// -------------------  END  ------------------------