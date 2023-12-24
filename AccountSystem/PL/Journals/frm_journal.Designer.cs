namespace AccountSystem.PL.Journal
{
    partial class frm_journal
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
            gp_jh = new GroupBox();
            btn_search = new Button();
            txt_search = new TextBox();
            chk_post = new CheckBox();
            txt_ju_no = new TextBox();
            btn_last = new Button();
            btn_next = new Button();
            btn_prev = new Button();
            btn_first = new Button();
            rb_wait = new RadioButton();
            rb_general = new RadioButton();
            dtp_jdate = new DateTimePicker();
            label4 = new Label();
            txt_note = new TextBox();
            txt_jno = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gp_inputs = new GroupBox();
            btn_enter = new Button();
            select_account = new Button();
            cb_currency = new ComboBox();
            txt_exp = new TextBox();
            txt_exch = new TextBox();
            txt_credit = new TextBox();
            txt_debit = new TextBox();
            txt_accname = new TextBox();
            txt_accno = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            gp_journal = new GroupBox();
            dgv_Journal = new DataGridView();
            Column8 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            cMenuStrip = new ContextMenuStrip(components);
            حذفصفToolStripMenuItem = new ToolStripMenuItem();
            تعديلصفToolStripMenuItem = new ToolStripMenuItem();
            gp_cntrl = new GroupBox();
            btn_exit = new Button();
            btn_del = new Button();
            btn_edit = new Button();
            btn_save = new Button();
            btn_new = new Button();
            txt_Deff = new TextBox();
            txt_Tcredit = new TextBox();
            txt_Tdebit = new TextBox();
            label14 = new Label();
            lebel20 = new Label();
            label12 = new Label();
            label13 = new Label();
            txt_ptype = new TextBox();
            gp_jh.SuspendLayout();
            gp_inputs.SuspendLayout();
            gp_journal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Journal).BeginInit();
            cMenuStrip.SuspendLayout();
            gp_cntrl.SuspendLayout();
            SuspendLayout();
            // 
            // gp_jh
            // 
            gp_jh.Controls.Add(btn_search);
            gp_jh.Controls.Add(txt_search);
            gp_jh.Controls.Add(chk_post);
            gp_jh.Controls.Add(txt_ptype);
            gp_jh.Controls.Add(txt_ju_no);
            gp_jh.Controls.Add(btn_last);
            gp_jh.Controls.Add(btn_next);
            gp_jh.Controls.Add(btn_prev);
            gp_jh.Controls.Add(btn_first);
            gp_jh.Controls.Add(rb_wait);
            gp_jh.Controls.Add(rb_general);
            gp_jh.Controls.Add(dtp_jdate);
            gp_jh.Controls.Add(label13);
            gp_jh.Controls.Add(label4);
            gp_jh.Controls.Add(txt_note);
            gp_jh.Controls.Add(txt_jno);
            gp_jh.Controls.Add(label3);
            gp_jh.Controls.Add(label2);
            gp_jh.Controls.Add(label1);
            gp_jh.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gp_jh.Location = new Point(12, 12);
            gp_jh.Name = "gp_jh";
            gp_jh.Size = new Size(1038, 156);
            gp_jh.TabIndex = 15;
            gp_jh.TabStop = false;
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
            chk_post.Location = new Point(428, 107);
            chk_post.Name = "chk_post";
            chk_post.Size = new Size(57, 23);
            chk_post.TabIndex = 14;
            chk_post.Text = "مرحل";
            chk_post.UseVisualStyleBackColor = true;
            // 
            // txt_ju_no
            // 
            txt_ju_no.Location = new Point(181, 37);
            txt_ju_no.Name = "txt_ju_no";
            txt_ju_no.ReadOnly = true;
            txt_ju_no.Size = new Size(119, 26);
            txt_ju_no.TabIndex = 13;
            txt_ju_no.Text = "0";
            txt_ju_no.TextChanged += txt_ju_no_TextChanged;
            // 
            // btn_last
            // 
            btn_last.Location = new Point(19, 37);
            btn_last.Name = "btn_last";
            btn_last.Size = new Size(75, 26);
            btn_last.TabIndex = 12;
            btn_last.Text = "النهاية";
            btn_last.UseVisualStyleBackColor = true;
            btn_last.Click += btn_last_Click;
            // 
            // btn_next
            // 
            btn_next.Location = new Point(119, 37);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(56, 26);
            btn_next.TabIndex = 11;
            btn_next.Text = "التالي";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click;
            // 
            // btn_prev
            // 
            btn_prev.Location = new Point(306, 36);
            btn_prev.Name = "btn_prev";
            btn_prev.Size = new Size(56, 26);
            btn_prev.TabIndex = 10;
            btn_prev.Text = "السابق";
            btn_prev.UseVisualStyleBackColor = true;
            btn_prev.Click += btn_prev_Click;
            // 
            // btn_first
            // 
            btn_first.Location = new Point(387, 36);
            btn_first.Name = "btn_first";
            btn_first.Size = new Size(75, 26);
            btn_first.TabIndex = 18;
            btn_first.Text = "البداية";
            btn_first.UseVisualStyleBackColor = true;
            btn_first.Click += btn_first_Click;
            // 
            // rb_wait
            // 
            rb_wait.AutoSize = true;
            rb_wait.Location = new Point(33, 88);
            rb_wait.Name = "rb_wait";
            rb_wait.Size = new Size(54, 23);
            rb_wait.TabIndex = 8;
            rb_wait.Text = "معلق";
            rb_wait.UseVisualStyleBackColor = true;
            // 
            // rb_general
            // 
            rb_general.AutoSize = true;
            rb_general.Checked = true;
            rb_general.Location = new Point(93, 88);
            rb_general.Name = "rb_general";
            rb_general.Size = new Size(46, 23);
            rb_general.TabIndex = 7;
            rb_general.TabStop = true;
            rb_general.Text = "عام";
            rb_general.UseVisualStyleBackColor = true;
            // 
            // dtp_jdate
            // 
            dtp_jdate.Location = new Point(510, 37);
            dtp_jdate.Name = "dtp_jdate";
            dtp_jdate.Size = new Size(200, 26);
            dtp_jdate.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(149, 92);
            label4.Name = "label4";
            label4.Size = new Size(55, 19);
            label4.TabIndex = 5;
            label4.Text = "نوع القيد";
            // 
            // txt_note
            // 
            txt_note.Location = new Point(510, 104);
            txt_note.Name = "txt_note";
            txt_note.Size = new Size(452, 26);
            txt_note.TabIndex = 1;
            // 
            // txt_jno
            // 
            txt_jno.Location = new Point(820, 37);
            txt_jno.Name = "txt_jno";
            txt_jno.ReadOnly = true;
            txt_jno.Size = new Size(142, 26);
            txt_jno.TabIndex = 16;
            txt_jno.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(983, 111);
            label3.Name = "label3";
            label3.Size = new Size(38, 19);
            label3.TabIndex = 2;
            label3.Text = "البيان";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(730, 44);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 1;
            label2.Text = "تاريخ القيد";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(968, 44);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 0;
            label1.Text = "رقم القيد";
            // 
            // gp_inputs
            // 
            gp_inputs.Controls.Add(btn_enter);
            gp_inputs.Controls.Add(select_account);
            gp_inputs.Controls.Add(cb_currency);
            gp_inputs.Controls.Add(txt_exp);
            gp_inputs.Controls.Add(txt_exch);
            gp_inputs.Controls.Add(txt_credit);
            gp_inputs.Controls.Add(txt_debit);
            gp_inputs.Controls.Add(txt_accname);
            gp_inputs.Controls.Add(txt_accno);
            gp_inputs.Controls.Add(label11);
            gp_inputs.Controls.Add(label10);
            gp_inputs.Controls.Add(label9);
            gp_inputs.Controls.Add(label8);
            gp_inputs.Controls.Add(label7);
            gp_inputs.Controls.Add(label6);
            gp_inputs.Controls.Add(label5);
            gp_inputs.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gp_inputs.Location = new Point(12, 174);
            gp_inputs.Name = "gp_inputs";
            gp_inputs.Size = new Size(1038, 159);
            gp_inputs.TabIndex = 14;
            gp_inputs.TabStop = false;
            // 
            // btn_enter
            // 
            btn_enter.Location = new Point(19, 25);
            btn_enter.Name = "btn_enter";
            btn_enter.Size = new Size(109, 59);
            btn_enter.TabIndex = 31;
            btn_enter.Text = "ادخال الى القيد";
            btn_enter.UseVisualStyleBackColor = true;
            btn_enter.Click += btn_enter_Click;
            // 
            // select_account
            // 
            select_account.Location = new Point(881, 25);
            select_account.Name = "select_account";
            select_account.Size = new Size(151, 30);
            select_account.TabIndex = 30;
            select_account.Text = "البحث عن حساب";
            select_account.UseVisualStyleBackColor = true;
            select_account.Click += button1_Click;
            // 
            // cb_currency
            // 
            cb_currency.FormattingEnabled = true;
            cb_currency.Location = new Point(376, 110);
            cb_currency.Name = "cb_currency";
            cb_currency.Size = new Size(99, 27);
            cb_currency.TabIndex = 4;
            cb_currency.SelectedIndexChanged += cb_currency_SelectedIndexChanged;
            // 
            // txt_exp
            // 
            txt_exp.Location = new Point(89, 110);
            txt_exp.Name = "txt_exp";
            txt_exp.Size = new Size(151, 26);
            txt_exp.TabIndex = 6;
            // 
            // txt_exch
            // 
            txt_exch.Location = new Point(263, 110);
            txt_exch.Name = "txt_exch";
            txt_exch.Size = new Size(99, 26);
            txt_exch.TabIndex = 5;
            // 
            // txt_credit
            // 
            txt_credit.Location = new Point(491, 111);
            txt_credit.Name = "txt_credit";
            txt_credit.Size = new Size(99, 26);
            txt_credit.TabIndex = 3;
            txt_credit.Text = "0.00";
            // 
            // txt_debit
            // 
            txt_debit.Location = new Point(606, 112);
            txt_debit.Name = "txt_debit";
            txt_debit.Size = new Size(99, 26);
            txt_debit.TabIndex = 2;
            txt_debit.Text = "0.00";
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
            txt_accno.KeyDown += txt_accno_KeyDown;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(202, 78);
            label11.Name = "label11";
            label11.Size = new Size(38, 19);
            label11.TabIndex = 15;
            label11.Text = "البيان";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(314, 78);
            label10.Name = "label10";
            label10.Size = new Size(48, 19);
            label10.TabIndex = 14;
            label10.Text = "الصرف";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(434, 79);
            label9.Name = "label9";
            label9.Size = new Size(41, 19);
            label9.TabIndex = 13;
            label9.Text = "العملة";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(559, 79);
            label8.Name = "label8";
            label8.Size = new Size(31, 19);
            label8.TabIndex = 12;
            label8.Text = "دائن";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(671, 80);
            label7.Name = "label7";
            label7.Size = new Size(34, 19);
            label7.TabIndex = 11;
            label7.Text = "مدين";
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
            // gp_journal
            // 
            gp_journal.Controls.Add(dgv_Journal);
            gp_journal.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gp_journal.Location = new Point(12, 339);
            gp_journal.Name = "gp_journal";
            gp_journal.Size = new Size(1038, 256);
            gp_journal.TabIndex = 13;
            gp_journal.TabStop = false;
            gp_journal.Text = "قيد اليومية";
            // 
            // dgv_Journal
            // 
            dgv_Journal.AllowUserToAddRows = false;
            dgv_Journal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Journal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Journal.Columns.AddRange(new DataGridViewColumn[] { Column8, Column1, Column2, Column3, Column4, Column9, Column5, Column6, Column7, Column10, Column11 });
            dgv_Journal.ContextMenuStrip = cMenuStrip;
            dgv_Journal.Dock = DockStyle.Fill;
            dgv_Journal.Location = new Point(3, 22);
            dgv_Journal.Name = "dgv_Journal";
            dgv_Journal.RowHeadersVisible = false;
            dgv_Journal.RowTemplate.Height = 25;
            dgv_Journal.Size = new Size(1032, 231);
            dgv_Journal.TabIndex = 12;
            dgv_Journal.DoubleClick += dgv_Journal_DoubleClick;
            // 
            // Column8
            // 
            Column8.HeaderText = "رقم القيد";
            Column8.Name = "Column8";
            Column8.Visible = false;
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
            Column3.HeaderText = "مدين";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "دائن";
            Column4.Name = "Column4";
            // 
            // Column9
            // 
            Column9.HeaderText = "رقم العملة";
            Column9.Name = "Column9";
            Column9.Visible = false;
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
            // Column10
            // 
            Column10.HeaderText = "اجمالي مدين";
            Column10.Name = "Column10";
            Column10.Visible = false;
            // 
            // Column11
            // 
            Column11.HeaderText = "اجمالي دائن";
            Column11.Name = "Column11";
            Column11.Visible = false;
            // 
            // cMenuStrip
            // 
            cMenuStrip.Items.AddRange(new ToolStripItem[] { حذفصفToolStripMenuItem, تعديلصفToolStripMenuItem });
            cMenuStrip.Name = "cMenuStrip";
            cMenuStrip.RightToLeft = RightToLeft.Yes;
            cMenuStrip.Size = new Size(131, 48);
            // 
            // حذفصفToolStripMenuItem
            // 
            حذفصفToolStripMenuItem.Name = "حذفصفToolStripMenuItem";
            حذفصفToolStripMenuItem.Size = new Size(130, 22);
            حذفصفToolStripMenuItem.Text = "حذف صف";
            حذفصفToolStripMenuItem.Click += حذفصفToolStripMenuItem_Click;
            // 
            // تعديلصفToolStripMenuItem
            // 
            تعديلصفToolStripMenuItem.Name = "تعديلصفToolStripMenuItem";
            تعديلصفToolStripMenuItem.Size = new Size(130, 22);
            تعديلصفToolStripMenuItem.Text = "تعديل صف";
            تعديلصفToolStripMenuItem.Click += تعديلصفToolStripMenuItem_Click;
            // 
            // gp_cntrl
            // 
            gp_cntrl.Controls.Add(btn_exit);
            gp_cntrl.Controls.Add(btn_del);
            gp_cntrl.Controls.Add(btn_edit);
            gp_cntrl.Controls.Add(btn_save);
            gp_cntrl.Controls.Add(btn_new);
            gp_cntrl.Controls.Add(txt_Deff);
            gp_cntrl.Controls.Add(txt_Tcredit);
            gp_cntrl.Controls.Add(txt_Tdebit);
            gp_cntrl.Controls.Add(label14);
            gp_cntrl.Controls.Add(lebel20);
            gp_cntrl.Controls.Add(label12);
            gp_cntrl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gp_cntrl.Location = new Point(12, 601);
            gp_cntrl.Name = "gp_cntrl";
            gp_cntrl.Size = new Size(1038, 159);
            gp_cntrl.TabIndex = 11;
            gp_cntrl.TabStop = false;
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
            // txt_Deff
            // 
            txt_Deff.Location = new Point(491, 71);
            txt_Deff.Name = "txt_Deff";
            txt_Deff.ReadOnly = true;
            txt_Deff.Size = new Size(204, 26);
            txt_Deff.TabIndex = 25;
            txt_Deff.Text = "0.00";
            // 
            // txt_Tcredit
            // 
            txt_Tcredit.Location = new Point(759, 102);
            txt_Tcredit.Name = "txt_Tcredit";
            txt_Tcredit.ReadOnly = true;
            txt_Tcredit.Size = new Size(216, 26);
            txt_Tcredit.TabIndex = 24;
            txt_Tcredit.Text = "0.00";
            // 
            // txt_Tdebit
            // 
            txt_Tdebit.Location = new Point(759, 38);
            txt_Tdebit.Name = "txt_Tdebit";
            txt_Tdebit.ReadOnly = true;
            txt_Tdebit.Size = new Size(216, 26);
            txt_Tdebit.TabIndex = 23;
            txt_Tdebit.Text = "0.00";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(701, 78);
            label14.Name = "label14";
            label14.Size = new Size(39, 19);
            label14.TabIndex = 15;
            label14.Text = "الفرق";
            // 
            // lebel20
            // 
            lebel20.AutoSize = true;
            lebel20.Location = new Point(990, 109);
            lebel20.Name = "lebel20";
            lebel20.Size = new Size(31, 19);
            lebel20.TabIndex = 14;
            lebel20.Text = "دائن";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(987, 45);
            label12.Name = "label12";
            label12.Size = new Size(34, 19);
            label12.TabIndex = 13;
            label12.Text = "مدين";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(149, 127);
            label13.Name = "label13";
            label13.Size = new Size(69, 19);
            label13.TabIndex = 5;
            label13.Text = "نوع العملية";
            // 
            // txt_ptype
            // 
            txt_ptype.Location = new Point(21, 124);
            txt_ptype.Name = "txt_ptype";
            txt_ptype.ReadOnly = true;
            txt_ptype.Size = new Size(118, 26);
            txt_ptype.TabIndex = 6;
            // 
            // frm_journal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 772);
            ContextMenuStrip = cMenuStrip;
            Controls.Add(gp_cntrl);
            Controls.Add(gp_journal);
            Controls.Add(gp_inputs);
            Controls.Add(gp_jh);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_journal";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "قيد اليومية";
            gp_jh.ResumeLayout(false);
            gp_jh.PerformLayout();
            gp_inputs.ResumeLayout(false);
            gp_inputs.PerformLayout();
            gp_journal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Journal).EndInit();
            cMenuStrip.ResumeLayout(false);
            gp_cntrl.ResumeLayout(false);
            gp_cntrl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gp_jh;
        private Button btn_last;
        private Button btn_next;
        private Button btn_prev;
        private Button btn_first;
        private RadioButton rb_wait;
        private RadioButton rb_general;
        private DateTimePicker dtp_jdate;
        private Label label4;
        private TextBox txt_note;
        private TextBox txt_jno;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gp_inputs;
        private ComboBox cb_currency;
        private TextBox txt_exp;
        private TextBox txt_exch;
        private TextBox txt_credit;
        private TextBox txt_debit;
        private TextBox txt_accname;
        private TextBox txt_accno;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox gp_journal;
        private DataGridView dgv_Journal;
        private GroupBox gp_cntrl;
        private Button btn_exit;
        private Button btn_del;
        private Button btn_edit;
        private Button btn_save;
        private Button btn_new;
        private TextBox txt_Deff;
        //private TextBox textBox2;
        private TextBox txt_Tdebit;
        private Label label14;
        private Label label12;
        private TextBox textBox1;
        private TextBox txt_ju_no;
        private CheckBox chk_post;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private Button button1;
        private Button btn_enter;
        private ContextMenuStrip cMenuStrip;
        private ToolStripMenuItem حذفصفToolStripMenuItem;
        private ToolStripMenuItem تعديلصفToolStripMenuItem;
        private Label lebel20;
        private TextBox txt_Tcredit;
        private Button select_account;
        private Button btn_search;
        private TextBox txt_search;
        private TextBox txt_ptype;
        private Label label13;
    }
}