using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem.BL.Account
{
    class cls_accounts
    {   
        public DataTable Get_All_FinalAcc()
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();
            dt = con.selectData("Get_All_AccReps", null);
            con.closeConnection();
            return dt;
        }

        public DataTable Get_All_AccType()
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();
            dt = con.selectData("Get_All_AccTypes", null);
            con.closeConnection();
            return dt;
        }

        public DataTable Get_All_Accounts()
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();
            dt = con.selectData("Get_All_Accounts", null);
            con.closeConnection();
            return dt;
        }

        public DataTable Get_Account_Alone(int accno)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();

            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Acc_No",SqlDbType.Int);
            para[0].Value = accno;
            dt = con.selectData("Get_Account_Alone", para);
            con.closeConnection();
            return dt;
        }

        public void Account_Add(int accno, int accparent,string accname, int acclvl, double debit, double credit ,double bal, int rep,int atype)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();

            SqlParameter[] para = new SqlParameter[9];

            para[0] = new SqlParameter("@Acc_No", SqlDbType.Int);
            para[0].Value = accno;

            para[1] = new SqlParameter("@Acc_Parent_No", SqlDbType.Int);
            para[1].Value = accparent;

            para[2] = new SqlParameter("@Acc_Aname", SqlDbType.NVarChar,50);
            para[2].Value = accname;

            para[3] = new SqlParameter("@Acc_Level", SqlDbType.Int);
            para[3].Value = acclvl;

            para[4] = new SqlParameter("@Acc_Debit", SqlDbType.Decimal);
            para[4].Value = debit;

            para[5] = new SqlParameter("@Acc_Credit", SqlDbType.Decimal);
            para[5].Value = credit;

            para[6] = new SqlParameter("@Acc_Balance", SqlDbType.Decimal);
            para[6].Value = bal;

            para[7] = new SqlParameter("@Acc_Report", SqlDbType.Int);
            para[7].Value = rep;

            para[8] = new SqlParameter("@Acc_Type", SqlDbType.Int);
            para[8].Value = atype;

            con.ExcuteCmd("Account_Add", para);
            con.closeConnection();
        }

        public void Account_Edit(int accno, int accparent, string accname, int acclvl, double debit, double credit, double bal, int rep, int atype)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();

            SqlParameter[] para = new SqlParameter[9];

            para[0] = new SqlParameter("@Acc_No", SqlDbType.Int);
            para[0].Value = accno;

            para[1] = new SqlParameter("@Acc_Parent_No", SqlDbType.Int);
            para[1].Value = accparent;

            para[2] = new SqlParameter("@Acc_Aname", SqlDbType.NVarChar, 50);
            para[2].Value = accname;

            para[3] = new SqlParameter("@Acc_Level", SqlDbType.Int);
            para[3].Value = acclvl;

            para[4] = new SqlParameter("@Acc_Debit", SqlDbType.Decimal);
            para[4].Value = debit;

            para[5] = new SqlParameter("@Acc_Credit", SqlDbType.Decimal);
            para[5].Value = credit;

            para[6] = new SqlParameter("@Acc_Balance", SqlDbType.Decimal);
            para[6].Value = bal;

            para[7] = new SqlParameter("@Acc_Report", SqlDbType.Int);
            para[7].Value = rep;

            para[8] = new SqlParameter("@Acc_Type", SqlDbType.Int);
            para[8].Value = atype;

            con.ExcuteCmd("Account_Update", para);
            con.closeConnection();
        }

        public void AccountDel(int accno)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@Acc_No", SqlDbType.Int);
            para[0].Value = accno;

            con.ExcuteCmd("Account_Del", para); 
            con.closeConnection();

        }

        public DataTable Account_Test(int accno)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();

            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Acc_NO", SqlDbType.Int);
            para[0].Value = accno;

            dt = con.selectData("Account_Test", para);
            con.closeConnection();
            return dt;
        }

        public DataTable Journal_Test(int accno)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();

            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Acc_NO", SqlDbType.Int);
            para[0].Value = accno;

            dt = con.selectData("Journal_Test", para);
            con.closeConnection();
            return dt;
        }

        public DataTable Search_In_Accounts(string txt)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();

            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@txt", SqlDbType.Int);
            para[0].Value = txt;

            dt = con.selectData("Search_In_Accounts", para);
            con.closeConnection();
            return dt;
        }
    }
}
