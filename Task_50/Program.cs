/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. */

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

int n = 5;
int m = 10;
float[,] table = ToFillTable(n, m);
ToPrintTable(table);

string input_text = "элемент которой строки Вы ищете";
int find_row = int.Parse(ToInputVar(input_text));
input_text = "элемент которого стролбца Вы ищете";
int find_column = int.Parse(ToInputVar(input_text));

if ((find_row <= table.GetUpperBound(0) + 1) &&
    (find_column <= table.Length / (table.GetUpperBound(0) + 1)))//&& - логич "И"
{ System.Console.WriteLine($"Искомый элемент = {table[find_row - 1, find_column - 1]};"); }
else { System.Console.WriteLine("В массиве нет такого элемента!"); }

