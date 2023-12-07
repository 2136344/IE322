namespace IE322_project_23
{
    partial class frmRadio
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
            this.btnReset = new System.Windows.Forms.Button();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rdoGreen = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.rdoYellow = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.rdoYellow2 = new System.Windows.Forms.RadioButton();
            this.rdoBlue2 = new System.Windows.Forms.RadioButton();
            this.rdoGreen2 = new System.Windows.Forms.RadioButton();
            this.rdoRed2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(105, 51);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(308, 44);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(80, 169);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(53, 21);
            this.rdoRed.TabIndex = 1;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "Red";
            this.rdoRed.UseVisualStyleBackColor = true;
            this.rdoRed.CheckedChanged += new System.EventHandler(this.rdoRed_CheckedChanged);
            // 
            // rdoGreen
            // 
            this.rdoGreen.AutoSize = true;
            this.rdoGreen.Location = new System.Drawing.Point(80, 205);
            this.rdoGreen.Name = "rdoGreen";
            this.rdoGreen.Size = new System.Drawing.Size(65, 21);
            this.rdoGreen.TabIndex = 2;
            this.rdoGreen.TabStop = true;
            this.rdoGreen.Text = "Green";
            this.rdoGreen.UseVisualStyleBackColor = true;
            this.rdoGreen.CheckedChanged += new System.EventHandler(this.rdoGreen_CheckedChanged);
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Location = new System.Drawing.Point(80, 241);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(54, 21);
            this.rdoBlue.TabIndex = 3;
            this.rdoBlue.TabStop = true;
            this.rdoBlue.Text = "Blue";
            this.rdoBlue.UseVisualStyleBackColor = true;
            this.rdoBlue.CheckedChanged += new System.EventHandler(this.rdoBlue_CheckedChanged);
            // 
            // rdoYellow
            // 
            this.rdoYellow.AutoSize = true;
            this.rdoYellow.Location = new System.Drawing.Point(80, 278);
            this.rdoYellow.Name = "rdoYellow";
            this.rdoYellow.Size = new System.Drawing.Size(66, 21);
            this.rdoYellow.TabIndex = 4;
            this.rdoYellow.TabStop = true;
            this.rdoYellow.Text = "Yellow";
            this.rdoYellow.UseVisualStyleBackColor = true;
            this.rdoYellow.CheckedChanged += new System.EventHandler(this.rdoYellow_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoYellow2);
            this.groupBox1.Controls.Add(this.rdoBlue2);
            this.groupBox1.Controls.Add(this.rdoGreen2);
            this.groupBox1.Controls.Add(this.rdoRed2);
            this.groupBox1.Location = new System.Drawing.Point(256, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 221);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grouped Radio Buttons";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(352, 387);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 33);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rdoYellow2
            // 
            this.rdoYellow2.AutoSize = true;
            this.rdoYellow2.Location = new System.Drawing.Point(30, 157);
            this.rdoYellow2.Name = "rdoYellow2";
            this.rdoYellow2.Size = new System.Drawing.Size(66, 21);
            this.rdoYellow2.TabIndex = 8;
            this.rdoYellow2.TabStop = true;
            this.rdoYellow2.Text = "Yellow";
            this.rdoYellow2.UseVisualStyleBackColor = true;
            this.rdoYellow2.CheckedChanged += new System.EventHandler(this.rdoYellow2_CheckedChanged);
            // 
            // rdoBlue2
            // 
            this.rdoBlue2.AutoSize = true;
            this.rdoBlue2.Location = new System.Drawing.Point(30, 120);
            this.rdoBlue2.Name = "rdoBlue2";
            this.rdoBlue2.Size = new System.Drawing.Size(54, 21);
            this.rdoBlue2.TabIndex = 7;
            this.rdoBlue2.TabStop = true;
            this.rdoBlue2.Text = "Blue";
            this.rdoBlue2.UseVisualStyleBackColor = true;
            this.rdoBlue2.CheckedChanged += new System.EventHandler(this.rdoBlue2_CheckedChanged);
            // 
            // rdoGreen2
            // 
            this.rdoGreen2.AutoSize = true;
            this.rdoGreen2.Location = new System.Drawing.Point(30, 84);
            this.rdoGreen2.Name = "rdoGreen2";
            this.rdoGreen2.Size = new System.Drawing.Size(65, 21);
            this.rdoGreen2.TabIndex = 6;
            this.rdoGreen2.TabStop = true;
            this.rdoGreen2.Text = "Green";
            this.rdoGreen2.UseVisualStyleBackColor = true;
            this.rdoGreen2.CheckedChanged += new System.EventHandler(this.rdoGreen2_CheckedChanged);
            // 
            // rdoRed2
            // 
            this.rdoRed2.AutoSize = true;
            this.rdoRed2.Location = new System.Drawing.Point(30, 48);
            this.rdoRed2.Name = "rdoRed2";
            this.rdoRed2.Size = new System.Drawing.Size(53, 21);
            this.rdoRed2.TabIndex = 5;
            this.rdoRed2.TabStop = true;
            this.rdoRed2.Text = "Red";
            this.rdoRed2.UseVisualStyleBackColor = true;
            this.rdoRed2.CheckedChanged += new System.EventHandler(this.rdoRed2_CheckedChanged);
            // 
            // frmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdoYellow);
            this.Controls.Add(this.rdoBlue);
            this.Controls.Add(this.rdoGreen);
            this.Controls.Add(this.rdoRed);
            this.Controls.Add(this.btnReset);
            this.Name = "frmRadio";
            this.Text = "Radio Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.RadioButton rdoGreen;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.RadioButton rdoYellow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoYellow2;
        private System.Windows.Forms.RadioButton rdoBlue2;
        private System.Windows.Forms.RadioButton rdoGreen2;
        private System.Windows.Forms.RadioButton rdoRed2;
        private System.Windows.Forms.Button btnBack;
    }
}