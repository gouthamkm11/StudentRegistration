using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBDB;

namespace Assignment9.Data_Layer
{
    interface IRepositoryInitialize
    {
        int InitializeStudents(string StdID, string fn, string ln, string address, string city, string state, string telephone);
        int InitializeDept(int depID, string depName);
    }
}
