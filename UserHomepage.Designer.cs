namespace prj_CuoiKyXDHTTT
{
    partial class UserHomepage
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
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPricePerPiece = new System.Windows.Forms.TextBox();
            this.cbIMEINumber = new System.Windows.Forms.ComboBox();
            this.cbModelNumber = new System.Windows.Forms.ComboBox();
            this.cbCompanyName = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabViewStock = new System.Windows.Forms.TabPage();
            this.cbModelNumber_ViewStock = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbCompanyName_ViewStock = new System.Windows.Forms.ComboBox();
            this.txtStockAvailable = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabSearchCustomer = new System.Windows.Forms.TabPage();
            this.dtgvSearchResult = new System.Windows.Forms.DataGridView();
            this.lnkSearch = new System.Windows.Forms.LinkLabel();
            this.txtIMEINumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCtrl.SuspendLayout();
            this.tabSales.SuspendLayout();
            this.tabViewStock.SuspendLayout();
            this.tabSearchCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabSales);
            this.tabCtrl.Controls.Add(this.tabViewStock);
            this.tabCtrl.Controls.Add(this.tabSearchCustomer);
            this.tabCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrl.Location = new System.Drawing.Point(2, 0);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(718, 673);
            this.tabCtrl.TabIndex = 0;
            // 
            // tabSales
            // 
            this.tabSales.Controls.Add(this.btnSubmit);
            this.tabSales.Controls.Add(this.txtPricePerPiece);
            this.tabSales.Controls.Add(this.cbIMEINumber);
            this.tabSales.Controls.Add(this.cbModelNumber);
            this.tabSales.Controls.Add(this.cbCompanyName);
            this.tabSales.Controls.Add(this.txtEmail);
            this.tabSales.Controls.Add(this.txtAddress);
            this.tabSales.Controls.Add(this.txtMobileNumber);
            this.tabSales.Controls.Add(this.txtCustomerName);
            this.tabSales.Controls.Add(this.label9);
            this.tabSales.Controls.Add(this.label8);
            this.tabSales.Controls.Add(this.label7);
            this.tabSales.Controls.Add(this.label6);
            this.tabSales.Controls.Add(this.label5);
            this.tabSales.Controls.Add(this.label4);
            this.tabSales.Controls.Add(this.label3);
            this.tabSales.Controls.Add(this.label2);
            this.tabSales.Controls.Add(this.label1);
            this.tabSales.Location = new System.Drawing.Point(4, 29);
            this.tabSales.Name = "tabSales";
            this.tabSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabSales.Size = new System.Drawing.Size(710, 640);
            this.tabSales.TabIndex = 0;
            this.tabSales.Text = "Sales";
            this.tabSales.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(267, 562);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 58);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPricePerPiece
            // 
            this.txtPricePerPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePerPiece.Location = new System.Drawing.Point(300, 499);
            this.txtPricePerPiece.Name = "txtPricePerPiece";
            this.txtPricePerPiece.Size = new System.Drawing.Size(333, 34);
            this.txtPricePerPiece.TabIndex = 25;
            // 
            // cbIMEINumber
            // 
            this.cbIMEINumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIMEINumber.FormattingEnabled = true;
            this.cbIMEINumber.Location = new System.Drawing.Point(300, 436);
            this.cbIMEINumber.Name = "cbIMEINumber";
            this.cbIMEINumber.Size = new System.Drawing.Size(333, 37);
            this.cbIMEINumber.TabIndex = 24;
            this.cbIMEINumber.SelectedIndexChanged += new System.EventHandler(this.cbIMEINumber_SelectedIndexChanged);
            // 
            // cbModelNumber
            // 
            this.cbModelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModelNumber.FormattingEnabled = true;
            this.cbModelNumber.Location = new System.Drawing.Point(300, 378);
            this.cbModelNumber.Name = "cbModelNumber";
            this.cbModelNumber.Size = new System.Drawing.Size(333, 37);
            this.cbModelNumber.TabIndex = 23;
            this.cbModelNumber.SelectedIndexChanged += new System.EventHandler(this.cbModelNumber_SelectedIndexChanged);
            // 
            // cbCompanyName
            // 
            this.cbCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompanyName.FormattingEnabled = true;
            this.cbCompanyName.Location = new System.Drawing.Point(300, 325);
            this.cbCompanyName.Name = "cbCompanyName";
            this.cbCompanyName.Size = new System.Drawing.Size(333, 37);
            this.cbCompanyName.TabIndex = 22;
            this.cbCompanyName.SelectedIndexChanged += new System.EventHandler(this.cbCompanyName_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(300, 266);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(333, 34);
            this.txtEmail.TabIndex = 21;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(300, 177);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(333, 73);
            this.txtAddress.TabIndex = 20;
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNumber.Location = new System.Drawing.Point(300, 127);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(333, 34);
            this.txtMobileNumber.TabIndex = 19;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(300, 74);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(333, 34);
            this.txtCustomerName.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(71, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Customer Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mobile Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Company Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Model Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "IMEI Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Price/Piece";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sales";
            // 
            // tabViewStock
            // 
            this.tabViewStock.Controls.Add(this.cbModelNumber_ViewStock);
            this.tabViewStock.Controls.Add(this.label13);
            this.tabViewStock.Controls.Add(this.cbCompanyName_ViewStock);
            this.tabViewStock.Controls.Add(this.txtStockAvailable);
            this.tabViewStock.Controls.Add(this.label10);
            this.tabViewStock.Controls.Add(this.label11);
            this.tabViewStock.Controls.Add(this.label12);
            this.tabViewStock.Location = new System.Drawing.Point(4, 29);
            this.tabViewStock.Name = "tabViewStock";
            this.tabViewStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewStock.Size = new System.Drawing.Size(710, 640);
            this.tabViewStock.TabIndex = 1;
            this.tabViewStock.Text = "ViewStock";
            this.tabViewStock.UseVisualStyleBackColor = true;
            // 
            // cbModelNumber_ViewStock
            // 
            this.cbModelNumber_ViewStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModelNumber_ViewStock.FormattingEnabled = true;
            this.cbModelNumber_ViewStock.Location = new System.Drawing.Point(341, 233);
            this.cbModelNumber_ViewStock.Name = "cbModelNumber_ViewStock";
            this.cbModelNumber_ViewStock.Size = new System.Drawing.Size(298, 37);
            this.cbModelNumber_ViewStock.TabIndex = 31;
            this.cbModelNumber_ViewStock.SelectedIndexChanged += new System.EventHandler(this.cbModelNumber_ViewStock_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(49, 309);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 29);
            this.label13.TabIndex = 30;
            this.label13.Text = "Stock Available:";
            // 
            // cbCompanyName_ViewStock
            // 
            this.cbCompanyName_ViewStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompanyName_ViewStock.FormattingEnabled = true;
            this.cbCompanyName_ViewStock.Location = new System.Drawing.Point(341, 160);
            this.cbCompanyName_ViewStock.Name = "cbCompanyName_ViewStock";
            this.cbCompanyName_ViewStock.Size = new System.Drawing.Size(298, 37);
            this.cbCompanyName_ViewStock.TabIndex = 29;
            this.cbCompanyName_ViewStock.SelectedIndexChanged += new System.EventHandler(this.cbCompanyName_ViewStock_SelectedIndexChanged);
            // 
            // txtStockAvailable
            // 
            this.txtStockAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockAvailable.Location = new System.Drawing.Point(341, 306);
            this.txtStockAvailable.Name = "txtStockAvailable";
            this.txtStockAvailable.Size = new System.Drawing.Size(298, 34);
            this.txtStockAvailable.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 29);
            this.label10.TabIndex = 27;
            this.label10.Text = "Select Company Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(254, 29);
            this.label11.TabIndex = 26;
            this.label11.Text = "Select Model Number:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(255, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 32);
            this.label12.TabIndex = 25;
            this.label12.Text = "View Stock";
            // 
            // tabSearchCustomer
            // 
            this.tabSearchCustomer.Controls.Add(this.dtgvSearchResult);
            this.tabSearchCustomer.Controls.Add(this.lnkSearch);
            this.tabSearchCustomer.Controls.Add(this.txtIMEINumber);
            this.tabSearchCustomer.Controls.Add(this.label14);
            this.tabSearchCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSearchCustomer.Location = new System.Drawing.Point(4, 29);
            this.tabSearchCustomer.Name = "tabSearchCustomer";
            this.tabSearchCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchCustomer.Size = new System.Drawing.Size(710, 640);
            this.tabSearchCustomer.TabIndex = 2;
            this.tabSearchCustomer.Text = "SearchCustomerbyIMEI";
            this.tabSearchCustomer.UseVisualStyleBackColor = true;
            // 
            // dtgvSearchResult
            // 
            this.dtgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSearchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.MobileNumber,
            this.EmailId,
            this.Address});
            this.dtgvSearchResult.Location = new System.Drawing.Point(27, 248);
            this.dtgvSearchResult.Name = "dtgvSearchResult";
            this.dtgvSearchResult.RowHeadersWidth = 51;
            this.dtgvSearchResult.RowTemplate.Height = 24;
            this.dtgvSearchResult.Size = new System.Drawing.Size(658, 213);
            this.dtgvSearchResult.TabIndex = 31;
            // 
            // lnkSearch
            // 
            this.lnkSearch.AutoSize = true;
            this.lnkSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSearch.Location = new System.Drawing.Point(289, 165);
            this.lnkSearch.Name = "lnkSearch";
            this.lnkSearch.Size = new System.Drawing.Size(89, 29);
            this.lnkSearch.TabIndex = 30;
            this.lnkSearch.TabStop = true;
            this.lnkSearch.Text = "Search";
            this.lnkSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSearch_LinkClicked);
            // 
            // txtIMEINumber
            // 
            this.txtIMEINumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIMEINumber.Location = new System.Drawing.Point(294, 79);
            this.txtIMEINumber.Name = "txtIMEINumber";
            this.txtIMEINumber.Size = new System.Drawing.Size(331, 34);
            this.txtIMEINumber.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(59, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(217, 29);
            this.label14.TabIndex = 28;
            this.label14.Text = "Enter IMEI Number";
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustName";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 180;
            // 
            // MobileNumber
            // 
            this.MobileNumber.DataPropertyName = "MobileNumber";
            this.MobileNumber.HeaderText = "Mobile Number";
            this.MobileNumber.MinimumWidth = 6;
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.Width = 150;
            // 
            // EmailId
            // 
            this.EmailId.DataPropertyName = "EmailId";
            this.EmailId.HeaderText = "Email ID";
            this.EmailId.MinimumWidth = 6;
            this.EmailId.Name = "EmailId";
            this.EmailId.Width = 150;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // UserHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 673);
            this.Controls.Add(this.tabCtrl);
            this.Name = "UserHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserHomepage";
            this.Load += new System.EventHandler(this.UserHomepage_Load);
            this.tabCtrl.ResumeLayout(false);
            this.tabSales.ResumeLayout(false);
            this.tabSales.PerformLayout();
            this.tabViewStock.ResumeLayout(false);
            this.tabViewStock.PerformLayout();
            this.tabSearchCustomer.ResumeLayout(false);
            this.tabSearchCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSearchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabSales;
        private System.Windows.Forms.TabPage tabViewStock;
        private System.Windows.Forms.TabPage tabSearchCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ComboBox cbModelNumber;
        private System.Windows.Forms.ComboBox cbCompanyName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPricePerPiece;
        private System.Windows.Forms.ComboBox cbIMEINumber;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbCompanyName_ViewStock;
        private System.Windows.Forms.TextBox txtStockAvailable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbModelNumber_ViewStock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIMEINumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dtgvSearchResult;
        private System.Windows.Forms.LinkLabel lnkSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}