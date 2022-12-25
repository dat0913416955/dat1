using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulation;
public class Plant
{

    //access modifier => các bổ từ truy cập
    private             void Private()             => Console.WriteLine("private");
    protected           void Protected()           => Console.WriteLine("protected");
    internal            void Internal()            => Console.WriteLine("internal");
    private protected   void PrivateProtected()    => Console.WriteLine("privateprotected");
    protected internal  void ProtectedInternal()   => Console.WriteLine("protectedinternal");
    public              void Public()              => Console.WriteLine("public");
    //svm tab
    static void Main(string[] args)
    {
        Plant plant = new();
        plant.Private();
        plant.Protected();
        plant.ProtectedInternal();
        plant.Internal();
        plant.ProtectedInternal();
        plant.Public();
    }
}
