

Console.Clear();
//                                              ЗАДАЧА 1
/*  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
 Использовать рекурсию, не использовать циклы.*/

// Console.Write("Введите натуральное  число  для подсчета в промежутке: M  до N:  ");
// int integerN = Convert.ToInt32(Console.ReadLine());

void ShowNumbers(int startValM, int end)

{
    if (startValM == end)
    {
        Console.Write(startValM);
        return;
    }

    Console.Write(startValM + " ");
    ShowNumbers(startValM + 1, end);
}
Console.Write("Натуральные числа в промежутке от M(1) до N: ");
ShowNumbers(1, integerN);




//                                   ЗАДАЧА 2
/*             Напишите программу вычисления функции Аккермана с помощью рекурсии.
                       Даны два неотрицательных числа m и n.*/
// int m = 2;
// int n = 2;
// Console.WriteLine($"Результат функции Аккермана для m = {m} и n = {n}: {AckermannFunction(m, n)}");
// int AckermannFunction(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (m > 0 && n == 0)
//     {
//         return AckermannFunction(m - 1, 1);
//     }
//     else if (m > 0 && n > 0)
//     {
//         return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//     }
//     else
//     {
//         throw new ArgumentException("отрицательное число");
//     }
// }


//                                      ЗАДАЧА 3
/*                              Задайте произвольный массив. 
Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.*/



// int[] array = { 6, 2, 5, 0, 10, 25 };
// Console.WriteLine("Перевернутый массив:");
// int SizeElem = array.Length;
// ShowArray(array, SizeElem - 1);

// void ShowArray(int[] arr, int SizeElem)
// {
//     if (SizeElem == 0)
//     {
//         Console.Write(arr[SizeElem]);
//         return;
//     }
//     Console.Write(arr[SizeElem] + " ");
//     ShowArray(arr, SizeElem - 1);
// }

