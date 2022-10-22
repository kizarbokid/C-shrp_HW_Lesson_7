/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. */
System.Console.Clear();

string ToInputVar(string input_text)
{
    Console.Write($"Введите {input_text} и нажмите Enter: ");
    string result = Console.ReadLine();
    return result;
}


string input_text = "количество строк таблицы";
int n = int.Parse(ToInputVar(input_text));
input_text = "количество столбцов таблицы";
int m = int.Parse(ToInputVar(input_text));

float[,] table = new float[n, m];
var rand = new Random();
for (int i = 0; i < n; i++)
{
    Console.Write($"{i+1}-я:  ");
    for (int j = 0; j < m; j++)
    {

        table[i, j] = rand.NextSingle() * rand.Next(-100, 101);
        string formating_result = string.Format("{0:f}",table[i,j]);
        Console.Write($"{formating_result} ");
    }
    Console.WriteLine();
}