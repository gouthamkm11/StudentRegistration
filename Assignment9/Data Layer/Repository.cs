using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBDB;

namespace Assignment9.Data_Layer
{
    class Repository : IRepositoryInitialize,IRepositoryStdMang
    {
        IDataAccess _idac = null;
        public Repository()
        {
            string CONNSTR = "server =GOUTHAM\\SQLEXPRESS ; Integrated Security = True; Database = UBDB";
            _idac = new DataAccess(CONNSTR);
        }
        public Repository (IDataAccess idac)
        {
            _idac = idac;
        }

        public List<Courses> CECourse()
        {
            try
            {
                List<Courses> ct = null;
                try
                {
                    string sql = "select * from dbo.Table_Courses where DepartmentID = @DepartmentID";
                    List<DbParameter> ParamList = new List<DbParameter>();
                    SqlParameter p1 = new SqlParameter("@DepartmentID", SqlDbType.VarChar);
                    p1.Value = 1002;
                    ParamList.Add(p1);
                    DataTable dt = _idac.GetManyRowsandColumns(sql, ParamList);
                    ct = DBList.ToList<Courses>(dt);
                }
                catch (Exception)
                {
                    throw;
                }
                return ct;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Courses> ComputerCourse()
        {
            try
            {
                List<Courses> ct = null;
                try
                {
                    string sql = "select * from dbo.Table_Courses where DepartmentID = @DepartmentID";
                    List<DbParameter> ParamList = new List<DbParameter>();
                    SqlParameter p1 = new SqlParameter("@DepartmentID", SqlDbType.VarChar);
                    p1.Value = 1001;
                    ParamList.Add(p1);
                    DataTable dt = _idac.GetManyRowsandColumns(sql, ParamList);
                    ct = DBList.ToList<Courses>(dt);
                }
                catch (Exception)
                {
                    throw;
                }
                return ct;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Courses> EECourse()
        {
            try
            {
                List<Courses> ct = null;
                try
                {
                    string sql = "select * from dbo.Table_Courses where DepartmentID = @DepartmentID";
                    List<DbParameter> ParamList = new List<DbParameter>();
                    SqlParameter p1 = new SqlParameter("@DepartmentID", SqlDbType.VarChar);
                    p1.Value = 1003;
                    ParamList.Add(p1);
                    DataTable dt = _idac.GetManyRowsandColumns(sql, ParamList);
                    ct = DBList.ToList<Courses>(dt);
                }
                catch (Exception)
                {
                    throw;
                }
                return ct;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int InitializeDept(int depID, string depName)
        {
            int res = 0;
            try
            {
                string sql = "Insert into dbo.Table_Dept (DepartmentID,DepartmentName) values (@DepartmentID,@DepartmentName)";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@DepartmentID", SqlDbType.VarChar, 10);
                p1.Value = depID;
                ParamList.Add(p1);
                SqlParameter p2 = new SqlParameter("@DepartmentName", SqlDbType.VarChar, 10);
                p2.Value = depName;
                ParamList.Add(p2);
                res = _idac.InsertUpdateDelete(sql, ParamList);
            }
            catch (Exception)
            {
                throw;
            }
            return res;
        }

        public int InitializeStudents(string StdID, string fn, string ln, string address, string city, string state, string telephone)
        {
            int res = 0;
            try
            {
                string sql = "Insert into dbo.Table_StudentDetails (StudentID,FirstName, LastName,StreetAddress,City,State,Telephone) values (@StudentID,@FirstName,@LastName,@StreetAddress,@City,@State,@Telephone)";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@StudentID", SqlDbType.VarChar,10);
                p1.Value = StdID;
                ParamList.Add(p1);
                SqlParameter p2 = new SqlParameter("@FirstName", SqlDbType.VarChar,10);
                p2.Value = fn;
                ParamList.Add(p2);
                SqlParameter p3 = new SqlParameter("@LastName", SqlDbType.VarChar,10);
                p3.Value = ln;
                ParamList.Add(p3);
                SqlParameter p4 = new SqlParameter("@StreetAddress", SqlDbType.VarChar,100);
                p4.Value = address;
                ParamList.Add(p4);
                SqlParameter p5 = new SqlParameter("@City", SqlDbType.VarChar,50);
                p5.Value = city;
                ParamList.Add(p5);
                SqlParameter p6 = new SqlParameter("@State", SqlDbType.VarChar,50);
                p6.Value = state;
                ParamList.Add(p6);
                SqlParameter p7 = new SqlParameter("@Telephone", SqlDbType.VarChar,50);
                p7.Value = telephone;
                ParamList.Add(p7);
                res = _idac.InsertUpdateDelete(sql, ParamList);
            }
            catch(Exception)
            {
                throw;
            }
            return res;
        }

        public List<Courses> Math()
        {
            try
            {
                List<Courses> ct = null;
                try
                {
                    string sql = "select * from dbo.Table_Courses where DepartmentID = @DepartmentID";
                    List<DbParameter> ParamList = new List<DbParameter>();
                    SqlParameter p1 = new SqlParameter("@DepartmentID", SqlDbType.VarChar);
                    p1.Value = 1004;
                    ParamList.Add(p1);
                    DataTable dt = _idac.GetManyRowsandColumns(sql, ParamList);
                    ct = DBList.ToList<Courses>(dt);
                }
                catch (Exception)
                {
                    throw;
                }
                return ct;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Courses> TMCourse()
        {
            try
            {
                List<Courses> ct = null;
                try
                {
                    string sql = "select * from dbo.Table_Courses where DepartmentID = @DepartmentID";
                    List<DbParameter> ParamList = new List<DbParameter>();
                    SqlParameter p1 = new SqlParameter("@DepartmentID", SqlDbType.VarChar);
                    p1.Value = 1005;
                    ParamList.Add(p1);
                    DataTable dt = _idac.GetManyRowsandColumns(sql, ParamList);
                    ct = DBList.ToList<Courses>(dt);
                }
                catch (Exception)
                {
                    throw;
                }
                return ct;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}