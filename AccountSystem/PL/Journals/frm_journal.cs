using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountSystem.PL.Journal
{
    public partial class frm_journal : Form
    {
        BL.SysFormat.cls_sysFormat sf = new BL.SysFormat.cls_sysFormat();
        BL.Journal.cls_Journals cj = new BL.Journal.cls_Journals();
        BL.Users.cls_Users cu = new BL.Users.cls_Users();

        public frm_journal()
        {
            InitializeComponent();
            show();
        }

        void show()
        {
            cb_currency.DataSource = sf.Get_All_Currencies();
            cb_currency.ValueMember = "Curr_No";
            cb_currency.DisplayMember = "Curr_Aname";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PL.Account.ffrm_search fs = new Account.ffrm_search();
            fs.ShowDialog();
            if (fs.IsOk == true)
            {
                txt_accno.Text = fs.dgv_results.CurrentRow.Cells[0].Value.ToString();
                txt_accname.Text = fs.dgv_results.CurrentRow.Cells[2].Value.ToString();
                txt_debit.Focus();
            }
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

        void Enter_Row()
        {
            double TD = Convert.ToDouble(txt_debit.Text) * Convert.ToDouble(txt_exch.Text);
            double TC = Convert.ToDouble(txt_credit.Text) * Convert.ToDouble(txt_exch.Text);
            dgv_Journal.Rows.Add(txt_jno.Text, txt_accno.Text, txt_accname.Text, txt_debit.Text, txt_credit.Text, cb_currency.SelectedValue, cb_currency.Text, txt_exch.Text, txt_exp.Text, TD, TC);

        }

        void Clear()
        {
            txt_accno.Text = "";
            txt_accno.Focus();
            txt_accname.Text = "";
            txt_debit.Text = "0.00";
            txt_credit.Text = "0.00";
            txt_exp.Text = "";
        }
        void Total_Bal()
        {
            double TD = 0;
            double TC = 0;
            for (int i = 0; i < dgv_Journal.Rows.Count; i++)
            {
                TD = TD + Convert.ToDouble(dgv_Journal.Rows[i].Cells[9].Value);
                TC = TC + Convert.ToDouble(dgv_Journal.Rows[i].Cells[10].Value);
            }
            txt_Tdebit.Text = TD.ToString("0.00");
            txt_Tcredit.Text = TC.ToString("0.00");
            txt_Deff.Text = (TD - TC).ToString("0.00");
        }

        void clear_data()
        {
            txt_jno.Text = "0";
            dtp_jdate.Value = DateTime.Now;
            rb_general.Checked = true;
            chk_post.Checked = false;
            txt_note.Text = string.Empty;
            txt_debit.Text = "0.00";
            txt_Tcredit.Text = "0.00";
            txt_Deff.Text = "0.00";
        }
        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (txt_accno.Text == "")
            {
                MessageBox.Show("يجب اختيار رقم الحساب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToDouble(txt_debit.Text) == 0.00 && Convert.ToDouble(txt_credit.Text) == 0.00)
            {
                MessageBox.Show("لا يوجد مبلغ في طرف القيد....ادخل المبلغ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToDouble(txt_exch.Text) == 0.00)
            {
                MessageBox.Show("يرجى اختيار العملة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < dgv_Journal.Rows.Count; i++)
            {
                if (dgv_Journal.Rows[i].Cells[1].Value.ToString() == txt_accno.Text)
                {
                    MessageBox.Show("لا يمكن تكرار الحساب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Clear();
                    return;
                }
            }
            //entering data into DGV
            Enter_Row();
            //Clear data from text boxes
            Clear();
            //clac total of debi and credit balances
            Total_Bal();
        }

        private void حذفصفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_Journal.Rows.RemoveAt(dgv_Journal.CurrentRow.Index);
            Total_Bal();
        }

        private void dgv_Journal_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txt_accno.Text = dgv_Journal.CurrentRow.Cells[1].Value.ToString();
                txt_accname.Text = dgv_Journal.CurrentRow.Cells[2].Value.ToString();
                txt_debit.Text = dgv_Journal.CurrentRow.Cells[3].Value.ToString();
                txt_credit.Text = dgv_Journal.CurrentRow.Cells[4].Value.ToString();
                cb_currency.SelectedValue = dgv_Journal.CurrentRow.Cells[5].Value.ToString();
                txt_exch.Text = dgv_Journal.CurrentRow.Cells[7].Value.ToString();
                txt_exp.Text = dgv_Journal.CurrentRow.Cells[8].Value.ToString();

                dgv_Journal.Rows.RemoveAt(dgv_Journal.CurrentRow.Index);
                Total_Bal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex);
            }

        }

        private void تعديلصفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_accno.Text = dgv_Journal.CurrentRow.Cells[1].Value.ToString();
            txt_accname.Text = dgv_Journal.CurrentRow.Cells[2].Value.ToString();
            txt_debit.Text = dgv_Journal.CurrentRow.Cells[3].Value.ToString();
            txt_credit.Text = dgv_Journal.CurrentRow.Cells[4].Value.ToString();
            cb_currency.SelectedValue = dgv_Journal.CurrentRow.Cells[5].Value.ToString();
            txt_exch.Text = dgv_Journal.CurrentRow.Cells[7].Value.ToString();
            txt_exp.Text = dgv_Journal.CurrentRow.Cells[8].Value.ToString();

            dgv_Journal.Rows.RemoveAt(dgv_Journal.CurrentRow.Index);
            Total_Bal();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            BL.Journal.cls_Journals cj = new BL.Journal.cls_Journals();

            txt_jno.Text = cj.Generate_Jno().Rows[0][0].ToString();

            txt_note.Text = "";
            Clear();
            dgv_Journal.Rows.Clear();
            Total_Bal();
        }

        void Journal_Header_Add()
        {
            DateTime jdate = Convert.ToDateTime(dtp_jdate.Value.ToLongDateString());
            DateTime adate = DateTime.Now;
#pragma warning disable CS8604 // Possible null reference argument.
            int jno = Convert.ToInt32(cu.Get_User_No(Program.uname).Rows[0][0].ToString());
#pragma warning restore CS8604 // Possible null reference argument.

            int jtype = 0;
            if (rb_general.Checked == true)
            {
                jtype = 1;
            }
            if (rb_wait.Checked == true)
            {
                jtype = 4;
            }

            int jpost = 0;
            if (chk_post.Checked == true)
            {
                jpost = 1;
            }
            else
            {
                jpost = 0;
            }

            int ptype = 1;

            cj.Journal_Hdr_Add(
                Convert.ToInt32(txt_jno.Text),
                jdate,
                jtype,
                txt_note.Text,
                jpost,
                Convert.ToDouble(txt_Tdebit.Text),
                Convert.ToDouble(txt_Tcredit.Text),
                Convert.ToDouble(txt_Deff.Text),
                jno,
                adate,
                Convert.ToInt32(cb_currency.SelectedValue),
                Convert.ToDouble(txt_exch.Text),
                ptype);
        }

        void Journal_Details_Add()
        {
            for (int i = 0; i < dgv_Journal.Rows.Count; i++)
            {
                if (dgv_Journal.Rows.Count > 0)
                {
                    int jno = Convert.ToInt32(dgv_Journal.Rows[i].Cells[0].Value.ToString());
                    int accno = Convert.ToInt32(dgv_Journal.Rows[i].Cells[1].Value.ToString());
                    double accdeb = Convert.ToDouble(dgv_Journal.Rows[i].Cells[3].Value.ToString());
                    double acccred = Convert.ToDouble(dgv_Journal.Rows[i].Cells[4].Value.ToString());
                    string? accnote = Convert.ToString(dgv_Journal.Rows[i].Cells[8].Value);

#pragma warning disable CS8604 // Possible null reference argument.
                    cj.Journal_Details_Add(accno, accdeb, acccred, accnote, jno);
#pragma warning restore CS8604 // Possible null reference argument.
                }
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_Deff.Text) != 0.00 && rb_general.Checked == true)
                {
                    MessageBox.Show("القيد المحاسبي غير متوازن", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (Convert.ToDouble(txt_Deff.Text) == 0.00 || (Convert.ToDouble(txt_Deff.Text) != 0.00 && rb_wait.Checked == true))
                {
                    Journal_Header_Add();
                    Journal_Details_Add();
                    show();
                    MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("يجب التأكد من البيانات التي تريد حفظها" + ex, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            txt_ju_no.Text = txt_search.Text;
        }

        private void txt_ju_no_TextChanged(object sender, EventArgs e)
        {

            try
            {
                //get data from journal_Header

                DataTable dt1 = cj.Show_Journal_Header(Convert.ToInt32(txt_ju_no.Text));

                if (dt1.Rows.Count > 0)
                {
                    txt_jno.Text = dt1.Rows[0][0].ToString();

                    dtp_jdate.Text = dt1.Rows[0][1].ToString();

                    if (dt1.Rows[0][2].ToString() == "1")
                    {
                        rb_general.Checked = true;
                    }
                    if (dt1.Rows[0][2].ToString() == "4")
                    {
                        rb_wait.Checked = true;
                    }

                    txt_note.Text = dt1.Rows[0][3].ToString();

                    if (dt1.Rows[0][4].ToString() == "1")
                    {
                        chk_post.Checked = true;
                    }
                    else
                    {
                        chk_post.Checked = false;
                    }

                    txt_Tdebit.Text = dt1.Rows[0][5].ToString();

                    txt_Tcredit.Text = dt1.Rows[0][6].ToString();

                    txt_Deff.Text = dt1.Rows[0][7].ToString();

                    cb_currency.SelectedValue = Convert.ToInt32(dt1.Rows[0][12].ToString());

                    txt_exch.Text = dt1.Rows[0][14].ToString();
                
                    txt_ptype.Text = dt1.Rows[0][16].ToString();
                }
                else
                {
                    clear_data();
                }

                //get data from Journal_Details

                DataTable dt2 = new DataTable();
                dt2 = cj.Show_Journal_Details(Convert.ToInt32(txt_ju_no.Text));

                if (dt2.Rows.Count > 0)
                {
                    dgv_Journal.Rows.Clear();
                    int i = 0;
                    dgv_Journal.RowCount = dt2.Rows.Count;

                    for (int j = 0; j < dgv_Journal.Rows.Count; j++)
                    {
                        dgv_Journal.Rows[i].Cells[0].Value = dt2.Rows[j][5].ToString();
                        dgv_Journal.Rows[i].Cells[1].Value = dt2.Rows[j][0].ToString();
                        dgv_Journal.Rows[i].Cells[2].Value = dt2.Rows[j][1].ToString();
                        dgv_Journal.Rows[i].Cells[3].Value = dt2.Rows[j][2].ToString();
                        dgv_Journal.Rows[i].Cells[4].Value = dt2.Rows[j][3].ToString();
                        dgv_Journal.Rows[i].Cells[5].Value = dt1.Rows[0][12].ToString();
                        dgv_Journal.Rows[i].Cells[6].Value = dt1.Rows[0][13].ToString();
                        dgv_Journal.Rows[i].Cells[7].Value = dt1.Rows[0][14].ToString();
                        dgv_Journal.Rows[i].Cells[8].Value = dt2.Rows[j][4].ToString();
                        dgv_Journal.Rows[i].Cells[9].Value = Convert.ToDouble(dt2.Rows[j][2].ToString()) * Convert.ToDouble(dt1.Rows[0][14].ToString());
                        dgv_Journal.Rows[i].Cells[10].Value = Convert.ToDouble(dt2.Rows[j][3].ToString()) * Convert.ToDouble(dt1.Rows[0][14].ToString());
                        i++;
                    }
                }
                else
                {
                    dgv_Journal.Rows.Clear();
                    MessageBox.Show("رقم القيد الذي تبحث عنه غير موجود", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n\n" + ex);
            }
        }


        void Journal_Header_Update()
        {
            DateTime jdate = Convert.ToDateTime(dtp_jdate.Value.ToLongDateString());
            DateTime Edate = DateTime.Now;
#pragma warning disable CS8604 // Possible null reference argument.
            int jno = Convert.ToInt32(cu.Get_User_No(Program.uname).Rows[0][0].ToString());
#pragma warning restore CS8604 // Possible null reference argument.

            int jtype = 0;
            if (rb_general.Checked == true)
            {
                jtype = 1;
            }
            if (rb_wait.Checked == true)
            {
                jtype = 4;
            }

            int jpost = 0;
            if (chk_post.Checked == true)
            {
                jpost = 1;
            }
            else
            {
                jpost = 0;
            }

            cj.Journal_Hdr_Update(
                Convert.ToInt32(txt_jno.Text),
                jdate,
                jtype,
                txt_note.Text,
                jpost,
                Convert.ToDouble(txt_Tdebit.Text),
                Convert.ToDouble(txt_Tcredit.Text),
                Convert.ToDouble(txt_Deff.Text),
                jno,
                Edate,
                Convert.ToInt32(cb_currency.SelectedValue),
                Convert.ToDouble(txt_exch.Text));
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_ptype.Text == "سند صرف" || txt_ptype.Text == "سند قبض")
                {
                    MessageBox.Show("هذا القيد ناتج عن عملية صرف او قبض لا يمكن تعديله", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (chk_post.Checked == true)
                {
                    MessageBox.Show("هذا القيد مرحل لا يمكن تعديله", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Convert.ToDouble(txt_Deff.Text) != 0.00 && rb_general.Checked == true)
                {
                    MessageBox.Show("القيد المحاسبي غير متوازن", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (Convert.ToDouble(txt_Deff.Text) == 0.00 || (Convert.ToDouble(txt_Deff.Text) != 0.00 && rb_wait.Checked == true))
                {
                    Journal_Header_Update();
                    cj.Del_Journal_Details(Convert.ToInt32(txt_ju_no.Text));
                    Journal_Details_Add();
                    show();
                    MessageBox.Show("تمت عملية التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("يجب التأكد من البيانات التي تريد تعديلها", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ptype.Text == "سند صرف" || txt_ptype.Text == "سند قبض")
                {
                    MessageBox.Show("هذا القيد ناتج عن عملية صرف او قبض لا يمكن حذفه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (chk_post.Checked == true)
                {
                    MessageBox.Show("هذا القيد مرحل لا يمكن حذفه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("هل تريد حذف القيد المحاسبي", "تنبيه حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cj.Del_Journal_Details(Convert.ToInt32(txt_ju_no.Text));
                    cj.Del_Journal_Header(Convert.ToInt32(txt_ju_no.Text));
                    clear_data();
                    dgv_Journal.Rows.Clear();
                    MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            txt_ju_no.Text = cj.Get_Journal_First().Rows[0][0].ToString();

        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            txt_ju_no.Text = cj.Get_Journal_Last().Rows[0][0].ToString();

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int jmax = Convert.ToInt32(cj.Get_Journal_Last().Rows[0][0].ToString());
            if (Convert.ToInt32(txt_ju_no.Text) == jmax)
            {
                MessageBox.Show("هذا اخر قيد محاسبي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                txt_ju_no.Text = (Convert.ToInt32(txt_ju_no.Text) + 1).ToString();
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            int jmin = Convert.ToInt32(cj.Get_Journal_First().Rows[0][0].ToString());
            if (Convert.ToInt32(txt_ju_no.Text) == jmin)
            {
                MessageBox.Show("هذا اول قيد محاسبي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                txt_ju_no.Text = (Convert.ToInt32(txt_ju_no.Text) - 1).ToString();
            }
        }

        private void txt_accno_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
