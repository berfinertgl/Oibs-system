namespace school_reg
{
    partial class frmAddCourse
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
            this.components = new System.ComponentModel.Container();
            this.txtCId = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtTitleName = new System.Windows.Forms.TextBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.lblCourseId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.cmdDeptName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCId
            // 
            this.txtCId.Location = new System.Drawing.Point(386, 90);
            this.txtCId.Name = "txtCId";
            this.txtCId.Size = new System.Drawing.Size(182, 22);
            this.txtCId.TabIndex = 0;
            this.txtCId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtTitleName
            // 
            this.txtTitleName.Location = new System.Drawing.Point(386, 133);
            this.txtTitleName.Name = "txtTitleName";
            this.txtTitleName.Size = new System.Drawing.Size(182, 22);
            this.txtTitleName.TabIndex = 2;
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(386, 233);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(182, 22);
            this.txtCredit.TabIndex = 4;
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCourseId.Location = new System.Drawing.Point(174, 88);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(158, 27);
            this.lblCourseId.TabIndex = 5;
            this.lblCourseId.Text = "COURSE ID :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(243, 133);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(89, 27);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "TITLE :";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartment.Location = new System.Drawing.Point(163, 182);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(169, 27);
            this.lblDepartment.TabIndex = 7;
            this.lblDepartment.Text = "DEPT_NAME :";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCredits.Location = new System.Drawing.Point(203, 233);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(129, 27);
            this.lblCredits.TabIndex = 8;
            this.lblCredits.Text = "CREDITS :";
            // 
            // cmdDeptName
            // 
            this.cmdDeptName.FormattingEnabled = true;
            this.cmdDeptName.Location = new System.Drawing.Point(386, 185);
            this.cmdDeptName.Name = "cmdDeptName";
            this.cmdDeptName.Size = new System.Drawing.Size(182, 24);
            this.cmdDeptName.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(335, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "ADD COURSE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdDeptName);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCourseId);
            this.Controls.Add(this.txtCredit);
            this.Controls.Add(this.txtTitleName);
            this.Controls.Add(this.txtCId);
            this.Name = "frmAddCourse";
            this.Text = "frmAddCourse";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddCourse_FormClosed);
            this.Load += new System.EventHandler(this.frmAddCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtTitleName;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Label lblCourseId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.ComboBox cmdDeptName;
        private System.Windows.Forms.Button button1;
    }
}