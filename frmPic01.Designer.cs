namespace IE322_project_23
{
    partial class frmPic01
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
            this.BtnImageFromFile = new System.Windows.Forms.Button();
            this.BtnImageFromRes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RdoZoom = new System.Windows.Forms.RadioButton();
            this.RdoCentre = new System.Windows.Forms.RadioButton();
            this.RdoAuto = new System.Windows.Forms.RadioButton();
            this.RdoStretch = new System.Windows.Forms.RadioButton();
            this.RdoNormal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picTry = new System.Windows.Forms.PictureBox();
            this.picTry2 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnImageFromFile
            // 
            this.BtnImageFromFile.Location = new System.Drawing.Point(41, 52);
            this.BtnImageFromFile.Margin = new System.Windows.Forms.Padding(4);
            this.BtnImageFromFile.Name = "BtnImageFromFile";
            this.BtnImageFromFile.Size = new System.Drawing.Size(148, 55);
            this.BtnImageFromFile.TabIndex = 7;
            this.BtnImageFromFile.Text = "Image from File";
            this.BtnImageFromFile.UseVisualStyleBackColor = true;
            this.BtnImageFromFile.Click += new System.EventHandler(this.BtnImageFromFile_Click);
            // 
            // BtnImageFromRes
            // 
            this.BtnImageFromRes.Location = new System.Drawing.Point(41, 134);
            this.BtnImageFromRes.Margin = new System.Windows.Forms.Padding(4);
            this.BtnImageFromRes.Name = "BtnImageFromRes";
            this.BtnImageFromRes.Size = new System.Drawing.Size(148, 55);
            this.BtnImageFromRes.TabIndex = 10;
            this.BtnImageFromRes.Text = "Image from Resource";
            this.BtnImageFromRes.UseVisualStyleBackColor = true;
            this.BtnImageFromRes.Click += new System.EventHandler(this.BtnImageFromRes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdoZoom);
            this.groupBox2.Controls.Add(this.RdoCentre);
            this.groupBox2.Controls.Add(this.RdoAuto);
            this.groupBox2.Controls.Add(this.RdoStretch);
            this.groupBox2.Controls.Add(this.RdoNormal);
            this.groupBox2.Location = new System.Drawing.Point(41, 213);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(142, 213);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size Mode";
            // 
            // RdoZoom
            // 
            this.RdoZoom.AutoSize = true;
            this.RdoZoom.Location = new System.Drawing.Point(21, 164);
            this.RdoZoom.Margin = new System.Windows.Forms.Padding(4);
            this.RdoZoom.Name = "RdoZoom";
            this.RdoZoom.Size = new System.Drawing.Size(65, 21);
            this.RdoZoom.TabIndex = 4;
            this.RdoZoom.TabStop = true;
            this.RdoZoom.Text = "Zoom";
            this.RdoZoom.UseVisualStyleBackColor = true;
            this.RdoZoom.CheckedChanged += new System.EventHandler(this.RdoZoom_CheckedChanged);
            // 
            // RdoCentre
            // 
            this.RdoCentre.AutoSize = true;
            this.RdoCentre.Location = new System.Drawing.Point(21, 132);
            this.RdoCentre.Margin = new System.Windows.Forms.Padding(4);
            this.RdoCentre.Name = "RdoCentre";
            this.RdoCentre.Size = new System.Drawing.Size(108, 21);
            this.RdoCentre.TabIndex = 3;
            this.RdoCentre.TabStop = true;
            this.RdoCentre.Text = "CentreImage";
            this.RdoCentre.UseVisualStyleBackColor = true;
            this.RdoCentre.CheckedChanged += new System.EventHandler(this.RdoCentre_CheckedChanged);
            // 
            // RdoAuto
            // 
            this.RdoAuto.AutoSize = true;
            this.RdoAuto.Location = new System.Drawing.Point(21, 100);
            this.RdoAuto.Margin = new System.Windows.Forms.Padding(4);
            this.RdoAuto.Name = "RdoAuto";
            this.RdoAuto.Size = new System.Drawing.Size(81, 21);
            this.RdoAuto.TabIndex = 2;
            this.RdoAuto.TabStop = true;
            this.RdoAuto.Text = "AutoSize";
            this.RdoAuto.UseVisualStyleBackColor = true;
            this.RdoAuto.CheckedChanged += new System.EventHandler(this.RdoAuto_CheckedChanged);
            // 
            // RdoStretch
            // 
            this.RdoStretch.AutoSize = true;
            this.RdoStretch.Location = new System.Drawing.Point(21, 68);
            this.RdoStretch.Margin = new System.Windows.Forms.Padding(4);
            this.RdoStretch.Name = "RdoStretch";
            this.RdoStretch.Size = new System.Drawing.Size(112, 21);
            this.RdoStretch.TabIndex = 1;
            this.RdoStretch.TabStop = true;
            this.RdoStretch.Text = "StretchImage";
            this.RdoStretch.UseVisualStyleBackColor = true;
            this.RdoStretch.CheckedChanged += new System.EventHandler(this.RdoStretch_CheckedChanged);
            // 
            // RdoNormal
            // 
            this.RdoNormal.AutoSize = true;
            this.RdoNormal.Location = new System.Drawing.Point(21, 36);
            this.RdoNormal.Margin = new System.Windows.Forms.Padding(4);
            this.RdoNormal.Name = "RdoNormal";
            this.RdoNormal.Size = new System.Drawing.Size(72, 21);
            this.RdoNormal.TabIndex = 0;
            this.RdoNormal.TabStop = true;
            this.RdoNormal.Text = "Normal";
            this.RdoNormal.UseVisualStyleBackColor = true;
            this.RdoNormal.CheckedChanged += new System.EventHandler(this.RdoNormal_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picTry);
            this.groupBox1.Controls.Add(this.picTry2);
            this.groupBox1.Location = new System.Drawing.Point(220, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(598, 356);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picture Boxes";
            // 
            // picTry
            // 
            this.picTry.Location = new System.Drawing.Point(19, 22);
            this.picTry.Margin = new System.Windows.Forms.Padding(4);
            this.picTry.Name = "picTry";
            this.picTry.Size = new System.Drawing.Size(270, 313);
            this.picTry.TabIndex = 0;
            this.picTry.TabStop = false;
            // 
            // picTry2
            // 
            this.picTry2.Location = new System.Drawing.Point(307, 22);
            this.picTry2.Margin = new System.Windows.Forms.Padding(4);
            this.picTry2.Name = "picTry2";
            this.picTry2.Size = new System.Drawing.Size(270, 313);
            this.picTry2.TabIndex = 7;
            this.picTry2.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(755, 431);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 28);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmPic01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 549);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnImageFromRes);
            this.Controls.Add(this.BtnImageFromFile);
            this.Name = "frmPic01";
            this.Text = "Picture";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnImageFromFile;
        private System.Windows.Forms.Button BtnImageFromRes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RdoZoom;
        private System.Windows.Forms.RadioButton RdoCentre;
        private System.Windows.Forms.RadioButton RdoAuto;
        private System.Windows.Forms.RadioButton RdoStretch;
        private System.Windows.Forms.RadioButton RdoNormal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picTry;
        private System.Windows.Forms.PictureBox picTry2;
        private System.Windows.Forms.Button btnBack;
    }
}