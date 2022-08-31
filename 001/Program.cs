// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int a = Prompt("Введите колличество чисел, которые хотите проверить = ");
int result = 0;
for (int i = 0; i < a; i++)
{

    int b = Prompt("Введите число = ");
    if (b % 2 == 0)
    {
        result++;
    }
}
System.Console.WriteLine($"Колличество четных чисел = {result}");