// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.Clear();

void FillArray(string[] array)
{
    Console.WriteLine("Введите любые 10 комбинаций из чисел через Enter:");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
}

// string PrintArray(int[] array)
// {
//     string result = "";
//     for (int i = 0; i < array.Length; i++)
//     {
//         result += array[i].ToString() + " ";
//     }
//     Console.WriteLine(result);
//     return result;
// }

// int[] FillNewArray(int[] array)
// {
//     int newarraylength = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 8)
//         {
//             newarraylength ++;
//         }
//     }

//     int[] newarray = new int [newarraylength];
//     for (int j = 0, k = 0; j < array.Length; j++)
//     {
//         if (array[j] > 8)
//         {
//             newarray[k] = array[j];
//             k++;
//         }
//     }
//     return newarray;
// }

void Demo ()
{
    string[] array = new string[10];
    FillArray(array);
    // PrintArray(array);
    // Console.WriteLine("");
    // FillNewArray(array);
    // PrintArray(FillNewArray(array));
}

Demo ();