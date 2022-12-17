using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int number = 10;
double money = 10.5;
bool check = true;
string str = "nguyen";

//Trong C Sharp thường có 2 dạng kiểu chính
// 1.value type (dạng số):không chứa dc null
// 2.reference type (chuỗi,đối tượng):cho phép null

string name = null;
//Code Cũ
Nullable<bool> a = null;

//Code Mới Dấu ? : => nullable value type
int? b= null;
bool? flag = null;


//if(name != null)
//{
//    Console.WriteLine(true);
//}
//else
//{
//    Console.WriteLine(false);
//}

//?: => ternary operator
//Console.WriteLine(name != null ? true : false);
// is not  (!=)
// is (==)
//Console.WriteLine(name is not null ? true : false);

//int age = 10;
//if (age is 10)
//{

//}

//     ? => null conditional operator
//     ? dùng sau đít tên biến , hay đối tượng
//     ? tương tự (!=) ,nếu cái gì đó khác null thì lấy cái vế sau
int? length = name?.Length;
/*
if (length != null)
{
    length=name.Length;
}
else
{
    length = null;
}*/

//??=> null coalescring operator
//?? tương tự dấu == ,nếu cái gì đó bằng null thì lấy cái vế sau

//int? chieudai = name?.Length ?? 10;
//Console.WriteLine(chieudai);
List<int> numbers = null;
int? m = null;
int? n = null;

 
(numbers ??= new List<int>()).Add(7);

Console.WriteLine(string.Join(" ", numbers));  // output: 5 7

numbers.Add(m ??= 0);
Console.WriteLine(string.Join(" ", numbers));  // output: 5 7 0
numbers.Add(n ??= 4);
Console.WriteLine(string.Join(" ", numbers)); // output: 5 7 0 4

Console.WriteLine(m);// output: 0
Console.WriteLine(n);// output: 4