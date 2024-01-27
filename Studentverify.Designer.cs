using System;

namespace college_chairman_voting_system
{
    partial class Studentverify
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtverify = new System.Windows.Forms.TextBox();
            this.stu_nametxt = new System.Windows.Forms.Label();
            this.stu_idtxt = new System.Windows.Forms.Label();
            this.stunametxt = new System.Windows.Forms.TextBox();
            this.stuidtxt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student Verify";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Send OTP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Verify OTP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtemail
            // 
            this.txtemail.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtemail.Location = new System.Drawing.Point(162, 176);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(184, 20);
            this.txtemail.TabIndex = 13;
            this.txtemail.Tag = "";
            this.txtemail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtverify
            // 
            this.txtverify.Location = new System.Drawing.Point(162, 215);
            this.txtverify.Multiline = true;
            this.txtverify.Name = "txtverify";
            this.txtverify.Size = new System.Drawing.Size(184, 20);
            this.txtverify.TabIndex = 14;
            this.txtverify.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // stu_nametxt
            // 
            this.stu_nametxt.AutoSize = true;
            this.stu_nametxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stu_nametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stu_nametxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.stu_nametxt.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stu_nametxt.ImageKey = "(none)";
            this.stu_nametxt.Location = new System.Drawing.Point(213, 135);
            this.stu_nametxt.Name = "stu_nametxt";
            this.stu_nametxt.Size = new System.Drawing.Size(98, 18);
            this.stu_nametxt.TabIndex = 18;
            this.stu_nametxt.Text = "Student Name :";
            // 
            // stu_idtxt
            // 
            this.stu_idtxt.AutoSize = true;
            this.stu_idtxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stu_idtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stu_idtxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.stu_idtxt.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stu_idtxt.ImageKey = "(none)";
            this.stu_idtxt.Location = new System.Drawing.Point(183, 95);
            this.stu_idtxt.Name = "stu_idtxt";
            this.stu_idtxt.Size = new System.Drawing.Size(128, 18);
            this.stu_idtxt.TabIndex = 17;
            this.stu_idtxt.Text = "Student ID Card No :";
            // 
            // stunametxt
            // 
            this.stunametxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.stunametxt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stunametxt.Location = new System.Drawing.Point(347, 135);
            this.stunametxt.Name = "stunametxt";
            this.stunametxt.Size = new System.Drawing.Size(135, 21);
            this.stunametxt.TabIndex = 16;
            // 
            // stuidtxt
            // 
            this.stuidtxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.stuidtxt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuidtxt.Location = new System.Drawing.Point(347, 95);
            this.stuidtxt.Name = "stuidtxt";
            this.stuidtxt.Size = new System.Drawing.Size(135, 21);
            this.stuidtxt.TabIndex = 15;
            this.stuidtxt.TextChanged += new System.EventHandler(this.stuidtxt_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(304, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 33);
            this.button3.TabIndex = 19;
            this.button3.Text = "Next >";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.backbtn.FlatAppearance.BorderSize = 5;
            this.backbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backbtn.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.Location = new System.Drawing.Point(564, 21);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(72, 24);
            this.backbtn.TabIndex = 35;
            this.backbtn.Text = "< Back";
            this.backbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(44, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 36;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(676, 129);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Studentverify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::college_chairman_voting_system.Properties.Resources.desktop_wallpaper_abstract_login_page;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.stu_nametxt);
            this.Controls.Add(this.stu_idtxt);
            this.Controls.Add(this.stunametxt);
            this.Controls.Add(this.stuidtxt);
            this.Controls.Add(this.txtverify);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Studentverify";
            this.Text = "Studentverify";
            this.Load += new System.EventHandler(this.Studentverify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtverify;
        private System.Windows.Forms.Label stu_nametxt;
        private System.Windows.Forms.Label stu_idtxt;
        private System.Windows.Forms.TextBox stunametxt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox stuidtxt;
    }
}