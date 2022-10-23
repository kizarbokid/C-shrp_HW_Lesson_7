// Заполнить двумерный массив змейкой из чисел от 1 до N
System.Console.Clear();
string ToInputVar(string input_text)
{
    Console.Write($"Введите {input_text} и нажмите Enter: ");
    string result = Console.ReadLine();
    return result;
}
int[,] ToFillTable(int n, int m)
{
    int[,] table = new int[n, m];
    int count =1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        { table[i, j] =  count;
        count++; }
    }
    return table;
}
void ToPrintTable(int[,] table)
{
    int rows = table.GetUpperBound(0) + 1;    // количество строк
    int columns = table.Length / rows;        // количество столбцов
    for (int i = 0; i < rows; i++)
    {
        Console.Write($"{i + 1}-я:  ");
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"|{table[i,j]}    ");
        }
        Console.WriteLine();
    }
}

string input_text = "количество строк таблицы";
int n = int.Parse(ToInputVar(input_text));
input_text = "количество столбцов таблицы";
int m = int.Parse(ToInputVar(input_text));
int[,] table = ToFillTable(n, m);
ToPrintTable(table);