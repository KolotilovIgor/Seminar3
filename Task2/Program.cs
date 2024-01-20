/* /* Задайте массив из 10 элементов, заполненный числами из
промежутка [-10, 10]. Замените отрицательные элементы на
положительные, а положительные на отрицательные.
Пример
[1 -5 6]
=> [-1 5 -6] */
int sizearray = 10;
int[] array = new int[sizearray];
/* System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine()); */

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,11);
    Console.Write(array[i]+ " ");
}
System.Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    array[i] = -1 * array[i];
    Console.Write(array[i]+ " ");

}
