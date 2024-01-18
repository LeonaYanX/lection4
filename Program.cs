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


// System.Console.WriteLine("Enter the count of rows");
// int rowCount = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter the count of cells");
// int cellCount = Convert.ToInt32(Console.ReadLine());
// int [,] myTable = GetTableOfInts (rowCount, cellCount);
// PrintTable(myTable);

//task2 Наzовем число “интересным” , если сумма цифр четная. Создать двумерный массив ,
// состоящий из целых чисел.
//Вывести на экран”интересные” эл. массива.
// Random random = new Random();
// int rowCount = random.Next(2,4);
// int cellCount = random.Next(2,7);
// int [,] myTable = GetTableOfInts(rowCount , cellCount);
// PrintTable(myTable);
// System.Console.WriteLine();
// int Sum ;
// for(int i=0 ; i< myTable.GetLength(0) ; i++)
// {
//     for(int j=0 ; j< myTable.GetLength(1) ; j++)
//     {
//       Sum = GetSumOfDigits(myTable[i,j]);
//       if(IsEven(Sum))
//       {
//         System.Console.Write(myTable[i,j] + "\t");
//       }
//     }
// }

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

// Задача 3: Считать с консоли строку , состоящую из цыфр и латинских букв.
// Сформировать новую строку из букв исходной строки.
string GetStringFromConsole()
{
    System.Console.WriteLine("Enter the string");
    string str = Console.ReadLine();
    return str;
}
string GetLetterFromString (string str)
{
    string Letters = "";
    foreach (char e in str)
    {
        if(char.IsAsciiLetter(e) == true)
        {
            Letters = Letters + e;
        }
    }
    return Letters;
}
// string myStr = GetStringFromConsole();
// string myOnlyLetters = GetLetterFromString(myStr);
// System.Console.WriteLine(myOnlyLetters);

// ДЗ: Считать с консоли строку из цифр и латинских букв , сформировать массив состоящий из
//  цыфр этой строки, с функциями и под массив место не болше чем количество чисел.
string mySTR = GetStringFromConsole();
void PrintArray(int [] array)
{
    for(int i=0 ; i< array.Length ; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}
int CountOfDigitsInString (string str)
{
    int CountOfints = 0;
    foreach(char e in str)
    {
        if(char.IsAsciiLetter(e)==false)
        {
            CountOfints +=1;
            
        }

    }
    
    return CountOfints;
}
string  GetNumbersInString (string str)
{
string Numbers = "";
foreach(char e in str)
{ 
    if(char.IsAsciiLetter(e)==false)
    {
        Numbers = Numbers + e; 
    }
}
return Numbers;
}
string onlyNumbers = GetNumbersInString(mySTR);
int [] myArray = new int[CountOfDigitsInString(str)];
int Num = Convert.ToInt32(onlyNumbers);
int [] GetArrayFromDigitsOfNum(int Num)
{
    
}

    