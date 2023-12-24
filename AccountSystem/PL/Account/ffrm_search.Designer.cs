namespace AccountSystem.PL.Account
{
    partial class ffrm_search
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
            gp_search = new GroupBox();
            txt_search = new TextBox();
            gp_result = new GroupBox();
            dgv_results = new DataGridView();
            groupBox1 = new GroupBox();
            txt_close = new Button();
            gp_search.SuspendLayout();
            gp_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_results).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gp_search
            // 
            gp_search.Controls.Add(txt_search);
            gp_search.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gp_search.Location = new Point(12, 11);
            gp_search.Name = "gp_search";
            gp_search.Size = new Size(532, 90);
            gp_search.TabIndex = 0;
            gp_search.TabStop = false;
            gp_search.Text = "ادخل رقم الحساب";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(6, 28);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(520, 29);
            txt_search.TabIndex = 0;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // gp_result
            // 
            gp_result.Controls.Add(dgv_results);
            gp_result.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gp_result.Location = new Point(12, 107);
            gp_result.Name = "gp_result";
            gp_result.Size = new Size(532, 381);
            gp_result.TabIndex = 1;
            gp_result.TabStop = false;
            gp_result.Text = "النتائج";
            // 
            // dgv_results
            // 
            dgv_results.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_results.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_results.Dock = DockStyle.Fill;
            dgv_results.Location = new Point(3, 25);
            dgv_results.Name = "dgv_results";
            dgv_results.RowHeadersVisible = false;
            dgv_results.RowTemplate.Height = 25;
            dgv_results.Size = new Size(526, 353);
            dgv_results.TabIndex = 0;
            dgv_results.CellClick += dgv_results_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_close);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 494);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 90);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // txt_close
            // 
            txt_close.Location = new Point(198, 28);
            txt_close.Name = "txt_close";
            txt_close.Size = new Size(98, 42);
            txt_close.TabIndex = 0;
            txt_close.Text = "خروج";
            txt_close.UseVisualStyleBackColor = true;
            txt_close.Click += txt_close_Click;
            // 
            // ffrm_search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 596);
            Controls.Add(groupBox1);
            Controls.Add(gp_result);
            Controls.Add(gp_search);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ffrm_search";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ffrm_search";
            gp_search.ResumeLayout(false);
            gp_search.PerformLayout();
            gp_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_results).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button txt_close;
        public GroupBox gp_search;
        public GroupBox gp_result;
        public DataGridView dgv_results;
        public TextBox txt_search;
    }
}