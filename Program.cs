// // Task10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// void MiddleNum(int num)
// {
//     int midNum = num % 100 / 10;
//     System.Console.WriteLine($"The middle digit of your number {num} is {midNum}");
// }

// Console.Write("Input your three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// MiddleNum(num);




// // Task13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// void GiveMeTheThirdDigitPieceOfIronGarbage(int num)
// {
//     if (num < 100)
//     {
//         Console.WriteLine($"Your number {num} is not three-digit.\nPlease restart the programm and enter another number");
//     }
//     else
//     {
//         int tempNum = num;
//         int length = num.ToString().Length;
//         int[] arr = new int[length];
//         for (int i = 0; tempNum > 0; i++)
//         {
//             arr[i] = tempNum % 10;
//             tempNum = tempNum / 10;
//         }

//         Console.WriteLine($"Your number is {num}.\nThe third digit is {arr[arr.Length - 3]}");
//     }
// }

// Console.Write("Input your number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// GiveMeTheThirdDigitPieceOfIronGarbage(num);



//Task13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

 void GiveMeTheThirdDigitPieceOfIronGarbage(int num)
{
    if (num < 100)
    {
        Console.WriteLine($"Your number {num} is not three-digit.\nPlease restart the programm and enter another number");
    }
    else
    {
        int tempNum = num;
        int lastDigit = 0;
        int reversNum = 0;
        while(tempNum > 0)
        {
            lastDigit = num % 10;
            reversNum = reversNum * 10 + lastDigit;
            tempNum = tempNum / 10;
        }
        Console.WriteLine($"Your number is {num}.\nThe third digit is {reversNum / 100 % 10}");
    }
}

Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

GiveMeTheThirdDigitPieceOfIronGarbage(num);







// // Task15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// void  IsWeekend(int dayNum)
// {
//     if(dayNum >= 6 && dayNum <= 7)
//     {
//         System.Console.WriteLine("Your day of the week is a day off");
//     }
//     else
//     {
//         System.Console.WriteLine("Your day of the week is NOT a day off");
//     }
// }

// Console.Write("Input your number the day of the week: ");
// int dayNum = Convert.ToInt32(Console.ReadLine());

// IsWeekend(dayNum);