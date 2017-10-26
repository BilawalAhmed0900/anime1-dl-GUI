namespace anime1_dl_GUI
{
    partial class anime1dl_GUI
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
            this.dButton = new System.Windows.Forms.Button();
            this.linkBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dButton
            // 
            this.dButton.Location = new System.Drawing.Point(399, 51);
            this.dButton.Name = "dButton";
            this.dButton.Size = new System.Drawing.Size(75, 20);
            this.dButton.TabIndex = 0;
            this.dButton.Text = "Download";
            this.dButton.UseVisualStyleBackColor = true;
            this.dButton.Click += new System.EventHandler(this.dButton_Click);
            // 
            // linkBox
            // 
            this.linkBox.Location = new System.Drawing.Point(12, 51);
            this.linkBox.Name = "linkBox";
            this.linkBox.Size = new System.Drawing.Size(381, 20);
            this.linkBox.TabIndex = 1;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(305, 39);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "A frontend for anime1-dl for those who are itchy\r\nwith console. Just add the link" +
    " to Link Box and press Download\r\n\r\n";
            // 
            // anime1dl_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 79);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.linkBox);
            this.Controls.Add(this.dButton);
            this.Name = "anime1dl_GUI";
            this.Text = "anime1-dl-GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dButton;
        private System.Windows.Forms.TextBox linkBox;
        private System.Windows.Forms.Label infoLabel;
    }
}

