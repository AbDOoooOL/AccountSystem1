namespace AccountSystem.PL.SysFormat
{
    partial class frm_cash
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
            gb_cash = new GroupBox();
            dgv_cash = new DataGridView();
            gb_inputs = new GroupBox();
            txt_accname = new TextBox();
            txt_function = new TextBox();
            txt_accno = new TextBox();
            label2 = new Label();
            label1 = new Label();
            gb_ctrl = new GroupBox();
            btn_display = new Button();
            btn_close = new Button();
            btn_del = new Button();
            btn_save = new Button();
            btn_new = new Button();
            gb_cash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_cash).BeginInit();
            gb_inputs.SuspendLayout();
            gb_ctrl.SuspendLayout();
            SuspendLayout();
            // 
            // gb_cash
            // 
            gb_cash.Controls.Add(dgv_cash);
            gb_cash.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gb_cash.Location = new Point(12, 12);
            gb_cash.Name = "gb_cash";
            gb_cash.Size = new Size(721, 274);
            gb_cash.TabIndex = 0;
            gb_cash.TabStop = false;
            gb_cash.Text = "النقدية";
            // 
            // dgv_cash
            // 
            dgv_cash.AllowUserToAddRows = false;
            dgv_cash.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_cash.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_cash.Dock = DockStyle.Fill;
            dgv_cash.Location = new Point(3, 25);
            dgv_cash.Name = "dgv_cash";
            dgv_cash.RowHeadersVisible = false;
            dgv_cash.RowTemplate.Height = 25;
            dgv_cash.Size = new Size(715, 246);
            dgv_cash.TabIndex = 0;
            dgv_cash.CellClick += dgv_cash_CellClick;
            // 
            // gb_inputs
            // 
            gb_inputs.Controls.Add(txt_accname);
            gb_inputs.Controls.Add(txt_function);
            gb_inputs.Controls.Add(txt_accno);
            gb_inputs.Controls.Add(label2);
            gb_inputs.Controls.Add(label1);
            gb_inputs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gb_inputs.Location = new Point(12, 292);
            gb_inputs.Name = "gb_inputs";
            gb_inputs.Size = new Size(721, 159);
            gb_inputs.TabIndex = 0;
            gb_inputs.TabStop = false;
            gb_inputs.Text = "المدخلات";
            // 
            // txt_accname
            // 
            txt_accname.Enabled = false;
            txt_accname.Location = new Point(50, 88);
            txt_accname.Name = "txt_accname";
            txt_accname.Size = new Size(473, 29);
            txt_accname.TabIndex = 7;
            // 
            // txt_function
            // 
            txt_function.Location = new Point(529, 42);
            txt_function.Name = "txt_function";
            txt_function.Size = new Size(37, 29);
            txt_function.TabIndex = 6;
            // 
            // txt_accno
            // 
            txt_accno.Enabled = false;
            txt_accno.Location = new Point(50, 42);
            txt_accno.Name = "txt_accno";
            txt_accno.Size = new Size(473, 29);
            txt_accno.TabIndex = 1;
            txt_accno.KeyDown += txt_accno_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(601, 91);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 1;
            label2.Text = "اسم الحساب";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(604, 45);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 0;
            label1.Text = "رقم الحساب";
            // 
            // gb_ctrl
            // 
            gb_ctrl.Controls.Add(btn_display);
            gb_ctrl.Controls.Add(btn_close);
            gb_ctrl.Controls.Add(btn_del);
            gb_ctrl.Controls.Add(btn_save);
            gb_ctrl.Controls.Add(btn_new);
            gb_ctrl.Location = new Point(12, 457);
            gb_ctrl.Name = "gb_ctrl";
            gb_ctrl.Size = new Size(721, 97);
            gb_ctrl.TabIndex = 0;
            gb_ctrl.TabStop = false;
            // 
            // btn_display
            // 
            btn_display.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_display.Location = new Point(322, 39);
            btn_display.Name = "btn_display";
            btn_display.Size = new Size(108, 40);
            btn_display.TabIndex = 7;
            btn_display.Text = "عرض";
            btn_display.UseVisualStyleBackColor = true;
            btn_display.Click += btn_display_Click;
            // 
            // btn_close
            // 
            btn_close.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_close.Location = new Point(6, 39);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(108, 40);
            btn_close.TabIndex = 7;
            btn_close.Text = "خروج";
            btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            btn_del.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_del.Location = new Point(186, 39);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(108, 40);
            btn_del.TabIndex = 6;
            btn_del.Text = "حذف";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_save.Location = new Point(462, 39);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(108, 40);
            btn_save.TabIndex = 4;
            btn_save.Text = "حفظ";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_new
            // 
            btn_new.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_new.Location = new Point(598, 39);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(108, 40);
            btn_new.TabIndex = 0;
            btn_new.Text = "جديد";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // frm_cash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 563);
            Controls.Add(gb_ctrl);
            Controls.Add(gb_inputs);
            Controls.Add(gb_cash);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_cash";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            gb_cash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_cash).EndInit();
            gb_inputs.ResumeLayout(false);
            gb_inputs.PerformLayout();
            gb_ctrl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gb_inputs;
        private GroupBox gb_ctrl;
        private DataGridView dgv_cash;
        //private TextBox acc_ename;
        private TextBox acc_name;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_close;
        private Button btn_del;
        private Button btn_edit;
        private Button btn_save;
        private Button btn_new;
        public TextBox txt_function;
        public GroupBox gb_cash;
        private Button button2;
        private TextBox txt_name;
        private TextBox txt_accname;
        public TextBox txt_accno;
        private Button btn_display;
    }
}