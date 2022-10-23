// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
System.Console.Clear();

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
int m = 3;
float[,] table = ToFillTable(n, m);
ToPrintTable(table);

float row_average = 0;
for (int i=0;i<n;i++)
{
float row_sum = 0;
for (int j=0;j<m;j++)
{
row_sum = row_sum+table[i,j];
}
row_average = row_sum/m;
System.Console.WriteLine($"Среднее арифметическое для {i+1}-ой строки составляет {row_average};");
}

