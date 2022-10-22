/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. */
System.Console.Clear();
string ToInputVar(string input_text)
{
    Console.Write($"Введите {input_text} и нажмите Enter: ");
    string result = Console.ReadLine();
    return result;
}
float[,] ToFillTable(int n, int m)
{
    float[,] table = new float[n, m];
    var rand = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        { table[i, j] = rand.NextSingle() * rand.Next(-100, 101); }
    }
    return table;
}
void ToPrintTable(float[,] table)
{
    int rows = table.GetUpperBound(0) + 1;    // количество строк
    int columns = table.Length / rows;        // количество столбцов
    for (int i = 0; i < rows; i++)
    {
        Console.Write($"{i + 1}-я:  ");
        for (int j = 0; j < columns; j++)
        {
            string formating_result = string.Format("{0:f}", table[i, j]);//форматирование: оставить 2 знака после запятой
            Console.Write($"|{formating_result}    ");
        }
        Console.WriteLine();
    }
}

string input_text = "количество строк таблицы";
int n = int.Parse(ToInputVar(input_text));
input_text = "количество столбцов таблицы";
int m = int.Parse(ToInputVar(input_text));
ToPrintTable(ToFillTable(n, m));