//Задайте массив. Напишите программу, которая определяет,
//присутствует ли заданное число в массиве. Программа
//должна выдать ответ: Да/Нет.
//Примеры
//[1 3 4 19 3], 8 => Нет
//[-4 3 4 1], 3 => Да 

// тип массив + [] + назвение = new + тип + [размер]

//int [] array = new int [8];
//System.Console.WriteLine(array [0]);

int[] array = new int[8];
System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string find = "Нет";
//bool isFind = false;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,10);
    Console.Write(array[i]+ " ");
    if(array[i] == num)
    {
        //isFind = true;
        find = "Да";
    }
}
System.Console.WriteLine(find);
//if(isFind)
//{
//    System.Console.WriteLine("Да");
//}
//else
//{
//    System.Console.WriteLine("Нет");
//}