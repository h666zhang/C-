namespace HomeWork_012
{
    partial class frmTempCheck
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
            this.gboxPerson = new System.Windows.Forms.GroupBox();
            this.labName = new System.Windows.Forms.Label();
            this.labClass = new System.Windows.Forms.Label();
            this.labNumber = new System.Windows.Forms.Label();
            this.labDorm = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtDorm = new System.Windows.Forms.TextBox();
            this.gboxTemp = new System.Windows.Forms.GroupBox();
            this.labTemp = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.labC = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.labCheck = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.gboxPerson.SuspendLayout();
            this.gboxTemp.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxPerson
            // 
            this.gboxPerson.Controls.Add(this.txtDorm);
            this.gboxPerson.Controls.Add(this.txtNumber);
            this.gboxPerson.Controls.Add(this.txtClass);
            this.gboxPerson.Controls.Add(this.txtName);
            this.gboxPerson.Controls.Add(this.labNumber);
            this.gboxPerson.Controls.Add(this.labClass);
            this.gboxPerson.Controls.Add(this.labDorm);
            this.gboxPerson.Controls.Add(this.labName);
            this.gboxPerson.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gboxPerson.Location = new System.Drawing.Point(60, 36);
            this.gboxPerson.Name = "gboxPerson";
            this.gboxPerson.Size = new System.Drawing.Size(626, 295);
            this.gboxPerson.TabIndex = 0;
            this.gboxPerson.TabStop = false;
            this.gboxPerson.Text = "人员信息";
            this.gboxPerson.Enter += new System.EventHandler(this.gboxPerson_Enter);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(36, 66);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(110, 28);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓 名：";
            // 
            // labClass
            // 
            this.labClass.AutoSize = true;
            this.labClass.Location = new System.Drawing.Point(36, 118);
            this.labClass.Name = "labClass";
            this.labClass.Size = new System.Drawing.Size(124, 28);
            this.labClass.TabIndex = 1;
            this.labClass.Text = "班  级：";
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Location = new System.Drawing.Point(36, 170);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(124, 28);
            this.labNumber.TabIndex = 2;
            this.labNumber.Text = "学  号：";
            // 
            // labDorm
            // 
            this.labDorm.AutoSize = true;
            this.labDorm.Location = new System.Drawing.Point(36, 222);
            this.labDorm.Name = "labDorm";
            this.labDorm.Size = new System.Drawing.Size(124, 28);
            this.labDorm.TabIndex = 3;
            this.labDorm.Text = "宿舍号：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(187, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(375, 39);
            this.txtName.TabIndex = 4;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(187, 115);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(375, 39);
            this.txtClass.TabIndex = 5;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(187, 167);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(375, 39);
            this.txtNumber.TabIndex = 6;
            // 
            // txtDorm
            // 
            this.txtDorm.Location = new System.Drawing.Point(187, 219);
            this.txtDorm.Name = "txtDorm";
            this.txtDorm.Size = new System.Drawing.Size(375, 39);
            this.txtDorm.TabIndex = 7;
            // 
            // gboxTemp
            // 
            this.gboxTemp.Controls.Add(this.btnColor);
            this.gboxTemp.Controls.Add(this.labCheck);
            this.gboxTemp.Controls.Add(this.btnCheck);
            this.gboxTemp.Controls.Add(this.labC);
            this.gboxTemp.Controls.Add(this.txtTemp);
            this.gboxTemp.Controls.Add(this.labTemp);
            this.gboxTemp.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gboxTemp.Location = new System.Drawing.Point(60, 446);
            this.gboxTemp.Name = "gboxTemp";
            this.gboxTemp.Size = new System.Drawing.Size(626, 302);
            this.gboxTemp.TabIndex = 1;
            this.gboxTemp.TabStop = false;
            this.gboxTemp.Text = "体温信息";
            // 
            // labTemp
            // 
            this.labTemp.AutoSize = true;
            this.labTemp.Location = new System.Drawing.Point(6, 70);
            this.labTemp.Name = "labTemp";
            this.labTemp.Size = new System.Drawing.Size(152, 28);
            this.labTemp.TabIndex = 0;
            this.labTemp.Text = "体    温：";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(187, 70);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(289, 39);
            this.txtTemp.TabIndex = 1;
            // 
            // labC
            // 
            this.labC.AutoSize = true;
            this.labC.Location = new System.Drawing.Point(522, 70);
            this.labC.Name = "labC";
            this.labC.Size = new System.Drawing.Size(40, 28);
            this.labC.TabIndex = 2;
            this.labC.Text = "℃";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(215, 133);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(204, 51);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "检测";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // labCheck
            // 
            this.labCheck.AutoSize = true;
            this.labCheck.Location = new System.Drawing.Point(6, 216);
            this.labCheck.Name = "labCheck";
            this.labCheck.Size = new System.Drawing.Size(152, 28);
            this.labCheck.TabIndex = 4;
            this.labCheck.Text = "是否正常：";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Green;
            this.btnColor.Location = new System.Drawing.Point(266, 210);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(88, 41);
            this.btnColor.TabIndex = 5;
            this.btnColor.UseVisualStyleBackColor = false;
            // 
            // frmTempCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 841);
            this.Controls.Add(this.gboxTemp);
            this.Controls.Add(this.gboxPerson);
            this.Name = "frmTempCheck";
            this.Text = "人体体温采集软件";
            this.gboxPerson.ResumeLayout(false);
            this.gboxPerson.PerformLayout();
            this.gboxTemp.ResumeLayout(false);
            this.gboxTemp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxPerson;
        private System.Windows.Forms.Label labDorm;
        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.Label labClass;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtDorm;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gboxTemp;
        private System.Windows.Forms.Label labTemp;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label labCheck;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label labC;
        private System.Windows.Forms.TextBox txtTemp;
    }
}

