namespace PartialClass;
internal partial class Human
{
    //1 phương thức chỉ có 1 câu lệnh
    //C# sẽ không sử dụng phương thức mà dùng
    // expression body => biểu thức dưới dạng phương thức
    public void Show()=>Console.WriteLine($"{nameof(fullname)}={fullname}");

    public void Check() => Console.WriteLine(10 > 5 ? true : false);
    
}
