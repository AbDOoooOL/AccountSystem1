namespace AccountSystem.PL.SysFormat
{
    partial class frm_Company
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txt_aname = new TextBox();
            txt_ename = new TextBox();
            txt_aaddress = new TextBox();
            txt_eaddress = new TextBox();
            txt_tel = new TextBox();
            txt_fax = new TextBox();
            txt_email = new TextBox();
            txt_website = new TextBox();
            dgv_cdata = new DataGridView();
            btn_new = new Button();
            btn_save = new Button();
            btn_edit = new Button();
            btn_del = new Button();
            btn_close = new Button();
            pb_Logo = new PictureBox();
            btn_clear = new Button();
            btn_browse = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_cdata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 1;
            label2.Text = "الاسم بالعربي";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 45);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 2;
            label3.Text = "الاسم الاجنبي";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 80);
            label4.Name = "label4";
            label4.Size = new Size(85, 19);
            label4.TabIndex = 3;
            label4.Text = "العنوان العربي";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 123);
            label5.Name = "label5";
            label5.Size = new Size(92, 19);
            label5.TabIndex = 4;
            label5.Text = "العنوان بالاجنبي";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 163);
            label6.Name = "label6";
            label6.Size = new Size(38, 19);
            label6.TabIndex = 5;
            label6.Text = "تلفون";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 204);
            label7.Name = "label7";
            label7.Size = new Size(38, 19);
            label7.TabIndex = 6;
            label7.Text = "فاكس";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 243);
            label8.Name = "label8";
            label8.Size = new Size(78, 19);
            label8.TabIndex = 7;
            label8.Text = "بريد الكتروني";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 283);
            label9.Name = "label9";
            label9.Size = new Size(101, 19);
            label9.TabIndex = 8;
            label9.Text = "الموقع الالكتروني";
            // 
            // txt_aname
            // 
            txt_aname.Enabled = false;
            txt_aname.Location = new Point(117, 6);
            txt_aname.Name = "txt_aname";
            txt_aname.Size = new Size(340, 23);
            txt_aname.TabIndex = 1;
            txt_aname.TextAlign = HorizontalAlignment.Center;
            txt_aname.Enter += txt_aname_Enter;
            // 
            // txt_ename
            // 
            txt_ename.Enabled = false;
            txt_ename.Location = new Point(117, 42);
            txt_ename.Name = "txt_ename";
            txt_ename.Size = new Size(340, 23);
            txt_ename.TabIndex = 2;
            txt_ename.TextAlign = HorizontalAlignment.Center;
            txt_ename.Enter += txt_ename_Enter;
            // 
            // txt_aaddress
            // 
            txt_aaddress.Enabled = false;
            txt_aaddress.Location = new Point(117, 77);
            txt_aaddress.Name = "txt_aaddress";
            txt_aaddress.Size = new Size(340, 23);
            txt_aaddress.TabIndex = 3;
            txt_aaddress.TextAlign = HorizontalAlignment.Center;
            txt_aaddress.Enter += txt_aaddress_Enter;
            // 
            // txt_eaddress
            // 
            txt_eaddress.Enabled = false;
            txt_eaddress.Location = new Point(117, 120);
            txt_eaddress.Name = "txt_eaddress";
            txt_eaddress.Size = new Size(340, 23);
            txt_eaddress.TabIndex = 4;
            txt_eaddress.TextAlign = HorizontalAlignment.Center;
            txt_eaddress.Enter += txt_eaddress_Enter;
            // 
            // txt_tel
            // 
            txt_tel.Enabled = false;
            txt_tel.Location = new Point(117, 160);
            txt_tel.Name = "txt_tel";
            txt_tel.Size = new Size(340, 23);
            txt_tel.TabIndex = 5;
            txt_tel.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_fax
            // 
            txt_fax.Enabled = false;
            txt_fax.Location = new Point(117, 201);
            txt_fax.Name = "txt_fax";
            txt_fax.Size = new Size(340, 23);
            txt_fax.TabIndex = 6;
            txt_fax.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_email
            // 
            txt_email.Enabled = false;
            txt_email.Location = new Point(117, 240);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(340, 23);
            txt_email.TabIndex = 7;
            txt_email.TextAlign = HorizontalAlignment.Center;
            txt_email.Enter += txt_email_Enter;
            txt_email.Validated += txt_email_Validated;
            // 
            // txt_website
            // 
            txt_website.Enabled = false;
            txt_website.Location = new Point(117, 280);
            txt_website.Name = "txt_website";
            txt_website.Size = new Size(340, 23);
            txt_website.TabIndex = 8;
            txt_website.TextAlign = HorizontalAlignment.Center;
            txt_website.TextChanged += txt_website_TextChanged;
            txt_website.Enter += txt_website_Enter;
            // 
            // dgv_cdata
            // 
            dgv_cdata.AllowUserToAddRows = false;
            dgv_cdata.AllowUserToDeleteRows = false;
            dgv_cdata.AllowUserToResizeColumns = false;
            dgv_cdata.AllowUserToResizeRows = false;
            dgv_cdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_cdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_cdata.Location = new Point(12, 309);
            dgv_cdata.Name = "dgv_cdata";
            dgv_cdata.RowHeadersVisible = false;
            dgv_cdata.RowTemplate.Height = 25;
            dgv_cdata.Size = new Size(616, 216);
            dgv_cdata.TabIndex = 19;
            dgv_cdata.DoubleClick += dgv_cdata_DoubleClick;
            // 
            // btn_new
            // 
            btn_new.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_new.ForeColor = Color.DarkBlue;
            btn_new.Location = new Point(20, 540);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(93, 31);
            btn_new.TabIndex = 10;
            btn_new.Text = "جديد";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // btn_save
            // 
            btn_save.Enabled = false;
            btn_save.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_save.ForeColor = Color.DarkBlue;
            btn_save.Location = new Point(119, 540);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(93, 31);
            btn_save.TabIndex = 9;
            btn_save.Text = "حفظ";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click_1;
            // 
            // btn_edit
            // 
            btn_edit.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_edit.ForeColor = Color.DarkBlue;
            btn_edit.Location = new Point(218, 540);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(93, 31);
            btn_edit.TabIndex = 11;
            btn_edit.Text = " حفظ التعديلات";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_del
            // 
            btn_del.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_del.ForeColor = Color.DarkBlue;
            btn_del.Location = new Point(317, 540);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(93, 31);
            btn_del.TabIndex = 12;
            btn_del.Text = "حذف";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // btn_close
            // 
            btn_close.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_close.ForeColor = Color.DarkBlue;
            btn_close.Location = new Point(534, 540);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(93, 31);
            btn_close.TabIndex = 13;
            btn_close.Text = "خروج";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // pb_Logo
            // 
            pb_Logo.Location = new Point(468, 6);
            pb_Logo.Name = "pb_Logo";
            pb_Logo.Size = new Size(160, 169);
            pb_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Logo.TabIndex = 18;
            pb_Logo.TabStop = false;
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clear.ForeColor = Color.DarkBlue;
            btn_clear.Location = new Point(553, 181);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 31);
            btn_clear.TabIndex = 16;
            btn_clear.Text = "مسح";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_browse
            // 
            btn_browse.Enabled = false;
            btn_browse.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_browse.ForeColor = Color.DarkBlue;
            btn_browse.Location = new Point(468, 181);
            btn_browse.Name = "btn_browse";
            btn_browse.Size = new Size(75, 31);
            btn_browse.TabIndex = 15;
            btn_browse.Text = "استعراض";
            btn_browse.UseVisualStyleBackColor = true;
            btn_browse.Click += btn_browse_Click;
            // 
            // frm_Company
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 576);
            Controls.Add(btn_browse);
            Controls.Add(btn_clear);
            Controls.Add(btn_close);
            Controls.Add(btn_del);
            Controls.Add(btn_edit);
            Controls.Add(btn_save);
            Controls.Add(btn_new);
            Controls.Add(dgv_cdata);
            Controls.Add(pb_Logo);
            Controls.Add(txt_website);
            Controls.Add(txt_email);
            Controls.Add(txt_fax);
            Controls.Add(txt_tel);
            Controls.Add(txt_eaddress);
            Controls.Add(txt_aaddress);
            Controls.Add(txt_ename);
            Controls.Add(txt_aname);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_Company";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "بيانات الشركة";
            ((System.ComponentModel.ISupportInitialize)dgv_cdata).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txt_aname;
        private TextBox txt_ename;
        private TextBox txt_aaddress;
        private TextBox txt_eaddress;
        private TextBox txt_tel;
        private TextBox txt_fax;
        private TextBox txt_email;
        private TextBox txt_website;
        private DataGridView dgv_cdata;
        private Button btn_new;
        private Button btn_save;
        private Button btn_edit;
        private Button btn_del;
        private Button btn_close;

        private Button btn_clear;
        private Button btn_browse;
        private PictureBox pb_Logo;
    }
}