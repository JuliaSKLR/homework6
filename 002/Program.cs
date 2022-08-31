//Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y1 = k1 * x + b1, y2 = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//в точке пересечения у прямых будут одинаковые координаты, поэтому у1 приравняем к у2


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

double k1 = Prompt("Введите значение K1 ");
double b1 = Prompt("Введите значение b1 ");
double k2 = Prompt("Введите значение K2 ");
double b2 = Prompt("Введите значение b2 ");

//k1*x + b1 = k2*x + b2;
//k1*x - k2*x = b2- b1;
double x = (b2-b1)/(k1-k2);
double y = k1 * x + b1;

System.Console.WriteLine($"Координаты пересечения ({x} ; {y})");

