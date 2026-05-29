namespace HomeWork_013
{
    partial class frmSimpleCom
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
            this.gboxCom = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labComNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxCom = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gboxCom.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxCom
            // 
            this.gboxCom.Controls.Add(this.comboBox2);
            this.gboxCom.Controls.Add(this.cboxCom);
            this.gboxCom.Controls.Add(this.label2);
            this.gboxCom.Controls.Add(this.labComNumber);
            this.gboxCom.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gboxCom.Location = new System.Drawing.Point(54, 72);
            this.gboxCom.Name = "gboxCom";
            this.gboxCom.Size = new System.Drawing.Size(508, 574);
            this.gboxCom.TabIndex = 0;
            this.gboxCom.TabStop = false;
            this.gboxCom.Text = "串口能数设置";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(649, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(649, 413);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 233);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // labComNumber
            // 
            this.labComNumber.AutoSize = true;
            this.labComNumber.Location = new System.Drawing.Point(37, 87);
            this.labComNumber.Name = "labComNumber";
            this.labComNumber.Size = new System.Drawing.Size(124, 28);
            this.labComNumber.TabIndex = 0;
            this.labComNumber.Text = "串口号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboxCom
            // 
            this.cboxCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCom.FormattingEnabled = true;
            this.cboxCom.Location = new System.Drawing.Point(187, 87);
            this.cboxCom.Name = "cboxCom";
            this.cboxCom.Size = new System.Drawing.Size(249, 36);
            this.cboxCom.TabIndex = 2;
            this.cboxCom.SelectedIndexChanged += new System.EventHandler(this.cboxCom_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(187, 176);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(249, 36);
            this.comboBox2.TabIndex = 3;
            // 
            // frmSimpleCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 815);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gboxCom);
            this.Name = "frmSimpleCom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "简单串口通信软件";
            this.Load += new System.EventHandler(this.frmSimpleCom_Load);
            this.gboxCom.ResumeLayout(false);
            this.gboxCom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxCom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labComNumber;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cboxCom;
    }
}

