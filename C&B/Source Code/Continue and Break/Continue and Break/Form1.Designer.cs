namespace Continue_and_Break
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_normal = new System.Windows.Forms.Button();
            this.btn_break = new System.Windows.Forms.Button();
            this.btn_continue = new System.Windows.Forms.Button();
            this.textBoxNormal = new System.Windows.Forms.TextBox();
            this.textBoxBreak = new System.Windows.Forms.TextBox();
            this.textBoxContinue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxAction = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.set1 = new System.Windows.Forms.Button();
            this.set2 = new System.Windows.Forms.Button();
            this.set3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_normal
            // 
            this.btn_normal.Location = new System.Drawing.Point(46, 203);
            this.btn_normal.Name = "btn_normal";
            this.btn_normal.Size = new System.Drawing.Size(101, 23);
            this.btn_normal.TabIndex = 0;
            this.btn_normal.Text = "Normal";
            this.btn_normal.UseVisualStyleBackColor = true;
            this.btn_normal.Click += new System.EventHandler(this.btn_normal_Click);
            // 
            // btn_break
            // 
            this.btn_break.Location = new System.Drawing.Point(46, 267);
            this.btn_break.Name = "btn_break";
            this.btn_break.Size = new System.Drawing.Size(101, 23);
            this.btn_break.TabIndex = 1;
            this.btn_break.Text = "Break at 2";
            this.btn_break.UseVisualStyleBackColor = true;
            this.btn_break.Click += new System.EventHandler(this.btn_break_Click);
            // 
            // btn_continue
            // 
            this.btn_continue.Location = new System.Drawing.Point(46, 330);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(101, 23);
            this.btn_continue.TabIndex = 2;
            this.btn_continue.Text = "Continue at 2";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // textBoxNormal
            // 
            this.textBoxNormal.Location = new System.Drawing.Point(46, 232);
            this.textBoxNormal.Name = "textBoxNormal";
            this.textBoxNormal.Size = new System.Drawing.Size(392, 20);
            this.textBoxNormal.TabIndex = 3;
            this.textBoxNormal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBreak
            // 
            this.textBoxBreak.Location = new System.Drawing.Point(46, 296);
            this.textBoxBreak.Name = "textBoxBreak";
            this.textBoxBreak.Size = new System.Drawing.Size(392, 20);
            this.textBoxBreak.TabIndex = 4;
            this.textBoxBreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxContinue
            // 
            this.textBoxContinue.Location = new System.Drawing.Point(46, 359);
            this.textBoxContinue.Name = "textBoxContinue";
            this.textBoxContinue.Size = new System.Drawing.Size(392, 20);
            this.textBoxContinue.TabIndex = 5;
            this.textBoxContinue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Let\'s count in C#!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Insert the number to count from:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Insert the number to count to:";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(364, 61);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(46, 20);
            this.textBoxFrom.TabIndex = 9;
            this.textBoxFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(50, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "(The range of numbers is from 0  to 100, max amount of displayed numbers is 20)";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(364, 91);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(46, 20);
            this.textBoxTo.TabIndex = 11;
            this.textBoxTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAction
            // 
            this.textBoxAction.Location = new System.Drawing.Point(364, 122);
            this.textBoxAction.Name = "textBoxAction";
            this.textBoxAction.Size = new System.Drawing.Size(46, 20);
            this.textBoxAction.TabIndex = 13;
            this.textBoxAction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Insert the number to perform action at:";
            // 
            // set1
            // 
            this.set1.Location = new System.Drawing.Point(416, 59);
            this.set1.Name = "set1";
            this.set1.Size = new System.Drawing.Size(44, 23);
            this.set1.TabIndex = 14;
            this.set1.Text = "Set";
            this.set1.UseVisualStyleBackColor = true;
            this.set1.Click += new System.EventHandler(this.set1_Click);
            // 
            // set2
            // 
            this.set2.Location = new System.Drawing.Point(416, 89);
            this.set2.Name = "set2";
            this.set2.Size = new System.Drawing.Size(44, 23);
            this.set2.TabIndex = 15;
            this.set2.Text = "Set";
            this.set2.UseVisualStyleBackColor = true;
            this.set2.Click += new System.EventHandler(this.set2_Click);
            // 
            // set3
            // 
            this.set3.Location = new System.Drawing.Point(416, 118);
            this.set3.Name = "set3";
            this.set3.Size = new System.Drawing.Size(44, 23);
            this.set3.TabIndex = 16;
            this.set3.Text = "Set";
            this.set3.UseVisualStyleBackColor = true;
            this.set3.Click += new System.EventHandler(this.set3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(187, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "(A list of numbers from the number #1 till number #2)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(158, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "(Exits the \"for\" statement when the number #3 is reached)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(174, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "(Skips all the remaining code in a loop if #3 is reached)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(332, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "(#1)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(332, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "(#2)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(332, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "(#3)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(379, 390);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "made by";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(422, 390);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 13);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Khud0";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(213, 390);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(59, 13);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "C# Tutorial";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Gray;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(50, 390);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 412);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.set3);
            this.Controls.Add(this.set2);
            this.Controls.Add(this.set1);
            this.Controls.Add(this.textBoxAction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxContinue);
            this.Controls.Add(this.textBoxBreak);
            this.Controls.Add(this.textBoxNormal);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.btn_break);
            this.Controls.Add(this.btn_normal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statements \"break;\" and \"continue;\" on a \"for\" loop example.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_normal;
        private System.Windows.Forms.Button btn_break;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.TextBox textBoxNormal;
        private System.Windows.Forms.TextBox textBoxBreak;
        private System.Windows.Forms.TextBox textBoxContinue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxAction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button set1;
        private System.Windows.Forms.Button set2;
        private System.Windows.Forms.Button set3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label13;
    }
}

