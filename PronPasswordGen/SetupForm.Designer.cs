namespace PronPasswordGen
{
    partial class SetupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupForm));
            this.label4 = new System.Windows.Forms.Label();
            this.nudPassToGen = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPassLen = new System.Windows.Forms.NumericUpDown();
            this.lblSpecialMax = new System.Windows.Forms.Label();
            this.nudSpecialsMax = new System.Windows.Forms.NumericUpDown();
            this.pbSeparatorsReset = new System.Windows.Forms.Button();
            this.tbSeparators = new System.Windows.Forms.TextBox();
            this.cbRotSeparators = new System.Windows.Forms.CheckBox();
            this.tbFixedSeparator = new System.Windows.Forms.TextBox();
            this.pbSpecialsReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSpecials = new System.Windows.Forms.TextBox();
            this.cbSeparators = new System.Windows.Forms.CheckBox();
            this.cbSpecials = new System.Windows.Forms.CheckBox();
            this.cbBlanks = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudLiquid = new System.Windows.Forms.NumericUpDown();
            this.nudMixed = new System.Windows.Forms.NumericUpDown();
            this.nudInvertedDip = new System.Windows.Forms.NumericUpDown();
            this.nudInverted = new System.Windows.Forms.NumericUpDown();
            this.nudDirectDip = new System.Windows.Forms.NumericUpDown();
            this.nudDirect = new System.Windows.Forms.NumericUpDown();
            this.pbAdjust = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbSave = new System.Windows.Forms.Button();
            this.pbCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCapitalsRandom = new System.Windows.Forms.RadioButton();
            this.rbCapitalsLast = new System.Windows.Forms.RadioButton();
            this.rbCapitalsFirst = new System.Windows.Forms.RadioButton();
            this.rbCapitalsNone = new System.Windows.Forms.RadioButton();
            this.nudCapitalsMax = new System.Windows.Forms.NumericUpDown();
            this.lblCapMax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassToGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpecialsMax)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLiquid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMixed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvertedDip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInverted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDirectDip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDirect)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapitalsMax)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Alpha chars:";
            // 
            // nudPassToGen
            // 
            this.nudPassToGen.Location = new System.Drawing.Point(404, 16);
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
            this.nudPassToGen.TabIndex = 30;
            this.nudPassToGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPassToGen.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Number of passwords to generate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Password Length (min):";
            // 
            // nudPassLen
            // 
            this.nudPassLen.Location = new System.Drawing.Point(129, 16);
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
            this.nudPassLen.TabIndex = 27;
            this.nudPassLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPassLen.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblSpecialMax
            // 
            this.lblSpecialMax.AutoSize = true;
            this.lblSpecialMax.Location = new System.Drawing.Point(149, 162);
            this.lblSpecialMax.Name = "lblSpecialMax";
            this.lblSpecialMax.Size = new System.Drawing.Size(30, 13);
            this.lblSpecialMax.TabIndex = 49;
            this.lblSpecialMax.Text = "Max:";
            // 
            // nudSpecialsMax
            // 
            this.nudSpecialsMax.Location = new System.Drawing.Point(181, 160);
            this.nudSpecialsMax.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudSpecialsMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpecialsMax.Name = "nudSpecialsMax";
            this.nudSpecialsMax.Size = new System.Drawing.Size(46, 20);
            this.nudSpecialsMax.TabIndex = 48;
            this.nudSpecialsMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSpecialsMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pbSeparatorsReset
            // 
            this.pbSeparatorsReset.Enabled = false;
            this.pbSeparatorsReset.Location = new System.Drawing.Point(366, 204);
            this.pbSeparatorsReset.Name = "pbSeparatorsReset";
            this.pbSeparatorsReset.Size = new System.Drawing.Size(47, 23);
            this.pbSeparatorsReset.TabIndex = 45;
            this.pbSeparatorsReset.Text = "Reset";
            this.pbSeparatorsReset.UseVisualStyleBackColor = true;
            // 
            // tbSeparators
            // 
            this.tbSeparators.Enabled = false;
            this.tbSeparators.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSeparators.Location = new System.Drawing.Point(255, 205);
            this.tbSeparators.Name = "tbSeparators";
            this.tbSeparators.Size = new System.Drawing.Size(105, 22);
            this.tbSeparators.TabIndex = 44;
            // 
            // cbRotSeparators
            // 
            this.cbRotSeparators.AutoSize = true;
            this.cbRotSeparators.Enabled = false;
            this.cbRotSeparators.Location = new System.Drawing.Point(158, 207);
            this.cbRotSeparators.Name = "cbRotSeparators";
            this.cbRotSeparators.Size = new System.Drawing.Size(91, 17);
            this.cbRotSeparators.TabIndex = 43;
            this.cbRotSeparators.Text = "Sep. Rotation";
            this.cbRotSeparators.UseVisualStyleBackColor = true;
            // 
            // tbFixedSeparator
            // 
            this.tbFixedSeparator.Enabled = false;
            this.tbFixedSeparator.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFixedSeparator.Location = new System.Drawing.Point(98, 203);
            this.tbFixedSeparator.MaxLength = 1;
            this.tbFixedSeparator.Name = "tbFixedSeparator";
            this.tbFixedSeparator.Size = new System.Drawing.Size(42, 22);
            this.tbFixedSeparator.TabIndex = 42;
            // 
            // pbSpecialsReset
            // 
            this.pbSpecialsReset.Location = new System.Drawing.Point(369, 132);
            this.pbSpecialsReset.Name = "pbSpecialsReset";
            this.pbSpecialsReset.Size = new System.Drawing.Size(47, 23);
            this.pbSpecialsReset.TabIndex = 41;
            this.pbSpecialsReset.Text = "Reset";
            this.pbSpecialsReset.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Specials:";
            // 
            // tbSpecials
            // 
            this.tbSpecials.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSpecials.Location = new System.Drawing.Point(223, 133);
            this.tbSpecials.Name = "tbSpecials";
            this.tbSpecials.Size = new System.Drawing.Size(140, 22);
            this.tbSpecials.TabIndex = 39;
            // 
            // cbSeparators
            // 
            this.cbSeparators.AutoSize = true;
            this.cbSeparators.Location = new System.Drawing.Point(15, 208);
            this.cbSeparators.Name = "cbSeparators";
            this.cbSeparators.Size = new System.Drawing.Size(77, 17);
            this.cbSeparators.TabIndex = 38;
            this.cbSeparators.Text = "Separators";
            this.cbSeparators.UseVisualStyleBackColor = true;
            // 
            // cbSpecials
            // 
            this.cbSpecials.AutoSize = true;
            this.cbSpecials.Checked = true;
            this.cbSpecials.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSpecials.Location = new System.Drawing.Point(18, 136);
            this.cbSpecials.Name = "cbSpecials";
            this.cbSpecials.Size = new System.Drawing.Size(125, 17);
            this.cbSpecials.TabIndex = 37;
            this.cbSpecials.Text = "Ciphers and Specials";
            this.cbSpecials.UseVisualStyleBackColor = true;
            // 
            // cbBlanks
            // 
            this.cbBlanks.AutoSize = true;
            this.cbBlanks.Location = new System.Drawing.Point(258, 161);
            this.cbBlanks.Name = "cbBlanks";
            this.cbBlanks.Size = new System.Drawing.Size(101, 17);
            this.cbBlanks.TabIndex = 50;
            this.cbBlanks.Text = "Blanks (spaces)";
            this.cbBlanks.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudLiquid);
            this.groupBox1.Controls.Add(this.nudMixed);
            this.groupBox1.Controls.Add(this.nudInvertedDip);
            this.groupBox1.Controls.Add(this.nudInverted);
            this.groupBox1.Controls.Add(this.nudDirectDip);
            this.groupBox1.Controls.Add(this.nudDirect);
            this.groupBox1.Controls.Add(this.pbAdjust);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(14, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 148);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weights of Password Chunks";
            // 
            // nudLiquid
            // 
            this.nudLiquid.Location = new System.Drawing.Point(66, 121);
            this.nudLiquid.Name = "nudLiquid";
            this.nudLiquid.Size = new System.Drawing.Size(51, 20);
            this.nudLiquid.TabIndex = 36;
            this.nudLiquid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudMixed
            // 
            this.nudMixed.Location = new System.Drawing.Point(66, 91);
            this.nudMixed.Name = "nudMixed";
            this.nudMixed.Size = new System.Drawing.Size(51, 20);
            this.nudMixed.TabIndex = 35;
            this.nudMixed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudInvertedDip
            // 
            this.nudInvertedDip.Location = new System.Drawing.Point(276, 62);
            this.nudInvertedDip.Name = "nudInvertedDip";
            this.nudInvertedDip.Size = new System.Drawing.Size(51, 20);
            this.nudInvertedDip.TabIndex = 34;
            this.nudInvertedDip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudInverted
            // 
            this.nudInverted.Location = new System.Drawing.Point(66, 62);
            this.nudInverted.Name = "nudInverted";
            this.nudInverted.Size = new System.Drawing.Size(51, 20);
            this.nudInverted.TabIndex = 33;
            this.nudInverted.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudDirectDip
            // 
            this.nudDirectDip.Location = new System.Drawing.Point(276, 30);
            this.nudDirectDip.Name = "nudDirectDip";
            this.nudDirectDip.Size = new System.Drawing.Size(51, 20);
            this.nudDirectDip.TabIndex = 32;
            this.nudDirectDip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudDirect
            // 
            this.nudDirect.Location = new System.Drawing.Point(66, 30);
            this.nudDirect.Name = "nudDirect";
            this.nudDirect.Size = new System.Drawing.Size(51, 20);
            this.nudDirect.TabIndex = 31;
            this.nudDirect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pbAdjust
            // 
            this.pbAdjust.Location = new System.Drawing.Point(224, 113);
            this.pbAdjust.Name = "pbAdjust";
            this.pbAdjust.Size = new System.Drawing.Size(75, 23);
            this.pbAdjust.TabIndex = 12;
            this.pbAdjust.Text = "Adjust";
            this.pbAdjust.UseVisualStyleBackColor = true;
            this.pbAdjust.Click += new System.EventHandler(this.pbAdjust_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Liquid:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mixed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Inverted with Diphtongue:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Inverted:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Direct with Diphtongue:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Direct:";
            // 
            // pbSave
            // 
            this.pbSave.Location = new System.Drawing.Point(387, 328);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(75, 23);
            this.pbSave.TabIndex = 52;
            this.pbSave.Text = "Save";
            this.pbSave.UseVisualStyleBackColor = true;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // pbCancel
            // 
            this.pbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.pbCancel.Location = new System.Drawing.Point(387, 362);
            this.pbCancel.Name = "pbCancel";
            this.pbCancel.Size = new System.Drawing.Size(75, 23);
            this.pbCancel.TabIndex = 53;
            this.pbCancel.Text = "Cancel";
            this.pbCancel.UseVisualStyleBackColor = true;
            this.pbCancel.Click += new System.EventHandler(this.pbCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCapitalsRandom);
            this.groupBox2.Controls.Add(this.rbCapitalsLast);
            this.groupBox2.Controls.Add(this.rbCapitalsFirst);
            this.groupBox2.Controls.Add(this.rbCapitalsNone);
            this.groupBox2.Controls.Add(this.nudCapitalsMax);
            this.groupBox2.Controls.Add(this.lblCapMax);
            this.groupBox2.Location = new System.Drawing.Point(80, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 66);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Capitals";
            // 
            // rbCapitalsRandom
            // 
            this.rbCapitalsRandom.AutoSize = true;
            this.rbCapitalsRandom.Checked = true;
            this.rbCapitalsRandom.Location = new System.Drawing.Point(181, 19);
            this.rbCapitalsRandom.Name = "rbCapitalsRandom";
            this.rbCapitalsRandom.Size = new System.Drawing.Size(65, 17);
            this.rbCapitalsRandom.TabIndex = 28;
            this.rbCapitalsRandom.TabStop = true;
            this.rbCapitalsRandom.Text = "Random";
            this.rbCapitalsRandom.UseVisualStyleBackColor = true;
            // 
            // rbCapitalsLast
            // 
            this.rbCapitalsLast.AutoSize = true;
            this.rbCapitalsLast.Location = new System.Drawing.Point(73, 43);
            this.rbCapitalsLast.Name = "rbCapitalsLast";
            this.rbCapitalsLast.Size = new System.Drawing.Size(94, 17);
            this.rbCapitalsLast.TabIndex = 27;
            this.rbCapitalsLast.Text = "Last in chunks";
            this.rbCapitalsLast.UseVisualStyleBackColor = true;
            // 
            // rbCapitalsFirst
            // 
            this.rbCapitalsFirst.AutoSize = true;
            this.rbCapitalsFirst.Location = new System.Drawing.Point(73, 19);
            this.rbCapitalsFirst.Name = "rbCapitalsFirst";
            this.rbCapitalsFirst.Size = new System.Drawing.Size(93, 17);
            this.rbCapitalsFirst.TabIndex = 1;
            this.rbCapitalsFirst.Text = "First in chunks";
            this.rbCapitalsFirst.UseVisualStyleBackColor = true;
            // 
            // rbCapitalsNone
            // 
            this.rbCapitalsNone.AutoSize = true;
            this.rbCapitalsNone.Location = new System.Drawing.Point(6, 19);
            this.rbCapitalsNone.Name = "rbCapitalsNone";
            this.rbCapitalsNone.Size = new System.Drawing.Size(51, 17);
            this.rbCapitalsNone.TabIndex = 0;
            this.rbCapitalsNone.Text = "None";
            this.rbCapitalsNone.UseVisualStyleBackColor = true;
            // 
            // nudCapitalsMax
            // 
            this.nudCapitalsMax.Location = new System.Drawing.Point(298, 19);
            this.nudCapitalsMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapitalsMax.Name = "nudCapitalsMax";
            this.nudCapitalsMax.Size = new System.Drawing.Size(46, 20);
            this.nudCapitalsMax.TabIndex = 25;
            this.nudCapitalsMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCapitalsMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCapMax
            // 
            this.lblCapMax.AutoSize = true;
            this.lblCapMax.Location = new System.Drawing.Point(262, 21);
            this.lblCapMax.Name = "lblCapMax";
            this.lblCapMax.Size = new System.Drawing.Size(30, 13);
            this.lblCapMax.TabIndex = 26;
            this.lblCapMax.Text = "Max:";
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.pbCancel;
            this.ClientSize = new System.Drawing.Size(472, 403);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pbCancel);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbBlanks);
            this.Controls.Add(this.lblSpecialMax);
            this.Controls.Add(this.nudSpecialsMax);
            this.Controls.Add(this.pbSeparatorsReset);
            this.Controls.Add(this.tbSeparators);
            this.Controls.Add(this.cbRotSeparators);
            this.Controls.Add(this.tbFixedSeparator);
            this.Controls.Add(this.pbSpecialsReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSpecials);
            this.Controls.Add(this.cbSeparators);
            this.Controls.Add(this.cbSpecials);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudPassToGen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPassLen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SetupForm";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.SetupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPassToGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpecialsMax)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLiquid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMixed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvertedDip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInverted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDirectDip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDirect)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapitalsMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPassToGen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPassLen;
        private System.Windows.Forms.Label lblSpecialMax;
        private System.Windows.Forms.NumericUpDown nudSpecialsMax;
        private System.Windows.Forms.Button pbSeparatorsReset;
        private System.Windows.Forms.TextBox tbSeparators;
        private System.Windows.Forms.CheckBox cbRotSeparators;
        private System.Windows.Forms.TextBox tbFixedSeparator;
        private System.Windows.Forms.Button pbSpecialsReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSpecials;
        private System.Windows.Forms.CheckBox cbSeparators;
        private System.Windows.Forms.CheckBox cbSpecials;
        private System.Windows.Forms.CheckBox cbBlanks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button pbAdjust;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button pbSave;
        private System.Windows.Forms.Button pbCancel;
        private System.Windows.Forms.NumericUpDown nudLiquid;
        private System.Windows.Forms.NumericUpDown nudMixed;
        private System.Windows.Forms.NumericUpDown nudInvertedDip;
        private System.Windows.Forms.NumericUpDown nudInverted;
        private System.Windows.Forms.NumericUpDown nudDirectDip;
        private System.Windows.Forms.NumericUpDown nudDirect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbCapitalsRandom;
        private System.Windows.Forms.RadioButton rbCapitalsLast;
        private System.Windows.Forms.RadioButton rbCapitalsFirst;
        private System.Windows.Forms.RadioButton rbCapitalsNone;
        private System.Windows.Forms.NumericUpDown nudCapitalsMax;
        private System.Windows.Forms.Label lblCapMax;
    }
}