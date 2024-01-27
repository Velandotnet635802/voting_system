namespace college_chairman_voting_system
{
    partial class VotingPage
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
            this.Submitbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.studentidtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vote_fortxt = new System.Windows.Forms.ComboBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Submitbtn
            // 
            this.Submitbtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Submitbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Submitbtn.FlatAppearance.BorderSize = 5;
            this.Submitbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Submitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Submitbtn.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submitbtn.ForeColor = System.Drawing.Color.Black;
            this.Submitbtn.Location = new System.Drawing.Point(306, 301);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(72, 24);
            this.Submitbtn.TabIndex = 13;
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.UseVisualStyleBackColor = false;
            this.Submitbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.ImageKey = "(none)";
            this.label2.Location = new System.Drawing.Point(176, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Student Id No :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // studentidtxt
            // 
            this.studentidtxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.studentidtxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.studentidtxt.Location = new System.Drawing.Point(347, 163);
            this.studentidtxt.Name = "studentidtxt";
            this.studentidtxt.Size = new System.Drawing.Size(152, 20);
            this.studentidtxt.TabIndex = 9;
            this.studentidtxt.TextChanged += new System.EventHandler(this.useridtxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Voting Booth ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.ImageKey = "(none)";
            this.label4.Location = new System.Drawing.Point(219, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Vote For :";
            // 
            // vote_fortxt
            // 
            this.vote_fortxt.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vote_fortxt.FormattingEnabled = true;
            this.vote_fortxt.Items.AddRange(new object[] {
            "Team \"A\"",
            "Team \"B\""});
            this.vote_fortxt.Location = new System.Drawing.Point(347, 221);
            this.vote_fortxt.Name = "vote_fortxt";
            this.vote_fortxt.Size = new System.Drawing.Size(151, 27);
            this.vote_fortxt.TabIndex = 16;
            this.vote_fortxt.Text = "Click Here ";
            this.vote_fortxt.SelectedIndexChanged += new System.EventHandler(this.vote_fortxt_SelectedIndexChanged);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.backbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.backbtn.FlatAppearance.BorderSize = 5;
            this.backbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backbtn.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.Window;
            this.backbtn.Location = new System.Drawing.Point(455, 301);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(72, 24);
            this.backbtn.TabIndex = 32;
            this.backbtn.Text = "< Back";
            this.backbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // VotingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::college_chairman_voting_system.Properties.Resources.istockphoto_884243522_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(726, 393);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.vote_fortxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentidtxt);
            this.Controls.Add(this.label1);
            this.Name = "VotingPage";
            this.Text = "VotingPage";
            this.Load += new System.EventHandler(this.VotingPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Submitbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox vote_fortxt;
        public System.Windows.Forms.TextBox studentidtxt;
        private System.Windows.Forms.Button backbtn;
    }
}