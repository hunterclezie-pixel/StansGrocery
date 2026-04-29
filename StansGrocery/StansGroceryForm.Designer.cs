namespace StansGrocery
{
    partial class StansGroceryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            FilterComboBox = new ComboBox();
            DisplayListBox = new ListBox();
            DisplayLabel = new Label();
            FilterGroupBox = new GroupBox();
            FilterByCategoryRadioButton = new RadioButton();
            FilterByAisleRadioButton = new RadioButton();
            TopMenuStrip = new MenuStrip();
            FileTopStripMenuItem = new ToolStripMenuItem();
            SearchTopStripMenuItem = new ToolStripMenuItem();
            ExitTopStripMenuItem = new ToolStripMenuItem();
            HelpTopStripMenuItem = new ToolStripMenuItem();
            AboutTopStripMenuItem = new ToolStripMenuItem();
            ContextMenuStrip = new ContextMenuStrip(components);
            SearchContextMenuItem = new ToolStripMenuItem();
            ExitContextMenuItem = new ToolStripMenuItem();
            MainToolTip = new ToolTip(components);
            FilterGroupBox.SuspendLayout();
            TopMenuStrip.SuspendLayout();
            ContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(6, 130);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(125, 27);
            SearchTextBox.TabIndex = 0;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(6, 163);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(123, 42);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // FilterComboBox
            // 
            FilterComboBox.FormattingEnabled = true;
            FilterComboBox.Location = new Point(414, 129);
            FilterComboBox.Name = "FilterComboBox";
            FilterComboBox.Size = new Size(151, 28);
            FilterComboBox.TabIndex = 2;
            // 
            // DisplayListBox
            // 
            DisplayListBox.FormattingEnabled = true;
            DisplayListBox.Location = new Point(414, 163);
            DisplayListBox.Name = "DisplayListBox";
            DisplayListBox.Size = new Size(318, 204);
            DisplayListBox.TabIndex = 3;
            // 
            // DisplayLabel
            // 
            DisplayLabel.AutoSize = true;
            DisplayLabel.Location = new Point(281, 163);
            DisplayLabel.Name = "DisplayLabel";
            DisplayLabel.Size = new Size(94, 20);
            DisplayLabel.TabIndex = 4;
            DisplayLabel.Text = "DisplayLabel";
            // 
            // FilterGroupBox
            // 
            FilterGroupBox.Controls.Add(FilterByCategoryRadioButton);
            FilterGroupBox.Controls.Add(FilterByAisleRadioButton);
            FilterGroupBox.Controls.Add(SearchButton);
            FilterGroupBox.Controls.Add(SearchTextBox);
            FilterGroupBox.Location = new Point(135, 155);
            FilterGroupBox.Name = "FilterGroupBox";
            FilterGroupBox.Size = new Size(250, 211);
            FilterGroupBox.TabIndex = 5;
            FilterGroupBox.TabStop = false;
            FilterGroupBox.Text = "Filter Group Box";
            // 
            // FilterByCategoryRadioButton
            // 
            FilterByCategoryRadioButton.AutoSize = true;
            FilterByCategoryRadioButton.Location = new Point(6, 68);
            FilterByCategoryRadioButton.Name = "FilterByCategoryRadioButton";
            FilterByCategoryRadioButton.Size = new Size(147, 24);
            FilterByCategoryRadioButton.TabIndex = 7;
            FilterByCategoryRadioButton.TabStop = true;
            FilterByCategoryRadioButton.Text = "Filter By Category";
            FilterByCategoryRadioButton.UseVisualStyleBackColor = true;
            FilterByCategoryRadioButton.CheckedChanged += FilterByCategoryRadioButton_CheckedChanged;
            // 
            // FilterByAisleRadioButton
            // 
            FilterByAisleRadioButton.AutoSize = true;
            FilterByAisleRadioButton.Location = new Point(6, 38);
            FilterByAisleRadioButton.Name = "FilterByAisleRadioButton";
            FilterByAisleRadioButton.Size = new Size(119, 24);
            FilterByAisleRadioButton.TabIndex = 6;
            FilterByAisleRadioButton.TabStop = true;
            FilterByAisleRadioButton.Text = "Filter By Aisle";
            FilterByAisleRadioButton.UseVisualStyleBackColor = true;
            FilterByAisleRadioButton.CheckedChanged += FilterByAisleRadioButton_CheckedChanged;
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.ImageScalingSize = new Size(20, 20);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { FileTopStripMenuItem, HelpTopStripMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Size = new Size(800, 28);
            TopMenuStrip.TabIndex = 6;
            TopMenuStrip.Text = "menuStrip1";
            // 
            // FileTopStripMenuItem
            // 
            FileTopStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SearchTopStripMenuItem, ExitTopStripMenuItem });
            FileTopStripMenuItem.Name = "FileTopStripMenuItem";
            FileTopStripMenuItem.Size = new Size(46, 24);
            FileTopStripMenuItem.Text = "File";
            // 
            // SearchTopStripMenuItem
            // 
            SearchTopStripMenuItem.Name = "SearchTopStripMenuItem";
            SearchTopStripMenuItem.Size = new Size(136, 26);
            SearchTopStripMenuItem.Text = "Search";
            // 
            // ExitTopStripMenuItem
            // 
            ExitTopStripMenuItem.Name = "ExitTopStripMenuItem";
            ExitTopStripMenuItem.Size = new Size(136, 26);
            ExitTopStripMenuItem.Text = "Exit";
            // 
            // HelpTopStripMenuItem
            // 
            HelpTopStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutTopStripMenuItem });
            HelpTopStripMenuItem.Name = "HelpTopStripMenuItem";
            HelpTopStripMenuItem.Size = new Size(55, 24);
            HelpTopStripMenuItem.Text = "Help";
            // 
            // AboutTopStripMenuItem
            // 
            AboutTopStripMenuItem.Name = "AboutTopStripMenuItem";
            AboutTopStripMenuItem.Size = new Size(133, 26);
            AboutTopStripMenuItem.Text = "About";
            // 
            // ContextMenuStrip
            // 
            ContextMenuStrip.ImageScalingSize = new Size(20, 20);
            ContextMenuStrip.Items.AddRange(new ToolStripItem[] { SearchContextMenuItem, ExitContextMenuItem });
            ContextMenuStrip.Name = "ContextMenuStrip";
            ContextMenuStrip.Size = new Size(123, 52);
            // 
            // SearchContextMenuItem
            // 
            SearchContextMenuItem.Name = "SearchContextMenuItem";
            SearchContextMenuItem.Size = new Size(122, 24);
            SearchContextMenuItem.Text = "Search";
            // 
            // ExitContextMenuItem
            // 
            ExitContextMenuItem.Name = "ExitContextMenuItem";
            ExitContextMenuItem.Size = new Size(122, 24);
            ExitContextMenuItem.Text = "Exit";
            // 
            // StansGroceryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FilterGroupBox);
            Controls.Add(DisplayLabel);
            Controls.Add(DisplayListBox);
            Controls.Add(FilterComboBox);
            Controls.Add(TopMenuStrip);
            MainMenuStrip = TopMenuStrip;
            Name = "StansGroceryForm";
            Text = "StansGrocery";
            FilterGroupBox.ResumeLayout(false);
            FilterGroupBox.PerformLayout();
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            ContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchTextBox;
        private Button SearchButton;
        private ComboBox FilterComboBox;
        private ListBox DisplayListBox;
        private Label DisplayLabel;
        private GroupBox FilterGroupBox;
        private RadioButton FilterByAisleRadioButton;
        private RadioButton FilterByCategoryRadioButton;
        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem FileTopStripMenuItem;
        private ToolStripMenuItem SearchTopStripMenuItem;
        private ToolStripMenuItem ExitTopStripMenuItem;
        private ToolStripMenuItem HelpTopStripMenuItem;
        private ToolStripMenuItem AboutTopStripMenuItem;
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem SearchContextMenuItem;
        private ToolStripMenuItem ExitContextMenuItem;
        private ToolTip MainToolTip;
    }
}
