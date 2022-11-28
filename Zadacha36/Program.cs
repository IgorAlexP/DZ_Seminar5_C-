/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Write("Введите размер массива: ");        //выводит сообщение пользователю
int size = Convert.ToInt32(Console.ReadLine());     //пользователь вводит длинну массива из консоли
int[] numbers = new int[size];                      //инициализируется массив согласно введенной длинны
FillArrayRandomNumbers(numbers);                    //метод заполнения массива случайными числами
PrintArray(numbers);             //метод вывод массива 
int count = 0;
int sum = 0;

for (int j = 0; j < numbers.Length; j++)
{if (j % 2 != 0)
sum = sum + numbers[j];
count++;
}
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0,100);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " " );
    }
    //Console.Write("] => ");
    //Console.WriteLine();
}
Console.Write("] сумма нечетных элементов массива => " + sum);


