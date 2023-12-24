namespace AccountSystem.PL.SysFormat
{
    partial class frm_currencies
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
            dgv_currencies = new DataGridView();
            gb_inputs = new GroupBox();
            rb_forign = new RadioButton();
            rb_local = new RadioButton();
            txt_part = new TextBox();
            txt_exch = new TextBox();
            txt_symbol = new TextBox();
            txt_cname = new TextBox();
            txt_aname = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gb_currencies = new GroupBox();
            gb_ctrl = new GroupBox();
            btn_edit = new Button();
            btn_close = new Button();
            btn_del = new Button();
            btn_save = new Button();
            btn_new = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_currencies).BeginInit();
            gb_inputs.SuspendLayout();
            gb_currencies.SuspendLayout();
            gb_ctrl.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_currencies
            // 
            dgv_currencies.AllowUserToAddRows = false;
            dgv_currencies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_currencies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_currencies.Dock = DockStyle.Fill;
            dgv_currencies.Location = new Point(3, 25);
            dgv_currencies.Name = "dgv_currencies";
            dgv_currencies.RowHeadersVisible = false;
            dgv_currencies.RowTemplate.Height = 25;
            dgv_currencies.Size = new Size(517, 246);
            dgv_currencies.TabIndex = 0;
            dgv_currencies.CellClick += dgv_currencies_CellClick;
            // 
            // gb_inputs
            // 
            gb_inputs.Controls.Add(rb_forign);
            gb_inputs.Controls.Add(rb_local);
            gb_inputs.Controls.Add(txt_part);
            gb_inputs.Controls.Add(txt_exch);
            gb_inputs.Controls.Add(txt_symbol);
            gb_inputs.Controls.Add(txt_cname);
            gb_inputs.Controls.Add(txt_aname);
            gb_inputs.Controls.Add(label6);
            gb_inputs.Controls.Add(label5);
            gb_inputs.Controls.Add(label4);
            gb_inputs.Controls.Add(label3);
            gb_inputs.Controls.Add(label2);
            gb_inputs.Controls.Add(label1);
            gb_inputs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gb_inputs.Location = new Point(12, 292);
            gb_inputs.Name = "gb_inputs";
            gb_inputs.Size = new Size(523, 397);
            gb_inputs.TabIndex = 1;
            gb_inputs.TabStop = false;
            gb_inputs.Text = "المدخلات";
            // 
            // rb_forign
            // 
            rb_forign.AutoSize = true;
            rb_forign.Enabled = false;
            rb_forign.Location = new Point(39, 334);
            rb_forign.Name = "rb_forign";
            rb_forign.Size = new Size(99, 25);
            rb_forign.TabIndex = 7;
            rb_forign.TabStop = true;
            rb_forign.Text = "عملة اجنبية";
            rb_forign.UseVisualStyleBackColor = true;
            // 
            // rb_local
            // 
            rb_local.AutoSize = true;
            rb_local.Enabled = false;
            rb_local.Location = new Point(200, 334);
            rb_local.Name = "rb_local";
            rb_local.Size = new Size(99, 25);
            rb_local.TabIndex = 6;
            rb_local.TabStop = true;
            rb_local.Text = "عملة محلية";
            rb_local.UseVisualStyleBackColor = true;
            // 
            // txt_part
            // 
            txt_part.Enabled = false;
            txt_part.Location = new Point(9, 264);
            txt_part.Name = "txt_part";
            txt_part.Size = new Size(360, 29);
            txt_part.TabIndex = 5;
            // 
            // txt_exch
            // 
            txt_exch.Enabled = false;
            txt_exch.Location = new Point(9, 208);
            txt_exch.Name = "txt_exch";
            txt_exch.Size = new Size(360, 29);
            txt_exch.TabIndex = 4;
            // 
            // txt_symbol
            // 
            txt_symbol.Enabled = false;
            txt_symbol.Location = new Point(9, 144);
            txt_symbol.Name = "txt_symbol";
            txt_symbol.Size = new Size(360, 29);
            txt_symbol.TabIndex = 3;
            // 
            // txt_cname
            // 
            txt_cname.Enabled = false;
            txt_cname.Location = new Point(9, 88);
            txt_cname.Name = "txt_cname";
            txt_cname.Size = new Size(360, 29);
            txt_cname.TabIndex = 2;
            // 
            // txt_aname
            // 
            txt_aname.Enabled = false;
            txt_aname.Location = new Point(9, 32);
            txt_aname.Name = "txt_aname";
            txt_aname.Size = new Size(360, 29);
            txt_aname.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(408, 338);
            label6.Name = "label6";
            label6.Size = new Size(76, 21);
            label6.TabIndex = 1;
            label6.Text = "نوع العملة";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(441, 272);
            label5.Name = "label5";
            label5.Size = new Size(43, 21);
            label5.TabIndex = 1;
            label5.Text = "الفكة";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(428, 216);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 1;
            label4.Text = "الصرف";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(408, 152);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 1;
            label3.Text = "رمز العملة";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(390, 96);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 1;
            label2.Text = "الاسم الاجنبي";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(404, 40);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 0;
            label1.Text = "اسم العملة";
            // 
            // gb_currencies
            // 
            gb_currencies.Controls.Add(dgv_currencies);
            gb_currencies.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gb_currencies.Location = new Point(12, 12);
            gb_currencies.Name = "gb_currencies";
            gb_currencies.Size = new Size(523, 274);
            gb_currencies.TabIndex = 2;
            gb_currencies.TabStop = false;
            gb_currencies.Text = "العملات";
            // 
            // gb_ctrl
            // 
            gb_ctrl.Controls.Add(btn_edit);
            gb_ctrl.Controls.Add(btn_close);
            gb_ctrl.Controls.Add(btn_del);
            gb_ctrl.Controls.Add(btn_save);
            gb_ctrl.Controls.Add(btn_new);
            gb_ctrl.Location = new Point(9, 695);
            gb_ctrl.Name = "gb_ctrl";
            gb_ctrl.Size = new Size(523, 116);
            gb_ctrl.TabIndex = 3;
            gb_ctrl.TabStop = false;
            // 
            // btn_edit
            // 
            btn_edit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_edit.Location = new Point(235, 39);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(91, 40);
            btn_edit.TabIndex = 9;
            btn_edit.Text = "تعديل";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_close
            // 
            btn_close.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_close.Location = new Point(7, 39);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(91, 40);
            btn_close.TabIndex = 11;
            btn_close.Text = "خروج";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // btn_del
            // 
            btn_del.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_del.Location = new Point(138, 39);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(91, 40);
            btn_del.TabIndex = 10;
            btn_del.Text = "حذف";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_save.Location = new Point(332, 39);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(91, 40);
            btn_save.TabIndex = 8;
            btn_save.Text = "حفظ";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_new
            // 
            btn_new.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_new.Location = new Point(429, 39);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(91, 40);
            btn_new.TabIndex = 0;
            btn_new.Text = "جديد";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // frm_currencies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 823);
            Controls.Add(gb_inputs);
            Controls.Add(gb_currencies);
            Controls.Add(gb_ctrl);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_currencies";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "العملات";
            ((System.ComponentModel.ISupportInitialize)dgv_currencies).EndInit();
            gb_inputs.ResumeLayout(false);
            gb_inputs.PerformLayout();
            gb_currencies.ResumeLayout(false);
            gb_ctrl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_currencies;
        private GroupBox gb_inputs;
        private RadioButton rb_forign;
        private RadioButton rb_local;
        private TextBox txt_part;
        private TextBox txt_exch;
        private TextBox txt_symbol;
        private TextBox txt_cname;
        public TextBox txt_aname;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public GroupBox gb_currencies;
        private GroupBox gb_ctrl;
        //private Button btn_display;
        private Button btn_close;
        private Button btn_del;
        private Button btn_save;
        private Button btn_new;
        private Button btn_edit;
    }
}