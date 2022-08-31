//Задача 3. Со Звездочкой (*). Сгенерировать двумерный массив со случайными числами, 
//вывести его на экран, оформить в виде функций (пригодится в дальнейшем)


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int[,] CreateMatrix(int rows, int columns)
{
    int[,] answer = new int[rows, columns];
    Random rnd = new Random();
    

    for (int i = 0; i < rows; i++)
    {
        
        for (int j = 0; j < columns; j++)
        {
            answer[i, j] = rnd.Next(-100, 100);
               
        }

    }
    
    
    return answer;
}

void PrintArray(int[,] array, int rows, int columns)
{

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i,j] + "\t");       
        }

        Console.WriteLine();
    }
    
    Console.WriteLine();
}

int rows = Prompt("Введите колличество строк = ");
int columns = Prompt("Введите колличество столбцов =");

PrintArray(CreateMatrix(rows, columns), rows, columns);

