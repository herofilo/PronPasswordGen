using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PronPasswordGen.Configuration;
using PronPasswordGen.Domain;
using PronPasswordGen.Domain.Generator;
using PronPasswordGen.Domain.StrengthMeter;
using PronPasswordGen.Util;

namespace PronPasswordGen
{
    public partial class MainForm : Form
    {

        private ApplicationConfiguration _configuration = null;

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

            InitializeOptions();
        }


        #region InitializationRegion

        private void InitializeOptions()
        {
            nudPassLen.Value = PasswordGenerator.PasswordDefaultLength;


            nudCapitalsMax.Value = PasswordGenerator.CapitalsMaximumDefault;


            tbSpecials.Text = PasswordChunkGeneratorBase.Specials;
            nudSpecialsMax.Value = PasswordGenerator.SpecialGroupsMaxDefault;

            tbFixedSeparator.Text = PasswordGenerator.SeparatorsDefault.Substring(0, 1);
            tbSeparators.Text = PasswordGenerator.SeparatorsDefault;


            LoadConfiguration();
            if (_configuration != null)
                ApplyConfiguration();

        }


        private void LoadConfiguration()
        {
            string errorText;
            if (!File.Exists(ApplicationConfiguration.ConfigurationFilePath))
            {
                ApplicationConfiguration configuration = CreateDefaultConfiguration();
                configuration.Save(ApplicationConfiguration.ConfigurationFilePath, out errorText);
                _configuration = configuration;
                return;
            }

            _configuration = ApplicationConfiguration.Load(out errorText);
        }

        private ApplicationConfiguration CreateDefaultConfiguration()
        {
            ApplicationConfiguration configuration = new ApplicationConfiguration()
            {
                PasswordLength = PasswordGenerator.PasswordDefaultLength,
                PasswordCount = 10,
                Options = new PasswordGeneratorOptionsEx(),
                ChunkTypeWeights = PasswordChunkTypeWeight.GetChunkTypeWeights(PasswordChunkTypeWeight.ChunkTypeProbabilityDefault)
            };
            configuration.Options.Options |= PasswordGeneratorOptions.Capitals | PasswordGeneratorOptions.Specials;

            return configuration;
        }


        private void ApplyConfiguration()
        {
            nudPassLen.Value = _configuration.PasswordLength;
            nudPassToGen.Value = _configuration.PasswordCount;

            // cbCapitals.Checked = _configuration.Options.Options.HasFlag(PasswordGeneratorOptions.Capitals);
            if (!_configuration.Options.Options.HasFlag(PasswordGeneratorOptions.Capitals))
                rbCapitalsNone.Checked = true;
            else
            {
                if (_configuration.Options.Options.HasFlag(PasswordGeneratorOptions.CapitalsFirstInChunks))
                    rbCapitalsFirst.Checked = true;
                else if (_configuration.Options.Options.HasFlag(PasswordGeneratorOptions.CapitalsLastInChunks))
                    rbCapitalsLast.Checked = true;
                else
                    rbCapitalsRandom.Checked = true;
            }


            nudCapitalsMax.Value = _configuration.Options.CapitalsMaximum;

            cbSpecials.Checked = _configuration.Options.Options.HasFlag(PasswordGeneratorOptions.Specials);
            cbBlanks.Checked = !_configuration.Options.Options.HasFlag(PasswordGeneratorOptions.SpecialsNotBlank);
            tbSpecials.Text = _configuration.Options.SpecialGroupSymbols;
            nudSpecialsMax.Value = _configuration.Options.SpecialGroupsMax;

            cbSeparators.Checked = _configuration.Options.Options.HasFlag(PasswordGeneratorOptions.Separators);
            cbRotSeparators.Checked = _configuration.Options.Options.HasFlag(PasswordGeneratorOptions.SeparatorRotation);
            tbFixedSeparator.Text = $"{_configuration.Options.FixedSeparatorChar}";
            tbSeparators.Text = _configuration.Options.RotatingSeparators;

            _passwordGenerator.SetChunkTypeWeights(_configuration.ChunkTypeWeights);
        }



        #endregion InitializationRegion

        #region MainFormControls

        private void pbSpecialSet_Click(object sender, EventArgs e)
        {

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

            tbFixedSeparator.Enabled = tbSeparators.Enabled = cbRotSeparators.Enabled = cbRotSeparators.Checked = pbSeparatorsReset.Enabled = false;
        }

