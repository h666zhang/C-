namespace CA6_02
{
    partial class frmPen
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
            this.gboxBasicinform = new System.Windows.Forms.GroupBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labAge = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.gboxJob = new System.Windows.Forms.GroupBox();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.gbox11 = new System.Windows.Forms.GroupBox();
            this.chbSport = new System.Windows.Forms.CheckBox();
            this.chbRead = new System.Windows.Forms.CheckBox();
            this.gboxBasicinform.SuspendLayout();
            this.gboxJob.SuspendLayout();
            this.gbox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxBasicinform
            // 
            this.gboxBasicinform.Controls.Add(this.txtAge);
            this.gboxBasicinform.Controls.Add(this.txtName);
            this.gboxBasicinform.Controls.Add(this.labAge);
            this.gboxBasicinform.Controls.Add(this.labName);
            this.gboxBasicinform.Cursor = System.Windows.Forms.Cursors.Default;
            this.gboxBasicinform.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gboxBasicinform.Location = new System.Drawing.Point(57, 33);
            this.gboxBasicinform.Name = "gboxBasicinform";
            this.gboxBasicinform.Size = new System.Drawing.Size(630, 271);
            this.gboxBasicinform.TabIndex = 0;
            this.gboxBasicinform.TabStop = false;
            this.gboxBasicinform.Text = "基本信息";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(196, 162);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(308, 39);
            this.txtAge.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(196, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(308, 39);
            this.txtName.TabIndex = 2;
            // 
            // labAge
            // 
            this.labAge.AutoSize = true;
            this.labAge.Location = new System.Drawing.Point(52, 162);
            this.labAge.Name = "labAge";
            this.labAge.Size = new System.Drawing.Size(68, 28);
            this.labAge.TabIndex = 1;
            this.labAge.Text = "年龄";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(52, 82);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(68, 28);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名";
            // 
            // gboxJob
            // 
            this.gboxJob.Controls.Add(this.rbtnNo);
            this.gboxJob.Controls.Add(this.rbtnYes);
            this.gboxJob.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gboxJob.Location = new System.Drawing.Point(57, 335);
            this.gboxJob.Name = "gboxJob";
            this.gboxJob.Size = new System.Drawing.Size(630, 230);
            this.gboxJob.TabIndex = 1;
            this.gboxJob.TabStop = false;
            this.gboxJob.Text = "就业情况";
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(387, 104);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(121, 32);
            this.rbtnNo.TabIndex = 1;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "未就业";
            this.rbtnNo.UseVisualStyleBackColor = true;
            this.rbtnNo.Click += new System.EventHandler(this.rbtnNo_Click);
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Location = new System.Drawing.Point(107, 99);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(121, 32);
            this.rbtnYes.TabIndex = 0;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "已就业";
            this.rbtnYes.UseVisualStyleBackColor = true;
            this.rbtnYes.CheckedChanged += new System.EventHandler(this.rbtnYes_CheckedChanged);
            // 
            // gbox11
            // 
            this.gbox11.Controls.Add(this.chbSport);
            this.gbox11.Controls.Add(this.chbRead);
            this.gbox11.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbox11.Location = new System.Drawing.Point(57, 599);
            this.gbox11.Name = "gbox11";
            this.gbox11.Size = new System.Drawing.Size(629, 168);
            this.gbox11.TabIndex = 2;
            this.gbox11.TabStop = false;
            this.gbox11.Text = "兴趣爱好";
            // 
            // chbSport
            // 
            this.chbSport.AutoSize = true;
            this.chbSport.Location = new System.Drawing.Point(387, 79);
            this.chbSport.Name = "chbSport";
            this.chbSport.Size = new System.Drawing.Size(94, 32);
            this.chbSport.TabIndex = 1;
            this.chbSport.Text = "运动";
            this.chbSport.UseVisualStyleBackColor = true;
            this.chbSport.CheckedChanged += new System.EventHandler(this.chbSport_Click);
            // 
            // chbRead
            // 
            this.chbRead.AutoSize = true;
            this.chbRead.Location = new System.Drawing.Point(107, 79);
            this.chbRead.Name = "chbRead";
            this.chbRead.Size = new System.Drawing.Size(94, 32);
            this.chbRead.TabIndex = 0;
            this.chbRead.Text = "阅读";
            this.chbRead.UseVisualStyleBackColor = true;
            this.chbRead.CheckedChanged += new System.EventHandler(this.chbRead_CheckedChanged);
            // 
            // frmPen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 808);
            this.Controls.Add(this.gbox11);
            this.Controls.Add(this.gboxJob);
            this.Controls.Add(this.gboxBasicinform);
            this.Name = "frmPen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "个人信息登记表";
            this.Load += new System.EventHandler(this.frm_Load);
            this.gboxBasicinform.ResumeLayout(false);
            this.gboxBasicinform.PerformLayout();
            this.gboxJob.ResumeLayout(false);
            this.gboxJob.PerformLayout();
            this.gbox11.ResumeLayout(false);
            this.gbox11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxBasicinform;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labAge;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.GroupBox gboxJob;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.GroupBox gbox11;
        private System.Windows.Forms.CheckBox chbSport;
        private System.Windows.Forms.CheckBox chbRead;
    }
}

