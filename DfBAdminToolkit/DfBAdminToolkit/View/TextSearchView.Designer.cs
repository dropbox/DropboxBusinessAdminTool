namespace DfBAdminToolkit.View
{
    partial class TextSearchView
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
            this.components = new System.ComponentModel.Container();
            DfBAdminToolkit.Common.Component.Office2010Blue office2010Blue1 = new DfBAdminToolkit.Common.Component.Office2010Blue();
            DfBAdminToolkit.Common.Component.Office2010White office2010White1 = new DfBAdminToolkit.Common.Component.Office2010White();
            this.tableLayoutPanel_TextSearch = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_TextSearchControlGroup = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_TextSearchQueryString = new System.Windows.Forms.TableLayoutPanel();
            this.label_TextSearchQueryString = new System.Windows.Forms.Label();
            this.textBox_TextSearchQueryString = new DfBAdminToolkit.Common.Component.TextBoxEx(this.components);
            this.tableLayoutPanel_TextSearchParamGroup = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_TextSearchResultLimit = new System.Windows.Forms.TableLayoutPanel();
            this.label_TextSearchResultLimit = new System.Windows.Forms.Label();
            this.numericUpDown_TextSearchResultLimit = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel_TextSearchMode = new System.Windows.Forms.TableLayoutPanel();
            this.label_TextSearchMode = new System.Windows.Forms.Label();
            this.comboBox_TextSearchMode = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel_TextSearchToken = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_TextSearchAccessToken = new DfBAdminToolkit.Common.Component.TextBoxEx(this.components);
            this.label_TextSearchAccessToken = new System.Windows.Forms.Label();
            this.tableLayoutPanel_TextSearchCommandButtonGroup = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEx_TextSearchSearch = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.buttonEx_TextSearchClear = new DfBAdminToolkit.Common.Component.ButtonEx();
            this.tableLayoutPanel_TextSearchSplitContainer = new System.Windows.Forms.TableLayoutPanel();
            this.label_TextSearchHorizontalSplitter = new System.Windows.Forms.Label();
            this.label_MemberSearchSearchResultHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel_TextSearchResult = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_TextSearch_MemberListGroup = new System.Windows.Forms.TableLayoutPanel();
            this.objectListView_Members = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnMembers_Email = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnMembers_MemberId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnMembers_Path = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel_TextSearch_MembersCount = new System.Windows.Forms.TableLayoutPanel();
            this.label_TextSearchResultTotalCount = new System.Windows.Forms.Label();
            this.label_TextSearchResultTotal = new System.Windows.Forms.Label();
            this.label_TextSearchMembersTotal = new System.Windows.Forms.Label();
            this.label_TextSearchMembersCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel_TextSearch.SuspendLayout();
            this.tableLayoutPanel_TextSearchControlGroup.SuspendLayout();
            this.tableLayoutPanel_TextSearchQueryString.SuspendLayout();
            this.tableLayoutPanel_TextSearchParamGroup.SuspendLayout();
            this.tableLayoutPanel_TextSearchResultLimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TextSearchResultLimit)).BeginInit();
            this.tableLayoutPanel_TextSearchMode.SuspendLayout();
            this.tableLayoutPanel_TextSearchToken.SuspendLayout();
            this.tableLayoutPanel_TextSearchCommandButtonGroup.SuspendLayout();
            this.tableLayoutPanel_TextSearchSplitContainer.SuspendLayout();
            this.tableLayoutPanel_TextSearchResult.SuspendLayout();
            this.tableLayoutPanel_TextSearch_MemberListGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Members)).BeginInit();
            this.tableLayoutPanel_TextSearch_MembersCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_TextSearch
            // 
            this.tableLayoutPanel_TextSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_TextSearch.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel_TextSearch.ColumnCount = 1;
            this.tableLayoutPanel_TextSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TextSearch.Controls.Add(this.tableLayoutPanel_TextSearchControlGroup, 0, 0);
            this.tableLayoutPanel_TextSearch.Controls.Add(this.tableLayoutPanel_TextSearchParamGroup, 0, 1);
            this.tableLayoutPanel_TextSearch.Controls.Add(this.tableLayoutPanel_TextSearchCommandButtonGroup, 0, 2);
            this.tableLayoutPanel_TextSearch.Controls.Add(this.tableLayoutPanel_TextSearchSplitContainer, 0, 3);
            this.tableLayoutPanel_TextSearch.Controls.Add(this.tableLayoutPanel_TextSearchResult, 0, 4);
            this.tableLayoutPanel_TextSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TextSearch.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel_TextSearch.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_TextSearch.Name = "tableLayoutPanel_TextSearch";
            this.tableLayoutPanel_TextSearch.RowCount = 5;
            this.tableLayoutPanel_TextSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel_TextSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel_TextSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_TextSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_TextSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TextSearch.Size = new System.Drawing.Size(601, 391);
            this.tableLayoutPanel_TextSearch.TabIndex = 0;
            // 
            // tableLayoutPanel_TextSearchControlGroup
            // 
            this.tableLayoutPanel_TextSearchControlGroup.ColumnCount = 1;
            this.tableLayoutPanel_TextSearchControlGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_TextSearchControlGroup.Controls.Add(this.tableLayoutPanel_TextSearchQueryString, 0, 0);
            this.tableLayoutPanel_TextSearchControlGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TextSearchControlGroup.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_TextSearchControlGroup.MaximumSize = new System.Drawing.Size(0, 200);
            this.tableLayoutPanel_TextSearchControlGroup.Name = "tableLayoutPanel_TextSearchControlGroup";
            this.tableLayoutPanel_TextSearchControlGroup.RowCount = 1;
            this.tableLayoutPanel_TextSearchControlGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_TextSearchControlGroup.Size = new System.Drawing.Size(595, 30);
            this.tableLayoutPanel_TextSearchControlGroup.TabIndex = 0;
            // 
            // tableLayoutPanel_TextSearchQueryString
            // 
            this.tableLayoutPanel_TextSearchQueryString.ColumnCount = 2;
            this.tableLayoutPanel_TextSearchQueryString.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel_TextSearchQueryString.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TextSearchQueryString.Controls.Add(this.label_TextSearchQueryString, 0, 0);
            this.tableLayoutPanel_TextSearchQueryString.Controls.Add(this.textBox_TextSearchQueryString, 1, 0);
            this.tableLayoutPanel_TextSearchQueryString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TextSearchQueryString.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_TextSearchQueryString.Name = "tableLayoutPanel_TextSearchQueryString";
            this.tableLayoutPanel_TextSearchQueryString.RowCount = 1;
            this.tableLayoutPanel_TextSearchQueryString.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TextSearchQueryString.Size = new System.Drawing.Size(589, 24);
            this.tableLayoutPanel_TextSearchQueryString.TabIndex = 1;
            // 
            // label_TextSearchQueryString
            // 
            this.label_TextSearchQueryString.AutoSize = true;
            this.label_TextSearchQueryString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TextSearchQueryString.Location = new System.Drawing.Point(3, 0);
            this.label_TextSearchQueryString.Name = "label_TextSearchQueryString";
            this.label_TextSearchQueryString.Size = new System.Drawing.Size(74, 24);
            this.label_TextSearchQueryString.TabIndex = 0;
            this.label_TextSearchQueryString.Text = "Search For";
            this.label_TextSearchQueryString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_TextSearchQueryString
            // 
            this.textBox_TextSearchQueryString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_TextSearchQueryString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TextSearchQueryString.FileFilter = null;
            this.textBox_TextSearchQueryString.Location = new System.Drawing.Point(83, 3);
            this.textBox_TextSearchQueryString.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.textBox_TextSearchQueryString.Name = "textBox_TextSearchQueryString";
            this.textBox_TextSearchQueryString.Size = new System.Drawing.Size(505, 20);
            this.textBox_TextSearchQueryString.TabIndex = 0;
            // 
            // tableLayoutPanel_TextSearchParamGroup
            // 
            this.tableLayoutPanel_TextSearchParamGroup.ColumnCount = 3;
            this.tableLayoutPanel_TextSearchParamGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel_TextSearchParamGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TextSearchParamGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel_TextSearchParamGroup.Controls.Add(this.tableLayoutPanel_TextSearchResultLimit, 2, 0);
            this.tableLayoutPanel_TextSearchParamGroup.Controls.Add(this.tableLayoutPanel_TextSearchMode, 0, 0);
            this.tableLayoutPanel_TextSearchParamGroup.Controls.Add(this.tableLayoutPanel_TextSearchToken, 1, 0);
            this.tableLayoutPanel_TextSearchParamGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TextSearchParamGroup.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel_TextSearchParamGroup.Name = "tableLayoutPanel_TextSearchParamGroup";
            this.tableLayoutPanel_TextSearchParamGroup.RowCount = 1;
            this.tableLayoutPanel_TextSearchParamGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TextSearchParamGroup.Size = new System.Drawing.Size(595, 30);
            this.tableLayoutPanel_TextSearchParamGroup.TabIndex = 1;
            // 
            // tableLayoutPanel_TextSearchResultLimit
            // 
            this.tableLayoutPanel_TextSearchResultLimit.ColumnCount = 2;
            this.tableLayoutPanel_TextSearchResultLimit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel_TextSearchResultLimit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TextSearchResultLimit.Controls.Add(this.label_TextSearchResultLimit, 0, 0);
            this.tableLayoutPanel_TextSearchResultLimit.Controls.Add(this.numericUpDown_TextSearchResultLimit, 1, 0);
            this.tableLayoutPanel_TextSearchResultLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TextSearchResultLimit.Location = new System.Drawing.Point(461, 1);
            this.tableLayoutPanel_TextSearchResultLimit.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel_TextSearchResultLimit.Name = "tableLayoutPanel_TextSearchResultLimit";
            this.tableLayoutPanel_TextSearchResultLimit.RowCount = 1;
            this.tableLayoutPanel_TextSearchResultLimit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TextSearchResultLimit.Size = new System.Drawing.Size(133, 28);
            this.tableLayoutPanel_TextSearchResultLimit.TabIndex = 4;
            // 
            // label_TextSearchResultLimit
            // 
            this.label_TextSearchResultLimit.AutoSize = true;
            this.label_TextSearchResultLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TextSearchResultLimit.Location = new System.Drawing.Point(3, 0);
            this.label_TextSearchResultLimit.Name = "label_TextSearchResultLimit";
            this.label_TextSearchResultLimit.Size = new System.Drawing.Size(69, 28);
            this.label_TextSearchResultLimit.TabIndex = 1;
            this.label_TextSearchResultLimit.Text = "Max Results:";
            this.label_TextSearchResultLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown_TextSearchResultLimit
            // 
            this.numericUpDown_TextSearchResultLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown_TextSearchResultLimit.Location = new System.Drawing.Point(78, 3);
            this.numericUpDown_TextSearchResultLimit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_TextSearchResultLimit.Name = "numericUpDown_TextSearchResultLimit";
            this.numericUpDown_TextSearchResultLimit.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown_TextSearchResultLimit.TabIndex = 0;
            // 
            // tableLayoutPanel_TextSearchMode
            // 
            this.tableLayoutPanel_TextSearchMode.ColumnCount = 2;
            this.tableLayoutPanel_TextSearchMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel_TextSearchMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_TextSearchMode.Controls.Add(this.label_TextSearchMode, 0, 0);
            this.tableLayoutPanel_TextSearchMode.Controls.Add(this.comboBox_TextSearchMode, 1, 0);
            this.tableLayoutPanel_TextSearchMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TextSearchMode.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_TextSearchMode.Name = "tableLayoutPanel_TextSearchMode";
            this.tableLayoutPanel_TextSearchMode.RowCount = 1;
            this.tableLayoutPanel_TextSearchMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TextSearchMode.Size = new System.Drawing.Size(244, 24);
            this.tableLayoutPanel_TextSearchMode.TabIndex = 0;
            // 
            // label_TextSearchMode
            // 
            this.label_TextSearchMode.AutoSize = true;
            this.label_TextSearchMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TextSearchMode.Location = new System.Drawing.Point(3, 0);
            this.label_TextSearchMode.Name = "label_TextSearchMode";
            this.label_TextSearchMode.Size = new System.Drawing.Size(74, 24);
            this.label_TextSearchMode.TabIndex = 1;
            this.label_TextSearchMode.Text = "Search Mode";
            this.label_TextSearchMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_TextSearchMode
            // 
            this.comboBox_TextSearchMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_TextSearchMode.FormattingEnabled = true;
            this.comboBox_TextSearchMode.Location = new System.Drawing.Point(83, 3);
            this.comboBox_TextSearchMode.Name = "comboBox_TextSearchMode";
            this.comboBox_TextSearchMode.Size = new System.Drawing.Size(158, 21);
            this.comboBox_TextSearchMode.TabIndex = 0;
            // 
            // tableLayoutPanel_TextSearchToken
            // 
            this.tableLayoutPanel_TextSearchToken.ColumnCount = 2;
            this.tableLayoutPanel_TextSearchToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel_TextSearchToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TextSearchToken.Controls.Add(this.textBox_TextSearchAccessToken, 0, 0);
            this.tableLayoutPanel_TextSearchToken.Controls.Add(this.label_TextSearchAccessToken, 0, 0);
            this.tableLayoutPanel_TextSearchToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TextSearchToken.Location = new System.Drawing.Point(253, 3);
            this.tableLayoutPanel_TextSearchToken.Name = "tableLayoutPanel_TextSearchToken";
            this.tableLayoutPanel_TextSearchToken.RowCount = 1;
            this.tableLayoutPanel_TextSearchToken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TextSearchToken.Size = new System.Drawing.Size(204, 24);
            this.tableLayoutPanel_TextSearchToken.TabIndex = 3;
            // 
            // textBox_TextSearchAccessToken
            // 
            this.textBox_TextSearchAccessToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_TextSearchAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TextSearchAccessToken.FileFilter = null;
            this.textBox_TextSearchAccessToken.Location = new System.Drawing.Point(93, 3);
            this.textBox_TextSearchAccessToken.Name = "textBox_TextSearchAccessToken";
            this.textBox_TextSearchAccessToken.Size = new System.Drawing.Size(108, 20);
            this.textBox_TextSearchAccessToken.TabIndex = 0;
            this.textBox_TextSearchAccessToken.Visible = false;
            // 
            // label_TextSearchAccessToken
            // 
            this.label_TextSearchAccessToken.AutoSize = true;
            this.label_TextSearchAccessToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TextSearchAccessToken.Location = new System.Drawing.Point(3, 0);
            this.label_TextSearchAccessToken.Name = "label_TextSearchAccessToken";
            this.label_TextSearchAccessToken.Size = new System.Drawing.Size(84, 24);
            this.label_TextSearchAccessToken.TabIndex = 1;
            this.label_TextSearchAccessToken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_TextSearchAccessToken.Visible = false;
            // 
            // tableLayoutPanel_TextSearchCommandButtonGroup
            // 
            this.tableLayoutPanel_TextSearchCommandButtonGroup.ColumnCount = 3;
            this.tableLayoutPanel_TextSearchCommandButtonGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TextSearchCommandButtonGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_TextSearchCommandButtonGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_TextSearchCommandButtonGroup.Controls.Add(this.buttonEx_TextSearchSearch, 1, 0);
            this.tableLayoutPanel_TextSearchCommandButtonGroup.Controls.Add(this.buttonEx_TextSearchClear, 2, 0);
            this.tableLayoutPanel_TextSearchCommandButtonGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TextSearchCommandButtonGroup.Location = new System.Drawing.Point(3, 75);
            this.tableLayoutPanel_TextSearchCommandButtonGroup.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.tableLayoutPanel_TextSearchCommandButtonGroup.Name = "tableLayoutPanel_TextSearchCommandButtonGroup";
            this.tableLayoutPanel_TextSearchCommandButtonGroup.RowCount = 1;
            this.tableLayoutPanel_TextSearchCommandButtonGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TextSearchCommandButtonGroup.Size = new System.Drawing.Size(592, 34);
            this.tableLayoutPanel_TextSearchCommandButtonGroup.TabIndex = 2;
            // 
            // buttonEx_TextSearchSearch
            // 
            office2010Blue1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Blue1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Blue1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Blue1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Blue1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010Blue1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010Blue1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Blue1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Blue1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            office2010Blue1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(125)))), ((int)(((byte)(219)))));
            office2010Blue1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Blue1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Blue1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010Blue1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010Blue1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Blue1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Blue1.TextColor = System.Drawing.Color.White;
            this.buttonEx_TextSearchSearch.ColorTable = office2010Blue1;
            this.buttonEx_TextSearchSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_TextSearchSearch.Location = new System.Drawing.Point(395, 3);
            this.buttonEx_TextSearchSearch.Name = "buttonEx_TextSearchSearch";
            this.buttonEx_TextSearchSearch.Size = new System.Drawing.Size(94, 28);
            this.buttonEx_TextSearchSearch.TabIndex = 2;
            this.buttonEx_TextSearchSearch.Text = "Search";
            this.buttonEx_TextSearchSearch.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_Blue;
            this.buttonEx_TextSearchSearch.UseVisualStyleBackColor = true;
            // 
            // buttonEx_TextSearchClear
            // 
            office2010White1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010White1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010White1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010White1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010White1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010White1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010White1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            office2010White1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            office2010White1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            office2010White1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            office2010White1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010White1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010White1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010White1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010White1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010White1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010White1.TextColor = System.Drawing.Color.Black;
            this.buttonEx_TextSearchClear.ColorTable = office2010White1;
            this.buttonEx_TextSearchClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEx_TextSearchClear.Location = new System.Drawing.Point(495, 3);
            this.buttonEx_TextSearchClear.Name = "buttonEx_TextSearchClear";
            this.buttonEx_TextSearchClear.Size = new System.Drawing.Size(94, 28);
            this.buttonEx_TextSearchClear.TabIndex = 3;
            this.buttonEx_TextSearchClear.Text = "Clear";
            this.buttonEx_TextSearchClear.Theme = DfBAdminToolkit.Common.Component.Theme.MSOffice2010_White;
            this.buttonEx_TextSearchClear.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_TextSearchSplitContainer
            // 
            this.tableLayoutPanel_TextSearchSplitContainer.ColumnCount = 1;
            this.tableLayoutPanel_TextSearchSplitContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TextSearchSplitContainer.Controls.Add(this.label_TextSearchHorizontalSplitter, 0, 0);
            this.tableLayoutPanel_TextSearchSplitContainer.Controls.Add(this.label_MemberSearchSearchResultHeader, 0, 1);
            this.tableLayoutPanel_TextSearchSplitContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_TextSearchSplitContainer.Location = new System.Drawing.Point(3, 115);
            this.tableLayoutPanel_TextSearchSplitContainer.Name = "tableLayoutPanel_TextSearchSplitContainer";
            this.tableLayoutPanel_TextSearchSplitContainer.RowCount = 2;
            this.tableLayoutPanel_TextSearchSplitContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel_TextSearchSplitContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TextSearchSplitContainer.Size = new System.Drawing.Size(595, 24);
            this.tableLayoutPanel_TextSearchSplitContainer.TabIndex = 2;
            // 
            // label_TextSearchHorizontalSplitter
            // 
            this.label_TextSearchHorizontalSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_TextSearchHorizontalSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_TextSearchHorizontalSplitter.Location = new System.Drawing.Point(3, 0);
            this.label_TextSearchHorizontalSplitter.Name = "label_TextSearchHorizontalSplitter";
            this.label_TextSearchHorizontalSplitter.Size = new System.Drawing.Size(589, 2);
            this.label_TextSearchHorizontalSplitter.TabIndex = 0;
            // 
            // label_MemberSearchSearchResultHeader
            // 
            this.label_MemberSearchSearchResultHeader.AutoSize = true;
            this.label_MemberSearchSearchResultHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_MemberSearchSearchResultHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MemberSearchSearchResultHeader.Location = new System.Drawing.Point(3, 4);
            this.label_MemberSearchSearchResultHeader.Name = "label_MemberSearchSearchResultHeader";
            this.label_MemberSearchSearchResultHeader.Size = new System.Drawing.Size(589, 20);
            this.label_MemberSearchSearchResultHeader.TabIndex = 1;
            this.label_MemberSearchSearchResultHeader.Text = "Search Results";
            this.label_MemberSearchSearchResultHeader.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel_TextSearchResult
            // 
            this.tableLayoutPanel_TextSearchResult.ColumnCount = 1;
            this.tableLayoutPanel_TextSearchResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TextSearchResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_TextSearchResult.Controls.Add(this.tableLayoutPanel_TextSearch_MemberListGroup, 0, 0);
            this.tableLayoutPanel_TextSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TextSearchResult.Location = new System.Drawing.Point(3, 145);
            this.tableLayoutPanel_TextSearchResult.Name = "tableLayoutPanel_TextSearchResult";
            this.tableLayoutPanel_TextSearchResult.RowCount = 1;
            this.tableLayoutPanel_TextSearchResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TextSearchResult.Size = new System.Drawing.Size(595, 243);
            this.tableLayoutPanel_TextSearchResult.TabIndex = 3;
            // 
            // tableLayoutPanel_TextSearch_MemberListGroup
            // 
            this.tableLayoutPanel_TextSearch_MemberListGroup.ColumnCount = 1;
            this.tableLayoutPanel_TextSearch_MemberListGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TextSearch_MemberListGroup.Controls.Add(this.objectListView_Members, 0, 0);
            this.tableLayoutPanel_TextSearch_MemberListGroup.Controls.Add(this.tableLayoutPanel_TextSearch_MembersCount, 0, 1);
            this.tableLayoutPanel_TextSearch_MemberListGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TextSearch_MemberListGroup.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_TextSearch_MemberListGroup.Name = "tableLayoutPanel_TextSearch_MemberListGroup";
            this.tableLayoutPanel_TextSearch_MemberListGroup.RowCount = 2;
            this.tableLayoutPanel_TextSearch_MemberListGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TextSearch_MemberListGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel_TextSearch_MemberListGroup.Size = new System.Drawing.Size(589, 237);
            this.tableLayoutPanel_TextSearch_MemberListGroup.TabIndex = 0;
            // 
            // objectListView_Members
            // 
            this.objectListView_Members.AllColumns.Add(this.olvColumnMembers_Email);
            this.objectListView_Members.AllColumns.Add(this.olvColumnMembers_MemberId);
            this.objectListView_Members.AllColumns.Add(this.olvColumnMembers_Path);
            this.objectListView_Members.CellEditUseWholeCell = false;
            this.objectListView_Members.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnMembers_Email,
            this.olvColumnMembers_MemberId,
            this.olvColumnMembers_Path});
            this.objectListView_Members.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView_Members.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListView_Members.EmptyListMsg = "No Result";
            this.objectListView_Members.FullRowSelect = true;
            this.objectListView_Members.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.objectListView_Members.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.objectListView_Members.Location = new System.Drawing.Point(3, 3);
            this.objectListView_Members.Name = "objectListView_Members";
            this.objectListView_Members.ShowFilterMenuOnRightClick = false;
            this.objectListView_Members.ShowItemCountOnGroups = true;
            this.objectListView_Members.Size = new System.Drawing.Size(583, 205);
            this.objectListView_Members.TabIndex = 0;
            this.objectListView_Members.UseCompatibleStateImageBehavior = false;
            this.objectListView_Members.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnMembers_Email
            // 
            this.olvColumnMembers_Email.AspectName = "Email";
            this.olvColumnMembers_Email.MinimumWidth = 120;
            this.olvColumnMembers_Email.Text = "Email";
            this.olvColumnMembers_Email.Width = 120;
            // 
            // olvColumnMembers_MemberId
            // 
            this.olvColumnMembers_MemberId.AspectName = "MemberId";
            this.olvColumnMembers_MemberId.MinimumWidth = 180;
            this.olvColumnMembers_MemberId.Text = "Member ID";
            this.olvColumnMembers_MemberId.Width = 180;
            // 
            // olvColumnMembers_Path
            // 
            this.olvColumnMembers_Path.AspectName = "Path";
            this.olvColumnMembers_Path.FillsFreeSpace = true;
            this.olvColumnMembers_Path.Text = "Path";
            // 
            // tableLayoutPanel_TextSearch_MembersCount
            // 
            this.tableLayoutPanel_TextSearch_MembersCount.ColumnCount = 5;
            this.tableLayoutPanel_TextSearch_MembersCount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel_TextSearch_MembersCount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_TextSearch_MembersCount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel_TextSearch_MembersCount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_TextSearch_MembersCount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TextSearch_MembersCount.Controls.Add(this.label_TextSearchResultTotalCount, 3, 0);
            this.tableLayoutPanel_TextSearch_MembersCount.Controls.Add(this.label_TextSearchResultTotal, 2, 0);
            this.tableLayoutPanel_TextSearch_MembersCount.Controls.Add(this.label_TextSearchMembersTotal, 0, 0);
            this.tableLayoutPanel_TextSearch_MembersCount.Controls.Add(this.label_TextSearchMembersCount, 1, 0);
            this.tableLayoutPanel_TextSearch_MembersCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TextSearch_MembersCount.Location = new System.Drawing.Point(1, 212);
            this.tableLayoutPanel_TextSearch_MembersCount.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel_TextSearch_MembersCount.Name = "tableLayoutPanel_TextSearch_MembersCount";
            this.tableLayoutPanel_TextSearch_MembersCount.RowCount = 1;
            this.tableLayoutPanel_TextSearch_MembersCount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TextSearch_MembersCount.Size = new System.Drawing.Size(587, 24);
            this.tableLayoutPanel_TextSearch_MembersCount.TabIndex = 1;
            // 
            // label_TextSearchResultTotalCount
            // 
            this.label_TextSearchResultTotalCount.AutoSize = true;
            this.label_TextSearchResultTotalCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TextSearchResultTotalCount.Location = new System.Drawing.Point(186, 0);
            this.label_TextSearchResultTotalCount.Name = "label_TextSearchResultTotalCount";
            this.label_TextSearchResultTotalCount.Size = new System.Drawing.Size(13, 24);
            this.label_TextSearchResultTotalCount.TabIndex = 2;
            this.label_TextSearchResultTotalCount.Text = "0";
            this.label_TextSearchResultTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_TextSearchResultTotal
            // 
            this.label_TextSearchResultTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TextSearchResultTotal.Location = new System.Drawing.Point(107, 0);
            this.label_TextSearchResultTotal.Name = "label_TextSearchResultTotal";
            this.label_TextSearchResultTotal.Size = new System.Drawing.Size(73, 24);
            this.label_TextSearchResultTotal.TabIndex = 3;
            this.label_TextSearchResultTotal.Text = "Results Total";
            this.label_TextSearchResultTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_TextSearchMembersTotal
            // 
            this.label_TextSearchMembersTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TextSearchMembersTotal.Location = new System.Drawing.Point(3, 0);
            this.label_TextSearchMembersTotal.Name = "label_TextSearchMembersTotal";
            this.label_TextSearchMembersTotal.Size = new System.Drawing.Size(79, 24);
            this.label_TextSearchMembersTotal.TabIndex = 0;
            this.label_TextSearchMembersTotal.Text = "Total Members";
            this.label_TextSearchMembersTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_TextSearchMembersCount
            // 
            this.label_TextSearchMembersCount.AutoSize = true;
            this.label_TextSearchMembersCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TextSearchMembersCount.Location = new System.Drawing.Point(88, 0);
            this.label_TextSearchMembersCount.Name = "label_TextSearchMembersCount";
            this.label_TextSearchMembersCount.Size = new System.Drawing.Size(13, 24);
            this.label_TextSearchMembersCount.TabIndex = 1;
            this.label_TextSearchMembersCount.Text = "0";
            this.label_TextSearchMembersCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextSearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 391);
            this.Controls.Add(this.tableLayoutPanel_TextSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TextSearchView";
            this.Text = "FullTextSearchView";
            this.tableLayoutPanel_TextSearch.ResumeLayout(false);
            this.tableLayoutPanel_TextSearchControlGroup.ResumeLayout(false);
            this.tableLayoutPanel_TextSearchQueryString.ResumeLayout(false);
            this.tableLayoutPanel_TextSearchQueryString.PerformLayout();
            this.tableLayoutPanel_TextSearchParamGroup.ResumeLayout(false);
            this.tableLayoutPanel_TextSearchResultLimit.ResumeLayout(false);
            this.tableLayoutPanel_TextSearchResultLimit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TextSearchResultLimit)).EndInit();
            this.tableLayoutPanel_TextSearchMode.ResumeLayout(false);
            this.tableLayoutPanel_TextSearchMode.PerformLayout();
            this.tableLayoutPanel_TextSearchToken.ResumeLayout(false);
            this.tableLayoutPanel_TextSearchToken.PerformLayout();
            this.tableLayoutPanel_TextSearchCommandButtonGroup.ResumeLayout(false);
            this.tableLayoutPanel_TextSearchSplitContainer.ResumeLayout(false);
            this.tableLayoutPanel_TextSearchSplitContainer.PerformLayout();
            this.tableLayoutPanel_TextSearchResult.ResumeLayout(false);
            this.tableLayoutPanel_TextSearch_MemberListGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView_Members)).EndInit();
            this.tableLayoutPanel_TextSearch_MembersCount.ResumeLayout(false);
            this.tableLayoutPanel_TextSearch_MembersCount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TextSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TextSearchControlGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TextSearchMode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TextSearchQueryString;
        private System.Windows.Forms.Label label_TextSearchQueryString;
        private DfBAdminToolkit.Common.Component.TextBoxEx textBox_TextSearchQueryString;
        private System.Windows.Forms.Label label_TextSearchMode;
        private System.Windows.Forms.ComboBox comboBox_TextSearchMode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TextSearchToken;
        private System.Windows.Forms.Label label_TextSearchAccessToken;
        private DfBAdminToolkit.Common.Component.TextBoxEx textBox_TextSearchAccessToken;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TextSearchResultLimit;
        private System.Windows.Forms.Label label_TextSearchResultLimit;
        private System.Windows.Forms.NumericUpDown numericUpDown_TextSearchResultLimit;
        private System.Windows.Forms.Label label_TextSearchMembersCount;
        private System.Windows.Forms.Label label_TextSearchMembersTotal;
        private System.Windows.Forms.Label label_TextSearchResultTotal;
        private System.Windows.Forms.Label label_TextSearchResultTotalCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TextSearch_MembersCount;
        private BrightIdeasSoftware.OLVColumn olvColumnMembers_Path;
        private BrightIdeasSoftware.OLVColumn olvColumnMembers_MemberId;
        private BrightIdeasSoftware.OLVColumn olvColumnMembers_Email;
        private BrightIdeasSoftware.ObjectListView objectListView_Members;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TextSearch_MemberListGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TextSearchResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TextSearchSplitContainer;
        private System.Windows.Forms.Label label_TextSearchHorizontalSplitter;
        private System.Windows.Forms.Label label_MemberSearchSearchResultHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TextSearchCommandButtonGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TextSearchParamGroup;
        private Common.Component.ButtonEx buttonEx_TextSearchSearch;
        private Common.Component.ButtonEx buttonEx_TextSearchClear;
    }
}