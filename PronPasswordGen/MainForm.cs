using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PronPasswordGen.Domain;
using PronPasswordGen.Domain.Generator;
using PronPasswordGen.Domain.StrengthMeter;
using PronPasswordGen.Util;

namespace PronPasswordGen
{
    public partial class MainForm : Form
    {

        private PasswordGenerator _passwordGenerator = new PasswordGenerator();

        private PasswordStrength _passwordStrengthMeter = new PasswordStrength();

        // ---------------------------------------------------------------------------

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = $@"Pronounceable Password Generator  (version {Utils.GetExecutableVersion()})";

            tbSpecials.Text = PasswordChunkGeneratorBase.Specials;
            tbFixedSeparator.Text = PasswordGenerator.SeparatorsDefault.Substring(0, 1);
            tbSeparators.Text = PasswordGenerator.SeparatorsDefault;
        }

        private void pbGenerate_Click(object sender, EventArgs e)
        {
            PasswordGeneratorOptions options = PasswordGeneratorOptions.None;
            if (cbCapitals.Checked)
                options |= PasswordGeneratorOptions.Capitals;
            if (cbSpecials.Checked)
                options |= PasswordGeneratorOptions.Specials;

            if(string.IsNullOrEmpty(tbFixedSeparator.Text))
                tbFixedSeparator.Text = PasswordGenerator.SeparatorsDefault.Substring(0, 1);

            char fixedSeparator = tbFixedSeparator.Text[0];
            if (cbSeparators.Checked)
            {
                options |= PasswordGeneratorOptions.Separators;
                if (cbRotSeparators.Checked)
                    options |= PasswordGeneratorOptions.SeparatorRotation;
            }


            tbOutput.Clear();

            for (int count = 0; count < nudPassToGen.Value; ++count)
            {
                string password = _passwordGenerator.Generate((int)nudPassLen.Value, options, fixedSeparator);
                if (!cbExtraInfo.Checked)
                {
                    tbOutput.AppendText($"{password}\n");
                    continue;
                }

                _passwordStrengthMeter.SetPassword(password);
                int strengthScore = _passwordStrengthMeter.GetPasswordScore();
                string strength = _passwordStrengthMeter.GetPasswordStrength();
                // DataTable strengthDetails =  _passwordStrengthMeter.GetStrengthDetails();
                string sepPassword = _passwordGenerator.LastPassword.TextDelimited.Replace("\t", " ");
                tbOutput.AppendText($"{password}       [len={password.Length} strength={strength} ({strengthScore})   {sepPassword}]\n");
            }
        }

        private void pbSpecialSet_Click(object sender, EventArgs e)
        {
            PasswordChunkGeneratorBase.Specials = tbSpecials.Text;
            tbSpecials.Text = PasswordChunkGeneratorBase.Specials;
        }

        private void pbSpecialsReset_Click(object sender, EventArgs e)
        {
            PasswordChunkGeneratorBase.Specials = null;
            tbSpecials.Text = PasswordChunkGeneratorBase.Specials;
        }

        private void cbSeparators_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSeparators.Checked)
            {
                tbFixedSeparator.Enabled = cbRotSeparators.Enabled = true;
                return;
            }

            tbFixedSeparator.Enabled = tbSeparators.Enabled = cbRotSeparators.Enabled = cbRotSeparators.Checked = pbSeparatorsSet.Enabled = pbSeparatorsReset.Enabled = false;
        }

        private void cbRotSeparators_CheckedChanged(object sender, EventArgs e)
        {
            tbSeparators.Enabled = pbSeparatorsSet.Enabled = pbSeparatorsReset.Enabled = cbRotSeparators.Checked;
        }

        private void cbSpecials_CheckedChanged(object sender, EventArgs e)
        {
            tbSpecials.Enabled = pbSpecialSet.Enabled = pbSpecialsReset.Enabled = cbSpecials.Checked;
        }

        private void pbSeparatorsSet_Click(object sender, EventArgs e)
        {
            PasswordGenerator.Separators = tbSeparators.Text;
            tbSeparators.Text = PasswordGenerator.Separators;
        }

        private void pbSeparatorsReset_Click(object sender, EventArgs e)
        {
            PasswordGenerator.Separators = null;
            tbSeparators.Text = PasswordGenerator.Separators;
        }
    }
}
