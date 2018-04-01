using Assignment9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBDB
{
    public partial class coursetaken : EntityBase
    {
        string studentId;
        string coursenum;
        string Semester;
        string Grade;
        string DepartmentID;

        public string StudentId
        {
            get
            {
                return studentId;
            }

            set
            {
                studentId = value;
            }
        }

        public string Coursenum
        {
            get
            {
                return coursenum;
            }

            set
            {
                coursenum = value;
            }
        }

        public string grade
        {
            get
            {
                return Grade;
}
            set
            {
                this.Grade = value;
            }
        }

        public string departmentID1
        {
            get
            {
                return DepartmentID;
            }

            set
            {
                this.DepartmentID = value;
            }
        }

        public string Semester1
        {
            get
            {
                return Semester;
            }

            set
            {
                this.Semester = value;
            }
        }
    }
}
