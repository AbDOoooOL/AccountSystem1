namespace AccountSystem.PL
{
    partial class frm_logins
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
            txt_user = new TextBox();
            txt_pwd = new TextBox();
            btn_login = new Button();
            btn_close = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 64);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 19);
            label1.TabIndex = 0;
            label1.Text = "اسم المستخدم";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 121);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 19);
            label2.TabIndex = 1;
            label2.Text = "كلمة المرور";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(167, 61);
            txt_user.Margin = new Padding(4);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(220, 26);
            txt_user.TabIndex = 2;
            txt_user.Text = "ahmad";
            txt_user.KeyDown += txt_user_KeyDown;
            // 
            // txt_pwd
            // 
            txt_pwd.Location = new Point(167, 118);
            txt_pwd.Margin = new Padding(4);
            txt_pwd.Name = "txt_pwd";
            txt_pwd.PasswordChar = '*';
            txt_pwd.Size = new Size(220, 26);
            txt_pwd.TabIndex = 3;
            txt_pwd.Text = "123";
            txt_pwd.KeyDown += txt_pwd_KeyDown;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(70, 194);
            btn_login.Margin = new Padding(4);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(140, 29);
            btn_login.TabIndex = 4;
            btn_login.Text = "دخول";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(247, 194);
            btn_close.Margin = new Padding(4);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(140, 29);
            btn_close.TabIndex = 5;
            btn_close.Text = "خروج";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // frm_logins
            // 
            AcceptButton = btn_login;
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 279);
            Controls.Add(btn_close);
            Controls.Add(btn_login);
            Controls.Add(txt_pwd);
            Controls.Add(txt_user);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_logins";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "دخول";
            Load += frm_logins_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_user;
        private TextBox txt_pwd;
        private Button btn_login;
        private Button btn_close;
    }
}