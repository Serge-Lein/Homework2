// Task13. 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void GiveMeTheThirdDigitPieceOfIronGarbage(int num)
{
    if (num < 100)
    {
        Console.WriteLine($"Your number {num} is not three-digit.\nPlease restart the programm and enter another number");
    }
    else
    {
        int tempNum = num;
        int length = num.ToString().Length;
        int[] arr = new int[length];
        for (int i = 0; tempNum > 0; i++)
        {
            arr[i] = tempNum % 10;
            tempNum = tempNum / 10;
        }

        Console.WriteLine($"Your number is {num}.\nThe third digit is {arr[arr.Length - 3]}");
    }
}

Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

GiveMeTheThirdDigitPieceOfIronGarbage(num);

