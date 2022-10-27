# Контрольная работа

## Условие задачи

*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.*

## Решение

1. Для начала настроим кодировку, которая настроит корректное отображение символов кириллицы в консоли, используя команду:

```
Console.OutputEncoding = System.Text.Encoding.UTF8;
```

2. Создадим 3 массива:

```
string[] textArray1 = new string[]{"hello", "2", "world", ":-)"};
string[] textArray2 = new string[]{"1234", "1567", "-2", "computer scince"};
string[] textArray3 = new string[]{"Russia", "Denmark", "Kazan"};
```

3. Определим функцию, принимающию в качестве аргумента строковый массив. Данная функция возвращает строковый массив, каждый элемент котрого содержит не более 3-х символов. 

    + В методе создается новый массив, длина которого равна длине переданного в функцию массива.
    + Запускается цикл for. Каждую строку переводим в массив символов. 
    + Производится проверка каждого массива символов. Если длина данного массива меньше, либо равна трем, то в новый массив (newArr) записывается это значение (например, "word" не пройдет проверку, а "one" - пройдет).
    + функция будет возвращать новый массив (newArr). При этом значения null из него будут удалены. 

```
string[] GetTextArrayMaxWithThreeSymbols(string[] arr)
{
    string[] newArr = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        char[] symbols = arr[i].ToCharArray();
        if (symbols.Length <= 3) newArr[i] = arr[i];
    }
    return newArr.Where(x => x != null).ToArray();
}
```

4. Определим функцию, принимающую в качестве аргумента строковый массив. При вызове данной функции в консоли будут отображены элементы массива, который будет передан в функцию в качестве аргумента.

```
void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
```

5. Отобразим в консоли исходные массивы.

```
Console.WriteLine("\nИсходные массивы:");
PrintArray(textArray1);
PrintArray(textArray2);
PrintArray(textArray3);
```

6. Отобразим в консоли результат.

```
Console.WriteLine("\nРезультат:");
string[] res1 = GetTextArrayMaxWithThreeSymbols(textArray1);
PrintArray(res1);
string[] res2 = GetTextArrayMaxWithThreeSymbols(textArray2);
PrintArray(res2);
string[] res3 = GetTextArrayMaxWithThreeSymbols(textArray3);
PrintArray(res3);
```

# Результат в консоли

Запустим программу:

```
$ dotnet run
```

Результат:

```
Исходные массивы:
[hello, 2, world, :-)]
[1234, 1567, -2, computer scince]
[Russia, Denmark, Kazan]

Результат:
[2, :-)]
[-2]
[]
```