using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBDB
{
    class CourseOffered
    {
        string coursenum;
        string semeseter;
        int maxenroll;
        int enrolledcount;
        string roomnumber;
        int profID;

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

        public string Semeseter
        {
            get
            {
                return semeseter;
            }

            set
            {
                semeseter = value;
            }
        }

        public int Maxenroll
        {
            get
            {
                return maxenroll;
            }

            set
            {
                maxenroll = value;
            }
        }

        public int Enrolledcount
        {
            get
            {
                return enrolledcount;
            }

            set
            {
                enrolledcount = value;
            }
        }

        public string Roomnumber
        {
            get
            {
                return roomnumber;
            }

            set
            {
                roomnumber = value;
            }
        }

        public int ProfID
        {
            get
            {
                return profID;
            }

            set
            {
                profID = value;
            }
        }
    }
}
