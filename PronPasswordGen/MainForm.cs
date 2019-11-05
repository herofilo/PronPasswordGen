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


            // tbOutput.Clear();
            PasswordCollection passwords = new PasswordCollection();

            for (int count = 0; count < nudPassToGen.Value; ++count)
            {
                string password = _passwordGenerator.Generate((int)nudPassLen.Value, options, fixedSeparator);
                passwords.Append(_passwordGenerator.LastPassword);
            }

            dgvPasswords.AutoGenerateColumns = false;

            var bindingList = new SortableBindingList<PasswordCollectionItem>(passwords.Passwords);
            BindingSource source = new BindingSource(bindingList, null);
            dgvPasswords.DataSource = source;
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


        // --------------------------------------------------------------------------------------------------------------

        private void pbStrengthMeter_Click(object sender, EventArgs e)
        {
            StrengthMeterForm form = new StrengthMeterForm();
            form.ShowDialog(this);
        }


        
        private void dgvPasswords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayStrengthEvaluationDetails();
        }


        private void DisplayStrengthEvaluationDetails()
        {
            string password = GetSelectedPassword();
            if (password == null)
                return;

            StrengthMeterForm form = new StrengthMeterForm(password);
            form.ShowDialog(this);
        }


        private string GetSelectedPassword()
        {
            if ((dgvPasswords.SelectedRows == null) || (dgvPasswords.SelectedRows.Count == 0))
                return null;

            return (string) dgvPasswords.SelectedRows[0].Cells["colPassword"].Value;
        }




        private void cmPasswords_Opening(object sender, CancelEventArgs e)
        {
            if (dgvPasswords.RowCount == 0)
                e.Cancel = true;
        }

        private void tmiCopyPassword_Click(object sender, EventArgs e)
        {
            string password = GetSelectedPassword();
            if (password == null)
                return;

            Clipboard.Clear();
            Clipboard.SetText(password);
        }

        private void tmiStrengthDetails_Click(object sender, EventArgs e)
        {
            DisplayStrengthEvaluationDetails();
        }


        
        private void dgvPasswords_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvPasswords.Rows)
            {
                DataGridViewCell cell = row.Cells["colStrength"];

                string strength = (string) cell.Value;
                

                switch (strength.ToLower())
                {
                    case "very weak": cell.Style.BackColor = Color.Red; cell.Style.ForeColor = Color.White; break;
                    case "weak": cell.Style.BackColor = Color.Orange; cell.Style.ForeColor = Color.Black; break;
                    case "good": cell.Style.BackColor = Color.Yellow; cell.Style.ForeColor = Color.Black; break;
                    case "strong": cell.Style.BackColor = Color.GreenYellow; cell.Style.ForeColor = Color.Black; break;
                    case "very strong": cell.Style.BackColor = Color.Green; cell.Style.ForeColor = Color.White; break;
                }
            }
        }
    }
}
