using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBDB;

namespace Assignment9.Data_Layer
{
    interface IRepositoryStdMang
    {
        List<Courses> ComputerCourse();
        List<Courses> CECourse();
        List<Courses> EECourse();
        List<Courses> Math();
        List<Courses> TMCourse();

    }
}
