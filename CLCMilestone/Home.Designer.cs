namespace CLCMilestone
{
    partial class Home
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
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.btn_calandar = new System.Windows.Forms.Button();
            this.btn_calendar = new System.Windows.Forms.Button();
            this.btn_NewNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.Location = new System.Drawing.Point(208, 31);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(186, 34);
            this.lbl_Welcome.TabIndex = 0;
            this.lbl_Welcome.Text = "Welcome User";
            this.lbl_Welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_calandar
            // 
            this.btn_calandar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_calandar.Location = new System.Drawing.Point(348, 127);
            this.btn_calandar.Name = "btn_calandar";
            this.btn_calandar.Size = new System.Drawing.Size(103, 104);
            this.btn_calandar.TabIndex = 1;
            this.btn_calandar.Text = "View Notes";
            this.btn_calandar.UseVisualStyleBackColor = false;
            this.btn_calandar.Click += new System.EventHandler(this.btn_calandar_Click);
            // 
            // btn_calendar
            // 
            this.btn_calendar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_calendar.Location = new System.Drawing.Point(136, 127);
            this.btn_calendar.Name = "btn_calendar";
            this.btn_calendar.Size = new System.Drawing.Size(99, 104);
            this.btn_calendar.TabIndex = 2;
            this.btn_calendar.Text = "Calender";
            this.btn_calendar.UseVisualStyleBackColor = false;
            this.btn_calendar.Click += new System.EventHandler(this.btn_calendar_Click);
            // 
            // btn_NewNote
            // 
            this.btn_NewNote.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_NewNote.Location = new System.Drawing.Point(511, 312);
            this.btn_NewNote.Name = "btn_NewNote";
            this.btn_NewNote.Size = new System.Drawing.Size(80, 64);
            this.btn_NewNote.TabIndex = 3;
            this.btn_NewNote.Text = "+ Sign";
            this.btn_NewNote.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 384);
            this.Controls.Add(this.btn_NewNote);
            this.Controls.Add(this.btn_calendar);
            this.Controls.Add(this.btn_calandar);
            this.Controls.Add(this.lbl_Welcome);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Button btn_calandar;
        private System.Windows.Forms.Button btn_calendar;
        private System.Windows.Forms.Button btn_NewNote;
    }
}

