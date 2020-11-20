namespace CLCMilestone
{
    partial class NewNote
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
            this.button_Back = new System.Windows.Forms.Button();
            this.btn_SaveToCalendar = new System.Windows.Forms.Button();
            this.btn_Trash = new System.Windows.Forms.Button();
            this.txtbox_NotePad = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(12, 12);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(113, 23);
            this.button_Back.TabIndex = 0;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            // 
            // btn_SaveToCalendar
            // 
            this.btn_SaveToCalendar.Location = new System.Drawing.Point(301, 15);
            this.btn_SaveToCalendar.Name = "btn_SaveToCalendar";
            this.btn_SaveToCalendar.Size = new System.Drawing.Size(156, 23);
            this.btn_SaveToCalendar.TabIndex = 2;
            this.btn_SaveToCalendar.Text = "Save to Calendar";
            this.btn_SaveToCalendar.UseVisualStyleBackColor = true;
            this.btn_SaveToCalendar.Click += new System.EventHandler(this.btn_SaveToCalendar_Click);
            // 
            // btn_Trash
            // 
            this.btn_Trash.Location = new System.Drawing.Point(12, 553);
            this.btn_Trash.Name = "btn_Trash";
            this.btn_Trash.Size = new System.Drawing.Size(75, 23);
            this.btn_Trash.TabIndex = 3;
            this.btn_Trash.Text = "Trash";
            this.btn_Trash.UseVisualStyleBackColor = true;
            // 
            // txtbox_NotePad
            // 
            this.txtbox_NotePad.Location = new System.Drawing.Point(26, 44);
            this.txtbox_NotePad.Name = "txtbox_NotePad";
            this.txtbox_NotePad.Size = new System.Drawing.Size(495, 491);
            this.txtbox_NotePad.TabIndex = 4;
            this.txtbox_NotePad.Text = "";
            // 
            // NewNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 588);
            this.Controls.Add(this.txtbox_NotePad);
            this.Controls.Add(this.btn_Trash);
            this.Controls.Add(this.btn_SaveToCalendar);
            this.Controls.Add(this.button_Back);
            this.Name = "NewNote";
            this.Text = "NewNote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewNote_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button btn_SaveToCalendar;
        private System.Windows.Forms.Button btn_Trash;
        private System.Windows.Forms.RichTextBox txtbox_NotePad;
    }
}