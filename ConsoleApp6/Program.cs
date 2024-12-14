//using System;

//class Program
//{
//    static void Main()
//    {
//        int N = 6;
//        int M = 5;
//        int[,] array = new int[N, M];

//        int counter = 1;

//        for (int j = 0; j < M; j++)
//        {
//            for (int i = 0; i < N; i++)
//            {
//                array[i, j] = counter;
//                counter++;
//            }
//        }

//        for (int i = 0; i < N; i++)
//        {
//            for (int j = 0; j < M; j++)
//            {
//                Console.Write(array[i, j].ToString().PadLeft(2) + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

///////////////////////////////////////////////////////////////////

//using System;
//using System.Text.RegularExpressions;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите строку:");
//        string input = Console.ReadLine();

//        if (IsPalindrome(input))
//        {
//            Console.WriteLine("Строка является палиндромом.");
//        }
//        else
//        {
//            Console.WriteLine("Строка не является палиндромом.");
//        }
//    }

//    static bool IsPalindrome(string str)
//    {  
//        string cleanedStr = Regex.Replace(str, @"[^\w]", "").ToLower();

//        char[] charArray = cleanedStr.ToCharArray();
//        Array.Reverse(charArray);
//        string reversedStr = new string(charArray);

//        return cleanedStr == reversedStr;
//    }
//}

/////////////////////////////////////////////

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите число от 0 до 10,000,000:");
//        if (int.TryParse(Console.ReadLine(), out int number) && number >= 0 && number <= 10000000)
//        {
//            Console.WriteLine(NumberToWords(number));
//        }
//        else
//        {
//            Console.WriteLine("Ошибка: введите корректное число в указанном диапазоне.");
//        }
//    }

//    static string NumberToWords(int number)
//    {
//        if (number == 0) return "ноль";
//        if (number == 10000000) return "десять миллионов";

//        string[] units = { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
//        string[] teens = { "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
//        string[] tens = { "", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
//        string[] hundreds = { "", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
//        string[] thousands = { "", "тысяча", "две тысячи", "три тысячи", "четыре тысячи", "пять тысяч", "шесть тысяч", "семь тысяч", "восемь тысяч", "девять тысяч" };

//        string words = "";

//        if (number >= 1000)
//        {
//            words += thousands[number / 1000] + " ";
//            number %= 1000;
//        }

//        if (number >= 100)
//        {
//            words += hundreds[number / 100] + " ";
//            number %= 100;
//        }

//        if (number >= 20)
//        {
//            words += tens[number / 10] + " ";
//            number %= 10;
//        }

//        if (number >= 10)
//        {
//            words += teens[number - 10] + " ";
//        }
//        else if (number > 0)
//        {
//            words += units[number] + " ";
//        }

//        return words.Trim();
//    }
//}