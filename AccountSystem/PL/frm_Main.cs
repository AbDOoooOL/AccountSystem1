
namespace AccountSystem.PL
{
    public partial class frm_Main : Form
    {
        PL.Bonds.from_Bounds fb = new PL.Bonds.from_Bounds();

        public frm_Main()
        {
            InitializeComponent();
        }

        private void بياناتالاتصالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SysFormat.frm_ConFormat cf = new SysFormat.frm_ConFormat();
            cf.ShowDialog();
        }

        private void بياناتالشركةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SysFormat.frm_Company fc = new SysFormat.frm_Company();
            fc.ShowDialog();
        }

        private void المستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.users.frm_user fu = new users.frm_user();
            fu.ShowDialog();
        }

        private void دليلالحساباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Account.frm_accounts fa = new Account.frm_accounts();
            fa.ShowDialog();
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void الصناديقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SysFormat.frm_cash fc = new SysFormat.frm_cash();
            fc.Text = "الصناديق";
            fc.gb_cash.Text = "الصناديق";
            fc.txt_function.Text = "1";
            fc.ShowDialog();
        }

        private void البنوكToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SysFormat.frm_cash fc = new SysFormat.frm_cash();
            fc.Text = "البنوك";
            fc.gb_cash.Text = "البنوك";
            fc.txt_function.Text = "2";
            fc.ShowDialog();
        }

        private void العملاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SysFormat.frm_currencies fc = new SysFormat.frm_currencies();
            fc.ShowDialog();
        }

        private void قيداليوميةالعامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Journal.frm_journal fj = new PL.Journal.frm_journal();
            fj.ShowDialog();
        }

        private void سندالصرفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fb.Text = "سند صرف";
            fb.gp_bonds.Text = "بيانات سند الصرف";
            fb.txt_btype.Text = "2";
            fb.ShowDialog();
        }

        private void سندالقبضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fb.Text = "سند القبض";
            fb.gp_bonds.Text = "بيانات سند القبض";
            fb.txt_btype.Text = "3";
            fb.ShowDialog();
        }
    }
}