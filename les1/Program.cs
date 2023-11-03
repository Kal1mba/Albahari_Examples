using System;
using System.Drawing;

#region exs #1
//int x = 12 * 30;
//Console.WriteLine(x); 
#endregion

#region exs #2
//Console.WriteLine(FeetToInches(30));
//Console.WriteLine(FeetToInches(100));

//int FeetToInches(int feet)
//{
//    int inches = 12 * feet;
//    return inches;
//}
#endregion

#region exs #3
//SayHello();

//void SayHello()
//{
//    Console.WriteLine("Hello, world!");
//}
#endregion

#region exs #4
//UnitConverter feetToInches = new UnitConverter(12);
//UnitConverter milesToFeet = new UnitConverter(5280);

//Console.WriteLine(feetToInches.Convert(30));
//Console.WriteLine(feetToInches.Convert(100));
//Console.WriteLine(feetToInches.Convert(milesToFeet.Convert(1)));

//public class UnitConverter
//{
//    int ratio;
//    public UnitConverter(int unitRatio)
//    {
//        ratio = unitRatio;

//    }
//    public int Convert(int unit)
//    {
//        return unit * ratio;
//    }
//}
#endregion

#region exs #5
//Panda p1 = new Panda ("Pan Dee");
//Panda p2 = new Panda ("Pan Dah");

//Console.WriteLine(p1.Name);
//Console.WriteLine(p2.Name);
//Console.WriteLine(Panda.Population);
//public class Panda
//{
//    public string Name;
//    public static int Population;
//    public Panda(string n)
//    {
//        Name = n;
//        Population = Population + 1;
//    }
//}
#endregion

#region exs #6
//class Program
//{
//    static void Main(string[] args)
//    {
//        int x = 12 * 30;
//        Console.WriteLine(x);
//    }
//}
#endregion

#region exs #7
//int x = 12345; // int — 32-битное целое
//long y = x; // Неявное преобразование в 64 бит
//short z = (short)x; // Явное преобразование в 16 бит
#endregion

#region exs #8
//Point p1 = new Point();
//p1.X = 7;
//Point p2 = p1; // Присваивание вызывает копирование

//Console.WriteLine(p1.X);
//Console.WriteLine(p2.X);

//p1.X = 9; // Изменение p1.X

//Console.WriteLine(p1.X);
//Console.WriteLine(p2.X);
#endregion

#region exs #9

//Point p1 = new Point();
//p1.X = 7;
//Point p2 = p1; // Присваивание вызывает копирование

//Console.WriteLine(p1.X);
//Console.WriteLine(p2.X);

//p1.X = 9; // Изменение p1.X

//Console.WriteLine(p1.X);
//Console.WriteLine(p2.X);
//public class Point { public int X, Y; } // Перевоплощение Point в ссылочный тип данных
#endregion

#region exs #10
// Одинаковые инструкции по разному написаны
//int x = 5;

//System.Int32 y = 5;
#endregion

#region exs #11
// что то связано с системами счисления
//Console.WriteLine(1.0.GetType());
//Console.WriteLine(1E06.GetType());
//Console.WriteLine(1.GetType());
//Console.WriteLine(0xF0000000.GetType());
//Console.WriteLine(0x100000000.GetType());
#endregion

#region exs #12
//float f = 4.5F;
//decimal d = -1.23M;
// Буквенные суффиксы указывают компилятору какой тип данных используется
#endregion

#region exs #13
//double x = 15.34;
//float y = (float)x; //Необходимо явное преобразование типов данных
//Console.WriteLine(y);
#endregion

#region exs #14
//int i1 = 100000001;
//float f = i1;
//int i2 = (int)f;
//Console.WriteLine($"{i1}, {i2}"); //Точность сохраняемых данных желает всего наилучшего
#endregion

#region exs #15
//инкремент и декремент
//int x = 0;
//Console.WriteLine(x++);
//Console.WriteLine(++x);
//Console.WriteLine(--x);
#endregion

#region exs #16
//int a = int.MaxValue; a++;
//Console.WriteLine(a == int.MinValue); //Инструкция выходит за арифметические
//                                      //пределы данного типа, true
#endregion

#region exs #17
// проверка переполнения
//int a = 1000000, b = 1000000;
//int c = checked(a*b); // выдается ошибка того что переменная переполнена
#endregion

#region exs #18
//short x = 1, y = 1;
//short z = (short)(x + y); //Попытка присваивания результата
//переменной меньшего целочисленного
//типа может вызвать ошибку времени компиляции
// выражение (x+y) пытается неявно преобразоваться в int
#endregion

#region exs #19
//// Как достичь бесконечности
//Console.WriteLine(double.NegativeInfinity); // -бесконечность
//Console.WriteLine(1.0/0.0); // +бесконечность
//Console.WriteLine(-1.0/0.0); // -бесконечность
//Console.WriteLine(1.0/-0.0); // -бесконечность
//Console.WriteLine(-1.0/-0.0); // +бесконечность

