﻿// Задание 1: Создать двумерный массив с размерами 3х5 ,
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


// System.Console.WriteLine("Enter the count of rows");
// int rowCount = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter the count of cells");
// int cellCount = Convert.ToInt32(Console.ReadLine());
// int [,] myTable = GetTableOfInts (rowCount, cellCount);
// PrintTable(myTable);

//task2 Наzовем число “интересным” , если сумма цифр четная. Создать двумерный массив ,
// состоящий из целых чисел.
//Вывести на экран”интересные” эл. массива.
Random random = new Random();
int rowCount = random.Next(2,4);
int cellCount = random.Next(2,7);
int [,] myTable = GetTableOfInts(rowCount , cellCount);
PrintTable(myTable);
System.Console.WriteLine();
int Sum ;
for(int i=0 ; i< myTable.GetLength(0) ; i++)
{
    for(int j=0 ; j< myTable.GetLength(1) ; j++)
    {
      Sum = GetSumOfDigits(myTable[i,j]);
      if(IsEven(Sum))
      {
        System.Console.Write(myTable[i,j] + "\t");
      }
    }
}

int GetSumOfDigits(int number)
{
int sum = 0;
while(number > 0)
{
    sum = sum + number%10;
    number = number/10;
}
return sum;
}
bool IsEven(int value)
{
    bool isEven = false;
    if (value%2==0)
    {
        isEven = true;
    }
    return isEven;
}


