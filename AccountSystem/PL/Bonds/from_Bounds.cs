using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountSystem.PL.Bonds
{
    public partial class from_Bounds : Form
    {
        BL.Users.cls_Users cu = new BL.Users.cls_Users();
        BL.SysFormat.cls_sysFormat sf = new BL.SysFormat.cls_sysFormat();
        BL.Bonds.cls_Bonds cb = new BL.Bonds.cls_Bonds();
        BL.Journal.cls_Journals cj = new BL.Journal.cls_Journals();

        public from_Bounds()
        {
            InitializeComponent();
        }

        void show()
        {
            cb_currency.DataSource = sf.Get_All_Currencies();
            cb_currency.ValueMember = "Curr_No";
            cb_currency.DisplayMember = "Curr_Aname";

            cb_cash.DataSource = sf.Get_All_Cashes();
            cb_cash.ValueMember = "C_Acc_No";
            cb_cash.DisplayMember = "C_Acc_Aname";
        }
        void clear()
        {
            dtp_bdate.Value = DateTime.Now;
            txt_note.Text = string.Empty;
            chk_post.Checked = false;
            dgv_bonds.Rows.Clear();

        }
        private void from_Bounds_Load(object sender, EventArgs e)
        {
            txt_bno.Text = "0";
            txt_jno.Text = "0";

            txt_user.Text = Program.uname;
            txt_uno.Text = cu.Get_User_No(Program.uname).Rows[0][0].ToString();
            show();

        }

        private void cb_currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = sf.Get_Curr_Exch(cb_currency.Text);

            if (dt.Rows.Count > 0)
            {
                txt_exch.Text = dt.Rows[0][2].ToString();
                txt_note.Focus();
            }
        }

        private void cb_cash_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = sf.Get_Cash_Accno(cb_cash.Text);
            if (dt.Rows.Count > 0)
            {
                txt_cash_accno.Text = dt.Rows[0][0].ToString();
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_bno.Text = cb.Generate_Bno(Convert.ToInt32(txt_btype.Text)).Rows[0][0].ToString();
            txt_jno.Text = cj.Generate_Jno().Rows[0][0].ToString();

            show();
            clear();

        }

        private void select_account_Click(object sender, EventArgs e)
        {
            PL.Account.ffrm_search fs = new Account.ffrm_search();
            fs.ShowDialog();
            if (fs.IsOk == true)
            {
                txt_accno.Text = fs.dgv_results.CurrentRow.Cells[0].Value.ToString();
                txt_accname.Text = fs.dgv_results.CurrentRow.Cells[2].Value.ToString();
                txt_amount.Focus();
            }
        }

        void Row_Clear()
        {
            txt_accno.Text = "";
            txt_accname.Text = "";
            txt_amount.Text = "0.00";
            txt_exp.Text = "";

            cb_currency.DataSource = sf.Get_All_Currencies();
            cb_currency.ValueMember = "Curr_No";
            cb_currency.DisplayMember = "Curr_Aname";
        }

        void Total_Amount()
        {
            double TA = 0.00;
            for (int i = 0; i < dgv_bonds.Rows.Count; i++)
            {
                TA = TA + Convert.ToDouble(dgv_bonds.Rows[i].Cells[8].Value);
            }
            txt_Tamount.Text = TA.ToString();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (txt_accno.Text == "")
            {
                MessageBox.Show("يجب اختيار رقم الحساب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_amount.Text == "0.00")
            {
                MessageBox.Show("يجب ادخال المبلع اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (txt_exch.Text == "0.00")
            {
                MessageBox.Show("يجب اختيار عملة السند", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            for (int i = 0; i < dgv_bonds.Rows.Count; i++)
            {
                if (dgv_bonds.Rows[i].Cells[1].Value.ToString() == txt_accno.Text)
                {
                    MessageBox.Show("رقم الحساب موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            double TA = 0.00;
            TA = Convert.ToDouble(txt_amount.Text) * Convert.ToDouble(txt_exch.Text);

            dgv_bonds.Rows.Add(txt_bno.Text, txt_accno.Text, txt_accname.Text, txt_amount.Text, cb_currency.SelectedValue, cb_currency.Text, txt_exch.Text, txt_exp.Text, TA);
            Total_Amount();
            Row_Clear();
        }

        void Edit_Row()
        {
            txt_accno.Text = dgv_bonds.CurrentRow.Cells[1].Value.ToString();
            txt_accname.Text = dgv_bonds.CurrentRow.Cells[2].Value.ToString();
            txt_amount.Text = dgv_bonds.CurrentRow.Cells[3].Value.ToString();
            cb_currency.SelectedValue = dgv_bonds.CurrentRow.Cells[4].Value.ToString();
            txt_exch.Text = dgv_bonds.CurrentRow.Cells[6].Value.ToString();
            txt_exp.Text = dgv_bonds.CurrentRow.Cells[7].Value.ToString();
            dgv_bonds.Rows.RemoveAt(dgv_bonds.CurrentRow.Index);

        }
        private void dgv_bonds_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit_Row();
            Total_Amount();
        }

        private void حذفصفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_bonds.Rows.RemoveAt(dgv_bonds.CurrentRow.Index);
            Total_Amount();

        }

        private void تعديلصفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Row();
            Total_Amount();
        }

        void Bond_Hdr_Add()
        {
            int bpost = 0;
            if (chk_post.Checked == true)
            {
                bpost = 1;
            }
            else
            {
                bpost = 0;
            }

            DateTime adate = DateTime.Now;
            int bankno = 0;

            cb.Bond_Hdr_Add(
                Convert.ToInt32(txt_bno.Text),
                Convert.ToDateTime(dtp_bdate.Value),
                Convert.ToInt32(txt_btype.Text),
                bpost,
                txt_note.Text,
                Convert.ToDouble(txt_Tamount.Text),
                Convert.ToInt32(txt_cash_accno.Text),
                bankno,
                Convert.ToInt32(txt_uno.Text),
                adate,
                Convert.ToInt32(txt_jno.Text)
                );
        }
        void Bond_Details_Add()
        {
            for (int i = 0; i < dgv_bonds.Rows.Count; i++)
            {
                int accno = Convert.ToInt32(dgv_bonds.Rows[i].Cells[1].Value);
                double amount = Convert.ToDouble(dgv_bonds.Rows[i].Cells[3].Value);
                string note = dgv_bonds.Rows[i].Cells[7].Value.ToString();
                int currno = Convert.ToInt32(dgv_bonds.Rows[i].Cells[4].Value);
                double cexch = Convert.ToDouble(dgv_bonds.Rows[i].Cells[6].Value);
                int bno = Convert.ToInt32(dgv_bonds.Rows[i].Cells[0].Value);

                cb.Bond_Details_Add(accno, amount, note, currno, cexch, bno);
            }
        }
        void Journal_Hdr_Add()
        {
            int jtype = 1;
            int jpost = 0;
            if (chk_post.Checked == true)
            {
                jpost = 1;
            }
            else
            {
                jpost = 0;
            }
            double bal = 0;
            DateTime adate = DateTime.Now;
            cj.Journal_Hdr_Add(

                Convert.ToInt32(txt_jno.Text),
                Convert.ToDateTime(dtp_bdate.Value),
                jtype,
                txt_note.Text,
                jpost,
                Convert.ToDouble(txt_Tamount.Text),
                Convert.ToDouble(txt_Tamount.Text),
                bal,
                Convert.ToInt32(txt_uno.Text),
                adate,
                Convert.ToInt32(cb_currency.SelectedValue),
                Convert.ToDouble(txt_exch.Text),
                Convert.ToInt32(txt_btype.Text)

                );
        }
        void Journal_Details_Add()
        {
            if (txt_btype.Text == "2")
            {
                // from account the other to account the box

                for (int i = 0; i < dgv_bonds.Rows.Count; i++)
                {
                    cj.Journal_Details_Add(

                        Convert.ToInt32(dgv_bonds.Rows[i].Cells[1].Value),
                        Convert.ToDouble(dgv_bonds.Rows[i].Cells[8].Value),
                        0,
                        dgv_bonds.Rows[i].Cells[7].Value.ToString(),
                        Convert.ToInt32(dgv_bonds.Rows[i].Cells[0].Value)

                        );
                }
                cj.Journal_Details_Add(

                    Convert.ToInt32(txt_cash_accno.Text),
                    0,
                    Convert.ToDouble(txt_Tamount.Text),
                    txt_note.Text,
                    Convert.ToInt32(txt_jno.Text)
                    );
            }
            else
            {
                // from account the box to account the other

                for (int i = 0; i < dgv_bonds.Rows.Count; i++)
                {
                    cj.Journal_Details_Add(

                        Convert.ToInt32(dgv_bonds.Rows[i].Cells[1].Value),
                        0,
                        Convert.ToDouble(dgv_bonds.Rows[i].Cells[8].Value),
                        dgv_bonds.Rows[i].Cells[7].Value.ToString(),
                        Convert.ToInt32(dgv_bonds.Rows[i].Cells[0].Value)

                        );
                }
                cj.Journal_Details_Add(

                    Convert.ToInt32(txt_cash_accno.Text),
                    Convert.ToDouble(txt_Tamount.Text),
                    0,
                    txt_note.Text,
                    Convert.ToInt32(txt_jno.Text)
                    );
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Bond_Hdr_Add();
                Bond_Details_Add();
                Journal_Hdr_Add();
                Journal_Details_Add();
                MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية حفظ سند", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("يجب التحقق من البيانات التي قمت بإدخالها" + ex, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            txt_bound_no.Text = txt_search.Text;
        }

        void show_bond_hdr()
        {
            DataTable dt = new DataTable();
            dt = cb.Show_Bond_Hdr(Convert.ToInt32(txt_bound_no.Text));

            if (dt.Rows.Count > 0)
            {
                txt_bno.Text = dt.Rows[0][0].ToString();
                dtp_bdate.Text = dt.Rows[0][1].ToString();
                txt_btype.Text = dt.Rows[0][2].ToString();
                txt_jno.Text = dt.Rows[0][13].ToString();

                if (dt.Rows[0][3].ToString() == "1")
                {
                    chk_post.Checked = true;
                }
                else
                {
                    chk_post.Checked = false;
                }
                txt_note.Text = dt.Rows[0][4].ToString();
                txt_Tamount.Text = dt.Rows[0][5].ToString();
                cb_cash.SelectedValue = dt.Rows[0][6];
                txt_uno.Text = dt.Rows[0][8].ToString();
                txt_user.Text = dt.Rows[0][9].ToString();

            }
        }
        void show_bond_details()
        {
            DataTable dt = new DataTable();
            dt = cb.Show_Bond_Details(Convert.ToInt32(txt_bound_no.Text));

            if (dt.Rows.Count > 0)
            {
                dgv_bonds.Rows.Clear();
                int i = 0;
                dgv_bonds.RowCount = dt.Rows.Count;
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    dgv_bonds.Rows[i].Cells[0].Value = dt.Rows[j][7].ToString();
                    dgv_bonds.Rows[i].Cells[1].Value = dt.Rows[j][0].ToString();
                    dgv_bonds.Rows[i].Cells[2].Value = dt.Rows[j][1].ToString();
                    dgv_bonds.Rows[i].Cells[3].Value = dt.Rows[j][2].ToString();
                    dgv_bonds.Rows[i].Cells[4].Value = dt.Rows[j][4].ToString();
                    dgv_bonds.Rows[i].Cells[5].Value = dt.Rows[0][5].ToString();
                    dgv_bonds.Rows[i].Cells[6].Value = dt.Rows[0][6].ToString();
                    dgv_bonds.Rows[i].Cells[7].Value = dt.Rows[0][3].ToString();
                    dgv_bonds.Rows[i].Cells[8].Value = Convert.ToDouble(dt.Rows[j][2]) * Convert.ToDouble(dt.Rows[0][6]);

                    i++;
                }
            }
        }
        private void txt_bound_no_TextChanged(object sender, EventArgs e)
        {
            try
            {
                show_bond_hdr();
                show_bond_details();
            }
            catch (Exception ex)
            {
                MessageBox.Show("يجب التحقق من البيانات التي قمت بإدخالها" + ex, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void Bond_Hdr_Update()
        {
            int bpost = 0;
            if (chk_post.Checked == true)
            {
                bpost = 1;
            }
            else
            {
                bpost = 0;
            }

            DateTime adate = DateTime.Now;
            int bankno = 0;

            cb.Bond_Hdr_Edit(
                Convert.ToInt32(txt_bno.Text),
                Convert.ToDateTime(dtp_bdate.Value),
                Convert.ToInt32(txt_btype.Text),
                bpost,
                txt_note.Text,
                Convert.ToDouble(txt_Tamount.Text),
                Convert.ToInt32(txt_cash_accno.Text),
                bankno,
                Convert.ToInt32(txt_uno.Text),
                adate,
                Convert.ToInt32(txt_jno.Text)
                );
        }

        void Bond_Details_Del()
        {
            cb.Bond_Details_Del(Convert.ToInt32(txt_bno.Text));
        }

        void Journal_Hdr_Del()
        {
            cj.Del_Journal_Header(Convert.ToInt32(txt_jno.Text));
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                Bond_Hdr_Update();
                Bond_Details_Del();
                Bond_Details_Add();
                Journal_Hdr_Del();
                Journal_Hdr_Add();
                Journal_Details_Add();


                MessageBox.Show("تمت عملية التعديل بنجاح", "عملية تعديل سند", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("يجب التحقق من البيانات التي قمت بإدخالها" + ex, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد حذف السند", "تنبيه حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cj.Del_Journal_Header(Convert.ToInt32(txt_jno.Text));
                    cb.Bond_Hdr_Del(Convert.ToInt32(txt_bno.Text));

                    show();
                    clear();
                    txt_bno.Text = "0";
                    txt_jno.Text = "0";

                    MessageBox.Show("تمت عملية حذف السند بنجاح", "حذف السند", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        void get_max_no()
        {
            try
            {
                txt_bound_no.Text = cb.Get_Bond_Max(Convert.ToInt32(txt_btype.Text)).Rows[0][0].ToString();
            }
            catch { }
        }
        void get_min_no()
        {
            try
            {
                txt_bound_no.Text = cb.Get_Bond_Min(Convert.ToInt32(txt_btype.Text)).Rows[0][0].ToString();
            }
            catch { }
        }
        private void btn_first_Click(object sender, EventArgs e)
        {
            get_min_no();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            get_max_no();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int Bmax = Convert.ToInt32(cb.Get_Bond_Max(Convert.ToInt32(txt_btype.Text)).Rows[0][0]);
            if(Convert.ToInt32(txt_bound_no.Text) == Bmax)
            {
                MessageBox.Show("هذا اخر سند", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                txt_bound_no.Text = (Convert.ToInt32(txt_bound_no.Text)+1).ToString();
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            int Bmin = Convert.ToInt32(cb.Get_Bond_Min(Convert.ToInt32(txt_btype.Text)).Rows[0][0]);
            if (Convert.ToInt32(txt_bound_no.Text) == Bmin)
            {
                MessageBox.Show("هذا اول سند", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                txt_bound_no.Text = (Convert.ToInt32(txt_bound_no.Text) - 1).ToString();
            }
        }
    }
}
