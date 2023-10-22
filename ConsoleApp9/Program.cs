#region task1
//int num = 75;
//if (num >= 0 && num <= 100)
//{
//    if (num > 90 && num <= 100)
//    {
//        Console.WriteLine("A");
//    }
//    else if (num > 80 && num <= 90)
//    {
//        Console.WriteLine("B");
//    }
//    else if (num >70 && num<=80) 
//    {
//        Console.WriteLine("C");
//    }
//    else if (num > 60 && num <= 70)
//    {
//        Console.WriteLine("D");
//    }
//    else  
//    {
//        Console.WriteLine("F");
//    }
//}
//else 
//{
//    Console.WriteLine("duzgun eded daxil edin");
//}
#endregion
#region task2
//int result = int.Parse(Console.ReadLine());
//while (result < 0 || result > 100) 
//{
//    Console.WriteLine("duzgun yaz");
//    result = int.Parse(Console.ReadLine());
//}
//if (result >= 0 && result <= 100)
//{
//    if (result > 90 &&  result <= 100)
//    {
//        Console.WriteLine("A");
//    }
//    else if (result > 80 && result <= 90)
//    {
//        Console.WriteLine("B");
//    }
//    else if (result > 70 && result <= 80)
//    {
//        Console.WriteLine("C");
//    }
//    else if (result > 60 && result  <= 70)
//    {
//        Console.WriteLine("D");
//    }
//    else
//    {
//        Console.WriteLine("F");
//    }
//}
//else
//{
//    Console.WriteLine("duzgun eded daxil edin");
//}
#endregion
#region task3
//int result = int.Parse(Console.ReadLine());
//switch (result)
//{
//    case 1:
//        Console.WriteLine("yanvar");
//        break;
//    case 2:
//        Console.WriteLine("fevral");
//        break;
//    case 3:
//        Console.WriteLine("mart");
//        break;
//    case 4:
//        Console.WriteLine("aprel");
//        break;
//    case 5:
//        Console.WriteLine("may");
//        break;
//    case 6:
//        Console.WriteLine("iyun");
//        break;
//    case 7:
//        Console.WriteLine("iyul");
//        break;
//    case 8:
//        Console.WriteLine("avqust");
//        break;
//    case 9:
//        Console.WriteLine("sentyabr");
//        break;
//    case 10:
//        Console.WriteLine("oktyabr");
//        break;
//    case 11:
//        Console.WriteLine("noyabr");
//        break;
//    case 12:
//        Console.WriteLine("dekabr");
//        break;
//    default:
//        Console.WriteLine("duzgun daxil edin");
//        break;
//}

#endregion
#region task4
//int number = int.Parse(Console.ReadLine());
//while (number>12 || number < 0) 
//{
//    Console.WriteLine("duzgun dxil edin");
//    number=int.Parse(Console.ReadLine());
//}
//string month = number switch
//{
//    1 => "fevral",
//    2 => "yanvar",
//    3 => "mart",
//}; 
//Console.WriteLine(month);
#endregion
#region task5
Console.WriteLine("num1 daxil edin");
int num1=int.Parse(Console.ReadLine());
Console.WriteLine("num2 daxil edin");
int num2=int.Parse(Console.ReadLine());
Console.WriteLine("operatoru daxil edin");
string op=Console.ReadLine();
int result = op switch
{
    "+" => num1 + num2,
    "-" => num1 - num2,
    "*" => num1 * num2,
    "/" => num1 / num2,
};
Console.WriteLine(result);
#endregion