        private void cbRotSeparators_CheckedChanged(object sender, EventArgs e)
        {
            tbSeparators.Enabled = pbSeparatorsReset.Enabled = cbRotSeparators.Checked;
        }

        private void cbSpecials_CheckedChanged(object sender, EventArgs e)
        {
            tbSpecials.Enabled = pbSpecialsReset.Enabled =
                lblSpecialMax.Enabled = nudSpecialsMax.Enabled = cbSpecials.Checked;
        }


        private void pbSeparatorsReset_Click(object sender, EventArgs e)
        {
            PasswordGenerator.Separators = null;
            tbSeparators.Text = PasswordGenerator.Separators;
        }





        private void nudCapitalsMax_ValueChanged(object sender, EventArgs e)
        {
        }


        private void nudSpecialsMax_ValueChanged(object sender, EventArgs e)
        {

        }

        #endregion MainFormControls

        // -------------------------------------------------------------------------------------------------------------------------------------------

        #region GeneratePasswords

        private void pbGenerate_Click(object sender, EventArgs e)
        {
            PasswordGeneratorOptions options = PasswordGeneratorOptions.None;

            if(rbCapitalsFirst.Checked)
                options |= PasswordGeneratorOptions.Capitals | PasswordGeneratorOptions.CapitalsFirstInChunks; 
            else if (rbCapitalsLast.Checked)
                options |= PasswordGeneratorOptions.Capitals | PasswordGeneratorOptions.CapitalsLastInChunks;
            else if (rbCapitalsRandom.Checked)
                options |= PasswordGeneratorOptions.Capitals;
            
            // if (cbCapitals.Checked)
            //    options |= PasswordGeneratorOptions.Capitals;
            if (cbSpecials.Checked)
            {
                options |= PasswordGeneratorOptions.Specials;
                if (!cbBlanks.Checked)
                    options |= PasswordGeneratorOptions.SpecialsNotBlank;
            }

            if (string.IsNullOrEmpty(tbFixedSeparator.Text))
                tbFixedSeparator.Text = PasswordGenerator.SeparatorsDefault.Substring(0, 1);

            char fixedSeparator = tbFixedSeparator.Text[0];
            if (cbSeparators.Checked)
            {
                options |= PasswordGeneratorOptions.Separators;
                if (cbRotSeparators.Checked)
                    options |= PasswordGeneratorOptions.SeparatorRotation;
            }

            PasswordGeneratorOptionsEx optionsEx = new PasswordGeneratorOptionsEx()
            {
                Options = options,
                CapitalsMinimum = 1,
                CapitalsMaximum = (int)nudCapitalsMax.Value,
                SpecialGroupSymbols = tbSpecials.Text,
                SpecialGroupsMin = 1,
                SpecialGroupsMax = (int)nudSpecialsMax.Value,
                FixedSeparatorChar = fixedSeparator,
                RotatingSeparators = tbSeparators.Text
            };


            PasswordCollection passwords = new PasswordCollection();

            for (int count = 0; count < nudPassToGen.Value; ++count)
            {
                string password = _passwordGenerator.Generate((int)nudPassLen.Value, optionsEx);
                passwords.Append(_passwordGenerator.LastPassword);
            }

            dgvPasswords.AutoGenerateColumns = false;

            var bindingList = new SortableBindingList<PasswordCollectionItem>(passwords.Passwords);
            BindingSource source = new BindingSource(bindingList, null);
            dgvPasswords.DataSource = source;
        }

        private void dgvPasswords_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvPasswords.Rows)
            {
                DataGridViewCell cell = row.Cells["colStrength"];

                string strength = (string)cell.Value;


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


        #endregion GeneratePasswords

        #region PasswordDataGrid

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

            return (string)dgvPasswords.SelectedRows[0].Cells["colPassword"].Value;
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

        #endregion PasswordDataGrid

        #region FormButtons

        // --------------------------------------------------------------------------------------------------------------

        private void pbStrengthMeter_Click(object sender, EventArgs e)
        {
            StrengthMeterForm form = new StrengthMeterForm();
            form.ShowDialog(this);
        }

        private void pbSetup_Click(object sender, EventArgs e)
        {
            SetupForm form = new SetupForm(_configuration);
            if (form.ShowDialog(this) != DialogResult.OK)
                return;

            if (form.NewConfiguration != null)
            {
                _configuration = form.NewConfiguration;
                ApplyConfiguration();
            }
        }

        private void pbHelp_Click(object sender, EventArgs e)
        {
            HelpForm form = new HelpForm();
            form.Show(this);
        }



        #endregion FormButtons


    }
}
