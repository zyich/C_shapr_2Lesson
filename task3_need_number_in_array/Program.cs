﻿int [] array = { 1 , 12, 31, 4, 18, 15, 16, 17, 18 };

int  n = array.Length; // возвращает длину массива (показывает сколько там числе , сслыка на массив)
int find  =  18 ;

int index = 0 ;

while (index  < n )
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; //прервет действие если оно выполнено
    }
    index++ ;
}