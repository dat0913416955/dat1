
//int a = 10;
//int b = 5;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

//RefOut.ChangeVar(ref a ,ref b);
RefOut.ChangeVar(out int  a, out int b);
Console.WriteLine("main: ");
Console.WriteLine($"{nameof(a)} ={a},{nameof(b)} ={b}");

// pure oop => oop nguyên thủy ,thuần oop => C# cũ
//RegexTryParse parse = new RegexTryParse();

// dùng var
//var par = new RegexTryParse();

//target-type C# new : không lấy của cha xuống thằng con dc
RegexTryParse p = new();
//p.CheckNumberByRegex();
//p.CheckStringByRegex();
p.TryCatchBug();