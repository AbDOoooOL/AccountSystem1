using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountSystem.PL.Account
{
    public partial class frm_accounts : Form
    {
        BL.Account.cls_accounts ca = new BL.Account.cls_accounts();

        public frm_accounts()
        {
            InitializeComponent();
            Fill_cb();
        }

        public void Fill_cb()
        {
            Create_Node();

            cb_report.DataSource = ca.Get_All_FinalAcc();
            cb_report.ValueMember = "Acc_Rep_No";
            cb_report.DisplayMember = "Acc_Rep_Aname";

            cb_type.DataSource = ca.Get_All_AccType();
            cb_type.ValueMember = "Acc_Type_No";
            cb_type.DisplayMember = "Acc_Type_Aname";
        }

        private void Create_Node()
        {
            TreeNode tn;
            tv_accounts.Nodes.Clear();
            DataView dv = new DataView(ca.Get_All_Accounts());
            dv.RowFilter = "Acc_Parent_No=0";

            foreach (DataRowView drv in dv)
            {
                tn = new TreeNode(drv["Acc_No"].ToString() + "   " + drv["Acc_Aname"].ToString());
                tn.Tag = drv["Acc_No"].ToString();
                tv_accounts.Nodes.Add(tn);
            }
            foreach (TreeNode tnode in tv_accounts.Nodes)
            {
                Node_Child(tnode);
            }

        }

        void Node_Child(TreeNode nd)
        {
            TreeNode ctn;

            DataView dv = new DataView(ca.Get_All_Accounts());
            dv.RowFilter = "Acc_Parent_No=" + Convert.ToInt32(nd.Tag);

            foreach (DataRowView drv in dv)
            {
                ctn = new TreeNode(drv["Acc_No"].ToString() + "   " + drv["Acc_Aname"].ToString());
                ctn.Tag = drv["Acc_No"].ToString();
                nd.Nodes.Add(ctn);
                Node_Child(ctn);
            }
        }

        void clearnce()
        {
            foreach (var c in gp_input.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            clearnce();
            txt_no.Enabled = true;
            txt_no.Focus();
            btn_save.Enabled = true;
            cb_report.Enabled = true;
            cb_type.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                ca.Account_Add(
                    Convert.ToInt32(txt_no.Text),
                    Convert.ToInt32(txt_parent.Text),
                    txt_name.Text,
                    Convert.ToInt32(txt_level.Text),
                    Convert.ToDouble(txt_drbit.Text),
                    Convert.ToDouble(txt_credit.Text),
                    Convert.ToDouble(txt_balance.Text),
                    Convert.ToInt32(cb_report.SelectedValue),
                    Convert.ToInt32(cb_type.SelectedValue));

                Create_Node();
                btn_save.Enabled = false;
                MessageBox.Show("تمت عملية الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = ca.Account_Test(Convert.ToInt32(txt_no.Text));
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الحساب رئيسي ومرتبط بحسابات فرعية اخرى ولا يمكن تعديله", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable dt1 = new DataTable();
                dt1 = ca.Journal_Test(Convert.ToInt32(txt_no.Text));
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الحساب قد اجريت عليه عملية محاسبية ولا يمكن تعديله", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ca.Account_Edit(
                    Convert.ToInt32(txt_no.Text),
                    Convert.ToInt32(txt_parent.Text),
                    txt_name.Text,
                    Convert.ToInt32(txt_level.Text),
                    Convert.ToDouble(txt_drbit.Text),
                    Convert.ToDouble(txt_credit.Text),
                    Convert.ToDouble(txt_balance.Text),
                    Convert.ToInt32(cb_report.SelectedValue),
                    Convert.ToInt32(cb_type.SelectedValue));

                Create_Node();
                btn_save.Enabled = false;
                MessageBox.Show("تمت عملية التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ca.Account_Test(Convert.ToInt32(txt_no.Text));
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("هذا الحساب رئيسي ومرتبط بحسابات فرعية اخرى ولا يمكن حذفه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dt1 = new DataTable();
            dt1 = ca.Journal_Test(Convert.ToInt32(txt_no.Text));
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("هذا الحساب قد اجريت عليه عملية محاسبية ولا يمكن حذفه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("هل انت متأكد بأنك تريد حذف الحساب", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ca.AccountDel(Convert.ToInt32(txt_no.Text));
                Create_Node();
                clearnce();
                MessageBox.Show("تمت عملية الحذف بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tv_accounts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txt_tag.Text = tv_accounts.SelectedNode.Tag.ToString();
            btn_save.Enabled = false;
        }

        private void txt_tag_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ca.Get_Account_Alone(Convert.ToInt32(txt_tag.Text));
            if (dt.Rows.Count > 0)
            {
                txt_no.Text = dt.Rows[0][0].ToString();
                txt_parent.Text = dt.Rows[0][1].ToString();
                txt_name.Text = dt.Rows[0][2].ToString();
                txt_level.Text = dt.Rows[0][3].ToString();
                txt_drbit.Text = dt.Rows[0][4].ToString();
                txt_credit.Text = dt.Rows[0][5].ToString();
                txt_balance.Text = dt.Rows[0][6].ToString();

                cb_report.SelectedValue = dt.Rows[0][7].ToString();
                cb_type.SelectedValue = dt.Rows[0][8].ToString();
            }
        }

        private void txt_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            // the number from asci ----- 8 = backspace
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
