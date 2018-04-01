using Assignment9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBDB
{
    public partial class Departments : EntityBase
    {
        int DepartmentID;
        string DepartmentName;

        public int DepartmentID1
        {
            get
            {
                return DepartmentID;
            }

            set
            {
                DepartmentID = value;
            }
        }

        public string DepartmentName1
        {
            get
            {
                return DepartmentName;
            }

            set
            {
                DepartmentName = value;
            }
        }
    }
}
