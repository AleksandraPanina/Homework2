 //Напишите программу, которая принимает на вход трёхзначное число 
 //и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Random random = new Random();
int number = random.Next( 100, 1000 );
Console.WriteLine(number);
int firstNumber = number / 100;
int secondNumber = (number / 10) % 10;
int thirdNumber = number % 10;
Console.WriteLine(secondNumber);


 //Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Не использовать string[]
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6



int ThirdDigit(int number)
        {
            int result = -1;
            if (number >= 100)
            {
                while (number > 999)
                {
                    number = number / 10;
                }
                result = number % 10;
            }
            return result; 
        }
Console.Write("Input threedigit number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (ThirdDigit(number1) == -1)
        {
            Console.WriteLine("there is no third digit");
        }
else
        {
            Console.WriteLine($"Third digit is {ThirdDigit(number1)}");
        }


 //Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
// -> да
//7 -> да
//1 -> нет

Console.Write("Input number of the day week");
int dayNum = int.Parse(Console.ReadLine());


if (dayNum == 6 || dayNum == 7)
{
    Console.WriteLine("This day is a weekend => True");
}
else if (dayNum < 1 || dayNum > 7)
{
    Console.WriteLine("This day is not a weekday");
}
else
{
    Console.WriteLine("This day is not a weekend => False");
}       