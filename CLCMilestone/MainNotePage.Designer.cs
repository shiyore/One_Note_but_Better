namespace CLCMilestone
{
    partial class MainNotePage
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
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_Sort = new System.Windows.Forms.Label();
            this.btn_NewNote = new System.Windows.Forms.Button();
            this.notes_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(80, 32);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // lbl_Sort
            // 
            this.lbl_Sort.AutoSize = true;
            this.lbl_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sort.Location = new System.Drawing.Point(525, 17);
            this.lbl_Sort.Name = "lbl_Sort";
            this.lbl_Sort.Size = new System.Drawing.Size(43, 20);
            this.lbl_Sort.TabIndex = 2;
            this.lbl_Sort.Text = "Sort ";
            // 
            // btn_NewNote
            // 
            this.btn_NewNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_NewNote.Location = new System.Drawing.Point(558, 407);
            this.btn_NewNote.Name = "btn_NewNote";
            this.btn_NewNote.Size = new System.Drawing.Size(75, 23);
            this.btn_NewNote.TabIndex = 3;
            this.btn_NewNote.Text = "+ new Note";
            this.btn_NewNote.UseVisualStyleBackColor = true;
            this.btn_NewNote.Click += new System.EventHandler(this.btn_NewNote_Click);
            // 
            // notes_list
            // 
            this.notes_list.FormattingEnabled = true;
            this.notes_list.Location = new System.Drawing.Point(107, 53);
            this.notes_list.Name = "notes_list";
            this.notes_list.Size = new System.Drawing.Size(410, 355);
            this.notes_list.TabIndex = 5;
            // 
            // MainNotePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 442);
            this.Controls.Add(this.notes_list);
            this.Controls.Add(this.btn_NewNote);
            this.Controls.Add(this.lbl_Sort);
            this.Controls.Add(this.btn_back);
            this.Name = "MainNotePage";
            this.Text = "MainNotePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_Sort;
        private System.Windows.Forms.Button btn_NewNote;
        private System.Windows.Forms.ListBox notes_list;
    }
}