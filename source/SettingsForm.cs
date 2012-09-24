using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LootAlert
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            txtBox62s.Text = Settings.Min62s.ToString();
            txtBox63s.Text = Settings.Min63s.ToString();
            txtBoxMagic.Text = Settings.MinMagic.ToString();
            txtBoxJewelry.Text = Settings.MinJewelry.ToString();
            txtBoxPID.Text = Settings.OverrideProcessID.ToString();
        }

        private void txtBox62s_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputCharValid(e.KeyChar);
        }

        private void txtBox63s_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputCharValid(e.KeyChar);
        }

        private void txtBoxMagic_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputCharValid(e.KeyChar);
        }

        private void RevertToDefault()
        {
            txtBox62s.Text = (62).ToString();
            txtBox63s.Text = (63).ToString();
            txtBoxMagic.Text = (61).ToString();
            txtBoxJewelry.Text = (62).ToString();
            txtBoxPID.Text = (0).ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int val62 = 0;
            int val63 = 0;
            int valMagic = 0;
            int valPID = 0;
            int valJewelry = 0;
            if (GetInt(txtBox62s.Text, out val62) == false ||
                GetInt(txtBox63s.Text, out val63) == false ||
                GetInt(txtBoxMagic.Text, out valMagic) == false ||
                GetInt(txtBoxPID.Text, out valPID) == false ||
                GetInt(txtBoxJewelry.Text, out valJewelry) == false)
            {
                MessageBox.Show("Invalid textfield input");
                return;
            }

            Settings.Min62s = val62;
            Settings.Min63s = val63;
            Settings.MinMagic = valMagic;
            Settings.OverrideProcessID = valPID;
            Settings.MinJewelry = valJewelry;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            RevertToDefault();
        }

        private void txtBoxPID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputCharValid(e.KeyChar);
        }

        private void txtBoxJewelry_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputCharValid(e.KeyChar);
        }

        private bool InputCharValid(char c)
        {
            return !char.IsDigit(c) && !char.IsControl(c);
        }

        private bool GetInt(string s, out int value)
        {
            if (string.IsNullOrEmpty(s))
            {
                value = 0;
                return true;
            }

            return int.TryParse(s, out value);
        }
    }
}
