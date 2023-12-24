using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.BL.Users
{
    class cls_Users
    {
        public DataTable Generate_Uid()
        {
            DAL.cn con = new DAL.cn();  
            con.openConnection();
            DataTable dt = new DataTable();
            dt = con.selectData("Generate_Uid", null);
            con.closeConnection();
            return dt;
        }

        public DataTable Get_All_Users()
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();
            dt = con.selectData("Get_all_Users", null);
            con.closeConnection();
            return dt;
        }

        public void Add_User(int uno,string fname, string name, string pwd, string tel, string email, int status, int utype, byte[] img)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[9];

            para[0] = new SqlParameter("@U_No", SqlDbType.Int);
            para[0].Value = uno;
            para[1] = new SqlParameter("@U_Fname", SqlDbType.NVarChar,60);
            para[1].Value = fname;
            para[2] = new SqlParameter("@U_Name", SqlDbType.NVarChar, 10);
            para[2].Value = name;
            para[3] = new SqlParameter("@U_PWD", SqlDbType.NVarChar, 20);
            para[3].Value = pwd;
            para[4] = new SqlParameter("@U_Tel", SqlDbType.NVarChar, 20);
            para[4].Value = tel;
            para[5] = new SqlParameter("@U_Email", SqlDbType.NVarChar, 50);
            para[5].Value = email;
            para[6] = new SqlParameter("@U_Status", SqlDbType.Int);
            para[6].Value = status;
            para[7] = new SqlParameter("@U_Type", SqlDbType.Int);
            para[7].Value = utype;
            para[8] = new SqlParameter("@U_IMG", SqlDbType.Image);
            para[8].Value = img;
            
            con.ExcuteCmd("User_Add", para);
            con.closeConnection();
        }

        public void Edit_User(int uno, string fname, string name, string pwd, string tel, string email, int status, int utype, byte[] img)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[9];

            para[0] = new SqlParameter("@U_No", SqlDbType.Int);
            para[0].Value = uno;
            para[1] = new SqlParameter("@U_Fname", SqlDbType.NVarChar, 60);
            para[1].Value = fname;
            para[2] = new SqlParameter("@U_Name", SqlDbType.NVarChar, 10);
            para[2].Value = name;
            para[3] = new SqlParameter("@U_PWD", SqlDbType.NVarChar, 20);
            para[3].Value = pwd;
            para[4] = new SqlParameter("@U_Tel", SqlDbType.NVarChar, 20);
            para[4].Value = tel;
            para[5] = new SqlParameter("@U_Email", SqlDbType.NVarChar, 50);
            para[5].Value = email;
            para[6] = new SqlParameter("@U_Status", SqlDbType.Int);
            para[6].Value = status;
            para[7] = new SqlParameter("@U_Type", SqlDbType.Int);
            para[7].Value = utype;
            para[8] = new SqlParameter("@U_IMG", SqlDbType.Image);
            para[8].Value = img;

            con.ExcuteCmd("User_Update", para);
            con.closeConnection();
        }

        public void Del_User(int uno)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@U_No", SqlDbType.Int);
            para[0].Value = uno;

            con.ExcuteCmd("User_Del", para);
            con.closeConnection();
        }

        public DataTable Get_User_No(string uname)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@U_Name", SqlDbType.NVarChar, 10);
            para[0].Value = uname;

            dt = con.selectData("Get_User_No", para);
            con.closeConnection();
            return dt;
        }
    }
}