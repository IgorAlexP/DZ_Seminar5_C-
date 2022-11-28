/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */


Console.Write("Введите размер массива: ");        //выводит сообщение пользователю
int size = Convert.ToInt32(Console.ReadLine());     //пользователь вводит длинну массива из консоли
double[] numbers = new double[size];                      //инициализируется массив согласно введенной длинны
FillArrayRandomNumbers(numbers);                    //метод заполнения массива случайными числами
Array.Sort(numbers);              //метод сортировки массива
PrintArray(numbers);             //метод вывод массива 
double diff = numbers[size - 1] - numbers[0]; //нахождение разницы между макс. и мин. элементами массива





void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0,10);
    }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " " );
    }
    //Console.Write("] => ");
    //Console.WriteLine();
}
Console.Write("] разница между максимальным и минимальным элементами массива => " + diff);


