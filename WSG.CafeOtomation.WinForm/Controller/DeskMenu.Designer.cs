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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblProductTitle = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlPay = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
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
            this.lblTitle.Location = new System.Drawing.Point(12, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(72, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "lblTitle";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(899, 584);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(373, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Kapat";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1291, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tVProducts
            // 
            this.tVProducts.Location = new System.Drawing.Point(16, 96);
            this.tVProducts.Name = "tVProducts";
            this.tVProducts.Size = new System.Drawing.Size(264, 526);
            this.tVProducts.TabIndex = 3;
            this.tVProducts.DoubleClick += new System.EventHandler(this.tVProducts_DoubleClick);
            // 
            // dGWOrders
            // 
            this.dGWOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGWOrders.BackgroundColor = System.Drawing.Color.White;
            this.dGWOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWOrders.Location = new System.Drawing.Point(286, 96);
            this.dGWOrders.Name = "dGWOrders";
            this.dGWOrders.ReadOnly = true;
            this.dGWOrders.Size = new System.Drawing.Size(599, 526);
            this.dGWOrders.TabIndex = 4;
            this.dGWOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGWOrders_CellClick);
            // 
            // txtBxFind
            // 
            this.txtBxFind.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxFind.Location = new System.Drawing.Point(16, 64);
            this.txtBxFind.Name = "txtBxFind";
            this.txtBxFind.Size = new System.Drawing.Size(264, 26);
            this.txtBxFind.TabIndex = 5;
            this.txtBxFind.Text = "Deneme";
            this.txtBxFind.TextChanged += new System.EventHandler(this.txtBxFind_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Toplam Tutar: ";
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPay.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPay.Location = new System.Drawing.Point(213, 145);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalPay.Size = new System.Drawing.Size(140, 35);
            this.lblTotalPay.TabIndex = 7;
            this.lblTotalPay.Text = "0";
            this.lblTotalPay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblChange
            // 
            this.lblChange.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblChange.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChange.Location = new System.Drawing.Point(213, 97);
            this.lblChange.Name = "lblChange";
            this.lblChange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblChange.Size = new System.Drawing.Size(140, 35);
            this.lblChange.TabIndex = 11;
            this.lblChange.Text = "0";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblChangeTitle
            // 
            this.lblChangeTitle.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChangeTitle.Location = new System.Drawing.Point(8, 99);
            this.lblChangeTitle.Name = "lblChangeTitle";
            this.lblChangeTitle.Size = new System.Drawing.Size(186, 35);
            this.lblChangeTitle.TabIndex = 10;
            this.lblChangeTitle.Text = "Para Ustu: ";
            this.lblChangeTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnPayCustomer
            // 
            this.btnPayCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPayCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPayCustomer.ForeColor = System.Drawing.Color.White;
            this.btnPayCustomer.Location = new System.Drawing.Point(9, 251);
            this.btnPayCustomer.Name = "btnPayCustomer";
            this.btnPayCustomer.Size = new System.Drawing.Size(373, 40);
            this.btnPayCustomer.TabIndex = 12;
            this.btnPayCustomer.Text = "Ödeme Yapılmadı Hesabı Müsteriye Yaz";
            this.btnPayCustomer.UseVisualStyleBackColor = false;
            this.btnPayCustomer.Click += new System.EventHandler(this.btnPayCustomer_Click);
            // 
            // btnPaySuccess
            // 
            this.btnPaySuccess.BackColor = System.Drawing.Color.YellowGreen;
            this.btnPaySuccess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPaySuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPaySuccess.ForeColor = System.Drawing.Color.White;
            this.btnPaySuccess.Location = new System.Drawing.Point(9, 205);
            this.btnPaySuccess.Name = "btnPaySuccess";
            this.btnPaySuccess.Size = new System.Drawing.Size(373, 40);
            this.btnPaySuccess.TabIndex = 13;
            this.btnPaySuccess.Text = "Ödeme Yapıldı Masayı Kapat";
            this.btnPaySuccess.UseVisualStyleBackColor = false;
            this.btnPaySuccess.Click += new System.EventHandler(this.btnPaySuccess_Click);
            // 
            // nUDPay
            // 
            this.nUDPay.DecimalPlaces = 2;
            this.nUDPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nUDPay.Location = new System.Drawing.Point(200, 47);
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
            this.nUDAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nUDAmount.Location = new System.Drawing.Point(202, 78);
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
            this.nUDAmount.Size = new System.Drawing.Size(182, 38);
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
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ödenen: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(104, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 35);
            this.label3.TabIndex = 17;
            this.label3.Text = "Adet: ";
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductTitle.Location = new System.Drawing.Point(104, 27);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(0, 35);
            this.lblProductTitle.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(9, 133);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(373, 40);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(353, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 35);
            this.label5.TabIndex = 20;
            this.label5.Text = "₺";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(353, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 35);
            this.label6.TabIndex = 21;
            this.label6.Text = "₺";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(353, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 35);
            this.label7.TabIndex = 22;
            this.label7.Text = "₺";
            // 
            // pnlPay
            // 
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
            this.pnlPay.Location = new System.Drawing.Point(891, 278);
            this.pnlPay.Name = "pnlPay";
            this.pnlPay.Size = new System.Drawing.Size(388, 300);
            this.pnlPay.TabIndex = 23;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.label3);
            this.pnlControl.Controls.Add(this.nUDAmount);
            this.pnlControl.Controls.Add(this.lblProductTitle);
            this.pnlControl.Controls.Add(this.btnDelete);
            this.pnlControl.Enabled = false;
            this.pnlControl.Location = new System.Drawing.Point(891, 96);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(388, 176);
            this.pnlControl.TabIndex = 24;
            // 
            // DeskMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 638);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlPay);
            this.Controls.Add(this.txtBxFind);
            this.Controls.Add(this.tVProducts);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dGWOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
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
            this.pnlControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProductTitle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlPay;
        private System.Windows.Forms.Panel pnlControl;
    }
}