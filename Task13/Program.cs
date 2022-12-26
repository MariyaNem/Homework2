//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 999)
{
    while (number > 999)
    {
        number = number / 10;
    }
}

int third = number % 10;
bool result = number > 99;
if (result) Console.Write(third);
else Console.Write("Третьей цифры нет");
