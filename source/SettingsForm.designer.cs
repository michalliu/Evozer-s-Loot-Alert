namespace LootAlert
{
    partial class SettingsForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRevert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox63s = new System.Windows.Forms.TextBox();
            this.txtBox62s = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxMagic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxPID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxJewelry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 259);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(93, 259);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRevert
            // 
            this.btnRevert.Location = new System.Drawing.Point(174, 259);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(105, 23);
            this.btnRevert.TabIndex = 2;
            this.btnRevert.Text = "Revert to default";
            this.btnRevert.UseVisualStyleBackColor = true;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minimum item levels for rares";
            // 
            // txtBox63s
            // 
            this.txtBox63s.Location = new System.Drawing.Point(12, 29);
            this.txtBox63s.Name = "txtBox63s";
            this.txtBox63s.Size = new System.Drawing.Size(72, 20);
            this.txtBox63s.TabIndex = 4;
            this.txtBox63s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox63s_KeyPress);
            // 
            // txtBox62s
            // 
            this.txtBox62s.Location = new System.Drawing.Point(12, 81);
            this.txtBox62s.Name = "txtBox62s";
            this.txtBox62s.Size = new System.Drawing.Size(72, 20);
            this.txtBox62s.TabIndex = 5;
            this.txtBox62s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox62s_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Standard items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Class specific";
            // 
            // txtBoxMagic
            // 
            this.txtBoxMagic.Location = new System.Drawing.Point(12, 160);
            this.txtBoxMagic.Name = "txtBoxMagic";
            this.txtBoxMagic.Size = new System.Drawing.Size(72, 20);
            this.txtBoxMagic.TabIndex = 8;
            this.txtBoxMagic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxMagic_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Minimum itemlevel for magic";
            // 
            // txtBoxPID
            // 
            this.txtBoxPID.Location = new System.Drawing.Point(12, 208);
            this.txtBoxPID.Name = "txtBoxPID";
            this.txtBoxPID.Size = new System.Drawing.Size(72, 20);
            this.txtBoxPID.TabIndex = 10;
            this.txtBoxPID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPID_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Use this process id if it exists";
            // 
            // txtBoxJewelry
            // 
            this.txtBoxJewelry.Location = new System.Drawing.Point(12, 56);
            this.txtBoxJewelry.Name = "txtBoxJewelry";
            this.txtBoxJewelry.Size = new System.Drawing.Size(72, 20);
            this.txtBoxJewelry.TabIndex = 12;
            this.txtBoxJewelry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxJewelry_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rings and Amulets";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 294);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxJewelry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxPID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxMagic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox62s);
            this.Controls.Add(this.txtBox63s);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRevert);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRevert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox63s;
        private System.Windows.Forms.TextBox txtBox62s;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxMagic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxPID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxJewelry;
        private System.Windows.Forms.Label label6;
    }
}