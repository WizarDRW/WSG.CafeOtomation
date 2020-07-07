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
            this.label4 = new System.Windows.Forms.Label();
            this.btnPayCustomer = new System.Windows.Forms.Button();
            this.btnPaySuccess = new System.Windows.Forms.Button();
            this.nUDPay = new System.Windows.Forms.NumericUpDown();
            this.nUDAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProductTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGWOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAmount)).BeginInit();
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
            this.btnExit.Location = new System.Drawing.Point(904, 584);
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
            this.dGWOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWOrders.Location = new System.Drawing.Point(286, 96);
            this.dGWOrders.Name = "dGWOrders";
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
            this.label1.Location = new System.Drawing.Point(898, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Toplam Tutar: ";
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalPay.AutoSize = true;
            this.lblTotalPay.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPay.Location = new System.Drawing.Point(1199, 432);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.Size = new System.Drawing.Size(29, 35);
            this.lblTotalPay.TabIndex = 7;
            this.lblTotalPay.Text = "0";
            this.lblTotalPay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblChange
            // 
            this.lblChange.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChange.Location = new System.Drawing.Point(1199, 386);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(29, 35);
            this.lblChange.TabIndex = 11;
            this.lblChange.Text = "0";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(940, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 35);
            this.label4.TabIndex = 10;
            this.label4.Text = "Para Ustu: ";
            // 
            // btnPayCustomer
            // 
            this.btnPayCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPayCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPayCustomer.ForeColor = System.Drawing.Color.White;
            this.btnPayCustomer.Location = new System.Drawing.Point(904, 538);
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
            this.btnPaySuccess.Location = new System.Drawing.Point(904, 492);
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
            this.nUDPay.Location = new System.Drawing.Point(1095, 332);
            this.nUDPay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUDPay.Name = "nUDPay";
            this.nUDPay.Size = new System.Drawing.Size(182, 38);
            this.nUDPay.TabIndex = 14;
            this.nUDPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUDPay.ValueChanged += new System.EventHandler(this.nUDPay_ValueChanged);
            // 
            // nUDAmount
            // 
            this.nUDAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nUDAmount.Location = new System.Drawing.Point(1097, 138);
            this.nUDAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUDAmount.Name = "nUDAmount";
            this.nUDAmount.Size = new System.Drawing.Size(182, 38);
            this.nUDAmount.TabIndex = 16;
            this.nUDAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(963, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ödenen: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(999, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 35);
            this.label3.TabIndex = 17;
            this.label3.Text = "Adet: ";
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductTitle.Location = new System.Drawing.Point(999, 96);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(63, 35);
            this.lblProductTitle.TabIndex = 18;
            this.lblProductTitle.Text = "Null";
            // 
            // DeskMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 636);
            this.Controls.Add(this.lblProductTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nUDAmount);
            this.Controls.Add(this.nUDPay);
            this.Controls.Add(this.btnPaySuccess);
            this.Controls.Add(this.btnPayCustomer);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalPay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxFind);
            this.Controls.Add(this.dGWOrders);
            this.Controls.Add(this.tVProducts);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DeskMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeskMenu";
            this.Load += new System.EventHandler(this.DeskMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGWOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAmount)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPayCustomer;
        private System.Windows.Forms.Button btnPaySuccess;
        private System.Windows.Forms.NumericUpDown nUDPay;
        private System.Windows.Forms.NumericUpDown nUDAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProductTitle;
    }
}