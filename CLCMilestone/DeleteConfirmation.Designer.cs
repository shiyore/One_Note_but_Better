namespace CLCMilestone
{
    partial class DeleteConfirmation
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
            this.lbl_QuestionForm = new System.Windows.Forms.Label();
            this.btn_Yes = new System.Windows.Forms.Button();
            this.btn_No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_QuestionForm
            // 
            this.lbl_QuestionForm.AutoSize = true;
            this.lbl_QuestionForm.Location = new System.Drawing.Point(93, 59);
            this.lbl_QuestionForm.Name = "lbl_QuestionForm";
            this.lbl_QuestionForm.Size = new System.Drawing.Size(160, 13);
            this.lbl_QuestionForm.TabIndex = 0;
            this.lbl_QuestionForm.Text = "Are You Sure you want to delete";
            // 
            // btn_Yes
            // 
            this.btn_Yes.Location = new System.Drawing.Point(42, 104);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(75, 23);
            this.btn_Yes.TabIndex = 1;
            this.btn_Yes.Text = "Yes";
            this.btn_Yes.UseVisualStyleBackColor = true;
            // 
            // btn_No
            // 
            this.btn_No.Location = new System.Drawing.Point(198, 104);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(75, 23);
            this.btn_No.TabIndex = 2;
            this.btn_No.Text = "No";
            this.btn_No.UseVisualStyleBackColor = true;
            // 
            // DeleteConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 208);
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.btn_Yes);
            this.Controls.Add(this.lbl_QuestionForm);
            this.Name = "DeleteConfirmation";
            this.Text = "DeleteConfirmation";
            this.Load += new System.EventHandler(this.DeleteConfirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_QuestionForm;
        private System.Windows.Forms.Button btn_Yes;
        private System.Windows.Forms.Button btn_No;
    }
}