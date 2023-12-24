namespace AccountSystem.PL.SysFormat
{
    partial class frm_ConFormat
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
            txt_Mode = new TextBox();
            txt_Server = new TextBox();
            txt_DB = new TextBox();
            txt_User = new TextBox();
            txt_PWD = new TextBox();
            btn_New = new Button();
            btn_Save = new Button();
            btn_browse = new Button();
            btn_Edit = new Button();
            btn_del = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(40, 31);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 0;
            label1.Text = "نمط الاتصال";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(40, 74);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 1;
            label2.Text = "اسم السرفر";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(40, 120);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 2;
            label3.Text = "قاعدة البيانات";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(40, 160);
            label4.Name = "label4";
            label4.Size = new Size(81, 19);
            label4.TabIndex = 3;
            label4.Text = "اسم المستخدم";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(40, 208);
            label5.Name = "label5";
            label5.Size = new Size(73, 19);
            label5.TabIndex = 4;
            label5.Text = "كلمة المرور";
            // 
            // txt_Mode
            // 
            txt_Mode.Enabled = false;
            txt_Mode.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Mode.Location = new Point(124, 28);
            txt_Mode.Name = "txt_Mode";
            txt_Mode.Size = new Size(384, 26);
            txt_Mode.TabIndex = 1;
            txt_Mode.KeyDown += txt_Mode_KeyDown;
            // 
            // txt_Server
            // 
            txt_Server.Enabled = false;
            txt_Server.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Server.Location = new Point(124, 71);
            txt_Server.Name = "txt_Server";
            txt_Server.Size = new Size(384, 26);
            txt_Server.TabIndex = 2;
            txt_Server.KeyDown += txt_Server_KeyDown;
            // 
            // txt_DB
            // 
            txt_DB.Enabled = false;
            txt_DB.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_DB.Location = new Point(124, 117);
            txt_DB.Name = "txt_DB";
            txt_DB.Size = new Size(384, 26);
            txt_DB.TabIndex = 3;
            txt_DB.KeyDown += txt_DB_KeyDown;
            // 
            // txt_User
            // 
            txt_User.Enabled = false;
            txt_User.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_User.Location = new Point(124, 157);
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(384, 26);
            txt_User.TabIndex = 4;
            txt_User.KeyDown += txt_User_KeyDown;
            // 
            // txt_PWD
            // 
            txt_PWD.Enabled = false;
            txt_PWD.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_PWD.Location = new Point(124, 205);
            txt_PWD.Name = "txt_PWD";
            txt_PWD.Size = new Size(384, 26);
            txt_PWD.TabIndex = 5;
            // 
            // btn_New
            // 
            btn_New.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_New.ForeColor = Color.Navy;
            btn_New.Location = new Point(40, 255);
            btn_New.Name = "btn_New";
            btn_New.Size = new Size(75, 28);
            btn_New.TabIndex = 8;
            btn_New.Text = "جديد";
            btn_New.UseVisualStyleBackColor = true;
            btn_New.Click += btn_New_Click;
            // 
            // btn_Save
            // 
            btn_Save.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Save.ForeColor = Color.Navy;
            btn_Save.Location = new Point(121, 255);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 28);
            btn_Save.TabIndex = 6;
            btn_Save.Text = "حفظ";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_browse
            // 
            btn_browse.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_browse.ForeColor = Color.Navy;
            btn_browse.Location = new Point(202, 255);
            btn_browse.Name = "btn_browse";
            btn_browse.Size = new Size(75, 28);
            btn_browse.TabIndex = 9;
            btn_browse.Text = "عرض";
            btn_browse.UseVisualStyleBackColor = true;
            btn_browse.Click += btn_browse_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Edit.ForeColor = Color.Navy;
            btn_Edit.Location = new Point(433, 255);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(75, 28);
            btn_Edit.TabIndex = 7;
            btn_Edit.Text = "خروج";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_del
            // 
            btn_del.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_del.ForeColor = Color.Navy;
            btn_del.Location = new Point(283, 255);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(75, 28);
            btn_del.TabIndex = 10;
            btn_del.Text = "حذف";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // frm_ConFormat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 306);
            Controls.Add(btn_del);
            Controls.Add(btn_Edit);
            Controls.Add(btn_browse);
            Controls.Add(btn_Save);
            Controls.Add(btn_New);
            Controls.Add(txt_PWD);
            Controls.Add(txt_User);
            Controls.Add(txt_DB);
            Controls.Add(txt_Server);
            Controls.Add(txt_Mode);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.DarkBlue;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_ConFormat";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "تهيئة الاتصال بقاعدة البيانات";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_Mode;
        private TextBox txt_Server;
        private TextBox txt_DB;
        private TextBox txt_User;
        private TextBox txt_PWD;
        private Button btn_New;
        private Button btn_Save;
        private Button btn_browse;
        private Button btn_Edit;
        private Button btn_del;
    }
}