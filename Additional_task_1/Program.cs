// Дан двумерный массив и два числа: i и j. Поменяйте в массиве столбцы с номерами i и j и выведите результат.
// Решение оформите в виде функции swap_columns(a, i, j).
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
float[,] ToSwapColumns(float[,] table, int swap_column_1, int swap_column_2)
{
    float[] temp = new float[table.GetUpperBound(0) + 1];
    int rows = table.GetUpperBound(0) + 1;    // количество строк
    int columns = table.Length / rows;        // количество столбцов
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (j == swap_column_1 - 1)
            {
                temp[i] = table[i, j];
                table[i, j] = table[i, swap_column_2 - 1];
                table[i, swap_column_2 - 1] = temp[i];
            }
        }
    }
    return table;
}

string input_text = "количество строк таблицы";
int n = int.Parse(ToInputVar(input_text));
input_text = "количество столбцов таблицы";
int m = int.Parse(ToInputVar(input_text));
float[,] table = ToFillTable(n, m);
ToPrintTable(table);

input_text = "номер столбца таблицы который вы хотите поменять";
int swap_column_1 = int.Parse(ToInputVar(input_text));
input_text = "с которым столбцом таблицы вы хотите поменять";
int swap_column_2 = int.Parse(ToInputVar(input_text));
ToPrintTable(ToSwapColumns(table, swap_column_1, swap_column_2));