//// Not a Number

//Console.WriteLine(0.0/0.0); //не число fr
//Console.WriteLine((1.0/0.0)-(1.0/0.0)); //не число fr

//Console.WriteLine((0.0 / 0.0) == double.NaN); //Проверка на не число производиться
//Console.WriteLine(double.IsNaN(0.0 / 0.0));   //производиться только вторым методом

//bool isTrue = object.Equals(0.0/0.0, double.NaN);
//Console.WriteLine(isTrue);
#endregion

#region exs #20
//int x = 1, y = 2, z = 1; // Операторы эквивалентности и сравнения
//Console.WriteLine(x == y);
//Console.WriteLine(x == z);
#endregion

#region exs #21
//static bool useUmbrella(bool rainy, bool sunny, bool windy) // метод позволяющий узнать
//{                                                           // использовать ли зонт от дождя
//    return !windy && (rainy || sunny);
//}

//static int Max(int a , int b)
//{
//    return (a > b) ? a : b; // оператор ? проверяет истинно ли выражение в скобках,
//}                           // если оно истинно, то выполняется вторая инструкция

//Console.WriteLine(Max(5, 4)); // по итогу выведется большее число 
#endregion

#region exs # 22 Символ Char
//char c = 'a'; // Простой символ

//char newLine = '\n'; //Символ новой строки
//char backSlash = '\\'; //Символ обратной косой черты

//char singleQuote = '\''; //Символ одинарной кавычки
//char bothQuote = '\"'; //Символ двойной кавычки
//char zeroSymbol = '\0'; //Нулевой символ или пустой символ
//char soundSymbol = '\a'; //Звуковой символ
//char slaughterSymbol = '\b'; //Символ Забоя - возврата на один символ назад
//char nextPageSymbol = '\f'; //Символ перехода на следующую страницу
//char newStringSymbol = '\n'; //Символ перехода на следующую строку
//char cursorHomeSymbol = '\r'; //Возврат курсора в начало строки - Возврат каретки
//char hTabulationSymbol = '\t'; //Горизонтальная табуляция
//char vTabulationSymbol = '\v'; //Вертикальная табуляция

//char copyrightSymbol = '\u00A9'; //Символ копирайта
//                                 //Управляющая последовательность \u (или \x)
//                                 //позволяет указывать любой символ Unicode
//char omegaSymbol = '\u03A9'; //Символ Омега
//char newLineSymbolUnicode = '\u000A'; //Символ перехода на следующую строку

#endregion

#region exs #23 Строка String
//Строка - string

//string a = "Heat";

//string a = "test", b = "test";

//Console.WriteLine(a==b); //операторы эквивалентности следуют семантике типов-значений

//string a = "Это табуляция:\tпривет"; //Управляющие последовательности работают
//Console.WriteLine(a);                //также как и с символами

//string a1 = "\\\\server\\fileShare\\helloWorld.cs"; //Для обратной черты
//                                                    //необходимо дублировать символ
//Console.WriteLine(a1);

//string a2 = @"\\server\fileShare\helloWorld.cs"; //Дословный строковый литерал снабжается
//префиксом @ и не поддерживает
//управляющие последовательности.
//Конкатенация строк
//string s1 = "a" + "b"; //ab
//string s2 = "a" + 5;//a5

//Интерполяция строк
//int x1 = 4;
//Console.WriteLine($"У квадрата {x1} стороны");

//string s3 = $"{15:X2} - это 15 в шестнадцатеричной записи";
//Console.WriteLine(s3);

//int x2 = 2;
//string s4 = $@"Это целых {
//    x2} строки";

//Console.WriteLine(s4);

//Сравнения строк

//Console.WriteLine("Bbb".CompareTo("Aaa")); // 1 - потому что "Bbb" идет после "Aaa" в алфавитном порядке.
//Console.WriteLine("Bbb".CompareTo("Bbb")); // 0 - потому что "Bbb" идет после "Aaa" в алфавитном порядке.
//Console.WriteLine("Bbb".CompareTo("Ccc")); // -1 - потому что "Bbb" идет перед "Ccc" в алфавитном порядке.

//Поиск в строках

//Console.WriteLine("слово"[3]); // в
//Console.WriteLine("слово".IndexOf('о')); // Находит символ 'о' и возвращает
//                                         // индекс первого найденного

//Console.WriteLine("слово".LastIndexOf('о')); // Находит крайний символ 'о'

//Console.WriteLine("слово".Contains('в')); // Булево возвращает есть ли символ в строке
//Console.WriteLine("слово".StartsWith('с')); // Булево возвращает начинается ли строка с символа
//Console.WriteLine("слово".EndsWith('о')); // Булево возвращает заканчивается ли строка с символа
#endregion

#region exs #24 Массивы

#endregion