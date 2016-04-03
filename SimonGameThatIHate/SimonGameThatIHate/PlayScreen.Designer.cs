namespace SimonGameThatIHate
{
    partial class PlayScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayScreen));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.greenButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(65, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 200);
            this.label3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(59, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 213);
            this.label1.TabIndex = 5;
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.PaleGreen;
            this.greenButton.Location = new System.Drawing.Point(77, 71);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(104, 88);
            this.greenButton.TabIndex = 7;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.LightCoral;
            this.redButton.Location = new System.Drawing.Point(191, 71);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(104, 88);
            this.redButton.TabIndex = 8;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Khaki;
            this.yellowButton.Location = new System.Drawing.Point(77, 166);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(104, 88);
            this.yellowButton.TabIndex = 9;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.blueButton.Location = new System.Drawing.Point(191, 166);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(104, 88);
            this.blueButton.TabIndex = 10;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(152, 24);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(49, 13);
            this.messageLabel.TabIndex = 11;
            this.messageLabel.Text = "message";
            // 
            // PlayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "PlayScreen";
            this.Size = new System.Drawing.Size(375, 319);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Label messageLabel;
    }
}
