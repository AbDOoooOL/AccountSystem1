using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace AccountSystem.DAL
{
    class cn
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        //constroctor to connection
        public cn() 
        {
            //conn = new SqlConnection(@"Data Source=(localdb)\Local;Initial Catalog=AccDBs;Integrated Security=True");
            //conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DB + ";Integrated Security=True");
            string mode = Properties.Settings.Default.Mode;
            try 
            {
                if (mode == "Win")
                {
                    //conn = new SqlConnection(@"Data Source=(localdb)\Local;Initial Catalog=AccDBs;Integrated Security=True");

                    conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DB + ";Integrated Security=True");
                }
                else
                {
                    conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DB + "; integrated security=false ; user id = " + Properties.Settings.Default.User + ";password=" + Properties.Settings.Default.PWD + "");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            

        }
        //method to open connection
        public void openConnection()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        //method to close connection
        public void closeConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
        }
        //method to insert,update,delete from DB using stored procedure
        public void ExcuteCmd(string sp, SqlParameter[] para)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;
                cmd.Connection = conn;
                if (para != null)
                {
                    cmd.Parameters.AddRange(para);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        //method to read (select) data from DB using stored procedure
        public DataTable selectData(string sp, SqlParameter[] para)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            cmd.Connection = conn;

            if (para != null)
            {
                for(int j=0; j<para.Length; j++)
                {
                    cmd.Parameters.Add(para[j]);
                }
            }
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dt.Clear();

            sda.Fill(dt);
            return dt;
        }
    }
}
