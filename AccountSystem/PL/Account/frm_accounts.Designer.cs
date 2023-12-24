namespace AccountSystem.PL.Account
{
    partial class frm_accounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gp_account = new GroupBox();
            tv_accounts = new TreeView();
            gp_input = new GroupBox();
            txt_balance = new TextBox();
            txt_credit = new TextBox();
            txt_drbit = new TextBox();
            txt_level = new TextBox();
            txt_name = new TextBox();
            txt_parent = new TextBox();
            txt_no = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_tag = new TextBox();
            groupBox3 = new GroupBox();
            cb_type = new ComboBox();
            cb_report = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            groupBox4 = new GroupBox();
            btn_close = new Button();
            btn_del = new Button();
            btn_update = new Button();
            btn_save = new Button();
            btn_new = new Button();
            btn_accounts = new Button();
            gp_account.SuspendLayout();
            gp_input.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // gp_account
            // 
            gp_account.Controls.Add(tv_accounts);
            gp_account.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gp_account.Location = new Point(12, 12);
            gp_account.Name = "gp_account";
            gp_account.Size = new Size(553, 536);
            gp_account.TabIndex = 0;
            gp_account.TabStop = false;
            gp_account.Text = "الدليل المحاسبي";
            // 
            // tv_accounts
            // 
            tv_accounts.Dock = DockStyle.Fill;
            tv_accounts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tv_accounts.Location = new Point(3, 25);
            tv_accounts.Name = "tv_accounts";
            tv_accounts.RightToLeftLayout = true;
            tv_accounts.Size = new Size(547, 508);
            tv_accounts.TabIndex = 0;
            tv_accounts.AfterSelect += tv_accounts_AfterSelect;
            // 
            // gp_input
            // 
            gp_input.Controls.Add(txt_balance);
            gp_input.Controls.Add(txt_credit);
            gp_input.Controls.Add(txt_drbit);
            gp_input.Controls.Add(txt_level);
            gp_input.Controls.Add(txt_name);
            gp_input.Controls.Add(txt_parent);
            gp_input.Controls.Add(txt_no);
            gp_input.Controls.Add(label7);
            gp_input.Controls.Add(label6);
            gp_input.Controls.Add(label5);
            gp_input.Controls.Add(label4);
            gp_input.Controls.Add(label3);
            gp_input.Controls.Add(label2);
            gp_input.Controls.Add(label1);
            gp_input.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gp_input.Location = new Point(571, 12);
            gp_input.Name = "gp_input";
            gp_input.Size = new Size(568, 364);
            gp_input.TabIndex = 1;
            gp_input.TabStop = false;
            gp_input.Text = "المدخلات";
            // 
            // txt_balance
            // 
            txt_balance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_balance.Location = new Point(6, 314);
            txt_balance.Name = "txt_balance";
            txt_balance.Size = new Size(439, 29);
            txt_balance.TabIndex = 7;
            txt_balance.Text = "0.00";
            // 
            // txt_credit
            // 
            txt_credit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_credit.Location = new Point(6, 267);
            txt_credit.Name = "txt_credit";
            txt_credit.Size = new Size(439, 29);
            txt_credit.TabIndex = 6;
            txt_credit.Text = "0.00";
            // 
            // txt_drbit
            // 
            txt_drbit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_drbit.Location = new Point(6, 223);
            txt_drbit.Name = "txt_drbit";
            txt_drbit.Size = new Size(439, 29);
            txt_drbit.TabIndex = 5;
            txt_drbit.Text = "0.00";
            // 
            // txt_level
            // 
            txt_level.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_level.Location = new Point(6, 176);
            txt_level.Name = "txt_level";
            txt_level.Size = new Size(439, 29);
            txt_level.TabIndex = 4;
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_name.Location = new Point(6, 131);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(439, 29);
            txt_name.TabIndex = 3;
            // 
            // txt_parent
            // 
            txt_parent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_parent.Location = new Point(6, 83);
            txt_parent.Name = "txt_parent";
            txt_parent.Size = new Size(439, 29);
            txt_parent.TabIndex = 2;
            // 
            // txt_no
            // 
            txt_no.Enabled = false;
            txt_no.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_no.Location = new Point(132, 28);
            txt_no.Name = "txt_no";
            txt_no.Size = new Size(313, 29);
            txt_no.TabIndex = 1;
            txt_no.KeyPress += txt_no_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(515, 322);
            label7.Name = "label7";
            label7.Size = new Size(45, 21);
            label7.TabIndex = 6;
            label7.Text = "رصيد";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(522, 275);
            label6.Name = "label6";
            label6.Size = new Size(38, 21);
            label6.TabIndex = 5;
            label6.Text = "دائن";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(517, 231);
            label5.Name = "label5";
            label5.Size = new Size(43, 21);
            label5.TabIndex = 4;
            label5.Text = "مدين";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(451, 184);
            label4.Name = "label4";
            label4.Size = new Size(111, 21);
            label4.TabIndex = 3;
            label4.Text = "مستوى الحساب";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(470, 138);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 2;
            label3.Text = "اسم الحساب";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(470, 91);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 1;
            label2.Text = "الحساب الاب";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(475, 36);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 0;
            label1.Text = "رقم الحساب";
            // 
            // txt_tag
            // 
            txt_tag.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_tag.Location = new Point(6, 16);
            txt_tag.Name = "txt_tag";
            txt_tag.Size = new Size(37, 29);
            txt_tag.TabIndex = 14;
            txt_tag.Visible = false;
            txt_tag.TextChanged += txt_tag_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_tag);
            groupBox3.Controls.Add(cb_type);
            groupBox3.Controls.Add(cb_report);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(571, 375);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(568, 173);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // cb_type
            // 
            cb_type.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cb_type.FormattingEnabled = true;
            cb_type.Location = new Point(6, 110);
            cb_type.Name = "cb_type";
            cb_type.Size = new Size(439, 29);
            cb_type.TabIndex = 10;
            // 
            // cb_report
            // 
            cb_report.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cb_report.FormattingEnabled = true;
            cb_report.Location = new Point(6, 51);
            cb_report.Name = "cb_report";
            cb_report.Size = new Size(439, 29);
            cb_report.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(510, 54);
            label8.Name = "label8";
            label8.Size = new Size(52, 21);
            label8.TabIndex = 7;
            label8.Text = "التقرير";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(476, 116);
            label9.Name = "label9";
            label9.Size = new Size(86, 21);
            label9.TabIndex = 8;
            label9.Text = "نوع الحساب";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_close);
            groupBox4.Controls.Add(btn_del);
            groupBox4.Controls.Add(btn_update);
            groupBox4.Controls.Add(btn_save);
            groupBox4.Controls.Add(btn_new);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(571, 544);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(568, 118);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            // 
            // btn_close
            // 
            btn_close.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_close.Location = new Point(0, 37);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(103, 58);
            btn_close.TabIndex = 13;
            btn_close.Text = "خروج";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // btn_del
            // 
            btn_del.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_del.Location = new Point(132, 37);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(103, 58);
            btn_del.TabIndex = 12;
            btn_del.Text = "حذف";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // btn_update
            // 
            btn_update.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.Location = new Point(241, 37);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(103, 58);
            btn_update.TabIndex = 11;
            btn_update.Text = "تعديل";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_save
            // 
            btn_save.Enabled = false;
            btn_save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_save.Location = new Point(350, 37);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(103, 58);
            btn_save.TabIndex = 10;
            btn_save.Text = "حفظ";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_new
            // 
            btn_new.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_new.Location = new Point(459, 37);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(103, 58);
            btn_new.TabIndex = 15;
            btn_new.Text = "جديد";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // btn_accounts
            // 
            btn_accounts.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_accounts.ForeColor = Color.Red;
            btn_accounts.Location = new Point(15, 581);
            btn_accounts.Name = "btn_accounts";
            btn_accounts.Size = new Size(547, 58);
            btn_accounts.TabIndex = 16;
            btn_accounts.Text = "الدليل المحاسبي";
            btn_accounts.UseVisualStyleBackColor = true;
            // 
            // frm_accounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 674);
            Controls.Add(btn_accounts);
            Controls.Add(gp_input);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(gp_account);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_accounts";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "الحسابات";
            gp_account.ResumeLayout(false);
            gp_input.ResumeLayout(false);
            gp_input.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gp_account;
        private TreeView tv_accounts;
        private GroupBox gp_input;
        private TextBox txt_balance;
        private TextBox txt_credit;
        private TextBox txt_drbit;
        private TextBox txt_level;
        private TextBox txt_name;
        private TextBox txt_parent;
        private TextBox txt_no;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private ComboBox cb_report;
        private Label label8;
        private Label label9;
        private GroupBox groupBox4;
        private Button btn_close;
        private Button btn_del;
        private Button btn_update;
        private Button btn_save;
        private Button btn_new;
        private TextBox txt_tag;
        private ComboBox cb_type;
        private Button btn_accounts;
    }
}