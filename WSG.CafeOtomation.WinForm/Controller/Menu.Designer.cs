﻿namespace WSG.CafeOtomation.WinForm.Controller
{
    partial class Menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCompany = new System.Windows.Forms.Label();
            this.pnlCompany = new System.Windows.Forms.Panel();
            this.menuLeft = new System.Windows.Forms.MenuStrip();
            this.tSSale = new System.Windows.Forms.ToolStripMenuItem();
            this.tSDesk = new System.Windows.Forms.ToolStripMenuItem();
            this.tSOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tSStock = new System.Windows.Forms.ToolStripMenuItem();
            this.tSExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.tPStock = new System.Windows.Forms.TabPage();
            this.lblCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGwProductList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lBxPCategory = new System.Windows.Forms.ListBox();
            this.tPOrder = new System.Windows.Forms.TabPage();
            this.tPDesk = new System.Windows.Forms.TabPage();
            this.tPSale = new System.Windows.Forms.TabPage();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.dGSale = new System.Windows.Forms.DataGridView();
            this.tCMain = new System.Windows.Forms.TabControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pBxImage = new System.Windows.Forms.PictureBox();
            this.gBxProductDetail = new System.Windows.Forms.GroupBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDayPerSale = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCompany.SuspendLayout();
            this.menuLeft.SuspendLayout();
            this.tPStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGwProductList)).BeginInit();
            this.tPOrder.SuspendLayout();
            this.tPSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGSale)).BeginInit();
            this.tCMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxImage)).BeginInit();
            this.gBxProductDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCompany
            // 
            this.lblCompany.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCompany.AutoSize = true;
            this.lblCompany.BackColor = System.Drawing.Color.Transparent;
            this.lblCompany.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCompany.ForeColor = System.Drawing.Color.White;
            this.lblCompany.Location = new System.Drawing.Point(1592, 14);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(168, 81);
            this.lblCompany.TabIndex = 3;
            this.lblCompany.Text = "WSG";
            // 
            // pnlCompany
            // 
            this.pnlCompany.AutoSize = true;
            this.pnlCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlCompany.Controls.Add(this.lblCompany);
            this.pnlCompany.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCompany.Location = new System.Drawing.Point(152, 871);
            this.pnlCompany.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCompany.Name = "pnlCompany";
            this.pnlCompany.Size = new System.Drawing.Size(1760, 95);
            this.pnlCompany.TabIndex = 18;
            // 
            // menuLeft
            // 
            this.menuLeft.AutoSize = false;
            this.menuLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuLeft.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSale,
            this.tSDesk,
            this.tSOrder,
            this.tSStock,
            this.tSExit});
            this.menuLeft.Location = new System.Drawing.Point(0, 0);
            this.menuLeft.Name = "menuLeft";
            this.menuLeft.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuLeft.Size = new System.Drawing.Size(152, 966);
            this.menuLeft.TabIndex = 1;
            this.menuLeft.Text = "menuStrip1";
            // 
            // tSSale
            // 
            this.tSSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tSSale.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tSSale.Image = global::WSG.CafeOtomation.WinForm.Properties.Resources.Sale;
            this.tSSale.Name = "tSSale";
            this.tSSale.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tSSale.Size = new System.Drawing.Size(147, 54);
            this.tSSale.Text = "Satışlar";
            this.tSSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSSale.Click += new System.EventHandler(this.tSSale_Click);
            // 
            // tSDesk
            // 
            this.tSDesk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tSDesk.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tSDesk.Image = global::WSG.CafeOtomation.WinForm.Properties.Resources.Desk;
            this.tSDesk.Name = "tSDesk";
            this.tSDesk.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tSDesk.Size = new System.Drawing.Size(147, 54);
            this.tSDesk.Text = "Masalar";
            this.tSDesk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSDesk.Click += new System.EventHandler(this.tSDesk_Click);
            // 
            // tSOrder
            // 
            this.tSOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tSOrder.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tSOrder.Image = global::WSG.CafeOtomation.WinForm.Properties.Resources.Order;
            this.tSOrder.Name = "tSOrder";
            this.tSOrder.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tSOrder.Size = new System.Drawing.Size(147, 54);
            this.tSOrder.Text = "Siparişler";
            this.tSOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSOrder.Click += new System.EventHandler(this.tSOrder_Click);
            // 
            // tSStock
            // 
            this.tSStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tSStock.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tSStock.Image = global::WSG.CafeOtomation.WinForm.Properties.Resources.Stock;
            this.tSStock.Name = "tSStock";
            this.tSStock.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tSStock.Size = new System.Drawing.Size(147, 54);
            this.tSStock.Text = "Ürün Stokları";
            this.tSStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSStock.Click += new System.EventHandler(this.tSStock_Click);
            // 
            // tSExit
            // 
            this.tSExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tSExit.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tSExit.Image = global::WSG.CafeOtomation.WinForm.Properties.Resources.Exit;
            this.tSExit.Name = "tSExit";
            this.tSExit.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tSExit.Size = new System.Drawing.Size(147, 54);
            this.tSExit.Text = "Çıkış";
            this.tSExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSExit.Click += new System.EventHandler(this.tSExit_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // tPStock
            // 
            this.tPStock.Controls.Add(this.gBxProductDetail);
            this.tPStock.Controls.Add(this.lblCount);
            this.tPStock.Controls.Add(this.label1);
            this.tPStock.Controls.Add(this.dGwProductList);
            this.tPStock.Controls.Add(this.panel1);
            this.tPStock.Controls.Add(this.lBxPCategory);
            this.tPStock.Location = new System.Drawing.Point(23, 4);
            this.tPStock.Name = "tPStock";
            this.tPStock.Padding = new System.Windows.Forms.Padding(3);
            this.tPStock.Size = new System.Drawing.Size(1733, 863);
            this.tPStock.TabIndex = 3;
            this.tPStock.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCount.Location = new System.Drawing.Point(446, 417);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(20, 24);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(263, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toplam Ürün Sayısı:";
            // 
            // dGwProductList
            // 
            this.dGwProductList.AllowUserToAddRows = false;
            this.dGwProductList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dGwProductList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGwProductList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGwProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGwProductList.BackgroundColor = System.Drawing.Color.White;
            this.dGwProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGwProductList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGwProductList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGwProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGwProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGwProductList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGwProductList.EnableHeadersVisualStyles = false;
            this.dGwProductList.GridColor = System.Drawing.SystemColors.Control;
            this.dGwProductList.Location = new System.Drawing.Point(262, 6);
            this.dGwProductList.Margin = new System.Windows.Forms.Padding(2);
            this.dGwProductList.Name = "dGwProductList";
            this.dGwProductList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGwProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dGwProductList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dGwProductList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Empty;
            this.dGwProductList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Empty;
            this.dGwProductList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dGwProductList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dGwProductList.RowTemplate.Height = 24;
            this.dGwProductList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dGwProductList.Size = new System.Drawing.Size(1469, 409);
            this.dGwProductList.TabIndex = 2;
            this.dGwProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGwProductList_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(247, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 880);
            this.panel1.TabIndex = 1;
            // 
            // lBxPCategory
            // 
            this.lBxPCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lBxPCategory.BackColor = System.Drawing.SystemColors.Window;
            this.lBxPCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBxPCategory.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lBxPCategory.FormattingEnabled = true;
            this.lBxPCategory.ItemHeight = 40;
            this.lBxPCategory.Location = new System.Drawing.Point(3, 3);
            this.lBxPCategory.Name = "lBxPCategory";
            this.lBxPCategory.Size = new System.Drawing.Size(238, 840);
            this.lBxPCategory.TabIndex = 0;
            this.lBxPCategory.SelectedIndexChanged += new System.EventHandler(this.lBxPCategory_SelectedIndexChanged);
            // 
            // tPOrder
            // 
            this.tPOrder.Controls.Add(this.dataGridView1);
            this.tPOrder.Location = new System.Drawing.Point(23, 4);
            this.tPOrder.Margin = new System.Windows.Forms.Padding(2);
            this.tPOrder.Name = "tPOrder";
            this.tPOrder.Padding = new System.Windows.Forms.Padding(2);
            this.tPOrder.Size = new System.Drawing.Size(1733, 863);
            this.tPOrder.TabIndex = 2;
            this.tPOrder.UseVisualStyleBackColor = true;
            // 
            // tPDesk
            // 
            this.tPDesk.Location = new System.Drawing.Point(23, 4);
            this.tPDesk.Margin = new System.Windows.Forms.Padding(2);
            this.tPDesk.Name = "tPDesk";
            this.tPDesk.Padding = new System.Windows.Forms.Padding(2);
            this.tPDesk.Size = new System.Drawing.Size(1733, 863);
            this.tPDesk.TabIndex = 1;
            this.tPDesk.UseVisualStyleBackColor = true;
            // 
            // tPSale
            // 
            this.tPSale.AutoScroll = true;
            this.tPSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tPSale.Controls.Add(this.cartesianChart1);
            this.tPSale.Controls.Add(this.dGSale);
            this.tPSale.Location = new System.Drawing.Point(23, 4);
            this.tPSale.Margin = new System.Windows.Forms.Padding(2);
            this.tPSale.Name = "tPSale";
            this.tPSale.Padding = new System.Windows.Forms.Padding(2);
            this.tPSale.Size = new System.Drawing.Size(1733, 863);
            this.tPSale.TabIndex = 0;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart1.Location = new System.Drawing.Point(720, 5);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1005, 225);
            this.cartesianChart1.TabIndex = 2;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // dGSale
            // 
            this.dGSale.AllowUserToAddRows = false;
            this.dGSale.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dGSale.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dGSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGSale.BackgroundColor = System.Drawing.Color.White;
            this.dGSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGSale.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGSale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dGSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGSale.DefaultCellStyle = dataGridViewCellStyle11;
            this.dGSale.EnableHeadersVisualStyles = false;
            this.dGSale.Location = new System.Drawing.Point(4, 5);
            this.dGSale.Margin = new System.Windows.Forms.Padding(2);
            this.dGSale.Name = "dGSale";
            this.dGSale.ReadOnly = true;
            this.dGSale.RowTemplate.Height = 24;
            this.dGSale.Size = new System.Drawing.Size(711, 225);
            this.dGSale.TabIndex = 0;
            // 
            // tCMain
            // 
            this.tCMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tCMain.Controls.Add(this.tPSale);
            this.tCMain.Controls.Add(this.tPDesk);
            this.tCMain.Controls.Add(this.tPOrder);
            this.tCMain.Controls.Add(this.tPStock);
            this.tCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCMain.Location = new System.Drawing.Point(152, 0);
            this.tCMain.Margin = new System.Windows.Forms.Padding(2);
            this.tCMain.Multiline = true;
            this.tCMain.Name = "tCMain";
            this.tCMain.SelectedIndex = 0;
            this.tCMain.Size = new System.Drawing.Size(1760, 871);
            this.tCMain.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1733, 462);
            this.dataGridView1.TabIndex = 3;
            // 
            // pBxImage
            // 
            this.pBxImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.pBxImage.Location = new System.Drawing.Point(939, 16);
            this.pBxImage.Name = "pBxImage";
            this.pBxImage.Size = new System.Drawing.Size(516, 394);
            this.pBxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBxImage.TabIndex = 5;
            this.pBxImage.TabStop = false;
            // 
            // gBxProductDetail
            // 
            this.gBxProductDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBxProductDetail.Controls.Add(this.label3);
            this.gBxProductDetail.Controls.Add(this.label5);
            this.gBxProductDetail.Controls.Add(this.lblStockAmount);
            this.gBxProductDetail.Controls.Add(this.label4);
            this.gBxProductDetail.Controls.Add(this.lblDayPerSale);
            this.gBxProductDetail.Controls.Add(this.label2);
            this.gBxProductDetail.Controls.Add(this.lblProductName);
            this.gBxProductDetail.Controls.Add(this.pBxImage);
            this.gBxProductDetail.Location = new System.Drawing.Point(267, 444);
            this.gBxProductDetail.Name = "gBxProductDetail";
            this.gBxProductDetail.Size = new System.Drawing.Size(1458, 413);
            this.gBxProductDetail.TabIndex = 6;
            this.gBxProductDetail.TabStop = false;
            this.gBxProductDetail.Text = "Ürün Detay Bilgisi";
            this.gBxProductDetail.Visible = false;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Location = new System.Drawing.Point(6, 16);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(143, 81);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Günlük Ortalama Satış:";
            // 
            // lblDayPerSale
            // 
            this.lblDayPerSale.AutoSize = true;
            this.lblDayPerSale.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDayPerSale.Location = new System.Drawing.Point(235, 154);
            this.lblDayPerSale.Name = "lblDayPerSale";
            this.lblDayPerSale.Size = new System.Drawing.Size(21, 24);
            this.lblDayPerSale.TabIndex = 7;
            this.lblDayPerSale.Text = "0";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStockAmount.Location = new System.Drawing.Point(235, 188);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(21, 24);
            this.lblStockAmount.TabIndex = 8;
            this.lblStockAmount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Skot Miktarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(235, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gün İçindeki Satış Miktarı:";
            // 
            // Menu
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1912, 966);
            this.Controls.Add(this.tCMain);
            this.Controls.Add(this.pnlCompany);
            this.Controls.Add(this.menuLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuLeft;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.pnlCompany.ResumeLayout(false);
            this.pnlCompany.PerformLayout();
            this.menuLeft.ResumeLayout(false);
            this.menuLeft.PerformLayout();
            this.tPStock.ResumeLayout(false);
            this.tPStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGwProductList)).EndInit();
            this.tPOrder.ResumeLayout(false);
            this.tPSale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGSale)).EndInit();
            this.tCMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxImage)).EndInit();
            this.gBxProductDetail.ResumeLayout(false);
            this.gBxProductDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Panel pnlCompany;
        private System.Windows.Forms.ToolStripMenuItem tSSale;
        private System.Windows.Forms.ToolStripMenuItem tSDesk;
        private System.Windows.Forms.ToolStripMenuItem tSExit;
        private System.Windows.Forms.MenuStrip menuLeft;
        private System.Windows.Forms.ToolStripMenuItem tSStock;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.ToolStripMenuItem tSOrder;
        private System.Windows.Forms.TabPage tPStock;
        private System.Windows.Forms.DataGridView dGwProductList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lBxPCategory;
        private System.Windows.Forms.TabPage tPOrder;
        private System.Windows.Forms.TabPage tPDesk;
        private System.Windows.Forms.TabPage tPSale;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.DataGridView dGSale;
        private System.Windows.Forms.TabControl tCMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pBxImage;
        private System.Windows.Forms.GroupBox gBxProductDetail;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDayPerSale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.Label label4;
    }
}