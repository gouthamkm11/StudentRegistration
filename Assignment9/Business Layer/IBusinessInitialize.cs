using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Business_Layer
{
    interface IBusinessInitialize
    {
        int InitializeStudents(string StdID, string fn, string ln, string address, string city, string state, string telephone);
        int InitializeDept(int depID, string depName);
    }
}
