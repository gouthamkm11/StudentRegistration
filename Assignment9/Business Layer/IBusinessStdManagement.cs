using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBDB;

namespace Assignment9.Business_Layer
{
    interface IBusinessStdManagement
    {
        List<Courses> ComputerCourse();
        List<Courses> CECourse();
        List<Courses> EECourse();
        List<Courses> Math();
        List<Courses> TMCourse();
    }
}
