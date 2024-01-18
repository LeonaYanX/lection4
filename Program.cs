// Задание 1: Создать двумерный массив с размерами 3х5 ,
//  состоящий из целых чисел и вывести элементы на экран.
int [,] GetTableOfInts (int rowsNum , int cellsNum)
{
    int [,] Table = new int [rowsNum , cellsNum];
    Random random = new Random();
    for(int i = 0 ; i<Table.GetLength(0) ; i++)
    {
        for(int j = 0 ; j< Table.GetLength(1); j++)
        {
            Table[i,j] = random.Next(1,1000);
        }
    }
    return Table;
} 
void PrintTable(int [,] table)
{
    for(int i=0 ; i< table.GetLength(0); i++)
    {
        for(int j =0 ; j<table.GetLength(1);j++)
        {
            Console.Write(table[i,j]+"\t");
        }
        Console.WriteLine();
    }
    
}


System.Console.WriteLine("Enter the count of rows");
int rowCount = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the count of cells");
int cellCount = Convert.ToInt32(Console.ReadLine());
int [,] myTable = GetTableOfInts (rowCount, cellCount);
PrintTable(myTable);


