namespace DfBAdminToolkit.View
{
    partial class SettingsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsView));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxDefaultProvision = new System.Windows.Forms.TextBox();
            this.textBoxDefaultAccess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearchDefault = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxApiVersion = new System.Windows.Forms.TextBox();
            this.textBoxContentUrl = new System.Windows.Forms.TextBox();
            this.textBoxBaseUrl = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(484, 242);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(403, 242);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxDefaultProvision
            // 
            this.textBoxDefaultProvision.Location = new System.Drawing.Point(146, 60);
            this.textBoxDefaultProvision.Name = "textBoxDefaultProvision";
            this.textBoxDefaultProvision.Size = new System.Drawing.Size(413, 20);
            this.textBoxDefaultProvision.TabIndex = 3;
            // 
            // textBoxDefaultAccess
            // 
            this.textBoxDefaultAccess.Location = new System.Drawing.Point(146, 21);
            this.textBoxDefaultAccess.Name = "textBoxDefaultAccess";
            this.textBoxDefaultAccess.Size = new System.Drawing.Size(413, 20);
            this.textBoxDefaultAccess.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Team File Access Token:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Team Management Token:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search Default Limit:";
            // 
            // textBoxSearchDefault
            // 
            this.textBoxSearchDefault.Location = new System.Drawing.Point(146, 99);
            this.textBoxSearchDefault.Name = "textBoxSearchDefault";
            this.textBoxSearchDefault.Size = new System.Drawing.Size(58, 20);
            this.textBoxSearchDefault.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Base Url:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Content Url:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Api Version:";
            // 
            // textBoxApiVersion
            // 
            this.textBoxApiVersion.Location = new System.Drawing.Point(386, 138);
            this.textBoxApiVersion.Name = "textBoxApiVersion";
            this.textBoxApiVersion.Size = new System.Drawing.Size(39, 20);
            this.textBoxApiVersion.TabIndex = 12;
            // 
            // textBoxContentUrl
            // 
            this.textBoxContentUrl.Location = new System.Drawing.Point(146, 177);
            this.textBoxContentUrl.Name = "textBoxContentUrl";
            this.textBoxContentUrl.Size = new System.Drawing.Size(166, 20);
            this.textBoxContentUrl.TabIndex = 13;
            // 
            // textBoxBaseUrl
            // 
            this.textBoxBaseUrl.Location = new System.Drawing.Point(146, 138);
            this.textBoxBaseUrl.Name = "textBoxBaseUrl";
            this.textBoxBaseUrl.Size = new System.Drawing.Size(166, 20);
            this.textBoxBaseUrl.TabIndex = 14;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 217);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(59, 13);
            this.labelStatus.TabIndex = 15;
            this.labelStatus.Text = "labelStatus";
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 273);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxBaseUrl);
            this.Controls.Add(this.textBoxContentUrl);
            this.Controls.Add(this.textBoxApiVersion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSearchDefault);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDefaultAccess);
            this.Controls.Add(this.textBoxDefaultProvision);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsView";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxDefaultProvision;
        private System.Windows.Forms.TextBox textBoxDefaultAccess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearchDefault;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxApiVersion;
        private System.Windows.Forms.TextBox textBoxContentUrl;
        private System.Windows.Forms.TextBox textBoxBaseUrl;
        private System.Windows.Forms.Label labelStatus;
    }
}