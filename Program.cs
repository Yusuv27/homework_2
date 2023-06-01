int count=0;
while(count!=1) 
{
    Console.WriteLine("Какое задание вас интересует? (1-3) :");
    int menu = Convert.ToInt32(Console.ReadLine());
    if(menu==1)
    {
        //Первое задание
        Console.WriteLine("1.Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
        Console.WriteLine("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        num=num%100;
        num=num/10;
        Console.WriteLine("Вторая цифра данного числа: "+num);
    }
    else if(menu==2)
    {
        //Второе задание
        Console.WriteLine("2.Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
        Console.WriteLine("Введите число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        if(num2>100)
        {
            while(num2>999)
            {
            num2=num2/10;
            }
            num2=num2%100;
            num2=num2%10;
            Console.WriteLine(num2);
        }
        else
        {
            Console.WriteLine("Третьей цифры нет");
        }
    }
    else if(menu==3)
    {
        //Третье задание
        Console.WriteLine("3.Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
        Console.WriteLine("Введите день недели ввиде числа: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        if((num3<=5)&&(num3>=1))
        {
            Console.WriteLine("Нет");
        }
        else if ((num3==6)||(num3==7))
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Это число не являеться днем недели");
        }
    }
    else
    {
        Console.WriteLine("Такого числа нет");
    }
    Console.WriteLine("Для завершения программы введите 1");
    Console.WriteLine("Для продолжение работы с программой введите любое другое число: ");
    count = Convert.ToInt32(Console.ReadLine());
}