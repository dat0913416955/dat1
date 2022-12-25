//// This example demonstrates the StringBuilder.AppendLine()
//// method.

//using System;
//using System.Text;

//class Sample
//{
//    public static void Main()
//    {
//        StringBuilder sb = new StringBuilder();
//        string line = "A line of text.";
//        int number = 123;

//        // Append two lines of text.(Nối hai dòng văn bản.)

//        sb.AppendLine("The first line of text.");
//        sb.AppendLine(line);
//        // Append a new line, an empty string, and a null cast as a string.( Nối thêm một dòng mới, một chuỗi rỗng và một ký tự rỗng dưới dạng một chuỗi.)

//        sb.AppendLine();    
//        sb.AppendLine("");
//        sb.AppendLine((string)null);

//        // Append the non-string value, 123, and two new lines.(Nối giá trị không phải chuỗi, 123 và hai dòng mới.)
//        sb.Append(number).AppendLine().AppendLine();

//        // Append two lines of text.
//        sb.AppendLine(line);
//        sb.AppendLine("The last line of text.");

//        // Convert the value of the StringBuilder to a string and display the string.(Chuyển đổi giá trị của StringBuilder thành chuỗi và hiển thị chuỗi.)
//        Console.WriteLine(sb.ToString());
//    }
//}
///*
//       * AppendLine()	

// Nối thêm dấu kết thúc dòng mặc định vào cuối đối tượng StringBuilder hiện tại.

//       * AppendLine(Chuỗi)

// Nối một bản sao của chuỗi đã chỉ định, theo sau là dấu kết thúc dòng mặc định vào cuối đối tượng StringBuilder hiện tại .

//       * AppendLine(StringBuilder+AppendInterpolatedStringHandler)	

// Nối chuỗi được nội suy đã chỉ định, theo sau là dấu kết thúc dòng mặc định vào cuối đối tượng StringBuilder hiện tại.

//       * AppendLine(IFormatProvider, StringBuilder+AppendInterpolatedStringHandler)	

// Nối thêm chuỗi nội suy đã chỉ định bằng cách sử dụng định dạng đã chỉ định, theo sau là dấu kết thúc dòng mặc định, vào cuối đối tượng StringBuilder hiện tại. 

// */
///*
//This example produces the following results:

//The first line of text.
//A line of text.



//123

//A line of text.
//The last line of text.
//*/

//await
/*
Console.Write("Hello ");
await Task.Delay(10);
Console.WriteLine("World!");
*/


//string? s = Console.ReadLine();

//int returnValue = int.Parse(s ?? "-1");
//return returnValue;
//Console.WriteLine(returnValue);