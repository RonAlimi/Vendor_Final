namespace Vendor
{
    partial class Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnProductManagement = new System.Windows.Forms.ToolStripButton();
            this.btnInserNewProduct = new System.Windows.Forms.ToolStripButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripServerConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shippedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewSuppliesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLOAD = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonLoadBills = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtAddCost = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.lblDummyInsert3 = new System.Windows.Forms.Label();
            this.lblDummyInsert2 = new System.Windows.Forms.Label();
            this.lblDummyInsert1 = new System.Windows.Forms.Label();
            this.txtAddCode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEditCost = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditID = new System.Windows.Forms.TextBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.searchResultGrid = new System.Windows.Forms.DataGridView();
            this.lblDummy3 = new System.Windows.Forms.Label();
            this.lblDummy2 = new System.Windows.Forms.Label();
            this.lblDummy1 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchByCost = new System.Windows.Forms.TextBox();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.txtSearchByCode = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShip = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(23, 23);
            // 
            // btnInserNewProduct
            // 
            this.btnInserNewProduct.Name = "btnInserNewProduct";
            this.btnInserNewProduct.Size = new System.Drawing.Size(23, 23);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.requestsToolStripMenuItem,
            this.manageStockToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstripServerConnect,
            this.configurationToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // mstripServerConnect
            // 
            this.mstripServerConnect.Name = "mstripServerConnect";
            this.mstripServerConnect.Size = new System.Drawing.Size(148, 22);
            this.mstripServerConnect.Text = "Connect";
            this.mstripServerConnect.Click += new System.EventHandler(this.mstripServerConnect_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // requestsToolStripMenuItem
            // 
            this.requestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendingToolStripMenuItem,
            this.shippedToolStripMenuItem});
            this.requestsToolStripMenuItem.Name = "requestsToolStripMenuItem";
            this.requestsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.requestsToolStripMenuItem.Text = "Requests";
            // 
            // pendingToolStripMenuItem
            // 
            this.pendingToolStripMenuItem.Name = "pendingToolStripMenuItem";
            this.pendingToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.pendingToolStripMenuItem.Text = "Pending ";
            // 
            // shippedToolStripMenuItem
            // 
            this.shippedToolStripMenuItem.Name = "shippedToolStripMenuItem";
            this.shippedToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.shippedToolStripMenuItem.Text = "Shipped";
            // 
            // manageStockToolStripMenuItem
            // 
            this.manageStockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerNewSuppliesToolStripMenuItem});
            this.manageStockToolStripMenuItem.Name = "manageStockToolStripMenuItem";
            this.manageStockToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.manageStockToolStripMenuItem.Text = "Manage stock";
            // 
            // registerNewSuppliesToolStripMenuItem
            // 
            this.registerNewSuppliesToolStripMenuItem.Name = "registerNewSuppliesToolStripMenuItem";
            this.registerNewSuppliesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.registerNewSuppliesToolStripMenuItem.Text = "Register new supplies";
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Orange;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLOAD,
            this.toolStripSeparator1,
            this.toolStripButtonLoadBills,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripButton2});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip.Size = new System.Drawing.Size(1354, 25);
            this.toolStrip.TabIndex = 8;
            // 
            // toolStripButtonLOAD
            // 
            this.toolStripButtonLOAD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLOAD.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLOAD.Image")));
            this.toolStripButtonLOAD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLOAD.Name = "toolStripButtonLOAD";
            this.toolStripButtonLOAD.Size = new System.Drawing.Size(104, 22);
            this.toolStripButtonLOAD.Text = "Load All Products";
            this.toolStripButtonLOAD.Click += new System.EventHandler(this.toolStripButtonLOAD_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonLoadBills
            // 
            this.toolStripButtonLoadBills.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLoadBills.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoadBills.Image")));
            this.toolStripButtonLoadBills.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoadBills.Name = "toolStripButtonLoadBills";
            this.toolStripButtonLoadBills.Size = new System.Drawing.Size(100, 22);
            this.toolStripButtonLoadBills.Text = "Load All Invoices";
            this.toolStripButtonLoadBills.Click += new System.EventHandler(this.toolStripButtonLoadBills_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(102, 22);
            this.toolStripButton1.Text = "Pending requests";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(93, 22);
            this.toolStripButton2.Text = "Process request";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 711);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1354, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLbl
            // 
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.txtAddCost);
            this.groupBox1.Controls.Add(this.txtAddName);
            this.groupBox1.Controls.Add(this.lblDummyInsert3);
            this.groupBox1.Controls.Add(this.lblDummyInsert2);
            this.groupBox1.Controls.Add(this.lblDummyInsert1);
            this.groupBox1.Controls.Add(this.txtAddCode);
            this.groupBox1.Location = new System.Drawing.Point(314, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 197);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert new Product";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(138, 106);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(208, 20);
            this.txtQty.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(271, 149);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Add product";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtAddCost
            // 
            this.txtAddCost.Location = new System.Drawing.Point(138, 80);
            this.txtAddCost.Name = "txtAddCost";
            this.txtAddCost.Size = new System.Drawing.Size(208, 20);
            this.txtAddCost.TabIndex = 5;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(138, 54);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(208, 20);
            this.txtAddName.TabIndex = 4;
            // 
            // lblDummyInsert3
            // 
            this.lblDummyInsert3.AutoSize = true;
            this.lblDummyInsert3.Location = new System.Drawing.Point(61, 83);
            this.lblDummyInsert3.Name = "lblDummyInsert3";
            this.lblDummyInsert3.Size = new System.Drawing.Size(71, 13);
            this.lblDummyInsert3.TabIndex = 3;
            this.lblDummyInsert3.Text = "Product Cost:";
            // 
            // lblDummyInsert2
            // 
            this.lblDummyInsert2.AutoSize = true;
            this.lblDummyInsert2.Location = new System.Drawing.Point(54, 57);
            this.lblDummyInsert2.Name = "lblDummyInsert2";
            this.lblDummyInsert2.Size = new System.Drawing.Size(78, 13);
            this.lblDummyInsert2.TabIndex = 2;
            this.lblDummyInsert2.Text = "Product Name:";
            // 
            // lblDummyInsert1
            // 
            this.lblDummyInsert1.AutoSize = true;
            this.lblDummyInsert1.Location = new System.Drawing.Point(54, 33);
            this.lblDummyInsert1.Name = "lblDummyInsert1";
            this.lblDummyInsert1.Size = new System.Drawing.Size(75, 13);
            this.lblDummyInsert1.TabIndex = 1;
            this.lblDummyInsert1.Text = "Product Code:";
            // 
            // txtAddCode
            // 
            this.txtAddCode.Location = new System.Drawing.Point(138, 30);
            this.txtAddCode.Name = "txtAddCode";
            this.txtAddCode.Size = new System.Drawing.Size(208, 20);
            this.txtAddCode.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtEditCost);
            this.groupBox2.Controls.Add(this.txtEditName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtEditID);
            this.groupBox2.Location = new System.Drawing.Point(730, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 197);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Product";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(235, 149);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEditCost
            // 
            this.txtEditCost.Location = new System.Drawing.Point(141, 104);
            this.txtEditCost.Name = "txtEditCost";
            this.txtEditCost.Size = new System.Drawing.Size(159, 20);
            this.txtEditCost.TabIndex = 5;
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(141, 74);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(159, 20);
            this.txtEditName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Cost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Product Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter Code:\r\n";
            // 
            // txtEditID
            // 
            this.txtEditID.Location = new System.Drawing.Point(141, 47);
            this.txtEditID.Name = "txtEditID";
            this.txtEditID.Size = new System.Drawing.Size(159, 20);
            this.txtEditID.TabIndex = 0;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Gold;
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.searchResultGrid);
            this.pnlSearch.Controls.Add(this.lblDummy3);
            this.pnlSearch.Controls.Add(this.lblDummy2);
            this.pnlSearch.Controls.Add(this.lblDummy1);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.txtSearchByCost);
            this.pnlSearch.Controls.Add(this.txtSearchByName);
            this.pnlSearch.Controls.Add(this.txtSearchByCode);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSearch.Location = new System.Drawing.Point(0, 49);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(285, 662);
            this.pnlSearch.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(193, 157);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // searchResultGrid
            // 
            this.searchResultGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchResultGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.searchResultGrid.BackgroundColor = System.Drawing.Color.Orange;
            this.searchResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchResultGrid.GridColor = System.Drawing.Color.DarkOrange;
            this.searchResultGrid.Location = new System.Drawing.Point(0, 239);
            this.searchResultGrid.Name = "searchResultGrid";
            this.searchResultGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchResultGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.searchResultGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchResultGrid.Size = new System.Drawing.Size(285, 423);
            this.searchResultGrid.TabIndex = 7;
            // 
            // lblDummy3
            // 
            this.lblDummy3.AutoSize = true;
            this.lblDummy3.Location = new System.Drawing.Point(33, 122);
            this.lblDummy3.Name = "lblDummy3";
            this.lblDummy3.Size = new System.Drawing.Size(31, 13);
            this.lblDummy3.TabIndex = 6;
            this.lblDummy3.Text = "Cost:";
            // 
            // lblDummy2
            // 
            this.lblDummy2.AutoSize = true;
            this.lblDummy2.Location = new System.Drawing.Point(26, 96);
            this.lblDummy2.Name = "lblDummy2";
            this.lblDummy2.Size = new System.Drawing.Size(38, 13);
            this.lblDummy2.TabIndex = 5;
            this.lblDummy2.Text = "Name:";
            // 
            // lblDummy1
            // 
            this.lblDummy1.AutoSize = true;
            this.lblDummy1.Location = new System.Drawing.Point(29, 70);
            this.lblDummy1.Name = "lblDummy1";
            this.lblDummy1.Size = new System.Drawing.Size(35, 13);
            this.lblDummy1.TabIndex = 4;
            this.lblDummy1.Text = "Code:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Gold;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblSearch.Location = new System.Drawing.Point(12, 17);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(76, 24);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search";
            // 
            // txtSearchByCost
            // 
            this.txtSearchByCost.Location = new System.Drawing.Point(70, 119);
            this.txtSearchByCost.Name = "txtSearchByCost";
            this.txtSearchByCost.Size = new System.Drawing.Size(198, 20);
            this.txtSearchByCost.TabIndex = 2;
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(70, 93);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(198, 20);
            this.txtSearchByName.TabIndex = 1;
            // 
            // txtSearchByCode
            // 
            this.txtSearchByCode.Location = new System.Drawing.Point(70, 67);
            this.txtSearchByCode.Name = "txtSearchByCode";
            this.txtSearchByCode.Size = new System.Drawing.Size(198, 20);
            this.txtSearchByCode.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vendor.Properties.Resources.Vendor_logo;
            this.pictureBox1.Location = new System.Drawing.Point(1064, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 197);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnShip);
            this.pnlControls.Controls.Add(this.dataGridView1);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControls.Location = new System.Drawing.Point(285, 288);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1069, 423);
            this.pnlControls.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(78, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 331);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnShip
            // 
            this.btnShip.Location = new System.Drawing.Point(698, 21);
            this.btnShip.Name = "btnShip";
            this.btnShip.Size = new System.Drawing.Size(75, 23);
            this.btnShip.TabIndex = 1;
            this.btnShip.Text = "Shipp this";
            this.btnShip.UseVisualStyleBackColor = true;
            this.btnShip.Visible = false;
            this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Management";
            this.Text = "Vendor Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnInserNewProduct;
        private System.Windows.Forms.ToolStripButton btnProductManagement;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstripServerConnect;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonLOAD;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtAddCost;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label lblDummyInsert3;
        private System.Windows.Forms.Label lblDummyInsert2;
        private System.Windows.Forms.Label lblDummyInsert1;
        private System.Windows.Forms.TextBox txtAddCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEditCost;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoadBills;
        private System.Windows.Forms.ToolStripMenuItem requestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shippedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerNewSuppliesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView searchResultGrid;
        private System.Windows.Forms.Label lblDummy3;
        private System.Windows.Forms.Label lblDummy2;
        private System.Windows.Forms.Label lblDummy1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchByCost;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.TextBox txtSearchByCode;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShip;

    }
}

