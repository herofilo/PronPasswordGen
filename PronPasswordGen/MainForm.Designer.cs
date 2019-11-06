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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbGenerate = new System.Windows.Forms.Button();
            this.nudPassLen = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPassToGen = new System.Windows.Forms.NumericUpDown();
            this.cbSpecials = new System.Windows.Forms.CheckBox();
            this.cbSeparators = new System.Windows.Forms.CheckBox();
            this.tbSpecials = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbSpecialsReset = new System.Windows.Forms.Button();
            this.tbFixedSeparator = new System.Windows.Forms.TextBox();
            this.cbRotSeparators = new System.Windows.Forms.CheckBox();
            this.tbSeparators = new System.Windows.Forms.TextBox();
            this.pbSeparatorsReset = new System.Windows.Forms.Button();
            this.pbStrengthMeter = new System.Windows.Forms.Button();
            this.pbSetup = new System.Windows.Forms.Button();
            this.dgvPasswords = new System.Windows.Forms.DataGridView();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStrength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStrengthValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCardinality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntropy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSepText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmPasswords = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmiCopyPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiStrengthDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCapMax = new System.Windows.Forms.Label();
            this.nudCapitalsMax = new System.Windows.Forms.NumericUpDown();
            this.lblSpecialMax = new System.Windows.Forms.Label();
            this.nudSpecialsMax = new System.Windows.Forms.NumericUpDown();
            this.cbBlanks = new System.Windows.Forms.CheckBox();
            this.pbHelp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCapitalsNone = new System.Windows.Forms.RadioButton();
            this.rbCapitalsFirst = new System.Windows.Forms.RadioButton();
            this.rbCapitalsLast = new System.Windows.Forms.RadioButton();
            this.rbCapitalsRandom = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassToGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswords)).BeginInit();
            this.cmPasswords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapitalsMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpecialsMax)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbGenerate
            // 
            this.pbGenerate.Location = new System.Drawing.Point(578, 144);
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
            // cbSpecials
            // 
            this.cbSpecials.AutoSize = true;
            this.cbSpecials.Checked = true;
            this.cbSpecials.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSpecials.Location = new System.Drawing.Point(16, 114);
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
            this.cbSeparators.Location = new System.Drawing.Point(16, 144);
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
            this.tbSpecials.Location = new System.Drawing.Point(300, 111);
            this.tbSpecials.Name = "tbSpecials";
            this.tbSpecials.Size = new System.Drawing.Size(140, 22);
            this.tbSpecials.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Specials:";
            // 
            // pbSpecialsReset
            // 
            this.pbSpecialsReset.Location = new System.Drawing.Point(446, 110);
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
            this.tbFixedSeparator.Location = new System.Drawing.Point(99, 139);
            this.tbFixedSeparator.MaxLength = 1;
            this.tbFixedSeparator.Name = "tbFixedSeparator";
            this.tbFixedSeparator.Size = new System.Drawing.Size(42, 22);
            this.tbFixedSeparator.TabIndex = 14;
            // 
            // cbRotSeparators
            // 
            this.cbRotSeparators.AutoSize = true;
            this.cbRotSeparators.Enabled = false;
            this.cbRotSeparators.Location = new System.Drawing.Point(159, 143);
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
            this.tbSeparators.Location = new System.Drawing.Point(256, 141);
            this.tbSeparators.Name = "tbSeparators";
            this.tbSeparators.Size = new System.Drawing.Size(105, 22);
            this.tbSeparators.TabIndex = 16;
            // 
            // pbSeparatorsReset
            // 
            this.pbSeparatorsReset.Enabled = false;
            this.pbSeparatorsReset.Location = new System.Drawing.Point(367, 140);
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
            this.pbSetup.Click += new System.EventHandler(this.pbSetup_Click);
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
            this.colRank,
            this.colLength,
            this.colSepText});
            this.dgvPasswords.ContextMenuStrip = this.cmPasswords;
            this.dgvPasswords.Location = new System.Drawing.Point(3, 173);
            this.dgvPasswords.MultiSelect = false;
            this.dgvPasswords.Name = "dgvPasswords";
            this.dgvPasswords.ReadOnly = true;
            this.dgvPasswords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPasswords.Size = new System.Drawing.Size(657, 302);
            this.dgvPasswords.TabIndex = 21;
            this.dgvPasswords.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPasswords_CellDoubleClick);
            this.dgvPasswords.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPasswords_DataBindingComplete);
            // 
            // colPassword
            // 
            this.colPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPassword.DataPropertyName = "Password";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPassword.DefaultCellStyle = dataGridViewCellStyle15;
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colStrengthValue.DefaultCellStyle = dataGridViewCellStyle16;
            this.colStrengthValue.HeaderText = "Val.";
            this.colStrengthValue.Name = "colStrengthValue";
            this.colStrengthValue.ReadOnly = true;
            this.colStrengthValue.Width = 50;
            // 
            // colCardinality
            // 
            this.colCardinality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCardinality.DataPropertyName = "Cardinality";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colCardinality.DefaultCellStyle = dataGridViewCellStyle17;
            this.colCardinality.HeaderText = "Cardin.";
            this.colCardinality.Name = "colCardinality";
            this.colCardinality.ReadOnly = true;
            this.colCardinality.Width = 65;
            // 
            // colEntropy
            // 
            this.colEntropy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEntropy.DataPropertyName = "Entropy";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "F1";
            dataGridViewCellStyle18.NullValue = null;
            this.colEntropy.DefaultCellStyle = dataGridViewCellStyle18;
            this.colEntropy.HeaderText = "H (bits)";
            this.colEntropy.Name = "colEntropy";
            this.colEntropy.ReadOnly = true;
            this.colEntropy.Width = 65;
            // 
            // colRank
            // 
            this.colRank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRank.DataPropertyName = "Rank";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colRank.DefaultCellStyle = dataGridViewCellStyle19;
            this.colRank.HeaderText = "Rank";
            this.colRank.Name = "colRank";
            this.colRank.ReadOnly = true;
            this.colRank.Width = 58;
            // 
            // colLength
            // 
            this.colLength.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLength.DataPropertyName = "Length";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colLength.DefaultCellStyle = dataGridViewCellStyle20;
            this.colLength.HeaderText = "Len.";
            this.colLength.Name = "colLength";
            this.colLength.ReadOnly = true;
            this.colLength.Width = 53;
            // 
            // colSepText
            // 
            this.colSepText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSepText.DataPropertyName = "SepText";
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Courier New", 9F);
            this.colSepText.DefaultCellStyle = dataGridViewCellStyle21;
            this.colSepText.HeaderText = "Chunks";
            this.colSepText.Name = "colSepText";
            this.colSepText.ReadOnly = true;
            this.colSepText.Width = 68;
            // 
            // cmPasswords
            // 
            this.cmPasswords.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiCopyPassword,
            this.tmiStrengthDetails});
            this.cmPasswords.Name = "cmPasswords";
            this.cmPasswords.Size = new System.Drawing.Size(230, 48);
            this.cmPasswords.Opening += new System.ComponentModel.CancelEventHandler(this.cmPasswords_Opening);
            // 
            // tmiCopyPassword
            // 
            this.tmiCopyPassword.Name = "tmiCopyPassword";
            this.tmiCopyPassword.Size = new System.Drawing.Size(229, 22);
            this.tmiCopyPassword.Text = "Copy Password to Clipboard";
            this.tmiCopyPassword.Click += new System.EventHandler(this.tmiCopyPassword_Click);
            // 
            // tmiStrengthDetails
            // 
            this.tmiStrengthDetails.Name = "tmiStrengthDetails";
            this.tmiStrengthDetails.Size = new System.Drawing.Size(229, 22);
            this.tmiStrengthDetails.Text = "Details of Strength Evaluation";
            this.tmiStrengthDetails.Click += new System.EventHandler(this.tmiStrengthDetails_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Alpha chars:";
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
            this.nudCapitalsMax.ValueChanged += new System.EventHandler(this.nudCapitalsMax_ValueChanged);
            // 
            // lblSpecialMax
            // 
            this.lblSpecialMax.AutoSize = true;
            this.lblSpecialMax.Location = new System.Drawing.Point(148, 115);
            this.lblSpecialMax.Name = "lblSpecialMax";
            this.lblSpecialMax.Size = new System.Drawing.Size(30, 13);
            this.lblSpecialMax.TabIndex = 30;
            this.lblSpecialMax.Text = "Max:";
            // 
            // nudSpecialsMax
            // 
            this.nudSpecialsMax.Location = new System.Drawing.Point(180, 113);
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
            this.nudSpecialsMax.TabIndex = 29;
            this.nudSpecialsMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSpecialsMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpecialsMax.ValueChanged += new System.EventHandler(this.nudSpecialsMax_ValueChanged);
            // 
            // cbBlanks
            // 
            this.cbBlanks.AutoSize = true;
            this.cbBlanks.Location = new System.Drawing.Point(511, 114);
            this.cbBlanks.Name = "cbBlanks";
            this.cbBlanks.Size = new System.Drawing.Size(101, 17);
            this.cbBlanks.TabIndex = 31;
            this.cbBlanks.Text = "Blanks (spaces)";
            this.cbBlanks.UseVisualStyleBackColor = true;
            // 
            // pbHelp
            // 
            this.pbHelp.Image = ((System.Drawing.Image)(resources.GetObject("pbHelp.Image")));
            this.pbHelp.Location = new System.Drawing.Point(547, 12);
            this.pbHelp.Name = "pbHelp";
            this.pbHelp.Size = new System.Drawing.Size(32, 32);
            this.pbHelp.TabIndex = 32;
            this.pbHelp.UseVisualStyleBackColor = true;
            this.pbHelp.Visible = false;
            this.pbHelp.Click += new System.EventHandler(this.pbHelp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCapitalsRandom);
            this.groupBox1.Controls.Add(this.rbCapitalsLast);
            this.groupBox1.Controls.Add(this.rbCapitalsFirst);
            this.groupBox1.Controls.Add(this.rbCapitalsNone);
            this.groupBox1.Controls.Add(this.nudCapitalsMax);
            this.groupBox1.Controls.Add(this.lblCapMax);
            this.groupBox1.Location = new System.Drawing.Point(84, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 66);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Capitals";
            // 
            // rbCapitalsNone
            // 
            this.rbCapitalsNone.AutoSize = true;
            this.rbCapitalsNone.Location = new System.Drawing.Point(6, 19);
            this.rbCapitalsNone.Name = "rbCapitalsNone";
            this.rbCapitalsNone.Size = new System.Drawing.Size(51, 17);
            this.rbCapitalsNone.TabIndex = 0;
            this.rbCapitalsNone.TabStop = true;
            this.rbCapitalsNone.Text = "None";
            this.rbCapitalsNone.UseVisualStyleBackColor = true;
            // 
            // rbCapitalsFirst
            // 
            this.rbCapitalsFirst.AutoSize = true;
            this.rbCapitalsFirst.Location = new System.Drawing.Point(73, 19);
            this.rbCapitalsFirst.Name = "rbCapitalsFirst";
            this.rbCapitalsFirst.Size = new System.Drawing.Size(93, 17);
            this.rbCapitalsFirst.TabIndex = 1;
            this.rbCapitalsFirst.TabStop = true;
            this.rbCapitalsFirst.Text = "First in chunks";
            this.rbCapitalsFirst.UseVisualStyleBackColor = true;
            // 
            // rbCapitalsLast
            // 
            this.rbCapitalsLast.AutoSize = true;
            this.rbCapitalsLast.Location = new System.Drawing.Point(73, 43);
            this.rbCapitalsLast.Name = "rbCapitalsLast";
            this.rbCapitalsLast.Size = new System.Drawing.Size(94, 17);
            this.rbCapitalsLast.TabIndex = 27;
            this.rbCapitalsLast.TabStop = true;
            this.rbCapitalsLast.Text = "Last in chunks";
            this.rbCapitalsLast.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 476);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbHelp);
            this.Controls.Add(this.cbBlanks);
            this.Controls.Add(this.lblSpecialMax);
            this.Controls.Add(this.nudSpecialsMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPasswords);
            this.Controls.Add(this.pbSetup);
            this.Controls.Add(this.pbStrengthMeter);
            this.Controls.Add(this.pbSeparatorsReset);
            this.Controls.Add(this.tbSeparators);
            this.Controls.Add(this.cbRotSeparators);
            this.Controls.Add(this.tbFixedSeparator);
            this.Controls.Add(this.pbSpecialsReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSpecials);
            this.Controls.Add(this.cbSeparators);
            this.Controls.Add(this.cbSpecials);
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
            this.cmPasswords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCapitalsMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpecialsMax)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pbGenerate;
        private System.Windows.Forms.NumericUpDown nudPassLen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPassToGen;
        private System.Windows.Forms.CheckBox cbSpecials;
        private System.Windows.Forms.CheckBox cbSeparators;
        private System.Windows.Forms.TextBox tbSpecials;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pbSpecialsReset;
        private System.Windows.Forms.TextBox tbFixedSeparator;
        private System.Windows.Forms.CheckBox cbRotSeparators;
        private System.Windows.Forms.TextBox tbSeparators;
        private System.Windows.Forms.Button pbSeparatorsReset;
        private System.Windows.Forms.Button pbStrengthMeter;
        private System.Windows.Forms.Button pbSetup;
        private System.Windows.Forms.DataGridView dgvPasswords;
        private System.Windows.Forms.ContextMenuStrip cmPasswords;
        private System.Windows.Forms.ToolStripMenuItem tmiCopyPassword;
        private System.Windows.Forms.ToolStripMenuItem tmiStrengthDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStrength;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStrengthValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCardinality;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntropy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSepText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCapMax;
        private System.Windows.Forms.NumericUpDown nudCapitalsMax;
        private System.Windows.Forms.Label lblSpecialMax;
        private System.Windows.Forms.NumericUpDown nudSpecialsMax;
        private System.Windows.Forms.CheckBox cbBlanks;
        private System.Windows.Forms.Button pbHelp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCapitalsFirst;
        private System.Windows.Forms.RadioButton rbCapitalsNone;
        private System.Windows.Forms.RadioButton rbCapitalsRandom;
        private System.Windows.Forms.RadioButton rbCapitalsLast;
    }
}

