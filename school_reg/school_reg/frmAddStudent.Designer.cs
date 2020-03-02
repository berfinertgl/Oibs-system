namespace school_reg
{
    partial class frmAddStudent
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.txtIDs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(234, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Department :";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(393, 224);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(228, 34);
            this.cmbDepartment.TabIndex = 17;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddStudent.Location = new System.Drawing.Point(391, 402);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(231, 96);
            this.btnAddStudent.TabIndex = 16;
            this.btnAddStudent.Text = "ADD STUDENT";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddInstructor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(240, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total credit :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(286, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name :";
            // 
            // txtTot
            // 
            this.txtTot.Location = new System.Drawing.Point(393, 290);
            this.txtTot.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTot.Name = "txtTot";
            this.txtTot.Size = new System.Drawing.Size(228, 34);
            this.txtTot.TabIndex = 13;
            // 
            // txtNames
            // 
            this.txtNames.Location = new System.Drawing.Point(394, 164);
            this.txtNames.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(228, 34);
            this.txtNames.TabIndex = 12;
            // 
            // txtIDs
            // 
            this.txtIDs.Location = new System.Drawing.Point(394, 105);
            this.txtIDs.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtIDs.Name = "txtIDs";
            this.txtIDs.Size = new System.Drawing.Size(227, 34);
            this.txtIDs.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(317, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID :";
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(972, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTot);
            this.Controls.Add(this.txtNames);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmAddStudent";
            this.Text = "ADD STUDENT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddStudent_FormClosed);
            this.Load += new System.EventHandler(this.frmAddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.TextBox txtIDs;
        private System.Windows.Forms.Label label1;
    }
}