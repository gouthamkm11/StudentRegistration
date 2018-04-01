using Assignment9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBDB
{
    public partial class Courses : EntityBase
    {
        string CourseNum { get; set; }
        string CourseName { get; set; }
        int CreditHours { get; set; }
        string Description { get; set; }
        int Deptid { get; set; }
    }
}
        