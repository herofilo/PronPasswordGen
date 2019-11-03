using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PronPasswordGen.Domain.StrengthMeter;
using PronPasswordGen.Util;

namespace PronPasswordGen
{
    public partial class StrengthMeterForm : Form
    {

        private static PasswordStrength _strengthMeter;

        private SolidBrush _brush;

        private Graphics _strengthBar;

        private string _password;


        public StrengthMeterForm(string pPassword = null)
        {
            _password = pPassword;
            InitializeComponent();
        }

        private void StrengthMeterForm_Load(object sender, EventArgs e)
        {
            if(_strengthMeter == null)
                _strengthMeter = new PasswordStrength();

            lblStrength.Text = "";
            lblLength.Text = "Length:";

            if (!string.IsNullOrEmpty(_password))
            {
                tbPassword.Text = _password;
                tbPassword.Enabled = false;
                timer1.Enabled = true;
            }
        }
        


        private void pbCheck_Click(object sender, EventArgs e)
        {
            ComputeValues();
        }


        private void ComputeValues()
        {
            string password = tbPassword.Text;

            DeleteStrengthBar();



            if (string.IsNullOrEmpty(password))
            {
                lblStrength.Text = "";
                lblLength.Text = "Length:";
                lblCardinality.Text = "Cardinality:";
                lblEntropy.Text = "Entropy:";
                dgvDetails.DataSource = null;
                return;
            }

            lblLength.Text = $"Length: {password.Length}";

            int cardinality;
            double entropy = PasswordEntropy.Compute(password, out cardinality);

            lblCardinality.Text = $"Cardinality: {cardinality}";
            lblEntropy.Text = $"Entropy: {entropy:F1} bits";

            _strengthMeter.SetPassword(password);
            int strengthValue = _strengthMeter.GetPasswordScore();
            string strength = _strengthMeter.GetPasswordStrength();
            DataTable details = _strengthMeter.GetStrengthDetails();

            lblStrength.Text = $"{strength} ({strengthValue})";

            DisplayBar(strengthValue, strength);
            DisplayDetails(details);
        }




        private void DeleteStrengthBar()
        {
            _strengthBar?.Dispose();
            _brush?.Dispose();

            SolidBrush deleteBrush = new SolidBrush(this.BackColor);
            Graphics deleteRectangle = pnlMeter.CreateGraphics();
            deleteRectangle.FillRectangle(deleteBrush, 1, 1, pnlMeter.Width-1, pnlMeter.Height -1);
            deleteRectangle.Dispose();
            deleteBrush.Dispose();


        }

        private void DisplayBar(int pValue, string pCategory)
        {
            _brush = new SolidBrush(Color.Red);
            switch (pCategory.ToLower())
            {
                case "very weak": _brush.Color = Color.Red; break;
                case "weak": _brush.Color = Color.Orange; break;
                case "good": _brush.Color = Color.Yellow; break;
                case "strong": _brush.Color = Color.GreenYellow; break;
                case "very strong": _brush.Color = Color.Green; break;
            }

            _strengthBar = pnlMeter.CreateGraphics();
            int width = (pnlMeter.Width - 2) * pValue / 100;
            _strengthBar.FillRectangle(_brush, 1, 1, width, pnlMeter.Height - 2);

        }

        private void DisplayDetails(DataTable pDetails)
        {
            dgvDetails.AutoGenerateColumns = false;
            dgvDetails.DataSource = pDetails;

        }

        private void StrengthMeterForm_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pbCheck.PerformClick();
            pbCheck.Enabled = false;
        }
    }
}
