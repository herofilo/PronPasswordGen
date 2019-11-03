namespace PronPasswordGen
{
    partial class StrengthMeterForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StrengthMeterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pbCheck = new System.Windows.Forms.Button();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.colLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMeter = new System.Windows.Forms.Panel();
            this.lblCardinality = new System.Windows.Forms.Label();
            this.lblEntropy = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password to check:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(119, 15);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(266, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // pbCheck
            // 
            this.pbCheck.Location = new System.Drawing.Point(416, 15);
            this.pbCheck.Name = "pbCheck";
            this.pbCheck.Size = new System.Drawing.Size(75, 23);
            this.pbCheck.TabIndex = 3;
            this.pbCheck.Text = "Calculate";
            this.pbCheck.UseVisualStyleBackColor = true;
            this.pbCheck.Click += new System.EventHandler(this.pbCheck_Click);
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.Location = new System.Drawing.Point(228, 122);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(51, 16);
            this.lblStrength.TabIndex = 4;
            this.lblStrength.Text = "label2";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(22, 50);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(50, 13);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "Length:";
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLevel,
            this.colDescription,
            this.colType,
            this.colRate,
            this.colCount,
            this.colBonus});
            this.dgvDetails.Location = new System.Drawing.Point(2, 156);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.Size = new System.Drawing.Size(489, 244);
            this.dgvDetails.TabIndex = 6;
            // 
            // colLevel
            // 
            this.colLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLevel.DataPropertyName = "Level";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colLevel.DefaultCellStyle = dataGridViewCellStyle4;
            this.colLevel.HeaderText = "Level";
            this.colLevel.Name = "colLevel";
            this.colLevel.ReadOnly = true;
            this.colLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colLevel.Width = 39;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDescription.Width = 66;
            // 
            // colType
            // 
            this.colType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colType.DataPropertyName = "Type";
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colType.Width = 37;
            // 
            // colRate
            // 
            this.colRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRate.DataPropertyName = "Rate";
            this.colRate.HeaderText = "Rate";
            this.colRate.Name = "colRate";
            this.colRate.ReadOnly = true;
            this.colRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colRate.Width = 36;
            // 
            // colCount
            // 
            this.colCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCount.DataPropertyName = "Count";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colCount.DefaultCellStyle = dataGridViewCellStyle5;
            this.colCount.HeaderText = "Count";
            this.colCount.Name = "colCount";
            this.colCount.ReadOnly = true;
            this.colCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCount.Width = 41;
            // 
            // colBonus
            // 
            this.colBonus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBonus.DataPropertyName = "Bonus";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colBonus.DefaultCellStyle = dataGridViewCellStyle6;
            this.colBonus.HeaderText = "Bonus";
            this.colBonus.Name = "colBonus";
            this.colBonus.ReadOnly = true;
            this.colBonus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colBonus.Width = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Details:";
            // 
            // pnlMeter
            // 
            this.pnlMeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMeter.Location = new System.Drawing.Point(105, 91);
            this.pnlMeter.Name = "pnlMeter";
            this.pnlMeter.Size = new System.Drawing.Size(344, 28);
            this.pnlMeter.TabIndex = 8;
            // 
            // lblCardinality
            // 
            this.lblCardinality.AutoSize = true;
            this.lblCardinality.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardinality.Location = new System.Drawing.Point(136, 50);
            this.lblCardinality.Name = "lblCardinality";
            this.lblCardinality.Size = new System.Drawing.Size(70, 13);
            this.lblCardinality.TabIndex = 9;
            this.lblCardinality.Text = "Cardinality:";
            // 
            // lblEntropy
            // 
            this.lblEntropy.AutoSize = true;
            this.lblEntropy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntropy.Location = new System.Drawing.Point(270, 50);
            this.lblEntropy.Name = "lblEntropy";
            this.lblEntropy.Size = new System.Drawing.Size(54, 13);
            this.lblEntropy.TabIndex = 10;
            this.lblEntropy.Text = "Entropy:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StrengthMeterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 406);
            this.Controls.Add(this.lblEntropy);
            this.Controls.Add(this.lblCardinality);
            this.Controls.Add(this.pnlMeter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblStrength);
            this.Controls.Add(this.pbCheck);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StrengthMeterForm";
            this.Text = "Password Strength Meter";
            this.Load += new System.EventHandler(this.StrengthMeterForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.StrengthMeterForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button pbCheck;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBonus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMeter;
        private System.Windows.Forms.Label lblCardinality;
        private System.Windows.Forms.Label lblEntropy;
        private System.Windows.Forms.Timer timer1;
    }
}