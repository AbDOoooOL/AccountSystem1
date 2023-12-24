using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using AccountSystem.DAL;
using static System.Net.Mime.MediaTypeNames;

namespace AccountSystem.BL.SysFormat
{
    class cls_sysFormat
    {
        #region company
        public void AddCompany(string aname, string ename, string apos, string epos, string tel, string fax, string email, string website, byte[] image)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@C_Aname", SqlDbType.NVarChar, 200);
            para[0].Value = aname;

            para[1] = new SqlParameter("@C_Ename", SqlDbType.NVarChar, 200);
            para[1].Value = ename;

            para[2] = new SqlParameter("@C_Apos", SqlDbType.NVarChar, 200);
            para[2].Value = apos;

            para[3] = new SqlParameter("@C_Epos ", SqlDbType.NVarChar, 200);
            para[3].Value = epos;

            para[4] = new SqlParameter("@C_Tel", SqlDbType.NVarChar, 20);
            para[4].Value = tel;

            para[5] = new SqlParameter("@C_Fax", SqlDbType.NVarChar, 20);
            para[5].Value = fax;

            para[6] = new SqlParameter("@C_Email", SqlDbType.NVarChar, 50);
            para[6].Value = email;

            para[7] = new SqlParameter("@C_Website", SqlDbType.NVarChar, 20);
            para[7].Value = website;

            para[8] = new SqlParameter("@C_Logo", SqlDbType.Image);
            para[8].Value = image;

            con.ExcuteCmd("Comp_Add", para);
            con.closeConnection();
        }

        public void EditCompany(int cno, string aname, string ename, string apos, string epos, string tel, string fax, string email, string website, byte[] img)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[10];

            para[0] = new SqlParameter("@C_No", SqlDbType.Int);
            para[0].Value = cno;

            para[1] = new SqlParameter("@C_Aname", SqlDbType.NVarChar, 200);
            para[1].Value = aname;

            para[2] = new SqlParameter("@C_Ename", SqlDbType.NVarChar, 200);
            para[2].Value = ename;

            para[3] = new SqlParameter("@C_Apos", SqlDbType.NVarChar, 200);
            para[3].Value = apos;

            para[4] = new SqlParameter("@C_Epos ", SqlDbType.NVarChar, 200);
            para[4].Value = epos;

            para[5] = new SqlParameter("@C_Tel", SqlDbType.NVarChar, 20);
            para[5].Value = tel;

            para[6] = new SqlParameter("@C_Fax", SqlDbType.NVarChar, 20);
            para[6].Value = fax;

            para[7] = new SqlParameter("@C_Email", SqlDbType.NVarChar, 50);
            para[7].Value = email;

            para[8] = new SqlParameter("@C_Website", SqlDbType.NVarChar, 20);
            para[8].Value = website;

            para[9] = new SqlParameter("@C_Logo", SqlDbType.Image);
            para[9].Value = img;

