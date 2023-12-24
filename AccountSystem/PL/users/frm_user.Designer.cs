namespace AccountSystem.PL.users
{
    partial class frm_user
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            rb_limit = new RadioButton();
            rb_admin = new RadioButton();
            chk_lock = new CheckBox();
            txt_email = new TextBox();
            txt_tel = new TextBox();
            txt_pwd = new TextBox();
            txt_name = new TextBox();
            txt_fname = new TextBox();
            txt_uno = new TextBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            btn_clear = new Button();
            btn_brwose = new Button();
            pb_image = new PictureBox();
            groupBox3 = new GroupBox();
            dgv_users = new DataGridView();
            groupBox4 = new GroupBox();
            btn_exit = new Button();
            btn_del = new Button();
            btn_edit = new Button();
            btn_save = new Button();
            btn_new = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_image).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_users).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(321, 16);
            label1.Name = "label1";
            label1.Size = new Size(79, 19);
            label1.TabIndex = 0;
            label1.Text = "رقم المستخدم";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(321, 65);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 1;
            label2.Text = "الاسم الرباعي";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(321, 117);
            label3.Name = "label3";
            label3.Size = new Size(57, 19);
            label3.TabIndex = 2;
            label3.Text = "المستخدم";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(321, 171);
            label4.Name = "label4";
            label4.Size = new Size(73, 19);
            label4.TabIndex = 3;
            label4.Text = "كلمة المرور";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(321, 231);
            label5.Name = "label5";
            label5.Size = new Size(37, 19);
            label5.TabIndex = 4;
            label5.Text = "هاتف";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(321, 284);
            label6.Name = "label6";
            label6.Size = new Size(94, 19);
            label6.TabIndex = 5;
            label6.Text = "البريد الالكتروني";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_limit);
            groupBox1.Controls.Add(rb_admin);
            groupBox1.Controls.Add(chk_lock);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(txt_tel);
            groupBox1.Controls.Add(txt_pwd);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(txt_fname);
            groupBox1.Controls.Add(txt_uno);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 369);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "البيانات";
            // 
            // rb_limit
            // 
            rb_limit.AutoSize = true;
            rb_limit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rb_limit.Location = new Point(10, 333);
            rb_limit.Name = "rb_limit";
            rb_limit.Size = new Size(81, 25);
            rb_limit.TabIndex = 15;
            rb_limit.TabStop = true;
            rb_limit.Text = "مستخدم";
            rb_limit.UseVisualStyleBackColor = true;
            // 
            // rb_admin
            // 
            rb_admin.AutoSize = true;
            rb_admin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rb_admin.Location = new Point(123, 331);
            rb_admin.Name = "rb_admin";
            rb_admin.Size = new Size(77, 25);
            rb_admin.TabIndex = 14;
            rb_admin.TabStop = true;
            rb_admin.Text = "مسؤول";
            rb_admin.UseVisualStyleBackColor = true;
            // 
            // chk_lock
            // 
            chk_lock.AutoSize = true;
            chk_lock.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chk_lock.Location = new Point(235, 332);
            chk_lock.Name = "chk_lock";
            chk_lock.Size = new Size(70, 25);
            chk_lock.TabIndex = 13;
            chk_lock.Text = "موقف";
            chk_lock.UseVisualStyleBackColor = true;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(0, 284);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(305, 23);
            txt_email.TabIndex = 12;
            txt_email.Validated += txt_email_Validated;
            // 
            // txt_tel
            // 
            txt_tel.Location = new Point(0, 231);
            txt_tel.Name = "txt_tel";
            txt_tel.Size = new Size(305, 23);
            txt_tel.TabIndex = 11;
            // 
            // txt_pwd
            // 
            txt_pwd.Location = new Point(0, 171);
            txt_pwd.Name = "txt_pwd";
            txt_pwd.Size = new Size(305, 23);
            txt_pwd.TabIndex = 10;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(0, 117);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(305, 23);
            txt_name.TabIndex = 9;
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(0, 65);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(305, 23);
            txt_fname.TabIndex = 8;
            // 
            // txt_uno
            // 
            txt_uno.Enabled = false;
            txt_uno.Location = new Point(0, 16);
            txt_uno.Name = "txt_uno";
            txt_uno.Size = new Size(305, 23);
            txt_uno.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(321, 333);
            label7.Name = "label7";
            label7.Size = new Size(84, 19);
            label7.TabIndex = 6;
            label7.Text = "حالة المستخدم";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_clear);
            groupBox2.Controls.Add(btn_brwose);
            groupBox2.Controls.Add(pb_image);
            groupBox2.Location = new Point(433, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 369);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(6, 260);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(87, 39);
            btn_clear.TabIndex = 2;
            btn_clear.Text = "مسح";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_brwose
            // 
            btn_brwose.Location = new Point(107, 260);
            btn_brwose.Name = "btn_brwose";
            btn_brwose.Size = new Size(87, 39);
            btn_brwose.TabIndex = 1;
            btn_brwose.Text = "استعراض";
            btn_brwose.UseVisualStyleBackColor = true;
            btn_brwose.Click += btn_brwose_Click;
            // 
            // pb_image
            // 
            pb_image.Location = new Point(6, 16);
            pb_image.Name = "pb_image";
            pb_image.Size = new Size(188, 238);
            pb_image.SizeMode = PictureBoxSizeMode.Zoom;
            pb_image.TabIndex = 0;
            pb_image.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgv_users);
            groupBox3.Location = new Point(12, 387);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(621, 179);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "المستخدمون";
            // 
            // dgv_users
            // 
            dgv_users.AllowUserToAddRows = false;
            dgv_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_users.Dock = DockStyle.Fill;
            dgv_users.Location = new Point(3, 19);
            dgv_users.Name = "dgv_users";
            dgv_users.RowHeadersVisible = false;
            dgv_users.RowTemplate.Height = 25;
            dgv_users.Size = new Size(615, 157);
            dgv_users.TabIndex = 0;
            dgv_users.DoubleClick += dgv_users_DoubleClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_exit);
            groupBox4.Controls.Add(btn_del);
            groupBox4.Controls.Add(btn_edit);
            groupBox4.Controls.Add(btn_save);
            groupBox4.Controls.Add(btn_new);
            groupBox4.Location = new Point(12, 572);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(621, 62);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(6, 13);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(75, 39);
            btn_exit.TabIndex = 4;
            btn_exit.Text = "خروج";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_del
            // 
            btn_del.Location = new Point(206, 13);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(75, 39);
            btn_del.TabIndex = 3;
            btn_del.Text = "حذف";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click_1;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(320, 13);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(75, 39);
            btn_edit.TabIndex = 2;
            btn_edit.Text = "تعديل";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_save
            // 
            btn_save.Enabled = false;
            btn_save.Location = new Point(436, 13);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 39);
            btn_save.TabIndex = 1;
            btn_save.Text = "حفظ";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_new
            // 
            btn_new.Location = new Point(540, 13);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(75, 39);
            btn_new.TabIndex = 0;
            btn_new.Text = "جديد";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // frm_user
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 636);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_user";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "المستخدمون";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_image).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_users).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private CheckBox chk_lock;
        private TextBox txt_email;
        private TextBox txt_tel;
        private TextBox txt_pwd;
        private TextBox txt_name;
        private TextBox txt_fname;
        private TextBox txt_uno;
        private Label label7;
        private GroupBox groupBox2;
        private Button btn_clear;
        private Button btn_brwose;
        private PictureBox pb_image;
        private GroupBox groupBox3;
        private DataGridView dgv_users;
        private GroupBox groupBox4;
        private Button btn_exit;
        private Button btn_del;
        private Button btn_edit;
        private Button btn_save;
        private Button btn_new;
        private RadioButton rb_limit;
        private RadioButton rb_admin;
    }
}