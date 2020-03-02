namespace school_reg
{
    partial class frmInstructorOperations
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
            this.btnAddInstructor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddTeaches = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddInstructor
            // 
            this.btnAddInstructor.Location = new System.Drawing.Point(12, 12);
            this.btnAddInstructor.Name = "btnAddInstructor";
            this.btnAddInstructor.Size = new System.Drawing.Size(151, 37);
            this.btnAddInstructor.TabIndex = 0;
            this.btnAddInstructor.Text = "Add Instructor";
            this.btnAddInstructor.UseVisualStyleBackColor = true;
            this.btnAddInstructor.Click += new System.EventHandler(this.btnAddInstructor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(799, 350);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnAddTeaches
            // 
            this.btnAddTeaches.Location = new System.Drawing.Point(169, 12);
            this.btnAddTeaches.Name = "btnAddTeaches";
            this.btnAddTeaches.Size = new System.Drawing.Size(237, 37);
            this.btnAddTeaches.TabIndex = 2;
            this.btnAddTeaches.Text = "Assign Instructor to Course";
            this.btnAddTeaches.UseVisualStyleBackColor = true;
            this.btnAddTeaches.Click += new System.EventHandler(this.btnAddTeaches_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(12, 65);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(107, 17);
            this.lblInformation.TabIndex = 3;
            this.lblInformation.Text = "INSTRUCTORS";
            // 
            // frmInstructorOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.btnAddTeaches);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddInstructor);
            this.Name = "frmInstructorOperations";
            this.Text = "InstructorOperations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInstructorOperations_FormClosed);
            this.Load += new System.EventHandler(this.frmInstructorOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddInstructor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddTeaches;
        private System.Windows.Forms.Label lblInformation;
    }
}