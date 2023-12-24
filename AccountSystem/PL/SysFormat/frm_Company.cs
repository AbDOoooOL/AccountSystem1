using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;

namespace AccountSystem.PL.SysFormat
{
    public partial class frm_Company : Form
    {
        BL.SysFormat.cls_sysFormat cs = new BL.SysFormat.cls_sysFormat();

        public frm_Company()
        {
            InitializeComponent();
            dgv_cdata.DataSource = cs.Get_All_CompData();
            dgv_cdata.Columns[0].HeaderText = "الرقم";
            dgv_cdata.Columns[1].HeaderText = "الاسم";
            dgv_cdata.Columns[2].HeaderText = "الاسم الاجنبي";
            dgv_cdata.Columns[3].HeaderText = "العنوان";
            dgv_cdata.Columns[4].Visible = false;
            dgv_cdata.Columns[5].HeaderText = "هاتف";
            dgv_cdata.Columns[6].Visible = false;
            dgv_cdata.Columns[7].HeaderText = "ايميل";
            dgv_cdata.Columns[8].Visible = false;
            dgv_cdata.Columns[9].HeaderText = "الصورة";
        }

        void dgv_table()
        {
            dgv_cdata.DataSource = cs.Get_All_CompData();
            dgv_cdata.Columns[0].HeaderText = "الرقم";
            dgv_cdata.Columns[1].HeaderText = "الاسم";
            dgv_cdata.Columns[2].HeaderText = "الاسم الاجنبي";
            dgv_cdata.Columns[3].HeaderText = "العنوان";
            dgv_cdata.Columns[4].Visible = false;
            dgv_cdata.Columns[5].HeaderText = "هاتف";
            dgv_cdata.Columns[6].Visible = false;
            dgv_cdata.Columns[7].HeaderText = "ايميل";
            dgv_cdata.Columns[8].Visible = false;
            dgv_cdata.Columns[9].HeaderText = "الصورة";
        }
        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "All file|*.gif;*jpg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pb_Logo.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            pb_Logo.Image = null;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                    ((TextBox)c).Enabled = true;
                }
            }
            pb_Logo.Image = null;
            btn_browse.Enabled = true;
            btn_save.Enabled = true;
            txt_aname.Focus();

        }



        private void btn_save_Click_1(object sender, EventArgs e)
        {
            byte[] Bimg;
            if (pb_Logo.Image == null)
            {
                MessageBox.Show("يجب ادخال صورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pb_Logo.Image.Save(ms, pb_Logo.Image.RawFormat);
                Bimg = ms.ToArray();
                cs.AddCompany(
                    txt_aname.Text,
                    txt_ename.Text,
                    txt_aaddress.Text,
                    txt_eaddress.Text,
                    txt_tel.Text,
                    txt_fax.Text,
                    txt_email.Text,
                    txt_website.Text,
                    Bimg
                    );
                dgv_table();
                MessageBox.Show("تمت عملية الحفظ بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void txt_aname_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-sa"));
        }

        private void txt_ename_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("zu"));
        }

        private void txt_aaddress_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-sa"));
        }

        private void txt_eaddress_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
        }

        private void txt_website_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
        }

        private void dgv_cdata_DoubleClick(object sender, EventArgs e)
        {
            txt_aname.Text = dgv_cdata.CurrentRow.Cells[1].Value.ToString();
            txt_ename.Text = dgv_cdata.CurrentRow.Cells[2].Value.ToString();
            txt_aaddress.Text = dgv_cdata.CurrentRow.Cells[3].Value.ToString();
            txt_eaddress.Text = dgv_cdata.CurrentRow.Cells[4].Value.ToString();
            txt_tel.Text = dgv_cdata.CurrentRow.Cells[5].Value.ToString();
            txt_fax.Text = dgv_cdata.CurrentRow.Cells[6].Value.ToString();
            txt_email.Text = dgv_cdata.CurrentRow.Cells[7].Value.ToString();
            txt_website.Text = dgv_cdata.CurrentRow.Cells[8].Value.ToString();

            byte[] Bimg = (byte[])dgv_cdata.CurrentRow.Cells[9].Value;
            MemoryStream ms = new MemoryStream(Bimg);
            pb_Logo.Image = Image.FromStream(ms);

            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Enabled = true;
                }
            }
            btn_browse.Enabled = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            byte[] Bimg;
            if (pb_Logo.Image == null)
            {
                MessageBox.Show("يجب ادخال صورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pb_Logo.Image.Save(ms, pb_Logo.Image.RawFormat);
                Bimg = ms.ToArray();
                int cno = Convert.ToInt32(dgv_cdata.CurrentRow.Cells[0].Value);
                cs.EditCompany(
                    cno,
                    txt_aname.Text,
                    txt_ename.Text,
                    txt_aaddress.Text,
                    txt_eaddress.Text,
                    txt_tel.Text,
                    txt_fax.Text,
                    txt_email.Text,
                    txt_website.Text,
                    Bimg
                    );
                dgv_table();
                MessageBox.Show("تمت عملية التعديل بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("هل انت متأكد من انك تريد الحذف",
                "تنبيه",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)) == DialogResult.Yes)
            {
                cs.DelCompany(Convert.ToInt32(dgv_cdata.CurrentRow.Cells[0].Value));

                dgv_table();
                MessageBox.Show("تمت عملية الحذف بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (var c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = string.Empty;
                        ((TextBox)c).Enabled = false;
                    }
                }
                btn_browse.Enabled = false;
                pb_Logo.Image = null;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_email_Validated(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$");
            if (!reg.IsMatch(txt_email.Text))
            {
                MessageBox.Show("الصيغة التي ادخلتها غير صحيحة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_email.Focus();
            }
        }

        private void txt_website_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^(http|https|ftp)\://([a-zA-Z0-9\.\-]
            +(\:[a-zA-Z0-9\.&amp;%\$\-]+)*@)*((25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])|localhost|([a-zA-Z0-9\-]+\.)*[a-zA-Z0-9\-]
            +\.(com|edu|gov|int|mil|net|org|biz|arpa|info|name|pro|aero|coop|museum|[a-zA-Z]{2}))(\:[0-9]+)*(/($|[a-zA-Z0-9\.\,\?\'\\\+&amp;%\$#\=~_\-]+))*$");

            if (!reg.IsMatch(txt_website.Text))
            {
                MessageBox.Show("الصيغة التي ادخلتها غير صحيحة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_website.Focus();
            }
        }
    }
}
