

using System.Text;

internal class Program
{
    public static void Main()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        //Chuyển đổi độ C thành độ K và độ F


        Console.Write("Nhap do C: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do K tuong ung la = {0}", celsius + 273);
            Console.WriteLine("Do F tuong ung la = {0}", celsius * 18 / 10 + 32);
            Console.ReadKey();
        
    }
}