namespace IE322_project_23
{
    partial class frmCheck
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
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCoffee = new System.Windows.Forms.CheckBox();
            this.chkDonut = new System.Windows.Forms.CheckBox();
            this.chkBrownie = new System.Windows.Forms.CheckBox();
            this.btnShowSelected = new System.Windows.Forms.Button();
            this.GrpQuestion = new System.Windows.Forms.GroupBox();
            this.LblQuestion = new System.Windows.Forms.Label();
            this.ChkCsharp = new System.Windows.Forms.CheckBox();
            this.checkJava = new System.Windows.Forms.CheckBox();
            this.checkPython = new System.Windows.Forms.CheckBox();
            this.checkJavascript = new System.Windows.Forms.CheckBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GrpQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(638, 400);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 38);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBrownie);
            this.groupBox1.Controls.Add(this.chkDonut);
            this.groupBox1.Controls.Add(this.chkCoffee);
            this.groupBox1.Location = new System.Drawing.Point(40, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // chkCoffee
            // 
            this.chkCoffee.AutoSize = true;
            this.chkCoffee.Location = new System.Drawing.Point(23, 41);
            this.chkCoffee.Name = "chkCoffee";
            this.chkCoffee.Size = new System.Drawing.Size(69, 21);
            this.chkCoffee.TabIndex = 0;
            this.chkCoffee.Text = "Coffee";
            this.chkCoffee.UseVisualStyleBackColor = true;
            // 
            // chkDonut
            // 
            this.chkDonut.AutoSize = true;
            this.chkDonut.Location = new System.Drawing.Point(23, 79);
            this.chkDonut.Name = "chkDonut";
            this.chkDonut.Size = new System.Drawing.Size(69, 21);
            this.chkDonut.TabIndex = 1;
            this.chkDonut.Text = "Donut";
            this.chkDonut.UseVisualStyleBackColor = true;
            // 
            // chkBrownie
            // 
            this.chkBrownie.AutoSize = true;
            this.chkBrownie.Location = new System.Drawing.Point(23, 117);
            this.chkBrownie.Name = "chkBrownie";
            this.chkBrownie.Size = new System.Drawing.Size(78, 21);
            this.chkBrownie.TabIndex = 2;
            this.chkBrownie.Text = "Brownie";
            this.chkBrownie.UseVisualStyleBackColor = true;
            // 
            // btnShowSelected
            // 
            this.btnShowSelected.Location = new System.Drawing.Point(81, 274);
            this.btnShowSelected.Name = "btnShowSelected";
            this.btnShowSelected.Size = new System.Drawing.Size(98, 38);
            this.btnShowSelected.TabIndex = 2;
            this.btnShowSelected.Text = "Show";
            this.btnShowSelected.UseVisualStyleBackColor = true;
            this.btnShowSelected.Click += new System.EventHandler(this.btnShowSelected_Click);
            // 
            // GrpQuestion
            // 
            this.GrpQuestion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrpQuestion.Controls.Add(this.BtnSubmit);
            this.GrpQuestion.Controls.Add(this.checkJavascript);
            this.GrpQuestion.Controls.Add(this.checkPython);
            this.GrpQuestion.Controls.Add(this.checkJava);
            this.GrpQuestion.Controls.Add(this.ChkCsharp);
            this.GrpQuestion.Controls.Add(this.LblQuestion);
            this.GrpQuestion.Location = new System.Drawing.Point(270, 94);
            this.GrpQuestion.Name = "GrpQuestion";
            this.GrpQuestion.Size = new System.Drawing.Size(500, 290);
            this.GrpQuestion.TabIndex = 3;
            this.GrpQuestion.TabStop = false;
            this.GrpQuestion.Text = "Question";
            // 
            // LblQuestion
            // 
            this.LblQuestion.AutoSize = true;
            this.LblQuestion.Location = new System.Drawing.Point(41, 41);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(429, 17);
            this.LblQuestion.TabIndex = 0;
            this.LblQuestion.Text = "In which programming languages, you can solve any given problem?";
            // 
            // ChkCsharp
            // 
            this.ChkCsharp.AutoSize = true;
            this.ChkCsharp.Location = new System.Drawing.Point(44, 79);
            this.ChkCsharp.Name = "ChkCsharp";
            this.ChkCsharp.Size = new System.Drawing.Size(49, 21);
            this.ChkCsharp.TabIndex = 1;
            this.ChkCsharp.Text = "C#";
            this.ChkCsharp.UseVisualStyleBackColor = true;
            // 
            // checkJava
            // 
            this.checkJava.AutoSize = true;
            this.checkJava.Location = new System.Drawing.Point(44, 160);
            this.checkJava.Name = "checkJava";
            this.checkJava.Size = new System.Drawing.Size(58, 21);
            this.checkJava.TabIndex = 2;
            this.checkJava.Text = "Java";
            this.checkJava.UseVisualStyleBackColor = true;
            // 
            // checkPython
            // 
            this.checkPython.AutoSize = true;
            this.checkPython.Location = new System.Drawing.Point(44, 117);
            this.checkPython.Name = "checkPython";
            this.checkPython.Size = new System.Drawing.Size(75, 21);
            this.checkPython.TabIndex = 3;
            this.checkPython.Text = "Python";
            this.checkPython.UseVisualStyleBackColor = true;
            // 
            // checkJavascript
            // 
            this.checkJavascript.AutoSize = true;
            this.checkJavascript.Location = new System.Drawing.Point(44, 197);
            this.checkJavascript.Name = "checkJavascript";
            this.checkJavascript.Size = new System.Drawing.Size(91, 21);
            this.checkJavascript.TabIndex = 4;
            this.checkJavascript.Text = "Javascript";
            this.checkJavascript.UseVisualStyleBackColor = true;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(215, 233);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(98, 38);
            this.BtnSubmit.TabIndex = 4;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GrpQuestion);
            this.Controls.Add(this.btnShowSelected);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Name = "frmCheck";
            this.Text = "CheckBox Form";
            this.Load += new System.EventHandler(this.frmCheck_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GrpQuestion.ResumeLayout(false);
            this.GrpQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBrownie;
        private System.Windows.Forms.CheckBox chkDonut;
        private System.Windows.Forms.CheckBox chkCoffee;
        private System.Windows.Forms.Button btnShowSelected;
        private System.Windows.Forms.GroupBox GrpQuestion;
        private System.Windows.Forms.CheckBox checkJavascript;
        private System.Windows.Forms.CheckBox checkPython;
        private System.Windows.Forms.CheckBox checkJava;
        private System.Windows.Forms.CheckBox ChkCsharp;
        private System.Windows.Forms.Label LblQuestion;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button button1;
    }
}