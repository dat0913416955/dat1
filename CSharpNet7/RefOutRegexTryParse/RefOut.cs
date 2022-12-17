namespace RefOutRegexTryParse;
internal class RefOut
{
    public static void ChangeVar( out int a,out int b)
    {
        a = 10; b=5;//out phải nhập giá trị vô trong 
        var tam = a;
        a = b; 
        b = tam;
        Console.WriteLine("change value: ");
        Console.WriteLine($"{nameof(a)} ={a},{nameof(b)} ={b}");
    }
}
