// task31 задайте массив из 12 элементов в промежутке от [-9; 9]. Найдите сумму
// отрицательных и положительных элементов массива

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

void ReleaseArray(int[] array)
{
    int sumPosition = 0, sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        sumPosition += array[i];
        else if (array[i] < 0)
        sumNegative += array[i];
    }
    Console.WriteLine($"Сумма положительных чисел в массива{sumPosition}");
    Console.WriteLine($"Сумма отрицательных чисел в массива{sumNegative}");
        
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
