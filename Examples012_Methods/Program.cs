// // Вид 1

// void Method1()
// {
//     Console.WriteLine("Автор: Дмитрий Воронков");
// }

// //Вызов метода
// Method1();

// //Вид 2

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// //Вызов метода
// Method2(msg: "Тексст сообщения");

// void Method21(string msg, int count)
// {

//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++; //Увеличение счетчика на единичку называют Инкриментом, тогда как уменьшение счетчика на единичку называют Декриментом
//     }
// }
// Method21("Текст", 4);
// Method21(msg: "Текст1", count: 4);
// Method21(count: 4, msg: "Текст2");

// //Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// //Вызов метода
// int year = Method3();

// Console.WriteLine(year);

// //Вид4

// // string Method4(int count, string text)
// // {
// //     int i = 0;
// //     string result = String.Empty;

// //     while (i < count)
// //     {
// //         result = result + text;
// //         i++;
// //     }
// //     return result;
// // }

// // string res = Method4(10, "asdf");
// // Console.WriteLine(res);


// string Method4(int count, string text)
// {

//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "asdf");
// Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

//===============Работа с текстом
//Дан текст. В тексте нужно все пробелы заменить черточками, 
//маленькие буквы "к" заменить большими "К",
//а большие "С" заменить маленькми "с".

string text = "-Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгороде,"
            + "вы бы взяли приступом согласиемм прусского короля."
            + "Вы так красноречивы. Вы дадите чаю?";

// string s = "qwerty";
//             01234
//s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;
// int length = text.Length;
// for (int i = 0; i < length; i++)
// {
//     if (text[i] == oldValue) result = result + $"{newValue}";
//     else result = result + $"{text[i]}";
// }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(text, 'с', 'С');
// Console.WriteLine(newText);

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        


        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);

SelectionSort(arr);

PrintArray(arr);