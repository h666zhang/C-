namespace CA6_01
{
    partial class frmGraduateDatails
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labName = new System.Windows.Forms.Label();
            this.labNumber = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labDeptName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lbDeptName = new System.Windows.Forms.ListBox();
            this.cboxGraYear = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.butSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(77, 45);
            this.labName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(106, 24);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓  名：";
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Location = new System.Drawing.Point(77, 111);
            this.labNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(106, 24);
            this.labNumber.TabIndex = 1;
            this.labNumber.Text = "学  号：";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Location = new System.Drawing.Point(77, 177);
            this.labYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(130, 24);
            this.labYear.TabIndex = 2;
            this.labYear.Text = "毕业年份：";
            // 
            // labDeptName
            // 
            this.labDeptName.AutoSize = true;
            this.labDeptName.Location = new System.Drawing.Point(77, 243);
            this.labDeptName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDeptName.Name = "labDeptName";
            this.labDeptName.Size = new System.Drawing.Size(130, 24);
            this.labDeptName.TabIndex = 3;
            this.labDeptName.Text = "所在院系：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(379, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(435, 35);
            this.txtName.TabIndex = 4;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(379, 111);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(435, 35);
            this.txtNumber.TabIndex = 5;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // lbDeptName
            // 
            this.lbDeptName.FormattingEnabled = true;
            this.lbDeptName.ItemHeight = 24;
            this.lbDeptName.Location = new System.Drawing.Point(379, 243);
            this.lbDeptName.Name = "lbDeptName";
            this.lbDeptName.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbDeptName.Size = new System.Drawing.Size(435, 196);
            this.lbDeptName.TabIndex = 6;
            this.lbDeptName.SelectedIndexChanged += new System.EventHandler(this.lbDeptName_SelectedIndexChanged);
            // 
            // cboxGraYear
            // 
            this.cboxGraYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGraYear.FormattingEnabled = true;
            this.cboxGraYear.Location = new System.Drawing.Point(379, 177);
            this.cboxGraYear.Name = "cboxGraYear";
            this.cboxGraYear.Size = new System.Drawing.Size(435, 32);
            this.cboxGraYear.TabIndex = 7;
            this.cboxGraYear.SelectedIndexChanged += new System.EventHandler(this.cboxGraYear_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(379, 508);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 33);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "添加（&A）";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(532, 508);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(129, 33);
            this.butCancel.TabIndex = 9;
            this.butCancel.Text = "取消（&C）";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butSubmit
            // 
            this.butSubmit.Location = new System.Drawing.Point(685, 508);
            this.butSubmit.Name = "butSubmit";
            this.butSubmit.Size = new System.Drawing.Size(129, 33);
            this.butSubmit.TabIndex = 10;
            this.butSubmit.Text = "提交（&S）";
            this.butSubmit.UseVisualStyleBackColor = true;
            this.butSubmit.Click += new System.EventHandler(this.butSubmit_Click);
            // 
            // frmGraduateDatails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 600);
            this.Controls.Add(this.butSubmit);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboxGraYear);
            this.Controls.Add(this.lbDeptName);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labDeptName);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labNumber);
            this.Controls.Add(this.labName);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGraduateDatails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "毕业生信息采集系统";
            this.Load += new System.EventHandler(this.frmGraduateDatails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labDeptName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.ListBox lbDeptName;
        private System.Windows.Forms.ComboBox cboxGraYear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butSubmit;
    }
}

