Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

List<Student> list = new()
{
    new Student(){Id =1,Name="khacnguyen",Gender=true,Dob=new DateTime(2022,02,22)},
    new Student(){Id =2,Name="tuan anh",Gender=true,Dob=new DateTime(1999,02,10)},
    new Student(){Id =3,Name="trung nghị",Gender=true,Dob=new DateTime(2002,02,19)},
    new Student(){Id =4,Name="ngọc anh",Gender=true,Dob=new DateTime(2022,02,16)},
    new Student(){Id =5,Name="trung tín",Gender=false,Dob=new DateTime(2003,02,03)},

};
//duyệt qua list bằng vòng lặp foreach
//foreach(var stu in list)
//{
//    Console.WriteLine(stu);
//}
//vòng lặp foreach sẽ chuyển thành 
//IEnumerator<Student> enu = list.GetEnumerator();
//while (enu.MoveNext())
//{
//    Console.WriteLine(enu.Current.ToString());
//}

//list.ForEach(Console.WriteLine);

//linq = language intergrated query
//linq to sql -> thay thế cú pháp sql trong C#
//linq to object -> console 
//sql -> select from where group by having order by
//c# -> FROM WHERE GROUP BY HAVING ORDER BY ... SELECT  
//linq có 2 dạng
//style 1 => query syntax => dựa theo cú pháp của sql, dễ học,dễ dùng
//style 2 => method syntax => dựa theo lambda => khó học khó dùng,nhưng cực nhanh

//Hiển thị toàn bộ thông tin sinh viên trong list,với điều kiện id sinh viên phải lớn hơn 2

//foreach(var stu in list)
//{
//    if(stu.Id > 2)
//    {
//        Console.WriteLine(stu);
//    }
//}
//=====style 1 của linq ======== query syntax
//var t = from stu in list 
//        where stu.Id > 2 
//        select stu;

//foreach(var i in t)
//{
//    Console.WriteLine(i);
//}
//======style 1 của linq thu gọn ==========
//foreach (var i in from stu in list where stu.Id > 2 select stu)
//{
//    Console.WriteLine(i);
//}
//==========Style 2 : method syntaxx============

var t =list.Where(stu => stu.Id >2);
foreach (var i in t)
{
    Console.WriteLine(i);
}

//==========Style 2 : method syntaxx rút gọn ============
foreach (var i in list.Where(stu => stu.Id > 2))
{
    Console.WriteLine(i);
}

// Ket hop voi foreach vaf list
list.Where(stu => stu.Id > 2).ToList().ForEach(Console.WriteLine);
