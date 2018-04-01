using Assignment9.Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBDB;

namespace Assignment9.Business_Layer
{
    class Business : IBusinessStdManagement,IBusinessInitialize
    {
        public IRepositoryInitialize _irepInit = null;
        public IRepositoryStdMang _irepstdmang = null;
        public Business()
        {
            _irepInit = new Repository() as IRepositoryInitialize;
            _irepstdmang = new Repository() as IRepositoryStdMang;
        }
        public Business(IRepositoryInitialize irepInit, IRepositoryStdMang irepstdmang)
        {
            _irepInit = irepInit;
            _irepstdmang = irepstdmang;
        }

        public List<Courses> CECourse()
        {
            return _irepstdmang.CECourse();
        }

        public List<Courses> ComputerCourse()
        {
            return _irepstdmang.ComputerCourse();
        }

        public List<Courses> EECourse()
        {
            return _irepstdmang.EECourse();
        }

        public int InitializeDept(int depID, string depName)
        {
            return _irepInit.InitializeDept(depID, depName);
        }

        public int InitializeStudents(string StdID, string fn, string ln, string address, string city, string state, string telephone)
        {
            return _irepInit.InitializeStudents(StdID,fn,ln,address,city,state,telephone);
        }

        public List<Courses> Math()
        {
            return _irepstdmang.Math();
        }

        public List<Courses> TMCourse()
        {
            return _irepstdmang.TMCourse();
        }
    }
}