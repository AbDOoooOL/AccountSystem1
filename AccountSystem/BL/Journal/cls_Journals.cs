using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AccountSystem.BL.Journal
{
    internal class cls_Journals
    {
        public DataTable Generate_Jno()
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();

            DataTable dt = new DataTable();
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            dt = con.selectData("Generate_Jno", para: null);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            con.closeConnection();
            return dt;
            
        }

        public void Journal_Hdr_Add(
            int jno,
            DateTime jdate,
            int Jtype,
            string jnote,
            int jpost ,
            double tdeb,
            double tcred,
            double bal,
            int uadd,
            DateTime adate, 
            int cno,
            double currexch,
            int ptype)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();

            SqlParameter[] para = new SqlParameter[13];

            para[0] = new SqlParameter("@J_No", SqlDbType.Int);
            para[0].Value = jno;

            para[1] = new SqlParameter("@J_Date", SqlDbType.DateTime);
            para[1].Value = jdate;

            para[2] = new SqlParameter("@J_Type", SqlDbType.Int);
            para[2].Value = Jtype;

            para[3] = new SqlParameter("@J_Note", SqlDbType.NVarChar,100);
            para[3].Value = jnote;

            para[4] = new SqlParameter("@J_Post", SqlDbType.Int);
            para[4].Value = jpost;

            para[5] = new SqlParameter("@T_Debit", SqlDbType.Money);
            para[5].Value = tdeb;

            para[6] = new SqlParameter("@T_Credit", SqlDbType.Money);
            para[6].Value = tcred;

            para[7] = new SqlParameter("@T_Balance", SqlDbType.Money);
            para[7].Value = bal;

            para[8] = new SqlParameter("@U_Add", SqlDbType.Int);
            para[8].Value = uadd;

            para[9] = new SqlParameter("@Add_Date", SqlDbType.DateTime);
            para[9].Value = adate;

            para[10] = new SqlParameter("@Curr_No", SqlDbType.Int);
            para[10].Value = cno;

            para[11] = new SqlParameter("@Curr_Exch", SqlDbType.Money);
            para[11].Value = currexch;

            para[12] = new SqlParameter("@pno", SqlDbType.Int);
            para[12].Value = ptype;

            con.ExcuteCmd("Journal_Hdr_Add", para);
            con.closeConnection();
        }

        public void Journal_Details_Add(int accno, double accdeb, double acccred, string accnote, int jno)
        {
            DAL.cn con = new DAL.cn();  
            con.openConnection();

            SqlParameter[] para = new SqlParameter[5];

            para[0] = new SqlParameter("@Acc_No", SqlDbType.Int);
            para[0].Value = accno;

            para[1] = new SqlParameter("@Acc_Debit", SqlDbType.Money);
            para[1].Value = accdeb;

            para[2] = new SqlParameter("@Acc_Credit", SqlDbType.Money);
            para[2].Value = acccred;

            para[3] = new SqlParameter("@Acc_Note", SqlDbType.NVarChar, 100);
            para[3].Value = accnote;

            para[4] = new SqlParameter("@J_No", SqlDbType.Int);
            para[4].Value = jno;

            con.ExcuteCmd("Journal_Bdy_Add", para); 
            con.closeConnection();
        }

        public DataTable Show_Journal_Header(int jno)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();

            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@J_No", SqlDbType.Int);
            para[0].Value = jno;

            dt = con.selectData("Show_Journal_Header", para);
            con.closeConnection();

            return dt;
        }

        public DataTable Show_Journal_Details(int jno)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();

            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@J_No", SqlDbType.Int);
            para[0].Value = jno;

            dt = con.selectData("Show_Journal_Details", para);
            con.closeConnection();

            return dt;
        }

        public void Journal_Hdr_Update(int jno, DateTime jdate, int Jtype, string jnote, int jpost, double tdeb, double tcred, double bal, int uedit, DateTime Edate, int cno, double currexch)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();

            SqlParameter[] para = new SqlParameter[12];

            para[0] = new SqlParameter("@J_No", SqlDbType.Int);
            para[0].Value = jno;

            para[1] = new SqlParameter("@J_Date", SqlDbType.DateTime);
            para[1].Value = jdate;

            para[2] = new SqlParameter("@J_Type", SqlDbType.Int);
            para[2].Value = Jtype;

            para[3] = new SqlParameter("@J_Note", SqlDbType.NVarChar, 100);
            para[3].Value = jnote;

            para[4] = new SqlParameter("@J_Post", SqlDbType.Int);
            para[4].Value = jpost;

            para[5] = new SqlParameter("@T_Debit", SqlDbType.Money);
            para[5].Value = tdeb;

            para[6] = new SqlParameter("@T_Credit", SqlDbType.Money);
            para[6].Value = tcred;

            para[7] = new SqlParameter("@T_Balance", SqlDbType.Money);
            para[7].Value = bal;

            para[8] = new SqlParameter("@U_Edit", SqlDbType.Int);
            para[8].Value = uedit;

            para[9] = new SqlParameter("@Edit_Date", SqlDbType.DateTime);
            para[9].Value = Edate;

            para[10] = new SqlParameter("@Curr_No", SqlDbType.Int);
            para[10].Value = cno;

            para[11] = new SqlParameter("@Curr_Exch", SqlDbType.Money);
            para[11].Value = currexch;

            con.ExcuteCmd("Journal_Hdr_Update", para);
            con.closeConnection();
        }

        public void Del_Journal_Header(int jno)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@J_No", SqlDbType.Int);
            para[0].Value = jno;

            con.ExcuteCmd("Journal_Hdr_Del", para);
            con.closeConnection();
        }

        public void Del_Journal_Details(int jno)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@J_No", SqlDbType.Int);
            para[0].Value = jno;

            con.ExcuteCmd("Journal_Bdy_Del", para);
            con.closeConnection();
        }

        public DataTable Get_Journal_First()
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();
            dt = con.selectData("Get_Journal_First", null);
            con.closeConnection();
            return dt;
        }
        public DataTable Get_Journal_Last()
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();
            dt = con.selectData("Get_Journal_Last", null);
            con.closeConnection();
            return dt;
        }
    }
}