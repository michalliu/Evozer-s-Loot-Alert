namespace LootAlert
{
    partial class LootAlert
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnTestSound = new System.Windows.Forms.Button();
            this.checkBoxRare = new System.Windows.Forms.CheckBox();
            this.checkBoxLegendary = new System.Windows.Forms.CheckBox();
            this.checkBoxCrafting = new System.Windows.Forms.CheckBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.checkBoxMagic = new System.Windows.Forms.CheckBox();
            this.checkBoxGoblin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnTestSound
            // 
            this.btnTestSound.Location = new System.Drawing.Point(13, 43);
            this.btnTestSound.Name = "btnTestSound";
            this.btnTestSound.Size = new System.Drawing.Size(75, 23);
            this.btnTestSound.TabIndex = 1;
            this.btnTestSound.Text = "Test sound";
            this.btnTestSound.UseVisualStyleBackColor = true;
            this.btnTestSound.Click += new System.EventHandler(this.btnTestSound_Click);
            // 
            // checkBoxRare
            // 
            this.checkBoxRare.AutoSize = true;
            this.checkBoxRare.Location = new System.Drawing.Point(105, 35);
            this.checkBoxRare.Name = "checkBoxRare";
            this.checkBoxRare.Size = new System.Drawing.Size(82, 17);
            this.checkBoxRare.TabIndex = 3;
            this.checkBoxRare.Text = "Play on rare";
            this.checkBoxRare.UseVisualStyleBackColor = true;
            this.checkBoxRare.CheckedChanged += new System.EventHandler(this.checkBoxRare_CheckedChanged);
            // 
            // checkBoxLegendary
            // 
            this.checkBoxLegendary.AutoSize = true;
            this.checkBoxLegendary.Checked = true;
            this.checkBoxLegendary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLegendary.Location = new System.Drawing.Point(105, 12);
            this.checkBoxLegendary.Name = "checkBoxLegendary";
            this.checkBoxLegendary.Size = new System.Drawing.Size(110, 17);
            this.checkBoxLegendary.TabIndex = 2;
            this.checkBoxLegendary.Text = "Play on legendary";
            this.checkBoxLegendary.UseVisualStyleBackColor = true;
            this.checkBoxLegendary.CheckedChanged += new System.EventHandler(this.checkBoxLegendary_CheckedChanged);
            // 
            // checkBoxCrafting
            // 
            this.checkBoxCrafting.AutoSize = true;
            this.checkBoxCrafting.Location = new System.Drawing.Point(105, 79);
            this.checkBoxCrafting.Name = "checkBoxCrafting";
            this.checkBoxCrafting.Size = new System.Drawing.Size(122, 17);
            this.checkBoxCrafting.TabIndex = 4;
            this.checkBoxCrafting.Text = "Play on crafting plan";
            this.checkBoxCrafting.UseVisualStyleBackColor = true;
            this.checkBoxCrafting.CheckedChanged += new System.EventHandler(this.checkBoxCrafting_CheckedChanged);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(13, 73);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // checkBoxMagic
            // 
            this.checkBoxMagic.AutoSize = true;
            this.checkBoxMagic.Location = new System.Drawing.Point(105, 56);
            this.checkBoxMagic.Name = "checkBoxMagic";
            this.checkBoxMagic.Size = new System.Drawing.Size(92, 17);
            this.checkBoxMagic.TabIndex = 6;
            this.checkBoxMagic.Text = "Play on magic";
            this.checkBoxMagic.UseVisualStyleBackColor = true;
            this.checkBoxMagic.CheckedChanged += new System.EventHandler(this.checkBoxMagic_CheckedChanged);
            // 
            // checkBoxGoblin
            // 
            this.checkBoxGoblin.AutoSize = true;
            this.checkBoxGoblin.Location = new System.Drawing.Point(266, 13);
            this.checkBoxGoblin.Name = "checkBoxGoblin";
            this.checkBoxGoblin.Size = new System.Drawing.Size(101, 17);
            this.checkBoxGoblin.TabIndex = 7;
            this.checkBoxGoblin.Text = "Treasure Goblin";
            this.checkBoxGoblin.UseVisualStyleBackColor = true;
            this.checkBoxGoblin.CheckedChanged += new System.EventHandler(this.checkBoxGoblin_CheckedChanged);
            // 
            // LootAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 121);
            this.Controls.Add(this.checkBoxGoblin);
            this.Controls.Add(this.checkBoxMagic);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.checkBoxCrafting);
            this.Controls.Add(this.checkBoxRare);
            this.Controls.Add(this.checkBoxLegendary);
            this.Controls.Add(this.btnTestSound);
            this.Controls.Add(this.btnStart);
            this.Name = "LootAlert";
            this.Text = "Loot Alert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnTestSound;
        private System.Windows.Forms.CheckBox checkBoxRare;
        private System.Windows.Forms.CheckBox checkBoxLegendary;
        private System.Windows.Forms.CheckBox checkBoxCrafting;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.CheckBox checkBoxMagic;
        private System.Windows.Forms.CheckBox checkBoxGoblin;
    }
}

