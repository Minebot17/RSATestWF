namespace RSATestWF
{
    partial class Form1
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
            this.encryptButton = new System.Windows.Forms.Button();
            this.encryptTextBox = new System.Windows.Forms.TextBox();
            this.decryptTextBox = new System.Windows.Forms.TextBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.keyPairInfoLabel = new System.Windows.Forms.Label();
            this.generatePairButton = new System.Windows.Forms.Button();
            this.importPairButton = new System.Windows.Forms.Button();
            this.exportPairButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(215, 75);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 0;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // encryptTextBox
            // 
            this.encryptTextBox.Location = new System.Drawing.Point(30, 78);
            this.encryptTextBox.Name = "encryptTextBox";
            this.encryptTextBox.Size = new System.Drawing.Size(179, 20);
            this.encryptTextBox.TabIndex = 2;
            // 
            // decryptTextBox
            // 
            this.decryptTextBox.Location = new System.Drawing.Point(30, 113);
            this.decryptTextBox.Name = "decryptTextBox";
            this.decryptTextBox.Size = new System.Drawing.Size(179, 20);
            this.decryptTextBox.TabIndex = 5;
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(215, 113);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 23);
            this.decryptButton.TabIndex = 3;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // keyPairInfoLabel
            // 
            this.keyPairInfoLabel.Location = new System.Drawing.Point(20, 31);
            this.keyPairInfoLabel.Name = "keyPairInfoLabel";
            this.keyPairInfoLabel.Size = new System.Drawing.Size(270, 23);
            this.keyPairInfoLabel.TabIndex = 6;
            this.keyPairInfoLabel.Text = "Used new random keypair";
            // 
            // generatePairButton
            // 
            this.generatePairButton.Location = new System.Drawing.Point(306, 31);
            this.generatePairButton.Name = "generatePairButton";
            this.generatePairButton.Size = new System.Drawing.Size(75, 23);
            this.generatePairButton.TabIndex = 7;
            this.generatePairButton.Text = "New pair";
            this.generatePairButton.UseVisualStyleBackColor = true;
            this.generatePairButton.Click += new System.EventHandler(this.generatePairButton_Click);
            // 
            // importPairButton
            // 
            this.importPairButton.Location = new System.Drawing.Point(306, 113);
            this.importPairButton.Name = "importPairButton";
            this.importPairButton.Size = new System.Drawing.Size(75, 23);
            this.importPairButton.TabIndex = 8;
            this.importPairButton.Text = "Import pair";
            this.importPairButton.UseVisualStyleBackColor = true;
            this.importPairButton.Click += new System.EventHandler(this.importPairButton_Click);
            // 
            // exportPairButton
            // 
            this.exportPairButton.Location = new System.Drawing.Point(306, 75);
            this.exportPairButton.Name = "exportPairButton";
            this.exportPairButton.Size = new System.Drawing.Size(75, 23);
            this.exportPairButton.TabIndex = 9;
            this.exportPairButton.Text = "Export pair";
            this.exportPairButton.UseVisualStyleBackColor = true;
            this.exportPairButton.Click += new System.EventHandler(this.exportPairButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(398, 154);
            this.Controls.Add(this.exportPairButton);
            this.Controls.Add(this.importPairButton);
            this.Controls.Add(this.generatePairButton);
            this.Controls.Add(this.keyPairInfoLabel);
            this.Controls.Add(this.decryptTextBox);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptTextBox);
            this.Controls.Add(this.encryptButton);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox decryptTextBox;
        private System.Windows.Forms.Label keyPairInfoLabel;
        private System.Windows.Forms.Button importPairButton;
        private System.Windows.Forms.Button exportPairButton;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;

        private System.Windows.Forms.TextBox encryptTextBox;

        private System.Windows.Forms.Button generatePairButton;

        #endregion
    }
}