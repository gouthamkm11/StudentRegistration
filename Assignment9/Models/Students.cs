using Assignment9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBDB
{
    public partial class Students : EntityBase
    {
        string studentid;
        string firstname;
        string lastname;
        string streetaddress;
        string city;
        string state;
        string telephone;

        public string Studentid
        {
            get
            {
                return studentid;
            }

            set
            {
                studentid = value;
            }
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        public string Streetaddress
        {
            get
            {
                return streetaddress;
            }

            set
            {
                streetaddress = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public string Telephone
        {
            get
            {
                return telephone;
            }

            set
            {
                telephone = value;
            }
        }

    }
}
