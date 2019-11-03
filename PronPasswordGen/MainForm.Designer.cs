namespace PronPasswordGen
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbGenerate = new System.Windows.Forms.Button();
            this.nudPassLen = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPassToGen = new System.Windows.Forms.NumericUpDown();
            this.cbCapitals = new System.Windows.Forms.CheckBox();
            this.cbSpecials = new System.Windows.Forms.CheckBox();
            this.cbSeparators = new System.Windows.Forms.CheckBox();
            this.tbSpecials = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbSpecialSet = new System.Windows.Forms.Button();
            this.pbSpecialsReset = new System.Windows.Forms.Button();
            this.tbFixedSeparator = new System.Windows.Forms.TextBox();
            this.cbRotSeparators = new System.Windows.Forms.CheckBox();
            this.tbSeparators = new System.Windows.Forms.TextBox();
            this.pbSeparatorsSet = new System.Windows.Forms.Button();
            this.pbSeparatorsReset = new System.Windows.Forms.Button();
            this.pbStrengthMeter = new System.Windows.Forms.Button();
            this.pbSetup = new System.Windows.Forms.Button();
            this.dgvPasswords = new System.Windows.Forms.DataGridView();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStrength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStrengthValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCardinality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntropy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSepText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassToGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswords)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGenerate
            // 
            this.pbGenerate.Location = new System.Drawing.Point(585, 105);
            this.pbGenerate.Name = "pbGenerate";
            this.pbGenerate.Size = new System.Drawing.Size(75, 23);
            this.pbGenerate.TabIndex = 1;
            this.pbGenerate.Text = "Generate";
            this.pbGenerate.UseVisualStyleBackColor = true;
            this.pbGenerate.Click += new System.EventHandler(this.pbGenerate_Click);
            // 
            // nudPassLen
            // 
            this.nudPassLen.Location = new System.Drawing.Point(129, 12);
            this.nudPassLen.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudPassLen.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudPassLen.Name = "nudPassLen";
            this.nudPassLen.Size = new System.Drawing.Size(58, 20);
            this.nudPassLen.TabIndex = 2;
            this.nudPassLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPassLen.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password Length (min):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of passwords to generate:";
            // 
            // nudPassToGen
            // 
            this.nudPassToGen.Location = new System.Drawing.Point(404, 12);
            this.nudPassToGen.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudPassToGen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPassToGen.Name = "nudPassToGen";
            this.nudPassToGen.Size = new System.Drawing.Size(51, 20);
            this.nudPassToGen.TabIndex = 5;
            this.nudPassToGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPassToGen.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cbCapitals
            // 
            this.cbCapitals.AutoSize = true;
            this.cbCapitals.Checked = true;
            this.cbCapitals.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCapitals.Location = new System.Drawing.Point(15, 45);
            this.cbCapitals.Name = "cbCapitals";
            this.cbCapitals.Size = new System.Drawing.Size(63, 17);
            this.cbCapitals.TabIndex = 6;
            this.cbCapitals.Text = "Capitals";
            this.cbCapitals.UseVisualStyleBackColor = true;
            // 
            // cbSpecials
            // 
            this.cbSpecials.AutoSize = true;
            this.cbSpecials.Checked = true;
            this.cbSpecials.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSpecials.Location = new System.Drawing.Point(110, 45);
            this.cbSpecials.Name = "cbSpecials";
            this.cbSpecials.Size = new System.Drawing.Size(125, 17);
            this.cbSpecials.TabIndex = 7;
            this.cbSpecials.Text = "Ciphers and Specials";
            this.cbSpecials.UseVisualStyleBackColor = true;
            this.cbSpecials.CheckedChanged += new System.EventHandler(this.cbSpecials_CheckedChanged);
            // 
            // cbSeparators
            // 
            this.cbSeparators.AutoSize = true;
            this.cbSeparators.Location = new System.Drawing.Point(110, 80);
            this.cbSeparators.Name = "cbSeparators";
            this.cbSeparators.Size = new System.Drawing.Size(77, 17);
            this.cbSeparators.TabIndex = 8;
            this.cbSeparators.Text = "Separators";
            this.cbSeparators.UseVisualStyleBackColor = true;
            this.cbSeparators.CheckedChanged += new System.EventHandler(this.cbSeparators_CheckedChanged);
            // 
            // tbSpecials
            // 
            this.tbSpecials.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSpecials.Location = new System.Drawing.Point(315, 42);
            this.tbSpecials.Name = "tbSpecials";
            this.tbSpecials.Size = new System.Drawing.Size(140, 22);
            this.tbSpecials.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Specials:";
            // 
            // pbSpecialSet
            // 
            this.pbSpecialSet.Location = new System.Drawing.Point(461, 41);
            this.pbSpecialSet.Name = "pbSpecialSet";
            this.pbSpecialSet.Size = new System.Drawing.Size(37, 23);
            this.pbSpecialSet.TabIndex = 11;
            this.pbSpecialSet.Text = "Set";
            this.pbSpecialSet.UseVisualStyleBackColor = true;
            this.pbSpecialSet.Click += new System.EventHandler(this.pbSpecialSet_Click);
            // 
            // pbSpecialsReset
            // 
            this.pbSpecialsReset.Location = new System.Drawing.Point(504, 41);
            this.pbSpecialsReset.Name = "pbSpecialsReset";
            this.pbSpecialsReset.Size = new System.Drawing.Size(47, 23);
            this.pbSpecialsReset.TabIndex = 12;
            this.pbSpecialsReset.Text = "Reset";
            this.pbSpecialsReset.UseVisualStyleBackColor = true;
            this.pbSpecialsReset.Click += new System.EventHandler(this.pbSpecialsReset_Click);
            // 
            // tbFixedSeparator
            // 
            this.tbFixedSeparator.Enabled = false;
            this.tbFixedSeparator.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFixedSeparator.Location = new System.Drawing.Point(193, 75);
            this.tbFixedSeparator.MaxLength = 1;
            this.tbFixedSeparator.Name = "tbFixedSeparator";
            this.tbFixedSeparator.Size = new System.Drawing.Size(42, 22);
            this.tbFixedSeparator.TabIndex = 14;
            // 
            // cbRotSeparators
            // 
            this.cbRotSeparators.AutoSize = true;
            this.cbRotSeparators.Enabled = false;
            this.cbRotSeparators.Location = new System.Drawing.Point(253, 79);
            this.cbRotSeparators.Name = "cbRotSeparators";
            this.cbRotSeparators.Size = new System.Drawing.Size(91, 17);
            this.cbRotSeparators.TabIndex = 15;
            this.cbRotSeparators.Text = "Sep. Rotation";
            this.cbRotSeparators.UseVisualStyleBackColor = true;
            this.cbRotSeparators.CheckedChanged += new System.EventHandler(this.cbRotSeparators_CheckedChanged);
            // 
            // tbSeparators
            // 
            this.tbSeparators.Enabled = false;
            this.tbSeparators.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSeparators.Location = new System.Drawing.Point(350, 77);
            this.tbSeparators.Name = "tbSeparators";
            this.tbSeparators.Size = new System.Drawing.Size(105, 22);
            this.tbSeparators.TabIndex = 16;
            // 
            // pbSeparatorsSet
            // 
            this.pbSeparatorsSet.Enabled = false;
            this.pbSeparatorsSet.Location = new System.Drawing.Point(461, 76);
            this.pbSeparatorsSet.Name = "pbSeparatorsSet";
            this.pbSeparatorsSet.Size = new System.Drawing.Size(36, 23);
            this.pbSeparatorsSet.TabIndex = 17;
            this.pbSeparatorsSet.Text = "Set";
            this.pbSeparatorsSet.UseVisualStyleBackColor = true;
            this.pbSeparatorsSet.Click += new System.EventHandler(this.pbSeparatorsSet_Click);
            // 
            // pbSeparatorsReset
            // 
            this.pbSeparatorsReset.Enabled = false;
            this.pbSeparatorsReset.Location = new System.Drawing.Point(503, 76);
            this.pbSeparatorsReset.Name = "pbSeparatorsReset";
            this.pbSeparatorsReset.Size = new System.Drawing.Size(47, 23);
            this.pbSeparatorsReset.TabIndex = 18;
            this.pbSeparatorsReset.Text = "Reset";
            this.pbSeparatorsReset.UseVisualStyleBackColor = true;
            this.pbSeparatorsReset.Click += new System.EventHandler(this.pbSeparatorsReset_Click);
            // 
            // pbStrengthMeter
            // 
            this.pbStrengthMeter.Image = ((System.Drawing.Image)(resources.GetObject("pbStrengthMeter.Image")));
            this.pbStrengthMeter.Location = new System.Drawing.Point(585, 12);
            this.pbStrengthMeter.Name = "pbStrengthMeter";
            this.pbStrengthMeter.Size = new System.Drawing.Size(32, 32);
            this.pbStrengthMeter.TabIndex = 19;
            this.pbStrengthMeter.UseVisualStyleBackColor = true;
            this.pbStrengthMeter.Click += new System.EventHandler(this.pbStrengthMeter_Click);
            // 
            // pbSetup
            // 
            this.pbSetup.Image = ((System.Drawing.Image)(resources.GetObject("pbSetup.Image")));
            this.pbSetup.Location = new System.Drawing.Point(628, 12);
            this.pbSetup.Name = "pbSetup";
            this.pbSetup.Size = new System.Drawing.Size(32, 32);
            this.pbSetup.TabIndex = 20;
            this.pbSetup.UseVisualStyleBackColor = true;
            // 
            // dgvPasswords
            // 
            this.dgvPasswords.AllowUserToAddRows = false;
            this.dgvPasswords.AllowUserToDeleteRows = false;
            this.dgvPasswords.AllowUserToResizeRows = false;
            this.dgvPasswords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasswords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPassword,
            this.colStrength,
            this.colStrengthValue,
            this.colCardinality,
            this.colEntropy,
            this.colLength,
            this.colSepText});
            this.dgvPasswords.Location = new System.Drawing.Point(3, 134);
            this.dgvPasswords.MultiSelect = false;
            this.dgvPasswords.Name = "dgvPasswords";
            this.dgvPasswords.ReadOnly = true;
            this.dgvPasswords.Size = new System.Drawing.Size(657, 249);
            this.dgvPasswords.TabIndex = 21;
            this.dgvPasswords.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPasswords_CellDoubleClick);
            // 
            // colPassword
            // 
            this.colPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPassword.DataPropertyName = "Password";
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPassword.DefaultCellStyle = dataGridViewCellStyle19;
            this.colPassword.HeaderText = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.ReadOnly = true;
            this.colPassword.Width = 78;
            // 
            // colStrength
            // 
            this.colStrength.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colStrength.DataPropertyName = "Strength";
            this.colStrength.HeaderText = "Strength";
            this.colStrength.Name = "colStrength";
            this.colStrength.ReadOnly = true;
            this.colStrength.Width = 72;
            // 
            // colStrengthValue
            // 
            this.colStrengthValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colStrengthValue.DataPropertyName = "StrengthValue";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colStrengthValue.DefaultCellStyle = dataGridViewCellStyle20;
            this.colStrengthValue.HeaderText = "Val.";
            this.colStrengthValue.Name = "colStrengthValue";
            this.colStrengthValue.ReadOnly = true;
            this.colStrengthValue.Width = 50;
            // 
            // colCardinality
            // 
            this.colCardinality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCardinality.DataPropertyName = "Cardinality";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colCardinality.DefaultCellStyle = dataGridViewCellStyle21;
            this.colCardinality.HeaderText = "Cardin.";
            this.colCardinality.Name = "colCardinality";
            this.colCardinality.ReadOnly = true;
            this.colCardinality.Width = 65;
            // 
            // colEntropy
            // 
            this.colEntropy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEntropy.DataPropertyName = "Entropy";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "F1";
            dataGridViewCellStyle22.NullValue = null;
            this.colEntropy.DefaultCellStyle = dataGridViewCellStyle22;
            this.colEntropy.HeaderText = "H (bits)";
            this.colEntropy.Name = "colEntropy";
            this.colEntropy.ReadOnly = true;
            this.colEntropy.Width = 65;
            // 
            // colLength
            // 
            this.colLength.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLength.DataPropertyName = "Length";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colLength.DefaultCellStyle = dataGridViewCellStyle23;
            this.colLength.HeaderText = "Len.";
            this.colLength.Name = "colLength";
            this.colLength.ReadOnly = true;
            this.colLength.Width = 53;
            // 
            // colSepText
            // 
            this.colSepText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSepText.DataPropertyName = "SepText";
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Courier New", 9F);
            this.colSepText.DefaultCellStyle = dataGridViewCellStyle24;
            this.colSepText.HeaderText = "Chunks";
            this.colSepText.Name = "colSepText";
            this.colSepText.ReadOnly = true;
            this.colSepText.Width = 68;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 386);
            this.Controls.Add(this.dgvPasswords);
            this.Controls.Add(this.pbSetup);
            this.Controls.Add(this.pbStrengthMeter);
            this.Controls.Add(this.pbSeparatorsReset);
            this.Controls.Add(this.pbSeparatorsSet);
            this.Controls.Add(this.tbSeparators);
            this.Controls.Add(this.cbRotSeparators);
            this.Controls.Add(this.tbFixedSeparator);
            this.Controls.Add(this.pbSpecialsReset);
            this.Controls.Add(this.pbSpecialSet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSpecials);
            this.Controls.Add(this.cbSeparators);
            this.Controls.Add(this.cbSpecials);
            this.Controls.Add(this.cbCapitals);
            this.Controls.Add(this.nudPassToGen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPassLen);
            this.Controls.Add(this.pbGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Pronounceable Password Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassToGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pbGenerate;
        private System.Windows.Forms.NumericUpDown nudPassLen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPassToGen;
        private System.Windows.Forms.CheckBox cbCapitals;
        private System.Windows.Forms.CheckBox cbSpecials;
        private System.Windows.Forms.CheckBox cbSeparators;
        private System.Windows.Forms.TextBox tbSpecials;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pbSpecialSet;
        private System.Windows.Forms.Button pbSpecialsReset;
        private System.Windows.Forms.TextBox tbFixedSeparator;
        private System.Windows.Forms.CheckBox cbRotSeparators;
        private System.Windows.Forms.TextBox tbSeparators;
        private System.Windows.Forms.Button pbSeparatorsSet;
        private System.Windows.Forms.Button pbSeparatorsReset;
        private System.Windows.Forms.Button pbStrengthMeter;
        private System.Windows.Forms.Button pbSetup;
        private System.Windows.Forms.DataGridView dgvPasswords;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStrength;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStrengthValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCardinality;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntropy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSepText;
    }
}

