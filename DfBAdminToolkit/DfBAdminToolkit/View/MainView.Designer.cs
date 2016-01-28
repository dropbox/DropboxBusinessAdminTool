namespace DfBAdminToolkit.View
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.tableLayoutPanel_MainGroup = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip_Main = new System.Windows.Forms.StatusStrip();
            this.loadingCircleToolStripMenuItem_Main = new MRG.Controls.UI.LoadingCircleToolStripMenuItem();
            this.toolStripStatusLabel_Progress = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel_MainGroup.SuspendLayout();
            this.statusStrip_Main.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_MainGroup
            // 
            this.tableLayoutPanel_MainGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel_MainGroup.ColumnCount = 1;
            this.tableLayoutPanel_MainGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MainGroup.Controls.Add(this.statusStrip_Main, 0, 1);
            this.tableLayoutPanel_MainGroup.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel_MainGroup.Name = "tableLayoutPanel_MainGroup";
            this.tableLayoutPanel_MainGroup.RowCount = 2;
            this.tableLayoutPanel_MainGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MainGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel_MainGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_MainGroup.Size = new System.Drawing.Size(858, 654);
            this.tableLayoutPanel_MainGroup.TabIndex = 3;
            // 
            // statusStrip_Main
            // 
            this.statusStrip_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadingCircleToolStripMenuItem_Main,
            this.toolStripStatusLabel_Progress});
            this.statusStrip_Main.Location = new System.Drawing.Point(0, 627);
            this.statusStrip_Main.Name = "statusStrip_Main";
            this.statusStrip_Main.Size = new System.Drawing.Size(858, 27);
            this.statusStrip_Main.TabIndex = 3;
            this.statusStrip_Main.Text = "statusStrip_Main";
            // 
            // loadingCircleToolStripMenuItem_Main
            // 
            // 
            // loadingCircleToolStripMenuItem_Main
            // 
            this.loadingCircleToolStripMenuItem_Main.LoadingCircleControl.AccessibleName = "loadingCircleToolStripMenuItem_Main";
            this.loadingCircleToolStripMenuItem_Main.LoadingCircleControl.Active = false;
            this.loadingCircleToolStripMenuItem_Main.LoadingCircleControl.Color = System.Drawing.Color.DarkGray;
            this.loadingCircleToolStripMenuItem_Main.LoadingCircleControl.InnerCircleRadius = 8;
            this.loadingCircleToolStripMenuItem_Main.LoadingCircleControl.Location = new System.Drawing.Point(0, 0);
            this.loadingCircleToolStripMenuItem_Main.LoadingCircleControl.Name = "loadingCircleToolStripMenuItem1";
            this.loadingCircleToolStripMenuItem_Main.LoadingCircleControl.NumberSpoke = 24;
            this.loadingCircleToolStripMenuItem_Main.LoadingCircleControl.OuterCircleRadius = 9;
            this.loadingCircleToolStripMenuItem_Main.LoadingCircleControl.RotationSpeed = 100;
            this.loadingCircleToolStripMenuItem_Main.LoadingCircleControl.Size = new System.Drawing.Size(26, 28);
            this.loadingCircleToolStripMenuItem_Main.LoadingCircleControl.SpokeThickness = 4;
            this.loadingCircleToolStripMenuItem_Main.LoadingCircleControl.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.IE7;
            this.loadingCircleToolStripMenuItem_Main.LoadingCircleControl.TabIndex = 1;
            this.loadingCircleToolStripMenuItem_Main.LoadingCircleControl.Text = "loadingCircleToolStripMenuItem1";
            this.loadingCircleToolStripMenuItem_Main.LoadingCircleControl.Visible = false;
            this.loadingCircleToolStripMenuItem_Main.Name = "loadingCircleToolStripMenuItem_Main";
            this.loadingCircleToolStripMenuItem_Main.Size = new System.Drawing.Size(26, 28);
            this.loadingCircleToolStripMenuItem_Main.Text = "loadingCircleToolStripMenuItem1";
            // 
            // toolStripStatusLabel_Progress
            // 
            this.toolStripStatusLabel_Progress.Name = "toolStripStatusLabel_Progress";
            this.toolStripStatusLabel_Progress.Size = new System.Drawing.Size(0, 22);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 681);
            this.Controls.Add(this.tableLayoutPanel_MainGroup);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainView";
            this.Text = "Dropbox Business Admin Toolkit";
            this.tableLayoutPanel_MainGroup.ResumeLayout(false);
            this.tableLayoutPanel_MainGroup.PerformLayout();
            this.statusStrip_Main.ResumeLayout(false);
            this.statusStrip_Main.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_MainGroup;
        private System.Windows.Forms.StatusStrip statusStrip_Main;
        private MRG.Controls.UI.LoadingCircleToolStripMenuItem loadingCircleToolStripMenuItem_Main;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Progress;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

