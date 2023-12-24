using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountSystem.PL
{
    public partial class frm_logins : Form
    {
        public frm_logins()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BL.Users.Login log = new BL.Users.Login();
            dt = log.loginTest(txt_user.Text, txt_pwd.Text);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                frm_Main fm = new frm_Main();
                Program.uname = txt_user.Text;
                fm.Show();
            }
            else
            {
                MessageBox.Show("كلمة المرور او اسم المستخدم خطأ");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_logins_Load(object sender, EventArgs e)
        {

        }

        private void txt_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_pwd.Focus();
            }
        }

        private void txt_pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.Focus();
            }
        }
    }
}
