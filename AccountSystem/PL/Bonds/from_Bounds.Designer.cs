namespace AccountSystem.PL.Bonds
{
    partial class from_Bounds
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
            components = new System.ComponentModel.Container();
            btn_enter = new Button();
            select_account = new Button();
            cb_currency = new ComboBox();
            txt_exp = new TextBox();
            txt_exch = new TextBox();
            txt_amount = new TextBox();
            txt_accname = new TextBox();
            txt_accno = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label11 = new Label();
            btn_exit = new Button();
            btn_del = new Button();
            btn_edit = new Button();
            btn_save = new Button();
            btn_new = new Button();
            txt_Tamount = new TextBox();
            label12 = new Label();
            gp_cntrl = new GroupBox();
            txt_uno = new TextBox();
            txt_user = new TextBox();
            label13 = new Label();
            تعديلصفToolStripMenuItem = new ToolStripMenuItem();
            حذفصفToolStripMenuItem = new ToolStripMenuItem();
            cMenuStrip = new ContextMenuStrip(components);
            gp_inputs = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            gp_jh = new GroupBox();
            txt_cash_accno = new TextBox();
            cb_cash = new ComboBox();
            label8 = new Label();
            btn_search = new Button();
            txt_jno = new TextBox();
            txt_btype = new TextBox();
            txt_search = new TextBox();
            chk_post = new CheckBox();
            txt_bound_no = new TextBox();
            btn_last = new Button();
            btn_next = new Button();
            btn_prev = new Button();
            btn_first = new Button();
            rb_in = new RadioButton();
            rb_out = new RadioButton();
            dtp_bdate = new DateTimePicker();
            label4 = new Label();
            txt_note = new TextBox();
            txt_bno = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgv_bonds = new DataGridView();
            Column8 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            gp_bonds = new GroupBox();
            gp_cntrl.SuspendLayout();
            cMenuStrip.SuspendLayout();
            gp_inputs.SuspendLayout();
            gp_jh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_bonds).BeginInit();
            gp_bonds.SuspendLayout();
            SuspendLayout();
            // 
            // btn_enter
            // 
            btn_enter.Location = new Point(19, 80);
            btn_enter.Name = "btn_enter";
            btn_enter.Size = new Size(109, 59);
            btn_enter.TabIndex = 31;
            btn_enter.Text = "ادخال";
            btn_enter.UseVisualStyleBackColor = true;
            btn_enter.Click += btn_enter_Click;
            // 
            // select_account
            // 
            select_account.Location = new Point(916, 25);
            select_account.Name = "select_account";
            select_account.Size = new Size(116, 30);
            select_account.TabIndex = 30;
            select_account.Text = "البحث عن حساب";
            select_account.UseVisualStyleBackColor = true;
            select_account.Click += select_account_Click;
            // 
            // cb_currency
            // 
            cb_currency.FormattingEnabled = true;
            cb_currency.Location = new Point(480, 111);
            cb_currency.Name = "cb_currency";
            cb_currency.Size = new Size(99, 27);
            cb_currency.TabIndex = 4;
            cb_currency.SelectedIndexChanged += cb_currency_SelectedIndexChanged;
            // 
            // txt_exp
            // 
            txt_exp.Location = new Point(170, 110);
            txt_exp.Name = "txt_exp";
            txt_exp.Size = new Size(151, 26);
            txt_exp.TabIndex = 6;
            // 
            // txt_exch
            // 
            txt_exch.Location = new Point(350, 110);
            txt_exch.Name = "txt_exch";
            txt_exch.Size = new Size(99, 26);
            txt_exch.TabIndex = 5;
            // 
            // txt_amount
            // 
            txt_amount.Location = new Point(606, 112);
            txt_amount.Name = "txt_amount";
            txt_amount.Size = new Size(99, 26);
            txt_amount.TabIndex = 2;
            txt_amount.Text = "0.00";
            // 
            // txt_accname
            // 
            txt_accname.Location = new Point(730, 111);
            txt_accname.Name = "txt_accname";
            txt_accname.ReadOnly = true;
            txt_accname.Size = new Size(166, 26);
            txt_accname.TabIndex = 16;
            // 
            // txt_accno
            // 
            txt_accno.Location = new Point(902, 112);
            txt_accno.Name = "txt_accno";
            txt_accno.ReadOnly = true;
            txt_accno.Size = new Size(99, 26);
            txt_accno.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(401, 78);
            label10.Name = "label10";
            label10.Size = new Size(48, 19);
            label10.TabIndex = 14;
            label10.Text = "الصرف";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(538, 80);
            label9.Name = "label9";
            label9.Size = new Size(41, 19);
            label9.TabIndex = 13;
            label9.Text = "العملة";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(283, 78);
            label11.Name = "label11";
            label11.Size = new Size(38, 19);
            label11.TabIndex = 15;
            label11.Text = "البيان";
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(19, 51);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(75, 64);
            btn_exit.TabIndex = 10;
            btn_exit.Text = "خروج";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_del
            // 
            btn_del.Location = new Point(165, 51);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(75, 64);
            btn_del.TabIndex = 9;
            btn_del.Text = "حذف";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(246, 51);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(75, 64);
            btn_edit.TabIndex = 8;
            btn_edit.Text = "تعديل";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(327, 51);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 64);
            btn_save.TabIndex = 7;
            btn_save.Text = "حفظ";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_new
            // 
            btn_new.Location = new Point(410, 51);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(75, 64);
            btn_new.TabIndex = 0;
            btn_new.Text = "جديد";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // txt_Tamount
            // 
            txt_Tamount.Location = new Point(775, 44);
            txt_Tamount.Name = "txt_Tamount";
            txt_Tamount.ReadOnly = true;
            txt_Tamount.Size = new Size(135, 26);
            txt_Tamount.TabIndex = 23;
            txt_Tamount.Text = "0.00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(930, 51);
            label12.Name = "label12";
            label12.Size = new Size(76, 19);
            label12.TabIndex = 13;
            label12.Text = "اجمالي السند";
            // 
            // gp_cntrl
            // 
            gp_cntrl.Controls.Add(btn_exit);
            gp_cntrl.Controls.Add(btn_del);
            gp_cntrl.Controls.Add(btn_edit);
            gp_cntrl.Controls.Add(btn_save);
            gp_cntrl.Controls.Add(btn_new);
            gp_cntrl.Controls.Add(txt_uno);
            gp_cntrl.Controls.Add(txt_user);
            gp_cntrl.Controls.Add(txt_Tamount);
            gp_cntrl.Controls.Add(label13);
            gp_cntrl.Controls.Add(label12);
            gp_cntrl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gp_cntrl.Location = new Point(12, 601);
            gp_cntrl.Name = "gp_cntrl";
            gp_cntrl.Size = new Size(1038, 159);
            gp_cntrl.TabIndex = 16;
            gp_cntrl.TabStop = false;
            // 
            // txt_uno
            // 
            txt_uno.Location = new Point(634, 101);
            txt_uno.Name = "txt_uno";
            txt_uno.ReadOnly = true;
            txt_uno.Size = new Size(135, 26);
            txt_uno.TabIndex = 23;
            // 
            // txt_user
            // 
            txt_user.Location = new Point(775, 101);
            txt_user.Name = "txt_user";
            txt_user.ReadOnly = true;
            txt_user.Size = new Size(135, 26);
            txt_user.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(930, 108);
            label13.Name = "label13";
            label13.Size = new Size(57, 19);
            label13.TabIndex = 13;
            label13.Text = "المستخدم";
            // 
            // تعديلصفToolStripMenuItem
            // 
            تعديلصفToolStripMenuItem.Name = "تعديلصفToolStripMenuItem";
            تعديلصفToolStripMenuItem.Size = new Size(130, 22);
            تعديلصفToolStripMenuItem.Text = "تعديل صف";
            تعديلصفToolStripMenuItem.Click += تعديلصفToolStripMenuItem_Click;
            // 
            // حذفصفToolStripMenuItem
            // 
            حذفصفToolStripMenuItem.Name = "حذفصفToolStripMenuItem";
            حذفصفToolStripMenuItem.Size = new Size(130, 22);
            حذفصفToolStripMenuItem.Text = "حذف صف";
            حذفصفToolStripMenuItem.Click += حذفصفToolStripMenuItem_Click;
            // 
            // cMenuStrip
            // 
            cMenuStrip.Items.AddRange(new ToolStripItem[] { حذفصفToolStripMenuItem, تعديلصفToolStripMenuItem });
            cMenuStrip.Name = "cMenuStrip";
            cMenuStrip.RightToLeft = RightToLeft.Yes;
            cMenuStrip.Size = new Size(131, 48);
            // 
            // gp_inputs
            // 
            gp_inputs.Controls.Add(btn_enter);
            gp_inputs.Controls.Add(select_account);
            gp_inputs.Controls.Add(cb_currency);
            gp_inputs.Controls.Add(txt_exp);
            gp_inputs.Controls.Add(txt_exch);
            gp_inputs.Controls.Add(txt_amount);
            gp_inputs.Controls.Add(txt_accname);
            gp_inputs.Controls.Add(txt_accno);
            gp_inputs.Controls.Add(label11);
            gp_inputs.Controls.Add(label10);
            gp_inputs.Controls.Add(label9);
            gp_inputs.Controls.Add(label7);
            gp_inputs.Controls.Add(label6);
            gp_inputs.Controls.Add(label5);
            gp_inputs.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gp_inputs.Location = new Point(12, 174);
            gp_inputs.Name = "gp_inputs";
            gp_inputs.Size = new Size(1038, 159);
            gp_inputs.TabIndex = 18;
            gp_inputs.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(671, 80);
            label7.Name = "label7";
            label7.Size = new Size(40, 19);
            label7.TabIndex = 11;
            label7.Text = "المبلغ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(823, 79);
            label6.Name = "label6";
            label6.Size = new Size(73, 19);
            label6.TabIndex = 10;
            label6.Text = "اسم الحساب";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(930, 80);
            label5.Name = "label5";
            label5.Size = new Size(71, 19);
            label5.TabIndex = 9;
            label5.Text = "رقم الحساب";
            // 
            // gp_jh
            // 
            gp_jh.Controls.Add(txt_cash_accno);
            gp_jh.Controls.Add(cb_cash);
            gp_jh.Controls.Add(label8);
            gp_jh.Controls.Add(btn_search);
            gp_jh.Controls.Add(txt_jno);
            gp_jh.Controls.Add(txt_btype);
            gp_jh.Controls.Add(txt_search);
            gp_jh.Controls.Add(chk_post);
            gp_jh.Controls.Add(txt_bound_no);
            gp_jh.Controls.Add(btn_last);
            gp_jh.Controls.Add(btn_next);
            gp_jh.Controls.Add(btn_prev);
            gp_jh.Controls.Add(btn_first);
            gp_jh.Controls.Add(rb_in);
            gp_jh.Controls.Add(rb_out);
            gp_jh.Controls.Add(dtp_bdate);
            gp_jh.Controls.Add(label4);
            gp_jh.Controls.Add(txt_note);
            gp_jh.Controls.Add(txt_bno);
            gp_jh.Controls.Add(label3);
            gp_jh.Controls.Add(label2);
            gp_jh.Controls.Add(label1);
            gp_jh.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gp_jh.Location = new Point(12, 12);
            gp_jh.Name = "gp_jh";
            gp_jh.Size = new Size(1038, 156);
            gp_jh.TabIndex = 19;
            gp_jh.TabStop = false;
            // 
            // txt_cash_accno
            // 
            txt_cash_accno.Location = new Point(538, 124);
            txt_cash_accno.Name = "txt_cash_accno";
            txt_cash_accno.Size = new Size(115, 26);
            txt_cash_accno.TabIndex = 32;
            // 
            // cb_cash
            // 
            cb_cash.FormattingEnabled = true;
            cb_cash.Location = new Point(538, 91);
            cb_cash.Name = "cb_cash";
            cb_cash.Size = new Size(115, 27);
            cb_cash.TabIndex = 32;
            cb_cash.SelectedIndexChanged += cb_cash_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(662, 109);
            label8.Name = "label8";
            label8.Size = new Size(55, 19);
            label8.TabIndex = 21;
            label8.Text = "الصندوق";
            // 
            // btn_search
            // 
            btn_search.Location = new Point(277, 92);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(75, 26);
            btn_search.TabIndex = 20;
            btn_search.Text = "بحث";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // txt_jno
            // 
            txt_jno.Location = new Point(327, 36);
            txt_jno.Name = "txt_jno";
            txt_jno.Size = new Size(100, 26);
            txt_jno.TabIndex = 19;
            // 
            // txt_btype
            // 
            txt_btype.Location = new Point(432, 36);
            txt_btype.Name = "txt_btype";
            txt_btype.Size = new Size(100, 26);
            txt_btype.TabIndex = 19;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(263, 124);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(100, 26);
            txt_search.TabIndex = 19;
            // 
            // chk_post
            // 
            chk_post.AutoSize = true;
            chk_post.Location = new Point(387, 107);
            chk_post.Name = "chk_post";
            chk_post.Size = new Size(57, 23);
            chk_post.TabIndex = 14;
            chk_post.Text = "مرحل";
            chk_post.UseVisualStyleBackColor = true;
            // 
            // txt_bound_no
            // 
            txt_bound_no.Location = new Point(81, 36);
            txt_bound_no.Name = "txt_bound_no";
            txt_bound_no.Size = new Size(119, 26);
            txt_bound_no.TabIndex = 13;
            txt_bound_no.Text = "0";
            txt_bound_no.TextChanged += txt_bound_no_TextChanged;
            // 
            // btn_last
            // 
            btn_last.Location = new Point(18, 19);
            btn_last.Name = "btn_last";
            btn_last.Size = new Size(57, 26);
            btn_last.TabIndex = 12;
            btn_last.Text = "النهاية";
            btn_last.UseVisualStyleBackColor = true;
            btn_last.Click += btn_last_Click;
            // 
            // btn_next
            // 
            btn_next.Location = new Point(206, 51);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(57, 26);
            btn_next.TabIndex = 11;
            btn_next.Text = "التالي";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click;
            // 
            // btn_prev
            // 
            btn_prev.Location = new Point(19, 51);
            btn_prev.Name = "btn_prev";
            btn_prev.Size = new Size(56, 26);
            btn_prev.TabIndex = 10;
            btn_prev.Text = "السابق";
            btn_prev.UseVisualStyleBackColor = true;
            btn_prev.Click += btn_prev_Click;
            // 
            // btn_first
            // 
            btn_first.Location = new Point(206, 19);
            btn_first.Name = "btn_first";
            btn_first.Size = new Size(57, 26);
            btn_first.TabIndex = 18;
            btn_first.Text = "البداية";
            btn_first.UseVisualStyleBackColor = true;
            btn_first.Click += btn_first_Click;
            // 
            // rb_in
            // 
            rb_in.AutoSize = true;
            rb_in.Location = new Point(19, 107);
            rb_in.Name = "rb_in";
            rb_in.Size = new Size(53, 23);
            rb_in.TabIndex = 8;
            rb_in.Text = "قبض";
            rb_in.UseVisualStyleBackColor = true;
            // 
            // rb_out
            // 
            rb_out.AutoSize = true;
            rb_out.Checked = true;
            rb_out.Location = new Point(81, 107);
            rb_out.Name = "rb_out";
            rb_out.Size = new Size(58, 23);
            rb_out.TabIndex = 7;
            rb_out.TabStop = true;
            rb_out.Text = "صرف";
            rb_out.UseVisualStyleBackColor = true;
            // 
            // dtp_bdate
            // 
            dtp_bdate.Location = new Point(538, 36);
            dtp_bdate.Name = "dtp_bdate";
            dtp_bdate.Size = new Size(200, 26);
            dtp_bdate.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 111);
            label4.Name = "label4";
            label4.Size = new Size(60, 19);
            label4.TabIndex = 5;
            label4.Text = "نوع السند";
            // 
            // txt_note
            // 
            txt_note.Location = new Point(730, 104);
            txt_note.Name = "txt_note";
            txt_note.Size = new Size(232, 26);
            txt_note.TabIndex = 1;
            // 
            // txt_bno
            // 
            txt_bno.Location = new Point(820, 37);
            txt_bno.Name = "txt_bno";
            txt_bno.ReadOnly = true;
            txt_bno.Size = new Size(142, 26);
            txt_bno.TabIndex = 16;
            txt_bno.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(968, 109);
            label3.Name = "label3";
            label3.Size = new Size(38, 19);
            label3.TabIndex = 2;
            label3.Text = "البيان";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(744, 43);
            label2.Name = "label2";
            label2.Size = new Size(68, 19);
            label2.TabIndex = 1;
            label2.Text = "تاريخ السند";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(968, 44);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 0;
            label1.Text = "رقم السند";
            // 
            // dgv_bonds
            // 
            dgv_bonds.AllowUserToAddRows = false;
            dgv_bonds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_bonds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_bonds.Columns.AddRange(new DataGridViewColumn[] { Column8, Column1, Column2, Column3, Column9, Column5, Column6, Column7, Column4 });
            dgv_bonds.ContextMenuStrip = cMenuStrip;
            dgv_bonds.Dock = DockStyle.Fill;
            dgv_bonds.Location = new Point(3, 22);
            dgv_bonds.Name = "dgv_bonds";
            dgv_bonds.RowHeadersVisible = false;
            dgv_bonds.RowTemplate.Height = 25;
            dgv_bonds.Size = new Size(1032, 231);
            dgv_bonds.TabIndex = 12;
            dgv_bonds.CellDoubleClick += dgv_bonds_CellDoubleClick;
            // 
            // Column8
            // 
            Column8.HeaderText = "رقم السند";
            Column8.Name = "Column8";
            // 
            // Column1
            // 
            Column1.HeaderText = "رقم الحساب";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "اسم الحساب";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "المبلغ";
            Column3.Name = "Column3";
            // 
            // Column9
            // 
            Column9.HeaderText = "رقم العملة";
            Column9.Name = "Column9";
            // 
            // Column5
            // 
            Column5.HeaderText = "العملة";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "الصرف";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "البيان";
            Column7.Name = "Column7";
            // 
            // Column4
            // 
            Column4.HeaderText = "اجمالي المبلغ";
            Column4.Name = "Column4";
            // 
            // gp_bonds
            // 
            gp_bonds.Controls.Add(dgv_bonds);
            gp_bonds.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gp_bonds.Location = new Point(12, 339);
            gp_bonds.Name = "gp_bonds";
            gp_bonds.Size = new Size(1038, 256);
            gp_bonds.TabIndex = 17;
            gp_bonds.TabStop = false;
            // 
            // from_Bounds
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 772);
            Controls.Add(gp_cntrl);
            Controls.Add(gp_inputs);
            Controls.Add(gp_jh);
            Controls.Add(gp_bonds);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "from_Bounds";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Load += from_Bounds_Load;
            gp_cntrl.ResumeLayout(false);
            gp_cntrl.PerformLayout();
            cMenuStrip.ResumeLayout(false);
            gp_inputs.ResumeLayout(false);
            gp_inputs.PerformLayout();
            gp_jh.ResumeLayout(false);
            gp_jh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_bonds).EndInit();
            gp_bonds.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btn_enter;
        private Button select_account;
        private ComboBox cb_currency;
        private TextBox txt_exp;
        private TextBox txt_exch;
        private TextBox txt_amount;
        private TextBox txt_accname;
        private TextBox txt_accno;
        private Label label10;
        private Label label9;
        private Label label11;
        private Button btn_exit;
        private Button btn_del;
        private Button btn_edit;
        private Button btn_save;
        private Button btn_new;
        private TextBox txt_Deff;
        private TextBox txt_Tcredit;
        private TextBox txt_Tamount;
        private Label label14;
        private Label label12;
        private GroupBox gp_cntrl;
        private Label lebel20;
        private ToolStripMenuItem تعديلصفToolStripMenuItem;
        private ToolStripMenuItem حذفصفToolStripMenuItem;
        private ContextMenuStrip cMenuStrip;
        private GroupBox gp_inputs;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox gp_jh;
        private Button btn_search;
        private TextBox txt_search;
        private CheckBox chk_post;
        private TextBox txt_bound_no;
        private Button btn_last;
        private Button btn_next;
        private Button btn_prev;
        private Button btn_first;
        private RadioButton rb_in;
        private RadioButton rb_out;
        private DateTimePicker dtp_bdate;
        private Label label4;
        private TextBox txt_note;
        private TextBox txt_bno;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgv_bonds;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private TextBox txt_acc_no;
        private ComboBox cb_cash;
        private Label label8;
        private TextBox txt_uno;
        private TextBox txt_user;
        private Label label13;
        public GroupBox gp_bonds;
        public TextBox txt_jno;
        public TextBox txt_btype;
        private TextBox txt_cash_accno;
        private DataGridViewTextBoxColumn Column4;
    }
}