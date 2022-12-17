
namespace RefOutRegexTryParse;
internal class RegexTryParse
{
    public void CheckNumberByRegex()
    {
        string? str = null;
        Console.WriteLine("Vui lòng nhập số: ");
        str = Console.ReadLine();

        if (new Regex("^[0-9]+$").IsMatch(str))
        {
            int result = int.Parse(str);//nhược điểm : nếu k phải là số bắt lỗi
            Console.WriteLine($"{nameof(result)}={result}");
        }
    }
    public void CheckStringByRegex()
    {
        string? str = null;
        Console.WriteLine("Vui lòng nhập số: ");
        str = Console.ReadLine();

        if(double.TryParse(str,out double i))
        {
            Console.WriteLine($"{nameof(i)}={i}");
        }

        double a = 12.78;
        Console.WriteLine(a);
    }
    public void TryCatchBug()
    {
        Console.WriteLine("Vui lòng nhập số lượng: ");
        string? amount  = Console.ReadLine();
        try
        {
            int total = int.Parse(amount);
            if(total <= 0)
            {
                throw new Exception("phải lớn hơn 0");
            }
        }
        catch (Exception) when (amount.Contains("$"))
        {
            Console.WriteLine("amount ko dc có dấu $");
        }
        catch(Exception e)
        {
            //Console.WriteLine(e.GetType()+" : "+e.Message);
            Console.WriteLine($"{e.GetType()}: {e.Message}");
            throw;
        }
       
    }
}
