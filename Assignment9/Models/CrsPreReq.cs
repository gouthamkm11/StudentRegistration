using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBDB
{
    class CrsPreReq
    {
        string coursenum;
        string prereqcoursenum;

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

        public string Prereqcoursenum
        {
            get
            {
                return prereqcoursenum;
            }

            set
            {
                prereqcoursenum = value;
            }
        }
    }
}
