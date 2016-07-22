namespace DfBAdminToolkit.View
{
    partial class VersionWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersionWindow));
            this.versionAlertText = new System.Windows.Forms.RichTextBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.dismissButton = new System.Windows.Forms.Button();
            this.versionDetails = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // versionAlertText
            // 
            this.versionAlertText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.versionAlertText.BackColor = System.Drawing.SystemColors.Menu;
            this.versionAlertText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.versionAlertText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionAlertText.Location = new System.Drawing.Point(20, 20);
            this.versionAlertText.Name = "versionAlertText";
            this.versionAlertText.Size = new System.Drawing.Size(416, 25);
            this.versionAlertText.TabIndex = 1;
            this.versionAlertText.Text = "A new version of the Admin Toolkit is now available.";
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(292, 201);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(144, 23);
            this.downloadButton.TabIndex = 2;
            this.downloadButton.Text = "Download Update";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Clicked);
            // 
            // dismissButton
            // 
            this.dismissButton.Location = new System.Drawing.Point(211, 201);
            this.dismissButton.Name = "dismissButton";
            this.dismissButton.Size = new System.Drawing.Size(75, 23);
            this.dismissButton.TabIndex = 3;
            this.dismissButton.Text = "Dismiss";
            this.dismissButton.UseVisualStyleBackColor = true;
            this.dismissButton.Click += new System.EventHandler(this.dismissButton_Click);
            // 
            // versionDetails
            // 
            this.versionDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.versionDetails.BackColor = System.Drawing.SystemColors.Menu;
            this.versionDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.versionDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionDetails.Location = new System.Drawing.Point(20, 51);
            this.versionDetails.Name = "versionDetails";
            this.versionDetails.Size = new System.Drawing.Size(416, 144);
            this.versionDetails.TabIndex = 4;
            this.versionDetails.Text = "";
            // 
            // VersionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 236);
            this.Controls.Add(this.versionDetails);
            this.Controls.Add(this.dismissButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.versionAlertText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VersionWindow";
            this.Text = "New Version Available";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox versionAlertText;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button dismissButton;
        private System.Windows.Forms.RichTextBox versionDetails;
    }
}