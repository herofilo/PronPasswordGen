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
            this.tbOutput = new System.Windows.Forms.TextBox();
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
            this.cbExtraInfo = new System.Windows.Forms.CheckBox();
            this.tbFixedSeparator = new System.Windows.Forms.TextBox();
            this.cbRotSeparators = new System.Windows.Forms.CheckBox();
            this.tbSeparators = new System.Windows.Forms.TextBox();
            this.pbSeparatorsSet = new System.Windows.Forms.Button();
            this.pbSeparatorsReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassToGen)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.Location = new System.Drawing.Point(3, 134);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOutput.Size = new System.Drawing.Size(574, 249);
            this.tbOutput.TabIndex = 0;
            this.tbOutput.WordWrap = false;
            // 
            // pbGenerate
            // 
            this.pbGenerate.Location = new System.Drawing.Point(502, 105);
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
            this.cbSeparators.Location = new System.Drawing.Point(110, 68);
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
            // cbExtraInfo
            // 
            this.cbExtraInfo.AutoSize = true;
            this.cbExtraInfo.Checked = true;
            this.cbExtraInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExtraInfo.Location = new System.Drawing.Point(504, 82);
            this.cbExtraInfo.Name = "cbExtraInfo";
            this.cbExtraInfo.Size = new System.Drawing.Size(70, 17);
            this.cbExtraInfo.TabIndex = 13;
            this.cbExtraInfo.Text = "Extra info";
            this.cbExtraInfo.UseVisualStyleBackColor = true;
            // 
            // tbFixedSeparator
            // 
            this.tbFixedSeparator.Enabled = false;
            this.tbFixedSeparator.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFixedSeparator.Location = new System.Drawing.Point(193, 63);
            this.tbFixedSeparator.MaxLength = 1;
            this.tbFixedSeparator.Name = "tbFixedSeparator";
            this.tbFixedSeparator.Size = new System.Drawing.Size(42, 22);
            this.tbFixedSeparator.TabIndex = 14;
            // 
            // cbRotSeparators
            // 
            this.cbRotSeparators.AutoSize = true;
            this.cbRotSeparators.Enabled = false;
            this.cbRotSeparators.Location = new System.Drawing.Point(130, 91);
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
            this.tbSeparators.Location = new System.Drawing.Point(227, 89);
            this.tbSeparators.Name = "tbSeparators";
            this.tbSeparators.Size = new System.Drawing.Size(105, 22);
            this.tbSeparators.TabIndex = 16;
            // 
            // pbSeparatorsSet
            // 
            this.pbSeparatorsSet.Enabled = false;
            this.pbSeparatorsSet.Location = new System.Drawing.Point(338, 88);
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
            this.pbSeparatorsReset.Location = new System.Drawing.Point(380, 88);
            this.pbSeparatorsReset.Name = "pbSeparatorsReset";
            this.pbSeparatorsReset.Size = new System.Drawing.Size(47, 23);
            this.pbSeparatorsReset.TabIndex = 18;
            this.pbSeparatorsReset.Text = "Reset";
            this.pbSeparatorsReset.UseVisualStyleBackColor = true;
            this.pbSeparatorsReset.Click += new System.EventHandler(this.pbSeparatorsReset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 386);
            this.Controls.Add(this.pbSeparatorsReset);
            this.Controls.Add(this.pbSeparatorsSet);
            this.Controls.Add(this.tbSeparators);
            this.Controls.Add(this.cbRotSeparators);
            this.Controls.Add(this.tbFixedSeparator);
            this.Controls.Add(this.cbExtraInfo);
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
            this.Controls.Add(this.tbOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Pronounceable Password Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassToGen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutput;
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
        private System.Windows.Forms.CheckBox cbExtraInfo;
        private System.Windows.Forms.TextBox tbFixedSeparator;
        private System.Windows.Forms.CheckBox cbRotSeparators;
        private System.Windows.Forms.TextBox tbSeparators;
        private System.Windows.Forms.Button pbSeparatorsSet;
        private System.Windows.Forms.Button pbSeparatorsReset;
    }
}

