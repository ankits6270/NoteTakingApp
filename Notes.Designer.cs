namespace NoteTakingApp
{
    partial class Notes
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
            panel1 = new Panel();
            btnLogout = new Button();
            lblName = new Label();
            lblTitle = new Label();
            lblDescription = new Label();
            btnAddNotes = new Button();
            txtTitle = new TextBox();
            rtxtDescription = new RichTextBox();
            lstboxMyNotes = new ListBox();
            lblNotes = new Label();
            lblNotesTitle = new Label();
            rtxtNotes = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblName);
            panel1.Location = new Point(-2, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1190, 46);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonFace;
            btnLogout.Location = new Point(682, 15);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblName.Location = new Point(252, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(216, 22);
            lblName.TabIndex = 0;
            lblName.Text = "User name will show here";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(15, 77);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(29, 15);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(15, 123);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(73, 15);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description :";
            // 
            // btnAddNotes
            // 
            btnAddNotes.BackColor = Color.Lime;
            btnAddNotes.FlatStyle = FlatStyle.Popup;
            btnAddNotes.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNotes.Location = new Point(90, 301);
            btnAddNotes.Name = "btnAddNotes";
            btnAddNotes.Size = new Size(134, 32);
            btnAddNotes.TabIndex = 7;
            btnAddNotes.Text = "Add Notes";
            btnAddNotes.UseVisualStyleBackColor = false;
            btnAddNotes.Click += btnAddNotes_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(90, 74);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(177, 23);
            txtTitle.TabIndex = 5;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(90, 126);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(177, 148);
            rtxtDescription.TabIndex = 6;
            rtxtDescription.Text = "";
            // 
            // lstboxMyNotes
            // 
            lstboxMyNotes.FormattingEnabled = true;
            lstboxMyNotes.ItemHeight = 15;
            lstboxMyNotes.Location = new Point(346, 120);
            lstboxMyNotes.Name = "lstboxMyNotes";
            lstboxMyNotes.Size = new Size(140, 154);
            lstboxMyNotes.TabIndex = 8;
            lstboxMyNotes.SelectedIndexChanged += lstboxMyNotes_SelectedIndexChanged;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(344, 96);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(58, 15);
            lblNotes.TabIndex = 8;
            lblNotes.Text = "My Notes";
            // 
            // lblNotesTitle
            // 
            lblNotesTitle.AutoSize = true;
            lblNotesTitle.Location = new Point(578, 98);
            lblNotesTitle.Name = "lblNotesTitle";
            lblNotesTitle.Size = new Size(66, 15);
            lblNotesTitle.TabIndex = 10;
            lblNotesTitle.Text = "Note's Title";
            // 
            // rtxtNotes
            // 
            rtxtNotes.Location = new Point(578, 123);
            rtxtNotes.Name = "rtxtNotes";
            rtxtNotes.Size = new Size(177, 151);
            rtxtNotes.TabIndex = 9;
            rtxtNotes.Text = "    ";
            // 
            // Notes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 345);
            Controls.Add(rtxtNotes);
            Controls.Add(lblNotesTitle);
            Controls.Add(lblNotes);
            Controls.Add(lstboxMyNotes);
            Controls.Add(rtxtDescription);
            Controls.Add(txtTitle);
            Controls.Add(btnAddNotes);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            Name = "Notes";
            Text = "Notes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblName;
        private Label lblTitle;
        private Label lblDescription;
        private Button btnAddNotes;
        private TextBox txtTitle;
        private RichTextBox rtxtDescription;
        private ListBox lstboxMyNotes;
        private Label lblNotes;
        private Label lblNotesTitle;
        private RichTextBox rtxtNotes;
        private Button btnLogout;
    }
}