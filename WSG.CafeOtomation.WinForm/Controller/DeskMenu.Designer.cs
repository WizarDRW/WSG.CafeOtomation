namespace WSG.CafeOtomation.WinForm.Controller
{
    partial class DeskMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tVProducts = new System.Windows.Forms.TreeView();
            this.dGWOrders = new System.Windows.Forms.DataGridView();
            this.txtBxFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPay = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblChangeTitle = new System.Windows.Forms.Label();
            this.btnPayCustomer = new System.Windows.Forms.Button();
            this.btnPaySuccess = new System.Windows.Forms.Button();
            this.nUDPay = new System.Windows.Forms.NumericUpDown();
            this.nUDAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblProductTitle = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlPay = new System.Windows.Forms.Panel();
            this.btnDeskSelectedMove = new System.Windows.Forms.Button();
            this.btnHalf = new System.Windows.Forms.Button();
            this.btnDeskMove = new System.Windows.Forms.Button();
            this.cmBxPayType = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPrintSelect = new System.Windows.Forms.Button();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnSuccessOrder = new System.Windows.Forms.Button();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.timerOrderList = new System.Windows.Forms.Timer(this.components);
            this.cmBxOrders = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGWOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAmount)).BeginInit();
            this.pnlPay.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 24);
            this.lblTitle.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1159, 683);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(416, 102);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Kapat";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tVProducts
            // 
            this.tVProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tVProducts.BackColor = System.Drawing.Color.Gray;
            this.tVProducts.ForeColor = System.Drawing.SystemColors.Control;
            this.tVProducts.Location = new System.Drawing.Point(10, 96);
            this.tVProducts.Name = "tVProducts";
            this.tVProducts.Size = new System.Drawing.Size(270, 692);
            this.tVProducts.TabIndex = 3;
            this.tVProducts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tVProducts_AfterSelect);
            this.tVProducts.DoubleClick += new System.EventHandler(this.tVProducts_DoubleClick);
            // 
            // dGWOrders
            // 
            this.dGWOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGWOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGWOrders.BackgroundColor = System.Drawing.Color.Gray;
            this.dGWOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGWOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGWOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGWOrders.DefaultCellStyle = dataGridViewCellStyle6;
            this.dGWOrders.Location = new System.Drawing.Point(286, 96);
            this.dGWOrders.Name = "dGWOrders";
            this.dGWOrders.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGWOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dGWOrders.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Control;
            this.dGWOrders.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dGWOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGWOrders.Size = new System.Drawing.Size(583, 692);
            this.dGWOrders.TabIndex = 4;
            this.dGWOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGWOrders_CellClick);
            this.dGWOrders.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dGWOrders_CellFormatting);
            // 
            // txtBxFind
            // 
            this.txtBxFind.BackColor = System.Drawing.Color.Black;
            this.txtBxFind.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxFind.ForeColor = System.Drawing.SystemColors.Control;
            this.txtBxFind.Location = new System.Drawing.Point(10, 64);
            this.txtBxFind.Name = "txtBxFind";
            this.txtBxFind.Size = new System.Drawing.Size(270, 26);
            this.txtBxFind.TabIndex = 5;
            this.txtBxFind.TextChanged += new System.EventHandler(this.txtBxFind_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(44, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Toplam Tutar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPay.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPay.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalPay.Location = new System.Drawing.Point(245, 91);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalPay.Size = new System.Drawing.Size(136, 35);
            this.lblTotalPay.TabIndex = 7;
            this.lblTotalPay.Text = "0";
            this.lblTotalPay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblChange
            // 
            this.lblChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChange.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChange.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChange.Location = new System.Drawing.Point(245, 56);
            this.lblChange.Name = "lblChange";
            this.lblChange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblChange.Size = new System.Drawing.Size(136, 35);
            this.lblChange.TabIndex = 11;
            this.lblChange.Text = "0";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblChangeTitle
            // 
            this.lblChangeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChangeTitle.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChangeTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChangeTitle.Location = new System.Drawing.Point(50, 59);
            this.lblChangeTitle.Name = "lblChangeTitle";
            this.lblChangeTitle.Size = new System.Drawing.Size(172, 35);
            this.lblChangeTitle.TabIndex = 10;
            this.lblChangeTitle.Text = "Para Ustu:";
            this.lblChangeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPayCustomer
            // 
            this.btnPayCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayCustomer.BackColor = System.Drawing.Color.Orange;
            this.btnPayCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPayCustomer.ForeColor = System.Drawing.Color.White;
            this.btnPayCustomer.Location = new System.Drawing.Point(217, 313);
            this.btnPayCustomer.Name = "btnPayCustomer";
            this.btnPayCustomer.Size = new System.Drawing.Size(197, 42);
            this.btnPayCustomer.TabIndex = 12;
            this.btnPayCustomer.Text = "Cari Hesaba Yaz";
            this.btnPayCustomer.UseVisualStyleBackColor = false;
            this.btnPayCustomer.Click += new System.EventHandler(this.btnPayCustomer_Click);
            // 
            // btnPaySuccess
            // 
            this.btnPaySuccess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaySuccess.BackColor = System.Drawing.Color.LightGreen;
            this.btnPaySuccess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPaySuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPaySuccess.ForeColor = System.Drawing.Color.White;
            this.btnPaySuccess.Location = new System.Drawing.Point(7, 215);
            this.btnPaySuccess.Name = "btnPaySuccess";
            this.btnPaySuccess.Size = new System.Drawing.Size(406, 42);
            this.btnPaySuccess.TabIndex = 13;
            this.btnPaySuccess.Text = "Ödeme Yap";
            this.btnPaySuccess.UseVisualStyleBackColor = false;
            this.btnPaySuccess.Click += new System.EventHandler(this.btnPaySuccess_Click);
            // 
            // nUDPay
            // 
            this.nUDPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nUDPay.BackColor = System.Drawing.SystemColors.InfoText;
            this.nUDPay.DecimalPlaces = 2;
            this.nUDPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nUDPay.ForeColor = System.Drawing.SystemColors.Control;
            this.nUDPay.Location = new System.Drawing.Point(228, 15);
            this.nUDPay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUDPay.Name = "nUDPay";
            this.nUDPay.Size = new System.Drawing.Size(153, 38);
            this.nUDPay.TabIndex = 14;
            this.nUDPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUDPay.ValueChanged += new System.EventHandler(this.nUDPay_ValueChanged);
            // 
            // nUDAmount
            // 
            this.nUDAmount.BackColor = System.Drawing.Color.Black;
            this.nUDAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nUDAmount.ForeColor = System.Drawing.SystemColors.Control;
            this.nUDAmount.Location = new System.Drawing.Point(228, 35);
            this.nUDAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUDAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDAmount.Name = "nUDAmount";
            this.nUDAmount.Size = new System.Drawing.Size(153, 38);
            this.nUDAmount.TabIndex = 16;
            this.nUDAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUDAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDAmount.ValueChanged += new System.EventHandler(this.nUDAmount_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(56, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ödenen:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAmount.Location = new System.Drawing.Point(138, 38);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(84, 35);
            this.lblAmount.TabIndex = 17;
            this.lblAmount.Text = "Adet: ";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProductTitle.Location = new System.Drawing.Point(307, 43);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(0, 49);
            this.lblProductTitle.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(3, 178);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(413, 82);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(387, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 35);
            this.label5.TabIndex = 20;
            this.label5.Text = "₺";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(387, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 35);
            this.label6.TabIndex = 21;
            this.label6.Text = "₺";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(387, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 35);
            this.label7.TabIndex = 22;
            this.label7.Text = "₺";
            // 
            // pnlPay
            // 
            this.pnlPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPay.Controls.Add(this.btnDeskSelectedMove);
            this.pnlPay.Controls.Add(this.btnHalf);
            this.pnlPay.Controls.Add(this.btnDeskMove);
            this.pnlPay.Controls.Add(this.cmBxPayType);
            this.pnlPay.Controls.Add(this.btnPrint);
            this.pnlPay.Controls.Add(this.btnPrintSelect);
            this.pnlPay.Controls.Add(this.label2);
            this.pnlPay.Controls.Add(this.nUDPay);
            this.pnlPay.Controls.Add(this.btnPaySuccess);
            this.pnlPay.Controls.Add(this.label7);
            this.pnlPay.Controls.Add(this.btnPayCustomer);
            this.pnlPay.Controls.Add(this.lblChange);
            this.pnlPay.Controls.Add(this.label1);
            this.pnlPay.Controls.Add(this.lblChangeTitle);
            this.pnlPay.Controls.Add(this.label5);
            this.pnlPay.Controls.Add(this.label6);
            this.pnlPay.Controls.Add(this.lblTotalPay);
            this.pnlPay.Enabled = false;
            this.pnlPay.Location = new System.Drawing.Point(1159, 270);
            this.pnlPay.Name = "pnlPay";
            this.pnlPay.Size = new System.Drawing.Size(419, 407);
            this.pnlPay.TabIndex = 23;
            // 
            // btnDeskSelectedMove
            // 
            this.btnDeskSelectedMove.BackColor = System.Drawing.Color.Orange;
            this.btnDeskSelectedMove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeskSelectedMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeskSelectedMove.ForeColor = System.Drawing.Color.White;
            this.btnDeskSelectedMove.Location = new System.Drawing.Point(7, 263);
            this.btnDeskSelectedMove.Name = "btnDeskSelectedMove";
            this.btnDeskSelectedMove.Size = new System.Drawing.Size(205, 44);
            this.btnDeskSelectedMove.TabIndex = 22;
            this.btnDeskSelectedMove.Text = "Siparişleri Taşı";
            this.btnDeskSelectedMove.UseVisualStyleBackColor = false;
            this.btnDeskSelectedMove.Click += new System.EventHandler(this.btnDeskSelectedMove_Click);
            // 
            // btnHalf
            // 
            this.btnHalf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHalf.BackColor = System.Drawing.Color.LightGreen;
            this.btnHalf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHalf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHalf.ForeColor = System.Drawing.Color.White;
            this.btnHalf.Location = new System.Drawing.Point(6, 313);
            this.btnHalf.Name = "btnHalf";
            this.btnHalf.Size = new System.Drawing.Size(206, 42);
            this.btnHalf.TabIndex = 26;
            this.btnHalf.Text = "Böl";
            this.btnHalf.UseVisualStyleBackColor = false;
            this.btnHalf.Click += new System.EventHandler(this.btnHalf_Click);
            // 
            // btnDeskMove
            // 
            this.btnDeskMove.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDeskMove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeskMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeskMove.ForeColor = System.Drawing.Color.White;
            this.btnDeskMove.Location = new System.Drawing.Point(217, 263);
            this.btnDeskMove.Name = "btnDeskMove";
            this.btnDeskMove.Size = new System.Drawing.Size(196, 44);
            this.btnDeskMove.TabIndex = 21;
            this.btnDeskMove.Text = "Masayı Taşı";
            this.btnDeskMove.UseVisualStyleBackColor = false;
            this.btnDeskMove.Click += new System.EventHandler(this.btnDeskMove_Click);
            // 
            // cmBxPayType
            // 
            this.cmBxPayType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmBxPayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxPayType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmBxPayType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBxPayType.FormattingEnabled = true;
            this.cmBxPayType.Items.AddRange(new object[] {
            "--Lütfen Seçiniz--"});
            this.cmBxPayType.Location = new System.Drawing.Point(7, 170);
            this.cmBxPayType.Name = "cmBxPayType";
            this.cmBxPayType.Size = new System.Drawing.Size(405, 39);
            this.cmBxPayType.TabIndex = 25;
            this.cmBxPayType.SelectedIndexChanged += new System.EventHandler(this.cmBxPayType_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(7, 362);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(206, 42);
            this.btnPrint.TabIndex = 24;
            this.btnPrint.Text = " Adisyon";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPrintSelect
            // 
            this.btnPrintSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintSelect.BackColor = System.Drawing.Color.Silver;
            this.btnPrintSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrintSelect.ForeColor = System.Drawing.Color.White;
            this.btnPrintSelect.Location = new System.Drawing.Point(217, 362);
            this.btnPrintSelect.Name = "btnPrintSelect";
            this.btnPrintSelect.Size = new System.Drawing.Size(197, 42);
            this.btnPrintSelect.TabIndex = 23;
            this.btnPrintSelect.Text = " Adisyon(Seçili)";
            this.btnPrintSelect.UseVisualStyleBackColor = false;
            this.btnPrintSelect.Click += new System.EventHandler(this.btnPrintSelect_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControl.Controls.Add(this.btnSuccessOrder);
            this.pnlControl.Controls.Add(this.lblAmount);
            this.pnlControl.Controls.Add(this.btnDelete);
            this.pnlControl.Controls.Add(this.nUDAmount);
            this.pnlControl.Enabled = false;
            this.pnlControl.Location = new System.Drawing.Point(1159, 3);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(419, 262);
            this.pnlControl.TabIndex = 24;
            // 
            // btnSuccessOrder
            // 
            this.btnSuccessOrder.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSuccessOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuccessOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSuccessOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSuccessOrder.Location = new System.Drawing.Point(3, 93);
            this.btnSuccessOrder.Name = "btnSuccessOrder";
            this.btnSuccessOrder.Size = new System.Drawing.Size(413, 79);
            this.btnSuccessOrder.TabIndex = 20;
            this.btnSuccessOrder.Text = "Istenen Siparis Verildi";
            this.btnSuccessOrder.UseVisualStyleBackColor = false;
            this.btnSuccessOrder.Click += new System.EventHandler(this.btnSuccessOrder_Click);
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnitPrice.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnitPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUnitPrice.Location = new System.Drawing.Point(916, 19);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(238, 66);
            this.lblUnitPrice.TabIndex = 25;
            this.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerOrderList
            // 
            this.timerOrderList.Enabled = true;
            this.timerOrderList.Interval = 400;
            this.timerOrderList.Tick += new System.EventHandler(this.timerOrderList_Tick);
            // 
            // cmBxOrders
            // 
            this.cmBxOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmBxOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmBxOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBxOrders.FormattingEnabled = true;
            this.cmBxOrders.Location = new System.Drawing.Point(875, 96);
            this.cmBxOrders.Name = "cmBxOrders";
            this.cmBxOrders.Size = new System.Drawing.Size(278, 39);
            this.cmBxOrders.TabIndex = 26;
            // 
            // DeskMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1590, 804);
            this.Controls.Add(this.cmBxOrders);
            this.Controls.Add(this.dGWOrders);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlPay);
            this.Controls.Add(this.txtBxFind);
            this.Controls.Add(this.tVProducts);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblProductTitle);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeskMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeskMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DeskMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGWOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAmount)).EndInit();
            this.pnlPay.ResumeLayout(false);
            this.pnlPay.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TreeView tVProducts;
        private System.Windows.Forms.DataGridView dGWOrders;
        private System.Windows.Forms.TextBox txtBxFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPay;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblChangeTitle;
        private System.Windows.Forms.Button btnPayCustomer;
        private System.Windows.Forms.Button btnPaySuccess;
        private System.Windows.Forms.NumericUpDown nUDPay;
        private System.Windows.Forms.NumericUpDown nUDAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblProductTitle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlPay;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnSuccessOrder;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Timer timerOrderList;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPrintSelect;
        private System.Windows.Forms.Button btnDeskMove;
        private System.Windows.Forms.Button btnDeskSelectedMove;
        private System.Windows.Forms.ComboBox cmBxPayType;
        private System.Windows.Forms.Button btnHalf;
        private System.Windows.Forms.ComboBox cmBxOrders;
    }
}