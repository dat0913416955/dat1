using System.Collections;
using System.Diagnostics;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
int number1 = Random.Shared.Next(0, 9);
int number2 = Random.Shared.Next(0, 9);

Console.WriteLine($"{nameof(number1)} ={number1},{nameof(number2)} ={number2}");

//Console.WriteLine("Vui lòng nhập dấu phép toán: ");
//string? dau = Console.ReadLine();
//Switch case
//switch (dau)
//{
//    case "+" when number1 >=0 && number2 >0:
//        //if(number1 > 0 && number2 > 0)
//        //{
//        //    Console.WriteLine(number1 + number2);
//        //}
       
//        break;
//    case "-" when number1 >= number2:
//        Console.WriteLine(number1 - number2);
//        break;
//    case "*":
//        Console.WriteLine(number1 * number2);
//        break;
//    case "/" when number2 != 0:
//        Console.WriteLine(number1 / number2);
//        break;

//    default:
//        Console.WriteLine("Hi ,i can't");
//        break;
//}
//Chuyển về biểu thức Switch Expression
//Console.WriteLine(
//    dau switch
//    {
//        "+" when number1 >= 0 && number2 >= 0 => number1 + number2,
//        "-" when number1 >= number2         => number1 - number2,
//        "*"                                 => number1 * number2,
//        "/" when number2 != 0               => number1 / number2,
//        _ => "Hi ,I can't"//_ : là defaut
//    }
//);
//Vòng lặp For

string[] arrs = { "Khải ","Tín","Thắng","Huy","Nghị" };
foreach(var t in arrs)
{
    Console.WriteLine(t);
}

//Vòng lặp while
//int i = 0;
//int chieudaimang = arrs.Length;
//while(i < chieudaimang )
//{
//    Console.WriteLine(arrs[i]);
//    i++;
//}

IEnumerator e =arrs.GetEnumerator();
while (e.MoveNext())
{
    string s = e.Current.ToString();
    Console.WriteLine(s);
}


