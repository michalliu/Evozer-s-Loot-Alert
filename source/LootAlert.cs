using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace LootAlert
{
    public partial class LootAlert : Form
    {
        private const string version = "1.0.3";
        private Timer timer;
        private bool Running;
        private ItemFinder finder;

        public LootAlert()
        {
            InitializeComponent();
            this.Text += " " + version;
            checkBoxLegendary.Checked = Settings.PlayOnLegendary;
            checkBoxRare.Checked = Settings.PlayOnRare;
            checkBoxCrafting.Checked = Settings.PlayOnCrafting;
            checkBoxMagic.Checked = Settings.PlayOnMagic;
            checkBoxGoblin.Checked = Settings.PlayOnGoblin;

            Sounds.InitSounds();

            timer = new Timer();
            timer.Enabled = false;
            timer.Interval = 250;
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                ACDActor acd = finder.FindBestItem();
                if (acd != null)
                {
                    if (acd.ACDType == ACDType.Item)
                    {
                        Item item = new Item(acd);
                        switch (item.Quality)
                        {
                            case ItemQuality.CraftingPlan: Sounds.PlaySound(Sound.Crafting); break;
                            case ItemQuality.Rare: Sounds.PlaySound(Sound.Rare); break;
                            case ItemQuality.Magic: Sounds.PlaySound(Sound.Magic); break;
                            case ItemQuality.Legendary: Sounds.PlaySound(Sound.Legendary); break;
                        }
                    }
                    else if (acd.IsGoblin())
                    {
                        Sounds.PlaySound(Sound.Goblin);
                    }
                }
            }
            catch (Exception ex)
            {
                SetStatus(false);
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void btnTestSound_Click(object sender, EventArgs e)
        {
            Sounds.PlaySound((Sound)new Random().Next(1, 5));
        }

        private bool SetStatus(bool status)
        {
            if (status == true)
            {
                try
                {
                    if (Settings.OverrideProcessID != 0)
                        finder = new ItemFinder(Settings.OverrideProcessID);
                    else
                        finder = new ItemFinder();
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not find the diablo process!");
                    return false;
                }
                timer.Enabled = true;
            }

            if (status == false)
            {
                try
                {
                    finder.Dispose();
                }
                catch (Exception)
                {
                }
                timer.Enabled = false;
            }

            return true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Running == false)
            {
                if (SetStatus(true))
                {
                    btnStart.Text = "Stop";
                    Running = true;
                }
            }
            else
            {
                if (SetStatus(false))
                {
                    btnStart.Text = "Start";
                    Running = false;
                }
            }
        }

        private void checkBoxLegendary_CheckedChanged(object sender, EventArgs e)
        {
            Settings.PlayOnLegendary = checkBoxLegendary.Checked;
        }

        private void checkBoxRare_CheckedChanged(object sender, EventArgs e)
        {
            Settings.PlayOnRare = checkBoxRare.Checked;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
            form.ShowDialog(this);
        }

        private void checkBoxCrafting_CheckedChanged(object sender, EventArgs e)
        {
            Settings.PlayOnCrafting = checkBoxCrafting.Checked;
        }

        private void checkBoxMagic_CheckedChanged(object sender, EventArgs e)
        {
            Settings.PlayOnMagic = checkBoxMagic.Checked;
        }

        private void checkBoxGoblin_CheckedChanged(object sender, EventArgs e)
        {
            Settings.PlayOnGoblin = checkBoxGoblin.Checked;
        }
    }
}
