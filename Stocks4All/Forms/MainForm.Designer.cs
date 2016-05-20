using System.Drawing;
namespace Stocks4All
{
  partial class MainForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.labelCash = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.addStockToolStripMenuItemAddStock = new System.Windows.Forms.ToolStripMenuItem();
			this.saveStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contactSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonAddStock = new System.Windows.Forms.Button();
			this.labelUnsettled = new System.Windows.Forms.Label();
			this.buyPowerLabel = new System.Windows.Forms.Label();
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.PositionsGrid = new System.Windows.Forms.DataGridView();
			this.pictureBoxBGImage = new System.Windows.Forms.PictureBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridViewRecentOrders = new System.Windows.Forms.DataGridView();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.WatchListGrid = new System.Windows.Forms.DataGridView();
			this.infoLabel = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.tabControlMain.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PositionsGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBGImage)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecentOrders)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.WatchListGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.addStockToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// addStockToolStripMenuItem
			// 
			this.addStockToolStripMenuItem.Name = "addStockToolStripMenuItem";
			this.addStockToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.addStockToolStripMenuItem.Text = "Add Stock";
			this.addStockToolStripMenuItem.Click += new System.EventHandler(this.addStockToolStripMenuItem_Click);
			// 
			// labelCash
			// 
			this.labelCash.AutoSize = true;
			this.labelCash.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.labelCash.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCash.Location = new System.Drawing.Point(816, 23);
			this.labelCash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelCash.Name = "labelCash";
			this.labelCash.Size = new System.Drawing.Size(52, 21);
			this.labelCash.TabIndex = 16;
			this.labelCash.Text = "Cash: ";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOptions,
            this.contactSupportToolStripMenuItem,
            this.reportBugToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1253, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItemOptions
			// 
			this.toolStripMenuItemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStockToolStripMenuItemAddStock,
            this.saveStocksToolStripMenuItem});
			this.toolStripMenuItemOptions.Name = "toolStripMenuItemOptions";
			this.toolStripMenuItemOptions.Size = new System.Drawing.Size(61, 20);
			this.toolStripMenuItemOptions.Text = "Options";
			// 
			// addStockToolStripMenuItemAddStock
			// 
			this.addStockToolStripMenuItemAddStock.Name = "addStockToolStripMenuItemAddStock";
			this.addStockToolStripMenuItemAddStock.Size = new System.Drawing.Size(140, 22);
			this.addStockToolStripMenuItemAddStock.Text = "Add Stock";
			this.addStockToolStripMenuItemAddStock.Click += new System.EventHandler(this.addStockToolStripMenuItemAddStock_Click);
			// 
			// saveStocksToolStripMenuItem
			// 
			this.saveStocksToolStripMenuItem.Name = "saveStocksToolStripMenuItem";
			this.saveStocksToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.saveStocksToolStripMenuItem.Text = "Save Stocks";
			this.saveStocksToolStripMenuItem.Click += new System.EventHandler(this.saveStocksToolStripMenuItem_Click);
			// 
			// contactSupportToolStripMenuItem
			// 
			this.contactSupportToolStripMenuItem.Name = "contactSupportToolStripMenuItem";
			this.contactSupportToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
			this.contactSupportToolStripMenuItem.Text = "Contact Support";
			this.contactSupportToolStripMenuItem.Click += new System.EventHandler(this.contactSupportToolStripMenuItem_Click);
			// 
			// reportBugToolStripMenuItem
			// 
			this.reportBugToolStripMenuItem.Name = "reportBugToolStripMenuItem";
			this.reportBugToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
			this.reportBugToolStripMenuItem.Text = "Report Bug";
			this.reportBugToolStripMenuItem.Click += new System.EventHandler(this.reportBugToolStripMenuItem_Click);
			// 
			// buttonAddStock
			// 
			this.buttonAddStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(181)))), ((int)(((byte)(133)))));
			this.buttonAddStock.Enabled = false;
			this.buttonAddStock.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonAddStock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAddStock.ForeColor = System.Drawing.Color.White;
			this.buttonAddStock.Location = new System.Drawing.Point(1171, 25);
			this.buttonAddStock.Name = "buttonAddStock";
			this.buttonAddStock.Size = new System.Drawing.Size(70, 21);
			this.buttonAddStock.TabIndex = 9;
			this.buttonAddStock.Text = "+ Stock";
			this.buttonAddStock.UseVisualStyleBackColor = false;
			this.buttonAddStock.Click += new System.EventHandler(this.buttonAddStock_Click);
			// 
			// labelUnsettled
			// 
			this.labelUnsettled.AutoSize = true;
			this.labelUnsettled.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.labelUnsettled.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUnsettled.Location = new System.Drawing.Point(971, 23);
			this.labelUnsettled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelUnsettled.Name = "labelUnsettled";
			this.labelUnsettled.Size = new System.Drawing.Size(85, 21);
			this.labelUnsettled.TabIndex = 8;
			this.labelUnsettled.Text = "Unsettled:";
			// 
			// buyPowerLabel
			// 
			this.buyPowerLabel.AutoSize = true;
			this.buyPowerLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buyPowerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buyPowerLabel.Location = new System.Drawing.Point(601, 24);
			this.buyPowerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.buyPowerLabel.Name = "buyPowerLabel";
			this.buyPowerLabel.Size = new System.Drawing.Size(118, 21);
			this.buyPowerLabel.TabIndex = 4;
			this.buyPowerLabel.Text = "Buying Power: ";
			// 
			// tabControlMain
			// 
			this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlMain.Controls.Add(this.tabPage1);
			this.tabControlMain.Controls.Add(this.tabPage2);
			this.tabControlMain.Controls.Add(this.tabPage3);
			this.tabControlMain.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControlMain.Location = new System.Drawing.Point(14, 50);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(1228, 623);
			this.tabControlMain.TabIndex = 11;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.PositionsGrid);
			this.tabPage1.Controls.Add(this.pictureBoxBGImage);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1220, 594);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Positions";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// PositionsGrid
			// 
			this.PositionsGrid.AllowUserToAddRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PositionsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.PositionsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.PositionsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.PositionsGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.PositionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.PositionsGrid.DefaultCellStyle = dataGridViewCellStyle2;
			this.PositionsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PositionsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
			this.PositionsGrid.Enabled = false;
			this.PositionsGrid.GridColor = System.Drawing.SystemColors.ControlLight;
			this.PositionsGrid.Location = new System.Drawing.Point(3, 3);
			this.PositionsGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.PositionsGrid.MultiSelect = false;
			this.PositionsGrid.Name = "PositionsGrid";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.PositionsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.PositionsGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PositionsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.PositionsGrid.ShowEditingIcon = false;
			this.PositionsGrid.Size = new System.Drawing.Size(1214, 588);
			this.PositionsGrid.TabIndex = 0;
			this.PositionsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPositions_CellDoubleClick);
			this.PositionsGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPositions_CellFormatting);
			this.PositionsGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PositionsGrid_ColumnHeaderMouseClick);
			this.PositionsGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewPositions_DataBindingComplete);
			this.PositionsGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewPositions_DataError);
			this.PositionsGrid.Leave += new System.EventHandler(this.dataGridViewPositions_Leave);
			this.PositionsGrid.Resize += new System.EventHandler(this.dataGridViewPositions_Resize);
			// 
			// pictureBoxBGImage
			// 
			this.pictureBoxBGImage.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pictureBoxBGImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxBGImage.Image = global::Stocks4All.Properties.Resources.sfa_logo_lrg;
			this.pictureBoxBGImage.Location = new System.Drawing.Point(3, 3);
			this.pictureBoxBGImage.Name = "pictureBoxBGImage";
			this.pictureBoxBGImage.Size = new System.Drawing.Size(1214, 588);
			this.pictureBoxBGImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBoxBGImage.TabIndex = 10;
			this.pictureBoxBGImage.TabStop = false;
			this.pictureBoxBGImage.WaitOnLoad = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dataGridViewRecentOrders);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1220, 594);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Recent Orders (Loading ...)";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dataGridViewRecentOrders
			// 
			this.dataGridViewRecentOrders.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.dataGridViewRecentOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewRecentOrders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewRecentOrders.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewRecentOrders.Name = "dataGridViewRecentOrders";
			this.dataGridViewRecentOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewRecentOrders.Size = new System.Drawing.Size(1214, 588);
			this.dataGridViewRecentOrders.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.WatchListGrid);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(1220, 594);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Watch List";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// WatchListGrid
			// 
			this.WatchListGrid.AllowUserToAddRows = false;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WatchListGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.WatchListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.WatchListGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.WatchListGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.WatchListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.WatchListGrid.DefaultCellStyle = dataGridViewCellStyle5;
			this.WatchListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.WatchListGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
			this.WatchListGrid.Enabled = false;
			this.WatchListGrid.GridColor = System.Drawing.SystemColors.ControlLight;
			this.WatchListGrid.Location = new System.Drawing.Point(0, 0);
			this.WatchListGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.WatchListGrid.MultiSelect = false;
			this.WatchListGrid.Name = "WatchListGrid";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.WatchListGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.WatchListGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WatchListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.WatchListGrid.ShowEditingIcon = false;
			this.WatchListGrid.Size = new System.Drawing.Size(1220, 594);
			this.WatchListGrid.TabIndex = 1;
			this.WatchListGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WatchListGrid_CellDoubleClick);
			this.WatchListGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.WatchListGrid_CellFormatting);
			this.WatchListGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.WatchListGrid_ColumnHeaderMouseClick);
			this.WatchListGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.WatchListGrid_DataBindingComplete);
			this.WatchListGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.WatchListGrid_DataError);
			this.WatchListGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.WatchListGrid_UserDeletingRow);
			// 
			// infoLabel
			// 
			this.infoLabel.AutoSize = true;
			this.infoLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.infoLabel.Location = new System.Drawing.Point(14, 26);
			this.infoLabel.Name = "infoLabel";
			this.infoLabel.Size = new System.Drawing.Size(0, 19);
			this.infoLabel.TabIndex = 17;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(1253, 685);
			this.Controls.Add(this.infoLabel);
			this.Controls.Add(this.labelCash);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.buttonAddStock);
			this.Controls.Add(this.labelUnsettled);
			this.Controls.Add(this.buyPowerLabel);
			this.Controls.Add(this.tabControlMain);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.Name = "MainForm";
			this.Text = "Stocks4All v1.3 - To the Next Thousand Trades";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabControlMain.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PositionsGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBGImage)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecentOrders)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.WatchListGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView PositionsGrid;
    public System.Windows.Forms.Label buyPowerLabel;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addStockToolStripMenuItem;
    public System.Windows.Forms.Label labelUnsettled;
    private System.Windows.Forms.Button buttonAddStock;
    private System.Windows.Forms.PictureBox pictureBoxBGImage;
    private System.Windows.Forms.TabControl tabControlMain;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOptions;
    private System.Windows.Forms.ToolStripMenuItem addStockToolStripMenuItemAddStock;
    private System.Windows.Forms.ToolStripMenuItem saveStocksToolStripMenuItem;
    private System.Windows.Forms.DataGridView dataGridViewRecentOrders;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.DataGridView WatchListGrid;
    private System.Windows.Forms.ToolStripMenuItem contactSupportToolStripMenuItem;
    public System.Windows.Forms.Label labelCash;
    private System.Windows.Forms.ToolStripMenuItem reportBugToolStripMenuItem;
		private System.Windows.Forms.Label infoLabel;
	}
}

