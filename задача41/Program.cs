// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите множество чисел, через Enter");
int M = int.Parse(Console.ReadLine());
int[] Numbers = new int[M];

void YourNumbers(int M)
{
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine($" {i}");
        Numbers[i] = int.Parse(Console.ReadLine());
    }
}
int Positive(int[] Numbers)
{
    int count = 0;
    for (int i = 0; i < Numbers.Length; i++)
    {
        if (Numbers[i] > 0) count++;
    }
    return count;
}

YourNumbers(M);

Console.WriteLine($"Введено чисел больше 0: {Positive(Numbers)} ");

