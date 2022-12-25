using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismOverriding;
internal class ChildOne : Parent
{
    //Viết lại phương thức của cha (override)
    public override void Display() => Console.WriteLine("childone display");
    public new void Show() => Console.WriteLine("childone show");


}
