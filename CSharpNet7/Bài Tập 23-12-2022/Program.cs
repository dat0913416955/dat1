using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;



        // BÀI TẬP KIỂM tRA 2 SỐ BẰNG NHAU
        /*int int1, int2;


        Console.Write("\n\n");
        Console.WriteLine("Chương trình C# kiểm tra hai số có bằng nhau không : \n");
        Console.WriteLine("=================");
        Console.WriteLine("\n\n");

        Console.WriteLine("Nhập số thứ nhất : ");
        int1 = Convert.ToInt32( Console.ReadLine());

       

        Console.WriteLine("Nhập số thứ hai : ");
        int2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nhập số thứ ba : ");
        int i3 = int.Parse(Console.ReadLine());

        if (int1 == int2 && int1 != i3)
            Console.WriteLine("{0} và {1} bằng  nhau khác {3}",int1,int2,i3);
        else
            Console.WriteLine("{0} và {1} không bằng nhau ",int1,int2);

        Console.ReadKey();

        */

        /* Bài 1.

        Viết chương trình java tạo và thực thi theo menu sau:

        1.Nhập vào tên của bạn

        2.Hiển thị tên vừa nhập.

        3.Thoát.
        */

        //Console.WriteLine("Chương trình bài tập 1");
        //Console.WriteLine("1.Nhập vào tên của bạn");
        //string name = Console.ReadLine();
        //Console.WriteLine("Tên của bạn vừa nhập là : " + name);
        //Console.ReadKey();

        // Bài 2.
        //NHẬP VÀO LẦN LƯỢT 3 GIÁ TRỊ VÀ XUẤT RA THEO ĐỊNH ĐẠNG

        /*string value1, value2, value3;
        Console.WriteLine("Nhập vào tuần tự 3 giá trị: ");
        Console.WriteLine("Nhập vào giá trị 1: ");
        value1 = Console.ReadLine();

        Console.WriteLine("Nhập vào giá trị 2: ");
        value2 = Console.ReadLine();

        Console.WriteLine("Nhập vào giá trị 3: ");
        value3 = Console.ReadLine();

        Console.WriteLine(string.Format("Số {0},Số {1} và Số {2}",value1,value2,value3));


        Console.ReadKey();
        */


        /*
 
Bài 2. Viết chương trình java thực thi theo menu sau:

1.      Nhập vào 2 số nguyên

2.      Hiển thị 2 số vừa nhập

3.      Tổng 2 số

4.      Tích 2 số

5.      Hiệu 2 số

6.      Thương 2 số.

7.      Thoát.
   
           */
        //Console.WriteLine("Chương trình bài 2: ");

        //Console.WriteLine("Nhập số nguyên thứ nhất : ");
        //int so1= int.Parse(Console.ReadLine());

        //Console.WriteLine("Nhập số nguyên thứ hai : ");
        //int so2 = int.Parse(Console.ReadLine());

        //Console.WriteLine($"Hai số vừa nhập là {so1} và {so2}");

        //Console.WriteLine("Tổng 2 số là : " + (so1 + so2));

        //Console.WriteLine("Hiệu 2 số là : " + (so1 - so2));

        //Console.WriteLine("Tích 2 số là : " + (so1 * so2));

        //Console.WriteLine("Thương 2 số là : " + (so1 / so2));

        //Console.ReadKey();

        /*
         Bài 3. Viết chương trình java thực thi theo menu sau:

1.      Nhập vào họ tên của bạn

2.      Nhập vào điểm toán lý hóa.

3.      Tính tổng 3 môn

4.      Tính trung bình 3 môn.

5.      Thoát.
         
         */
        //Console.WriteLine("Chương trình bài 3: ");
        //Console.WriteLine("Nhập vào họ tên của bạn: ");
        //string name = Console.ReadLine();
        //Console.WriteLine("Tên của bạn vừa nhập là : " + name);

        //Console.WriteLine("Nhập vào điểm 3 môn Toán Lý Hóa: ");
        //Console.WriteLine("Nhập vào điểm Toán: ");
        //double dtoan = double.Parse(Console.ReadLine());
        //Console.WriteLine("Nhập vào điêmt Lý: ");
        //double dly = double.Parse(Console.ReadLine());
        //Console.WriteLine("Nhập vào điểm Hóa: ");
        //double dhoa = double.Parse(Console.ReadLine());

        //double tong3mon =dtoan+dly+dhoa;
        //double tb3mon = tong3mon / 3;
        //Console.WriteLine("tong 3 mon là: "+tong3mon);
        //Console.WriteLine("tb 3 môn toán lý hóa là: "+tb3mon);

        //Console.ReadKey();





        /* Bài 4
         

         * Viết chương trình java cho phép tạo và thực thi theo menu sau:

1.      Nhập vào một số nguyên dương n.

2.      Tính tổng các số từ 1 đến n

3.      Kiểm tra n có là số nguyên tố

4.      Kiểm tra n có là số hoàn hảo.

5.      In ra các số nguyên tố từ 1 đến n

6.      In ra các số hoàn hảo từ 1 đến n.

7.      Hiển thị số n thành tích các thừa số nguyên tố.

8.      Thoát
         */
        Console.WriteLine("Chương trình bài 4: ");
        Console.WriteLine("Nhập vào 1 số nguyên dương n :");
        int n= int.Parse(Console.ReadLine());
        int num = 0;
        for(int i = 0; i <= n;i++)
        {
            num = num+ i;
        }

        Console.WriteLine($"Tổng các số từ 1 đến {n} là : " + num);

        Console.WriteLine("Kiểm tra số nguyên tố");
        Console.Write("Nhap vao mot so: ");
        int number = int.Parse(Console.ReadLine());
        bool IsPrime = true;
        if (number < 2)
        {
            IsPrime = false;
        }
        for (int i = 2; i < number / 2; i++)
        {
            if (number % i == 0)
            {
                IsPrime = false;
                break;
            }
        }
        if (IsPrime)
        {
            Console.Write($"{number} la so nguyen to.");
        }
        else
        {
            Console.Write($"{number} khong phai so nguyen to.");
        }
        Console.ReadKey();


        Console.Write("Nhap vao so bat dau: ");
        int startNumber = int.Parse(Console.ReadLine());
        Console.Write("Nhap vao so ket thuc: ");
        int endNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Cac so nguyen to tu {startNumber} den {endNumber} la: ");
        for (int i = startNumber; i <= endNumber; i++)
        {
            int counter = 0;
            for (int j = 2; j <= i / 2; j++)
            {
                if (i % j == 0)
                {
                    counter++;
                    break;
                }
            }

            if (counter == 0 && i != 1)
            {
                Console.Write("{0} ", i);
            }
        }
        Console.ReadKey();
    }
}