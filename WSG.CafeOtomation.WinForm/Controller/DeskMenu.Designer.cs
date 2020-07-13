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
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnSuccessOrder = new System.Windows.Forms.Button();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.timerOrderList = new System.Windows.Forms.Timer(this.components);
            this.btnPrintSelect = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
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
            this.lblTitle.Location = new System.Drawing.Point(16, 30);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 24);
            this.lblTitle.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1191, 719);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(517, 49);
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
            this.tVProducts.Location = new System.Drawing.Point(13, 118);
            this.tVProducts.Margin = new System.Windows.Forms.Padding(4);
            this.tVProducts.Name = "tVProducts";
            this.tVProducts.Size = new System.Drawing.Size(359, 646);
            this.tVProducts.TabIndex = 3;
            this.tVProducts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tVProducts_AfterSelect);
            this.tVProducts.DoubleClick += new System.EventHandler(this.tVProducts_DoubleClick);
            // 
            // dGWOrders
            // 
            this.dGWOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dGWOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGWOrders.BackgroundColor = System.Drawing.Color.Gray;
            this.dGWOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGWOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWOrders.Location = new System.Drawing.Point(381, 118);
            this.dGWOrders.Margin = new System.Windows.Forms.Padding(4);
            this.dGWOrders.Name = "dGWOrders";
            this.dGWOrders.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGWOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGWOrders.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            this.dGWOrders.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dGWOrders.Size = new System.Drawing.Size(799, 647);
            this.dGWOrders.TabIndex = 4;
            this.dGWOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGWOrders_CellClick);
            this.dGWOrders.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dGWOrders_CellFormatting);
            // 
            // txtBxFind
            // 
            this.txtBxFind.BackColor = System.Drawing.Color.Black;
            this.txtBxFind.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxFind.ForeColor = System.Drawing.SystemColors.Control;
            this.txtBxFind.Location = new System.Drawing.Point(13, 79);
            this.txtBxFind.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxFind.Name = "txtBxFind";
            this.txtBxFind.Size = new System.Drawing.Size(359, 26);
            this.txtBxFind.TabIndex = 5;
            this.txtBxFind.TextChanged += new System.EventHandler(this.txtBxFind_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(26, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Toplam Tutar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPay.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPay.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalPay.Location = new System.Drawing.Point(289, 139);
            this.lblTotalPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalPay.Size = new System.Drawing.Size(182, 43);
            this.lblTotalPay.TabIndex = 7;
            this.lblTotalPay.Text = "0";
            this.lblTotalPay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblChange
            // 
            this.lblChange.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblChange.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChange.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChange.Location = new System.Drawing.Point(289, 79);
            this.lblChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblChange.Size = new System.Drawing.Size(182, 43);
            this.lblChange.TabIndex = 11;
            this.lblChange.Text = "0";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblChangeTitle
            // 
            this.lblChangeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChangeTitle.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChangeTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChangeTitle.Location = new System.Drawing.Point(34, 81);
            this.lblChangeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangeTitle.Name = "lblChangeTitle";
            this.lblChangeTitle.Size = new System.Drawing.Size(230, 43);
            this.lblChangeTitle.TabIndex = 10;
            this.lblChangeTitle.Text = "Para Ustu:";
            this.lblChangeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPayCustomer
            // 
            this.btnPayCustomer.BackColor = System.Drawing.Color.Orange;
            this.btnPayCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPayCustomer.ForeColor = System.Drawing.Color.White;
            this.btnPayCustomer.Location = new System.Drawing.Point(4, 251);
            this.btnPayCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayCustomer.Name = "btnPayCustomer";
            this.btnPayCustomer.Size = new System.Drawing.Size(509, 52);
            this.btnPayCustomer.TabIndex = 12;
            this.btnPayCustomer.Text = "Ödeme Yapılmadı Hesabı Müsteriye Yaz";
            this.btnPayCustomer.UseVisualStyleBackColor = false;
            this.btnPayCustomer.Click += new System.EventHandler(this.btnPayCustomer_Click);
            // 
            // btnPaySuccess
            // 
            this.btnPaySuccess.BackColor = System.Drawing.Color.LightGreen;
            this.btnPaySuccess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPaySuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPaySuccess.ForeColor = System.Drawing.Color.White;
            this.btnPaySuccess.Location = new System.Drawing.Point(4, 191);
            this.btnPaySuccess.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaySuccess.Name = "btnPaySuccess";
            this.btnPaySuccess.Size = new System.Drawing.Size(509, 52);
            this.btnPaySuccess.TabIndex = 13;
            this.btnPaySuccess.Text = "Ödeme Yapıldı Masayı Kapat";
            this.btnPaySuccess.UseVisualStyleBackColor = false;
            this.btnPaySuccess.Click += new System.EventHandler(this.btnPaySuccess_Click);
            // 
            // nUDPay
            // 
            this.nUDPay.BackColor = System.Drawing.SystemColors.InfoText;
            this.nUDPay.DecimalPlaces = 2;
            this.nUDPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nUDPay.ForeColor = System.Drawing.SystemColors.Control;
            this.nUDPay.Location = new System.Drawing.Point(272, 19);
            this.nUDPay.Margin = new System.Windows.Forms.Padding(4);
            this.nUDPay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUDPay.Name = "nUDPay";
            this.nUDPay.Size = new System.Drawing.Size(204, 38);
            this.nUDPay.TabIndex = 14;
            this.nUDPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUDPay.ValueChanged += new System.EventHandler(this.nUDPay_ValueChanged);
            // 
            // nUDAmount
            // 
            this.nUDAmount.BackColor = System.Drawing.Color.Black;
            this.nUDAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nUDAmount.ForeColor = System.Drawing.SystemColors.Control;
            this.nUDAmount.Location = new System.Drawing.Point(267, 21);
            this.nUDAmount.Margin = new System.Windows.Forms.Padding(4);
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
            this.nUDAmount.Size = new System.Drawing.Size(204, 38);
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
            this.label2.Location = new System.Drawing.Point(42, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 43);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ödenen:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAmount.Location = new System.Drawing.Point(147, 21);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(112, 43);
            this.lblAmount.TabIndex = 17;
            this.lblAmount.Text = "Adet: ";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProductTitle.Location = new System.Drawing.Point(380, 39);
            this.lblProductTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.btnDelete.Location = new System.Drawing.Point(4, 198);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(509, 103);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(484, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 35);
            this.label5.TabIndex = 20;
            this.label5.Text = "₺";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(484, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 35);
            this.label6.TabIndex = 21;
            this.label6.Text = "₺";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(484, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 35);
            this.label7.TabIndex = 22;
            this.label7.Text = "₺";
            // 
            // pnlPay
            // 
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
            this.pnlPay.Location = new System.Drawing.Point(1191, 342);
            this.pnlPay.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPay.Name = "pnlPay";
            this.pnlPay.Size = new System.Drawing.Size(517, 369);
            this.pnlPay.TabIndex = 23;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.btnSuccessOrder);
            this.pnlControl.Controls.Add(this.lblAmount);
            this.pnlControl.Controls.Add(this.nUDAmount);
            this.pnlControl.Controls.Add(this.btnDelete);
            this.pnlControl.Enabled = false;
            this.pnlControl.Location = new System.Drawing.Point(1191, 30);
            this.pnlControl.Margin = new System.Windows.Forms.Padding(4);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(517, 305);
            this.pnlControl.TabIndex = 24;
            // 
            // btnSuccessOrder
            // 
            this.btnSuccessOrder.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSuccessOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuccessOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSuccessOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSuccessOrder.Location = new System.Drawing.Point(4, 87);
            this.btnSuccessOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuccessOrder.Name = "btnSuccessOrder";
            this.btnSuccessOrder.Size = new System.Drawing.Size(509, 103);
            this.btnSuccessOrder.TabIndex = 20;
            this.btnSuccessOrder.Text = "Istenen Siparis Verildi";
            this.btnSuccessOrder.UseVisualStyleBackColor = false;
            this.btnSuccessOrder.Click += new System.EventHandler(this.btnSuccessOrder_Click);
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnitPrice.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnitPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUnitPrice.Location = new System.Drawing.Point(865, 39);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(315, 71);
            this.lblUnitPrice.TabIndex = 25;
            this.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerOrderList
            // 
            this.timerOrderList.Enabled = true;
            this.timerOrderList.Interval = 400;
            this.timerOrderList.Tick += new System.EventHandler(this.timerOrderList_Tick);
            // 
            // btnPrintSelect
            // 
            this.btnPrintSelect.BackColor = System.Drawing.Color.Silver;
            this.btnPrintSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrintSelect.ForeColor = System.Drawing.Color.White;
            this.btnPrintSelect.Location = new System.Drawing.Point(263, 311);
            this.btnPrintSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintSelect.Name = "btnPrintSelect";
            this.btnPrintSelect.Size = new System.Drawing.Size(250, 52);
            this.btnPrintSelect.TabIndex = 23;
            this.btnPrintSelect.Text = " Adisyon Yazdır(Secili Olan)";
            this.btnPrintSelect.UseVisualStyleBackColor = false;
            this.btnPrintSelect.Click += new System.EventHandler(this.btnPrintSelect_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(4, 311);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(255, 52);
            this.btnPrint.TabIndex = 24;
            this.btnPrint.Text = " Adisyon Yazdir";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // DeskMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1721, 785);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlPay);
            this.Controls.Add(this.txtBxFind);
            this.Controls.Add(this.tVProducts);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dGWOrders);
            this.Controls.Add(this.lblProductTitle);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeskMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeskMenu";
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
    }
}