            con.ExcuteCmd("Comp_Update", para);
            con.closeConnection();
        }

        public void DelCompany(int cno)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@C_No", SqlDbType.Int);
            para[0].Value = cno;

            con.ExcuteCmd("Comp_Del", para);
            con.closeConnection();

        }

        public DataTable Get_All_CompData()
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();
            dt = con.selectData("Get_All_CompData", null);
            con.closeConnection();
            return dt;
        }

        #endregion

        #region Funds

        #endregion

        #region cash

        public DataTable Get_All_Cash(int test)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@cash_test", SqlDbType.Int);
            para[0].Value = test;
            dt = con.selectData("Get_All_Cash", para);
            con.closeConnection();
            return dt;
        }

        public void Add_cash(int accno, string accname, int test)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@Acc_No", SqlDbType.Int);
            para[0].Value = accno;

            para[1] = new SqlParameter("@Acc_Aname", SqlDbType.NVarChar, 50);
            para[1].Value = accname;

            para[2] = new SqlParameter("@Test", SqlDbType.Int);
            para[2].Value = test;

            con.ExcuteCmd("Cash_Add", para);

            con.closeConnection();
        }

        public void Del_cash(int accno, int test)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@Acc_No", SqlDbType.Int);
            para[0].Value = accno;

            para[1] = new SqlParameter("@Test", SqlDbType.Int);
            para[1].Value = test;

            con.ExcuteCmd("Cash_Del", para);

            con.closeConnection();
        }

        public DataTable Get_All_Cashes()
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();
            dt = con.selectData("Get_All_Cashes", null);
            con.closeConnection();
            return dt;
        }

        public DataTable Get_Cash_Accno(string cashname)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
            DataTable dt = new DataTable();
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@C_Acc_Aname", SqlDbType.NVarChar,50);
            para[0].Value = cashname;
            dt = con.selectData("Get_All_Cashes", null);
            con.closeConnection();
            return dt;
        }
        #endregion

        #region Currencies
        public DataTable Get_All_Currencies()
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();

            DataTable dt = new DataTable();
            dt = con.selectData("Get_All_Currencies", null);

            con.closeConnection();
            return dt;
        }

        public void Currency_Add(string aname, string ename, string symbol, double exch, string part, int ctype)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();

            SqlParameter[] para = new SqlParameter[6];

            para[0] = new SqlParameter("@Curr_Aname", SqlDbType.NVarChar, 20);
            para[0].Value = aname;

            para[1] = new SqlParameter("@Curr_Ename", SqlDbType.NVarChar, 20);
            para[1].Value = ename;

            para[2] = new SqlParameter("@Curr_Symbol", SqlDbType.NVarChar, 3);
            para[2].Value = symbol;

            para[3] = new SqlParameter("@Curr_Exch", SqlDbType.Decimal);
            para[3].Value = exch;

            para[4] = new SqlParameter("@Curr_Part", SqlDbType.NVarChar, 10);
            para[4].Value = part;

            para[5] = new SqlParameter("@Curr_Type", SqlDbType.Int);
            para[5].Value = ctype;

            con.ExcuteCmd("Currency_Add", para);

            con.closeConnection();
        }

        public void Currency_Edit(int cno, string aname, string ename, string symbol, double exch, string part, int ctype)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();

            SqlParameter[] para = new SqlParameter[7];

            para[0] = new SqlParameter("@Curr_No", SqlDbType.Int);
            para[0].Value = cno;

            para[1] = new SqlParameter("@Curr_Aname", SqlDbType.NVarChar, 20);
            para[1].Value = aname;

            para[2] = new SqlParameter("@Curr_Ename", SqlDbType.NVarChar, 20);
            para[2].Value = ename;

            para[3] = new SqlParameter("@Curr_Symbol", SqlDbType.NVarChar, 3);
            para[3].Value = symbol;

            para[4] = new SqlParameter("@Curr_Exch", SqlDbType.Decimal);
            para[4].Value = exch;

            para[5] = new SqlParameter("@Curr_Part", SqlDbType.NVarChar, 10);
            para[5].Value = part;

            para[6] = new SqlParameter("@Curr_Type", SqlDbType.Int);
            para[6].Value = ctype;

            con.ExcuteCmd("Currency_Update", para);

            con.closeConnection();
        }

        public void Currency_Del(int cno)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@Curr_No", SqlDbType.Int);
            para[0].Value = cno;

            con.ExcuteCmd("Currency_Del", para);

            con.closeConnection();
        }

        public DataTable Get_Curr_Exch(string cname)
        {
            DAL.cn con = new DAL.cn();
            con.openConnection();
  
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter("@Curr_Aname", SqlDbType.NVarChar,20);
            para[0].Value = cname;

            DataTable dt = new DataTable();
            dt = con.selectData("Get_Curr_Exch", para);

            con.closeConnection();
            return dt;
        }

        #endregion         
    }
}
