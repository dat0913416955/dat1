using System.Text;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        //1. Nhập 3 chữ cái và hiển thị theo chiều ngược lại

        /*char letter,letter1,letter2;
        Console.WriteLine("Chương trình nhập 3 chữ cái và hiển thị theo chiều ngược lại ");
        Console.WriteLine("Nhập chữ cái thứ nhất: ");
        letter = Convert.ToChar((Console.ReadLine()));
        Console.WriteLine("Nhập chữ cái thứ hai: ");
        letter1 = Convert.ToChar((Console.ReadLine()));
        Console.WriteLine("Nhập chữ cái thứ ba: ");
        letter2 = Convert.ToChar((Console.ReadLine()));

        Console.WriteLine("Hiển thị 3 chữ cái theo chiều ngược lại: ");
        Console.WriteLine($"{letter2} {letter1} {letter}");
        Console.ReadKey();
        */

        //2.Vẽ Tam Giác Số

        /*Console.WriteLine("Chương trình vẽ tam giác số: ");
        Console.Write("Nhập vào số bất kì: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Nhập vào độ rộng của tam giác: ");
        int width = int.Parse(Console.ReadLine());

        int height = width;
        for(int row = 0; row < height; row++)
        { 
            for(int column = 0; column < width; column++)
            {
                Console.Write(num);
            }
            Console.WriteLine();
            width--;
        }
        Console.ReadKey();
        */

        //3.Kiểm tra tên đăng nhập và mật khẩu  Nếu người dùng nhập sai quá 3 lần, in thông báo lỗi.

        /*string user, pass;
        int count = 0;
        Console.Write("Kiem tra ten dang nhap va mat khau:\n");
        Console.Write("Gia tri mac dinh la: user va password\n");
        Console.Write("---------------------------------\n");

        do
        {
            if (count != 0)
                Console.WriteLine("Tên Đăng Nhập Hoặc Mật Khẩu Sai!");

            Console.Write("Ten dang nhap: ");
            user = Console.ReadLine();

            Console.Write("Mat khau: ");
            pass = Console.ReadLine();

            count++;

        }
        while (((user != "user") || (pass != "pass"))
            && (count != 4));

        if (count == 4)
            Console.Write("Dang nhap that bai! vì nhập sai quá 3 lần");
        else
            Console.Write("Mat khau chinh xac. Ban da dang nhap thanh cong!");

        Console.ReadKey();
       */

        //4.Nhập hai số và thực hiện phép toán tương ứng

        /*int x, y;
        char phepToan;


        Console.Write("Nhap so dau tien: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Phep toan: ");
        phepToan = Convert.ToChar(Console.ReadLine());
        Console.Write("Nhap so thu hai: ");
        y = int.Parse(Console.ReadLine());

        switch(phepToan)
        {
            case '+':
                Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
                break;

            case '-':
                Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
                break;

            case '*':
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
                break;

            case '/':
                Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
                break;

        }
        Console.ReadKey();

        */

        //5. Chuyển đổi thập phân thành nhị phân

        
        string answer, result;

        Console.WriteLine("Nhập vào số bất kỳ thập phân: ");
        answer = Console.ReadLine();

        int num = int.Parse(answer);
        result = "";
        while (num > 1)
        {
            int remainder = num % 2;
            result = Convert.ToString(remainder) + result ;
            num /=2;

        }
        result = Convert.ToString(num) + result ;
        Console.WriteLine($"Số trong hệ nhị phân tương ứng là :{result}");

        Console.ReadKey();
    }
}