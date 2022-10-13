//Написать программу, которая из имеющегося массива строк
// формирует массив из строк,длина которых либо меньше либо равна 3 
// символа. Первоначальный массив можно ввести с клавиатуры,либо задать
// на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

//Задаем массив
string[] textArray = { "Hello", "2", "Worold", ":-)" };
//считаем количество эл-в >=3
int CountMetod(string[] textArray)
{
    int num = 0;
    for (int i = 0; i < textArray.Length; i++)
    {
        if (textArray[i].Length <= 3)
        {
            num++;
        }
    }
    return num;
}
//записываем эл-ты >=3 в новый массив
string[] SortMetod(string[] textArr, int num)

{
    string[] sortTextArr = new string[num];
    int count = 0;
    for (int i = 0; i < textArr.Length; i++)
    {
        if (textArr[i].Length <= 3)
        {
            sortTextArr[count] = textArr[i];
            count++;
        }
    }
    return sortTextArr;
}
//печатаем новый массив
void PrintArray(string[] arr)
{
    if (arr.Length > 0)
    {
        Console.Write("[" + arr[0]);
        for (int i = 1; i < arr.Length; i++)
        {
            Console.Write(", " + arr[i]);
        }
        Console.Write("]");
        Console.WriteLine();
    }
    else
    {
        Console.Write("[]");
        Console.WriteLine();
    }
}
int num = CountMetod(textArray);
string[] rezaltArr = SortMetod(textArray, num);
PrintArray(rezaltArr);
