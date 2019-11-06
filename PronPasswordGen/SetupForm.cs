using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PronPasswordGen.Configuration;
using PronPasswordGen.Domain;
using PronPasswordGen.Domain.Generator;

namespace PronPasswordGen
{
    public partial class SetupForm : Form
    {
        private ApplicationConfiguration _configuration;

        public ApplicationConfiguration NewConfiguration { get; private set; }


        public SetupForm(ApplicationConfiguration pConfiguration)
        {
            _configuration = pConfiguration;
            InitializeComponent();
        }

        private void SetupForm_Load(object sender, EventArgs e)
        {
            SetCurrentValues();
        }

        private void SetCurrentValues()
        {
            nudPassLen.Value = _configuration.PasswordLength;
            nudPassToGen.Value = _configuration.PasswordCount;

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

            if ((_configuration.ChunkTypeWeights == null) || (_configuration.ChunkTypeWeights.Count == 0))
            {
                _configuration.ChunkTypeWeights =
                    PasswordChunkTypeWeight.GetChunkTypeWeights(PasswordChunkTypeWeight.ChunkTypeProbabilityDefault);
            }

            Dictionary<PasswordChunkType, int> weights =
                PasswordChunkTypeWeight.ChunkTypeWeightsToProbabilities(_configuration.ChunkTypeWeights);


            weights = PasswordChunkTypeWeight.GetAdjusted(weights);

            RefreshWeights(weights);
        }


        private void RefreshWeights(Dictionary<PasswordChunkType, int> pWeights)
        {
            nudDirect.Value = pWeights[PasswordChunkType.Direct];
            nudDirectDip.Value = pWeights[PasswordChunkType.DirectDiphtongue];
            nudInverted.Value = pWeights[PasswordChunkType.Inverted];
            nudInvertedDip.Value = pWeights[PasswordChunkType.InvertedDiphtongue];
            nudMixed.Value = pWeights[PasswordChunkType.Mixed];
            nudLiquid.Value = pWeights[PasswordChunkType.Liquidified];
        }

        

        private void pbSave_Click(object sender, EventArgs e)
        {
            Dictionary<PasswordChunkType, int> weights = AdjustWeights();
            if (weights == null)
                return;
            
            ApplicationConfiguration configuration = new ApplicationConfiguration();

            configuration.PasswordLength = (int) nudPassLen.Value;
            configuration.PasswordCount = (int) nudPassToGen.Value;

            PasswordGeneratorOptions options = PasswordGeneratorOptions.None;

            if (rbCapitalsFirst.Checked)
                options |= PasswordGeneratorOptions.Capitals | PasswordGeneratorOptions.CapitalsFirstInChunks;
            else if (rbCapitalsLast.Checked)
                options |= PasswordGeneratorOptions.Capitals | PasswordGeneratorOptions.CapitalsLastInChunks;
            else if (rbCapitalsRandom.Checked)
                options |= PasswordGeneratorOptions.Capitals;


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

            configuration.Options = optionsEx;

            configuration.ChunkTypeWeights = PasswordChunkTypeWeight.GetChunkTypeWeights(weights);

            string errorText;
            configuration.Save(ApplicationConfiguration.ConfigurationFilePath, out errorText);

            NewConfiguration = configuration;

            DialogResult = DialogResult.OK;
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void pbAdjust_Click(object sender, EventArgs e)
        {
            AdjustWeights();
        }

        private Dictionary<PasswordChunkType, int> AdjustWeights()
        {
            Dictionary<PasswordChunkType, int> weights = new Dictionary<PasswordChunkType, int>();
            weights.Add(PasswordChunkType.Direct, (int) nudDirect.Value);
            weights.Add(PasswordChunkType.DirectDiphtongue, (int)nudDirectDip.Value);
            weights.Add(PasswordChunkType.Inverted, (int)nudInverted.Value);
            weights.Add(PasswordChunkType.InvertedDiphtongue, (int)nudInvertedDip.Value);
            weights.Add(PasswordChunkType.Mixed, (int)nudMixed.Value);
            weights.Add(PasswordChunkType.Liquidified, (int)nudLiquid.Value);

            weights = PasswordChunkTypeWeight.GetAdjusted(weights);
            if (weights == null)
                return null;


            RefreshWeights(weights);

            return weights;
        }
    }
}
