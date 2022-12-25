using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulationProperty;
internal class Human
{
    //field(phải là private)
    private string fullname;
    

    //property => mobile
    public string Fullname { 
        get => fullname;
        set => fullname = value;
    }
    

    //Auto - property => dập cái field thành thuộc tính
    public string Address { private get; set; }

    //các phương thức getter setter
    //các thuộc tính phải có bổ từ truy cập là public
    //public string FullName
    //{
    //    set => fullname= value;
    //    get => fullname;

    //}
     
   
}
