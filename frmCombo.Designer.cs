namespace IE322_project_23
{
    partial class frmCombo
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
            this.GrpComboExp1 = new System.Windows.Forms.GroupBox();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.LblCount = new System.Windows.Forms.Label();
            this.LblSelected = new System.Windows.Forms.Label();
            this.BtnRemove2ndLast = new System.Windows.Forms.Button();
            this.BtnRemoveLast = new System.Windows.Forms.Button();
            this.BtnRemoveSelectedItem = new System.Windows.Forms.Button();
            this.BtnRemoveByName = new System.Windows.Forms.Button();
            this.BtnRemoveByIndex = new System.Windows.Forms.Button();
            this.BtnShowSelected3 = new System.Windows.Forms.Button();
            this.BtnShowSelected2 = new System.Windows.Forms.Button();
            this.BtnShowSelected1 = new System.Windows.Forms.Button();
            this.GrpComboExp2 = new System.Windows.Forms.GroupBox();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.PicDraw = new System.Windows.Forms.PictureBox();
            this.CmbColors = new System.Windows.Forms.ComboBox();
            this.GrpComboExp1.SuspendLayout();
            this.GrpComboExp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpComboExp1
            // 
            this.GrpComboExp1.Controls.Add(this.CmbDays);
            this.GrpComboExp1.Controls.Add(this.LblCount);
            this.GrpComboExp1.Controls.Add(this.LblSelected);
            this.GrpComboExp1.Controls.Add(this.BtnRemove2ndLast);
            this.GrpComboExp1.Controls.Add(this.BtnRemoveLast);
            this.GrpComboExp1.Controls.Add(this.BtnRemoveSelectedItem);
            this.GrpComboExp1.Controls.Add(this.BtnRemoveByName);
            this.GrpComboExp1.Controls.Add(this.BtnRemoveByIndex);
            this.GrpComboExp1.Controls.Add(this.BtnShowSelected3);
            this.GrpComboExp1.Controls.Add(this.BtnShowSelected2);
            this.GrpComboExp1.Controls.Add(this.BtnShowSelected1);
            this.GrpComboExp1.Location = new System.Drawing.Point(27, 28);
            this.GrpComboExp1.Name = "GrpComboExp1";
            this.GrpComboExp1.Size = new System.Drawing.Size(387, 324);
            this.GrpComboExp1.TabIndex = 0;
            this.GrpComboExp1.TabStop = false;
            this.GrpComboExp1.Text = "Example1:";
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(194, 275);
            this.CmbDays.Margin = new System.Windows.Forms.Padding(4);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(171, 24);
            this.CmbDays.TabIndex = 11;
            this.CmbDays.SelectedIndexChanged += new System.EventHandler(this.CmbDays_SelectedIndexChanged);
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Location = new System.Drawing.Point(198, 240);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(167, 17);
            this.LblCount.TabIndex = 10;
            this.LblCount.Text = "Current Number of Items:";
            // 
            // LblSelected
            // 
            this.LblSelected.AutoSize = true;
            this.LblSelected.Location = new System.Drawing.Point(16, 240);
            this.LblSelected.Name = "LblSelected";
            this.LblSelected.Size = new System.Drawing.Size(125, 17);
            this.LblSelected.TabIndex = 9;
            this.LblSelected.Text = "Currently Selected:";
            // 
            // BtnRemove2ndLast
            // 
            this.BtnRemove2ndLast.Location = new System.Drawing.Point(194, 148);
            this.BtnRemove2ndLast.Name = "BtnRemove2ndLast";
            this.BtnRemove2ndLast.Size = new System.Drawing.Size(160, 46);
            this.BtnRemove2ndLast.TabIndex = 8;
            this.BtnRemove2ndLast.Text = "Remove 2nd last item";
            this.BtnRemove2ndLast.UseVisualStyleBackColor = true;
            this.BtnRemove2ndLast.Click += new System.EventHandler(this.BtnRemove2ndLast_Click);
            // 
            // BtnRemoveLast
            // 
            this.BtnRemoveLast.Location = new System.Drawing.Point(19, 148);
            this.BtnRemoveLast.Name = "BtnRemoveLast";
            this.BtnRemoveLast.Size = new System.Drawing.Size(153, 46);
            this.BtnRemoveLast.TabIndex = 7;
            this.BtnRemoveLast.Text = "Remove last item";
            this.BtnRemoveLast.UseVisualStyleBackColor = true;
            this.BtnRemoveLast.Click += new System.EventHandler(this.BtnRemoveLast_Click);
            // 
            // BtnRemoveSelectedItem
            // 
            this.BtnRemoveSelectedItem.Location = new System.Drawing.Point(247, 93);
            this.BtnRemoveSelectedItem.Name = "BtnRemoveSelectedItem";
            this.BtnRemoveSelectedItem.Size = new System.Drawing.Size(107, 49);
            this.BtnRemoveSelectedItem.TabIndex = 5;
            this.BtnRemoveSelectedItem.Text = "Remove Selected Item";
            this.BtnRemoveSelectedItem.UseVisualStyleBackColor = true;
            this.BtnRemoveSelectedItem.Click += new System.EventHandler(this.BtnRemoveSelectedItem_Click);
            // 
            // BtnRemoveByName
            // 
            this.BtnRemoveByName.Location = new System.Drawing.Point(134, 93);
            this.BtnRemoveByName.Name = "BtnRemoveByName";
            this.BtnRemoveByName.Size = new System.Drawing.Size(107, 49);
            this.BtnRemoveByName.TabIndex = 4;
            this.BtnRemoveByName.Text = "Remove by Name";
            this.BtnRemoveByName.UseVisualStyleBackColor = true;
            this.BtnRemoveByName.Click += new System.EventHandler(this.BtnRemoveByName_Click);
            // 
            // BtnRemoveByIndex
            // 
            this.BtnRemoveByIndex.Location = new System.Drawing.Point(19, 93);
            this.BtnRemoveByIndex.Name = "BtnRemoveByIndex";
            this.BtnRemoveByIndex.Size = new System.Drawing.Size(107, 49);
            this.BtnRemoveByIndex.TabIndex = 3;
            this.BtnRemoveByIndex.Text = "Remove by Index";
            this.BtnRemoveByIndex.UseVisualStyleBackColor = true;
            this.BtnRemoveByIndex.Click += new System.EventHandler(this.BtnRemoveByIndex_Click);
            // 
            // BtnShowSelected3
            // 
            this.BtnShowSelected3.Location = new System.Drawing.Point(247, 38);
            this.BtnShowSelected3.Name = "BtnShowSelected3";
            this.BtnShowSelected3.Size = new System.Drawing.Size(107, 49);
            this.BtnShowSelected3.TabIndex = 2;
            this.BtnShowSelected3.Text = "Show Selected Method3";
            this.BtnShowSelected3.UseVisualStyleBackColor = true;
            this.BtnShowSelected3.Click += new System.EventHandler(this.BtnShowSelected3_Click);
            // 
            // BtnShowSelected2
            // 
            this.BtnShowSelected2.Location = new System.Drawing.Point(134, 38);
            this.BtnShowSelected2.Name = "BtnShowSelected2";
            this.BtnShowSelected2.Size = new System.Drawing.Size(107, 49);
            this.BtnShowSelected2.TabIndex = 1;
            this.BtnShowSelected2.Text = "Show Selected Method2";
            this.BtnShowSelected2.UseVisualStyleBackColor = true;
            this.BtnShowSelected2.Click += new System.EventHandler(this.BtnShowSelected2_Click);
            // 
            // BtnShowSelected1
            // 
            this.BtnShowSelected1.Location = new System.Drawing.Point(19, 38);
            this.BtnShowSelected1.Name = "BtnShowSelected1";
            this.BtnShowSelected1.Size = new System.Drawing.Size(107, 49);
            this.BtnShowSelected1.TabIndex = 0;
            this.BtnShowSelected1.Text = "Show Selected Method1";
            this.BtnShowSelected1.UseVisualStyleBackColor = true;
            this.BtnShowSelected1.Click += new System.EventHandler(this.BtnShowSelected1_Click);
            // 
            // GrpComboExp2
            // 
            this.GrpComboExp2.Controls.Add(this.CmbColors);
            this.GrpComboExp2.Controls.Add(this.PicDraw);
            this.GrpComboExp2.Controls.Add(this.BtnClear);
            this.GrpComboExp2.Controls.Add(this.BtnDraw);
            this.GrpComboExp2.Location = new System.Drawing.Point(448, 28);
            this.GrpComboExp2.Name = "GrpComboExp2";
            this.GrpComboExp2.Size = new System.Drawing.Size(309, 324);
            this.GrpComboExp2.TabIndex = 1;
            this.GrpComboExp2.TabStop = false;
            this.GrpComboExp2.Text = "Eample 2:";
            // 
            // BtnDraw
            // 
            this.BtnDraw.Location = new System.Drawing.Point(15, 38);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(91, 36);
            this.BtnDraw.TabIndex = 0;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.UseVisualStyleBackColor = true;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(653, 372);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 41);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(205, 38);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(91, 36);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // PicDraw
            // 
            this.PicDraw.Location = new System.Drawing.Point(2, 80);
            this.PicDraw.Margin = new System.Windows.Forms.Padding(4);
            this.PicDraw.Name = "PicDraw";
            this.PicDraw.Size = new System.Drawing.Size(304, 165);
            this.PicDraw.TabIndex = 3;
            this.PicDraw.TabStop = false;
            this.PicDraw.Click += new System.EventHandler(this.PicDraw_Click);
            // 
            // CmbColors
            // 
            this.CmbColors.FormattingEnabled = true;
            this.CmbColors.Location = new System.Drawing.Point(109, 275);
            this.CmbColors.Margin = new System.Windows.Forms.Padding(4);
            this.CmbColors.Name = "CmbColors";
            this.CmbColors.Size = new System.Drawing.Size(193, 24);
            this.CmbColors.TabIndex = 4;
            // 
            // frmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.GrpComboExp2);
            this.Controls.Add(this.GrpComboExp1);
            this.Name = "frmCombo";
            this.Text = "Combo";
            this.GrpComboExp1.ResumeLayout(false);
            this.GrpComboExp1.PerformLayout();
            this.GrpComboExp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicDraw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpComboExp1;
        private System.Windows.Forms.Button BtnRemoveLast;
        private System.Windows.Forms.Button BtnRemoveSelectedItem;
        private System.Windows.Forms.Button BtnRemoveByName;
        private System.Windows.Forms.Button BtnRemoveByIndex;
        private System.Windows.Forms.Button BtnShowSelected3;
        private System.Windows.Forms.Button BtnShowSelected2;
        private System.Windows.Forms.Button BtnShowSelected1;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.Label LblSelected;
        private System.Windows.Forms.Button BtnRemove2ndLast;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.GroupBox GrpComboExp2;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox CmbColors;
        private System.Windows.Forms.PictureBox PicDraw;
    }
}