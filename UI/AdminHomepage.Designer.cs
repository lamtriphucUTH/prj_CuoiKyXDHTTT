namespace prj_CuoiKyXDHTTT.UI
{
    partial class AdminHomepage
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.tabControlAdd = new System.Windows.Forms.TabControl();
            this.tabAddCompany = new System.Windows.Forms.TabPage();
            this.btnAddCom = new System.Windows.Forms.Button();
            this.txtComName = new System.Windows.Forms.TextBox();
            this.txtComId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAddModel = new System.Windows.Forms.TabPage();
            this.cbComName_Model = new System.Windows.Forms.ComboBox();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.txtModelNum = new System.Windows.Forms.TextBox();
            this.txtModelId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabAddMobile = new System.Windows.Forms.TabPage();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtIMEI = new System.Windows.Forms.TextBox();
            this.cbWarranty = new System.Windows.Forms.ComboBox();
            this.cbModelNum_Mobile = new System.Windows.Forms.ComboBox();
            this.cbComName_Mobile = new System.Windows.Forms.ComboBox();
            this.btnAddMobile = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabUpdateStock = new System.Windows.Forms.TabPage();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.cbModelNum = new System.Windows.Forms.ComboBox();
            this.cbComName = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtTransId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabSaleReport = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabReportByDay = new System.Windows.Forms.TabPage();
            this.lblTotalByDay = new System.Windows.Forms.Label();
            this.dtgvReportByDay = new System.Windows.Forms.DataGridView();
            this.SlsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMEINO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchByDay = new System.Windows.Forms.Button();
            this.dtpSelectDay = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPeportDtoD = new System.Windows.Forms.TabPage();
            this.lblTotalDtoD = new System.Windows.Forms.Label();
            this.dtgvReportDtoD = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchDtoD = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.txtHint = new System.Windows.Forms.TextBox();
            this.txtRetypePass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEployeeName = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabControlAdd.SuspendLayout();
            this.tabAddCompany.SuspendLayout();
            this.tabAddModel.SuspendLayout();
            this.tabAddMobile.SuspendLayout();
            this.tabUpdateStock.SuspendLayout();
            this.tabSaleReport.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabReportByDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReportByDay)).BeginInit();
            this.tabPeportDtoD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReportDtoD)).BeginInit();
            this.tabEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabAdd);
            this.tabMain.Controls.Add(this.tabUpdateStock);
            this.tabMain.Controls.Add(this.tabSaleReport);
            this.tabMain.Controls.Add(this.tabEmployee);
            this.tabMain.Location = new System.Drawing.Point(-1, -1);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(841, 670);
            this.tabMain.TabIndex = 0;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.tabControlAdd);
            this.tabAdd.Location = new System.Drawing.Point(4, 38);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(833, 628);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Add";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // tabControlAdd
            // 
            this.tabControlAdd.Controls.Add(this.tabAddCompany);
            this.tabControlAdd.Controls.Add(this.tabAddModel);
            this.tabControlAdd.Controls.Add(this.tabAddMobile);
            this.tabControlAdd.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdd.Name = "tabControlAdd";
            this.tabControlAdd.SelectedIndex = 0;
            this.tabControlAdd.Size = new System.Drawing.Size(827, 622);
            this.tabControlAdd.TabIndex = 0;
            this.tabControlAdd.SelectedIndexChanged += new System.EventHandler(this.tabControlAdd_SelectedIndexChanged);
            // 
            // tabAddCompany
            // 
            this.tabAddCompany.Controls.Add(this.btnAddCom);
            this.tabAddCompany.Controls.Add(this.txtComName);
            this.tabAddCompany.Controls.Add(this.txtComId);
            this.tabAddCompany.Controls.Add(this.label2);
            this.tabAddCompany.Controls.Add(this.label1);
            this.tabAddCompany.Location = new System.Drawing.Point(4, 38);
            this.tabAddCompany.Name = "tabAddCompany";
            this.tabAddCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddCompany.Size = new System.Drawing.Size(819, 580);
            this.tabAddCompany.TabIndex = 0;
            this.tabAddCompany.Text = "Company";
            this.tabAddCompany.UseVisualStyleBackColor = true;
            // 
            // btnAddCom
            // 
            this.btnAddCom.Location = new System.Drawing.Point(290, 233);
            this.btnAddCom.Name = "btnAddCom";
            this.btnAddCom.Size = new System.Drawing.Size(141, 62);
            this.btnAddCom.TabIndex = 2;
            this.btnAddCom.Text = "Add";
            this.btnAddCom.UseVisualStyleBackColor = true;
            this.btnAddCom.Click += new System.EventHandler(this.btnAddCom_Click);
            // 
            // txtComName
            // 
            this.txtComName.Location = new System.Drawing.Point(365, 125);
            this.txtComName.Name = "txtComName";
            this.txtComName.Size = new System.Drawing.Size(320, 34);
            this.txtComName.TabIndex = 1;
            // 
            // txtComId
            // 
            this.txtComId.Location = new System.Drawing.Point(365, 49);
            this.txtComId.Name = "txtComId";
            this.txtComId.Size = new System.Drawing.Size(320, 34);
            this.txtComId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Company Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company ID:";
            // 
            // tabAddModel
            // 
            this.tabAddModel.Controls.Add(this.cbComName_Model);
            this.tabAddModel.Controls.Add(this.btnAddModel);
            this.tabAddModel.Controls.Add(this.txtModelNum);
            this.tabAddModel.Controls.Add(this.txtModelId);
            this.tabAddModel.Controls.Add(this.label5);
            this.tabAddModel.Controls.Add(this.label4);
            this.tabAddModel.Controls.Add(this.label3);
            this.tabAddModel.Location = new System.Drawing.Point(4, 38);
            this.tabAddModel.Name = "tabAddModel";
            this.tabAddModel.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddModel.Size = new System.Drawing.Size(819, 580);
            this.tabAddModel.TabIndex = 1;
            this.tabAddModel.Text = "Model";
            this.tabAddModel.UseVisualStyleBackColor = true;
            // 
            // cbComName_Model
            // 
            this.cbComName_Model.FormattingEnabled = true;
            this.cbComName_Model.Location = new System.Drawing.Point(365, 133);
            this.cbComName_Model.Name = "cbComName_Model";
            this.cbComName_Model.Size = new System.Drawing.Size(320, 37);
            this.cbComName_Model.TabIndex = 3;
            // 
            // btnAddModel
            // 
            this.btnAddModel.Location = new System.Drawing.Point(318, 307);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(140, 67);
            this.btnAddModel.TabIndex = 2;
            this.btnAddModel.Text = "Add";
            this.btnAddModel.UseVisualStyleBackColor = true;
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);
            // 
            // txtModelNum
            // 
            this.txtModelNum.Location = new System.Drawing.Point(365, 204);
            this.txtModelNum.Name = "txtModelNum";
            this.txtModelNum.Size = new System.Drawing.Size(320, 34);
            this.txtModelNum.TabIndex = 1;
            // 
            // txtModelId
            // 
            this.txtModelId.Location = new System.Drawing.Point(365, 49);
            this.txtModelId.Name = "txtModelId";
            this.txtModelId.Size = new System.Drawing.Size(320, 34);
            this.txtModelId.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Model Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Company Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Model ID:";
            // 
            // tabAddMobile
            // 
            this.tabAddMobile.Controls.Add(this.txtPrice);
            this.tabAddMobile.Controls.Add(this.txtIMEI);
            this.tabAddMobile.Controls.Add(this.cbWarranty);
            this.tabAddMobile.Controls.Add(this.cbModelNum_Mobile);
            this.tabAddMobile.Controls.Add(this.cbComName_Mobile);
            this.tabAddMobile.Controls.Add(this.btnAddMobile);
            this.tabAddMobile.Controls.Add(this.label10);
            this.tabAddMobile.Controls.Add(this.label9);
            this.tabAddMobile.Controls.Add(this.label8);
            this.tabAddMobile.Controls.Add(this.label7);
            this.tabAddMobile.Controls.Add(this.label6);
            this.tabAddMobile.Location = new System.Drawing.Point(4, 38);
            this.tabAddMobile.Name = "tabAddMobile";
            this.tabAddMobile.Size = new System.Drawing.Size(819, 580);
            this.tabAddMobile.TabIndex = 2;
            this.tabAddMobile.Text = "Mobile";
            this.tabAddMobile.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(365, 286);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(320, 34);
            this.txtPrice.TabIndex = 3;
            // 
            // txtIMEI
            // 
            this.txtIMEI.Location = new System.Drawing.Point(365, 204);
            this.txtIMEI.Name = "txtIMEI";
            this.txtIMEI.Size = new System.Drawing.Size(320, 34);
            this.txtIMEI.TabIndex = 3;
            // 
            // cbWarranty
            // 
            this.cbWarranty.FormattingEnabled = true;
            this.cbWarranty.Location = new System.Drawing.Point(365, 362);
            this.cbWarranty.Name = "cbWarranty";
            this.cbWarranty.Size = new System.Drawing.Size(320, 37);
            this.cbWarranty.TabIndex = 2;
            // 
            // cbModelNum_Mobile
            // 
            this.cbModelNum_Mobile.FormattingEnabled = true;
            this.cbModelNum_Mobile.Location = new System.Drawing.Point(365, 122);
            this.cbModelNum_Mobile.Name = "cbModelNum_Mobile";
            this.cbModelNum_Mobile.Size = new System.Drawing.Size(320, 37);
            this.cbModelNum_Mobile.TabIndex = 2;
            // 
            // cbComName_Mobile
            // 
            this.cbComName_Mobile.FormattingEnabled = true;
            this.cbComName_Mobile.Location = new System.Drawing.Point(365, 49);
            this.cbComName_Mobile.Name = "cbComName_Mobile";
            this.cbComName_Mobile.Size = new System.Drawing.Size(320, 37);
            this.cbComName_Mobile.TabIndex = 2;
            // 
            // btnAddMobile
            // 
            this.btnAddMobile.Location = new System.Drawing.Point(342, 460);
            this.btnAddMobile.Name = "btnAddMobile";
            this.btnAddMobile.Size = new System.Drawing.Size(119, 59);
            this.btnAddMobile.TabIndex = 1;
            this.btnAddMobile.Text = "Add";
            this.btnAddMobile.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(99, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Warranty Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(99, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "IMEI Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Model Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Company Name:";
            // 
            // tabUpdateStock
            // 
            this.tabUpdateStock.Controls.Add(this.btnUpdateStock);
            this.tabUpdateStock.Controls.Add(this.cbModelNum);
            this.tabUpdateStock.Controls.Add(this.cbComName);
            this.tabUpdateStock.Controls.Add(this.txtAmount);
            this.tabUpdateStock.Controls.Add(this.txtQuantity);
            this.tabUpdateStock.Controls.Add(this.txtTransId);
            this.tabUpdateStock.Controls.Add(this.label15);
            this.tabUpdateStock.Controls.Add(this.label14);
            this.tabUpdateStock.Controls.Add(this.label13);
            this.tabUpdateStock.Controls.Add(this.label12);
            this.tabUpdateStock.Controls.Add(this.label11);
            this.tabUpdateStock.Location = new System.Drawing.Point(4, 38);
            this.tabUpdateStock.Name = "tabUpdateStock";
            this.tabUpdateStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateStock.Size = new System.Drawing.Size(833, 628);
            this.tabUpdateStock.TabIndex = 1;
            this.tabUpdateStock.Text = "Update Stock";
            this.tabUpdateStock.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Location = new System.Drawing.Point(336, 479);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(127, 57);
            this.btnUpdateStock.TabIndex = 3;
            this.btnUpdateStock.Text = "Update";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            // 
            // cbModelNum
            // 
            this.cbModelNum.FormattingEnabled = true;
            this.cbModelNum.Location = new System.Drawing.Point(365, 202);
            this.cbModelNum.Name = "cbModelNum";
            this.cbModelNum.Size = new System.Drawing.Size(320, 37);
            this.cbModelNum.TabIndex = 2;
            // 
            // cbComName
            // 
            this.cbComName.FormattingEnabled = true;
            this.cbComName.Location = new System.Drawing.Point(365, 122);
            this.cbComName.Name = "cbComName";
            this.cbComName.Size = new System.Drawing.Size(320, 37);
            this.cbComName.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(365, 365);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(320, 34);
            this.txtAmount.TabIndex = 1;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(365, 286);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(320, 34);
            this.txtQuantity.TabIndex = 1;
            // 
            // txtTransId
            // 
            this.txtTransId.Location = new System.Drawing.Point(365, 49);
            this.txtTransId.Name = "txtTransId";
            this.txtTransId.Size = new System.Drawing.Size(320, 34);
            this.txtTransId.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(99, 370);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 29);
            this.label15.TabIndex = 0;
            this.label15.Text = "Amount:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(99, 290);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 29);
            this.label14.TabIndex = 0;
            this.label14.Text = "Quantity:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(99, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 29);
            this.label13.TabIndex = 0;
            this.label13.Text = "Model Number:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(99, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "Company Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(99, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 29);
            this.label11.TabIndex = 0;
            this.label11.Text = "Trans ID:";
            // 
            // tabSaleReport
            // 
            this.tabSaleReport.Controls.Add(this.tabControl3);
            this.tabSaleReport.Location = new System.Drawing.Point(4, 38);
            this.tabSaleReport.Name = "tabSaleReport";
            this.tabSaleReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabSaleReport.Size = new System.Drawing.Size(833, 628);
            this.tabSaleReport.TabIndex = 2;
            this.tabSaleReport.Text = "Sale Report";
            this.tabSaleReport.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabReportByDay);
            this.tabControl3.Controls.Add(this.tabPeportDtoD);
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(832, 625);
            this.tabControl3.TabIndex = 0;
            // 
            // tabReportByDay
            // 
            this.tabReportByDay.Controls.Add(this.lblTotalByDay);
            this.tabReportByDay.Controls.Add(this.dtgvReportByDay);
            this.tabReportByDay.Controls.Add(this.btnSearchByDay);
            this.tabReportByDay.Controls.Add(this.dtpSelectDay);
            this.tabReportByDay.Controls.Add(this.label16);
            this.tabReportByDay.Location = new System.Drawing.Point(4, 38);
            this.tabReportByDay.Name = "tabReportByDay";
            this.tabReportByDay.Padding = new System.Windows.Forms.Padding(3);
            this.tabReportByDay.Size = new System.Drawing.Size(824, 583);
            this.tabReportByDay.TabIndex = 0;
            this.tabReportByDay.Text = "Day";
            this.tabReportByDay.UseVisualStyleBackColor = true;
            // 
            // lblTotalByDay
            // 
            this.lblTotalByDay.AutoSize = true;
            this.lblTotalByDay.Location = new System.Drawing.Point(25, 504);
            this.lblTotalByDay.Name = "lblTotalByDay";
            this.lblTotalByDay.Size = new System.Drawing.Size(25, 29);
            this.lblTotalByDay.TabIndex = 4;
            this.lblTotalByDay.Text = "?";
            // 
            // dtgvReportByDay
            // 
            this.dtgvReportByDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReportByDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlsID,
            this.CompanyName,
            this.ModelNum,
            this.IMEINO,
            this.Price});
            this.dtgvReportByDay.Location = new System.Drawing.Point(30, 132);
            this.dtgvReportByDay.Name = "dtgvReportByDay";
            this.dtgvReportByDay.RowHeadersWidth = 51;
            this.dtgvReportByDay.RowTemplate.Height = 24;
            this.dtgvReportByDay.Size = new System.Drawing.Size(762, 320);
            this.dtgvReportByDay.TabIndex = 3;
            // 
            // SlsID
            // 
            this.SlsID.HeaderText = "SlsId";
            this.SlsID.MinimumWidth = 6;
            this.SlsID.Name = "SlsID";
            this.SlsID.Width = 80;
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "Company Name";
            this.CompanyName.MinimumWidth = 6;
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Width = 220;
            // 
            // ModelNum
            // 
            this.ModelNum.HeaderText = "Model Num";
            this.ModelNum.MinimumWidth = 6;
            this.ModelNum.Name = "ModelNum";
            this.ModelNum.Width = 180;
            // 
            // IMEINO
            // 
            this.IMEINO.HeaderText = "IMEINO";
            this.IMEINO.MinimumWidth = 6;
            this.IMEINO.Name = "IMEINO";
            this.IMEINO.Width = 180;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 150;
            // 
            // btnSearchByDay
            // 
            this.btnSearchByDay.Location = new System.Drawing.Point(568, 35);
            this.btnSearchByDay.Name = "btnSearchByDay";
            this.btnSearchByDay.Size = new System.Drawing.Size(129, 55);
            this.btnSearchByDay.TabIndex = 2;
            this.btnSearchByDay.Text = "Search";
            this.btnSearchByDay.UseVisualStyleBackColor = true;
            // 
            // dtpSelectDay
            // 
            this.dtpSelectDay.CustomFormat = "dd-MM-yyyy";
            this.dtpSelectDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSelectDay.Location = new System.Drawing.Point(251, 49);
            this.dtpSelectDay.Name = "dtpSelectDay";
            this.dtpSelectDay.Size = new System.Drawing.Size(189, 34);
            this.dtpSelectDay.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(99, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 29);
            this.label16.TabIndex = 0;
            this.label16.Text = "Select Day:";
            // 
            // tabPeportDtoD
            // 
            this.tabPeportDtoD.Controls.Add(this.lblTotalDtoD);
            this.tabPeportDtoD.Controls.Add(this.dtgvReportDtoD);
            this.tabPeportDtoD.Controls.Add(this.btnSearchDtoD);
            this.tabPeportDtoD.Controls.Add(this.dtpEnd);
            this.tabPeportDtoD.Controls.Add(this.dtpStart);
            this.tabPeportDtoD.Controls.Add(this.label19);
            this.tabPeportDtoD.Controls.Add(this.label18);
            this.tabPeportDtoD.Location = new System.Drawing.Point(4, 38);
            this.tabPeportDtoD.Name = "tabPeportDtoD";
            this.tabPeportDtoD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPeportDtoD.Size = new System.Drawing.Size(824, 583);
            this.tabPeportDtoD.TabIndex = 1;
            this.tabPeportDtoD.Text = "Date to Date";
            this.tabPeportDtoD.UseVisualStyleBackColor = true;
            // 
            // lblTotalDtoD
            // 
            this.lblTotalDtoD.AutoSize = true;
            this.lblTotalDtoD.Location = new System.Drawing.Point(23, 517);
            this.lblTotalDtoD.Name = "lblTotalDtoD";
            this.lblTotalDtoD.Size = new System.Drawing.Size(25, 29);
            this.lblTotalDtoD.TabIndex = 4;
            this.lblTotalDtoD.Text = "?";
            // 
            // dtgvReportDtoD
            // 
            this.dtgvReportDtoD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReportDtoD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.comName,
            this.model,
            this.imei,
            this.prc});
            this.dtgvReportDtoD.Location = new System.Drawing.Point(28, 184);
            this.dtgvReportDtoD.Name = "dtgvReportDtoD";
            this.dtgvReportDtoD.RowHeadersWidth = 51;
            this.dtgvReportDtoD.RowTemplate.Height = 24;
            this.dtgvReportDtoD.Size = new System.Drawing.Size(766, 278);
            this.dtgvReportDtoD.TabIndex = 3;
            // 
            // id
            // 
            this.id.HeaderText = "SlsID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 80;
            // 
            // comName
            // 
            this.comName.HeaderText = "CompanyName";
            this.comName.MinimumWidth = 6;
            this.comName.Name = "comName";
            this.comName.Width = 220;
            // 
            // model
            // 
            this.model.HeaderText = "Model Num";
            this.model.MinimumWidth = 6;
            this.model.Name = "model";
            this.model.Width = 125;
            // 
            // imei
            // 
            this.imei.HeaderText = "IMEINO";
            this.imei.MinimumWidth = 6;
            this.imei.Name = "imei";
            this.imei.Width = 125;
            // 
            // prc
            // 
            this.prc.HeaderText = "Price";
            this.prc.MinimumWidth = 6;
            this.prc.Name = "prc";
            this.prc.Width = 125;
            // 
            // btnSearchDtoD
            // 
            this.btnSearchDtoD.Location = new System.Drawing.Point(565, 54);
            this.btnSearchDtoD.Name = "btnSearchDtoD";
            this.btnSearchDtoD.Size = new System.Drawing.Size(114, 52);
            this.btnSearchDtoD.TabIndex = 2;
            this.btnSearchDtoD.Text = "Search";
            this.btnSearchDtoD.UseVisualStyleBackColor = true;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd-MM-yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(285, 94);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(186, 34);
            this.dtpEnd.TabIndex = 1;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd-MM-yyyy";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(285, 34);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(186, 34);
            this.dtpStart.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(111, 99);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 29);
            this.label19.TabIndex = 0;
            this.label19.Text = "Ending Date:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(111, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(157, 29);
            this.label18.TabIndex = 0;
            this.label18.Text = "Starting Date:";
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.btnAddEmployee);
            this.tabEmployee.Controls.Add(this.txtHint);
            this.tabEmployee.Controls.Add(this.txtRetypePass);
            this.tabEmployee.Controls.Add(this.txtPass);
            this.tabEmployee.Controls.Add(this.txtUsername);
            this.tabEmployee.Controls.Add(this.txtMobile);
            this.tabEmployee.Controls.Add(this.txtAddress);
            this.tabEmployee.Controls.Add(this.txtEployeeName);
            this.tabEmployee.Controls.Add(this.label27);
            this.tabEmployee.Controls.Add(this.label26);
            this.tabEmployee.Controls.Add(this.label25);
            this.tabEmployee.Controls.Add(this.label24);
            this.tabEmployee.Controls.Add(this.label23);
            this.tabEmployee.Controls.Add(this.label22);
            this.tabEmployee.Controls.Add(this.label21);
            this.tabEmployee.Location = new System.Drawing.Point(4, 38);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(833, 628);
            this.tabEmployee.TabIndex = 3;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(337, 505);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(120, 56);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // txtHint
            // 
            this.txtHint.Location = new System.Drawing.Point(365, 405);
            this.txtHint.Name = "txtHint";
            this.txtHint.Size = new System.Drawing.Size(320, 34);
            this.txtHint.TabIndex = 1;
            // 
            // txtRetypePass
            // 
            this.txtRetypePass.Location = new System.Drawing.Point(365, 345);
            this.txtRetypePass.Name = "txtRetypePass";
            this.txtRetypePass.Size = new System.Drawing.Size(320, 34);
            this.txtRetypePass.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(365, 285);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(320, 34);
            this.txtPass.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(365, 225);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(320, 34);
            this.txtUsername.TabIndex = 1;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(365, 165);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(320, 34);
            this.txtMobile.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(365, 105);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(320, 34);
            this.txtAddress.TabIndex = 1;
            // 
            // txtEployeeName
            // 
            this.txtEployeeName.Location = new System.Drawing.Point(365, 50);
            this.txtEployeeName.Name = "txtEployeeName";
            this.txtEployeeName.Size = new System.Drawing.Size(320, 34);
            this.txtEployeeName.TabIndex = 1;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(100, 410);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(61, 29);
            this.label27.TabIndex = 0;
            this.label27.Text = "Hint:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(100, 350);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(208, 29);
            this.label26.TabIndex = 0;
            this.label26.Text = "Retype Password:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(100, 290);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(126, 29);
            this.label25.TabIndex = 0;
            this.label25.Text = "Password:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(100, 230);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(130, 29);
            this.label24.TabIndex = 0;
            this.label24.Text = "Username:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(100, 170);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(93, 29);
            this.label23.TabIndex = 0;
            this.label23.Text = "Mobile:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(100, 110);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 29);
            this.label22.TabIndex = 0;
            this.label22.Text = "Address:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(100, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(199, 29);
            this.label21.TabIndex = 0;
            this.label21.Text = "Employee Name:";
            // 
            // AdminHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 673);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "AdminHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHomepage";
            this.Load += new System.EventHandler(this.AdminHomepage_Load);
            this.tabMain.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabControlAdd.ResumeLayout(false);
            this.tabAddCompany.ResumeLayout(false);
            this.tabAddCompany.PerformLayout();
            this.tabAddModel.ResumeLayout(false);
            this.tabAddModel.PerformLayout();
            this.tabAddMobile.ResumeLayout(false);
            this.tabAddMobile.PerformLayout();
            this.tabUpdateStock.ResumeLayout(false);
            this.tabUpdateStock.PerformLayout();
            this.tabSaleReport.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabReportByDay.ResumeLayout(false);
            this.tabReportByDay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReportByDay)).EndInit();
            this.tabPeportDtoD.ResumeLayout(false);
            this.tabPeportDtoD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReportDtoD)).EndInit();
            this.tabEmployee.ResumeLayout(false);
            this.tabEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabControl tabControlAdd;
        private System.Windows.Forms.TabPage tabAddCompany;
        private System.Windows.Forms.TabPage tabAddModel;
        private System.Windows.Forms.TabPage tabAddMobile;
        private System.Windows.Forms.TabPage tabUpdateStock;
        private System.Windows.Forms.TabPage tabSaleReport;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TextBox txtComName;
        private System.Windows.Forms.TextBox txtComId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModelNum;
        private System.Windows.Forms.TextBox txtModelId;
        private System.Windows.Forms.Button btnAddModel;
        private System.Windows.Forms.Button btnAddMobile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtIMEI;
        private System.Windows.Forms.ComboBox cbWarranty;
        private System.Windows.Forms.ComboBox cbModelNum_Mobile;
        private System.Windows.Forms.ComboBox cbComName_Mobile;
        private System.Windows.Forms.ComboBox cbComName_Model;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTransId;
        private System.Windows.Forms.ComboBox cbModelNum;
        private System.Windows.Forms.ComboBox cbComName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabReportByDay;
        private System.Windows.Forms.TabPage tabPeportDtoD;
        private System.Windows.Forms.DateTimePicker dtpSelectDay;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dtgvReportByDay;
        private System.Windows.Forms.Button btnSearchByDay;
        private System.Windows.Forms.Label lblTotalByDay;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSearchDtoD;
        private System.Windows.Forms.Label lblTotalDtoD;
        private System.Windows.Forms.DataGridView dtgvReportDtoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMEINO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn comName;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn imei;
        private System.Windows.Forms.DataGridViewTextBoxColumn prc;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.TextBox txtHint;
        private System.Windows.Forms.TextBox txtRetypePass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEployeeName;
    }
}