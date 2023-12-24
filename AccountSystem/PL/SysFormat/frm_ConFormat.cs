using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountSystem.PL.SysFormat
{
    public partial class frm_ConFormat : Form
    {
        public frm_ConFormat()
        {
            InitializeComponent();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            txt_Mode.Enabled = true;
            txt_Mode.Text = "";
            txt_Mode.Focus();

            txt_Server.Enabled = true;
            txt_Server.Text = "";

            txt_DB.Enabled = true;
            txt_DB.Text = "";

            txt_User.Enabled = true;
            txt_User.Text = "";

            txt_PWD.Enabled = true;
            txt_PWD.Text = "";

            btn_Save.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Mode = txt_Mode.Text;
            Properties.Settings.Default.Server = txt_Server.Text;
            Properties.Settings.Default.DB = txt_DB.Text;
            Properties.Settings.Default.User = txt_User.Text;
            Properties.Settings.Default.PWD = txt_PWD.Text;

            Properties.Settings.Default.Save();
            MessageBox.Show("تمت عملية الحفظ بنجاح");
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            txt_Mode.Text = Properties.Settings.Default.Mode;
            txt_Server.Text = Properties.Settings.Default.Server;
            txt_DB.Text = Properties.Settings.Default.DB;
            txt_User.Text = Properties.Settings.Default.User;
            txt_PWD.Text = Properties.Settings.Default.PWD;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Mode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Server.Focus();
            }
        }

        private void txt_Server_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_DB.Focus();
            }
        }

        private void txt_DB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_User.Focus();
            }
        }

        private void txt_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_PWD.Focus();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Mode = "";
            Properties.Settings.Default.Server = "";
            Properties.Settings.Default.DB = "";
            Properties.Settings.Default.User = "";
            Properties.Settings.Default.PWD = "";

            MessageBox.Show("تم مسح البيانات بنجاح");
        }
    }
}
