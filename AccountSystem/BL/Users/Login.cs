using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccountSystem.BL.Users
{
    class Login
    {
        public DataTable loginTest(string user, string pwd)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[2];
            para[0]=new SqlParameter("@U_Name", SqlDbType.NVarChar,20);
            para[0].Value = user;

            para[1] = new SqlParameter("@U_PWD", SqlDbType.NVarChar, 20);
            para[1].Value = pwd;

            DataTable dt = new DataTable();
            dt = con.selectData("Login_Test", para);
            con.closeConnection();
            return dt;
        }
    }
}
