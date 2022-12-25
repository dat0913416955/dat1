namespace OopAbstraction;
internal class Dog : Animal
{

    //thực thi lại cái phương thức abstract của animal 
    // buộc phải dùng từ khóa override

    public override void ShowInfo()
    {
        Console.WriteLine("this is a dog");

    }
}
