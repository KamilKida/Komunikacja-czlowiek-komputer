namespace WarehouseManagementApp.Forms
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            p_Main = new Panel();
            btn_LogOut = new Button();
            tC_Main = new TabControl();
            tabPage1 = new TabPage();
            tV_Producers = new TreeView();
            btn_DeleteProduct = new Button();
            btn_AddProduct = new Button();
            dGV_Products = new DataGridView();
            CheckColumn = new DataGridViewCheckBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            AmountInMagazin = new DataGridViewTextBoxColumn();
            AomuntUnit = new DataGridViewTextBoxColumn();
            weightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            weightUnitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bS_Products = new BindingSource(components);
            btn_DeleteProducer = new Button();
            btn_AddProducer = new Button();
            tabPage3 = new TabPage();
            btn_DeleteClient = new Button();
            btn_AddClient = new Button();
            dGV_Clients = new DataGridView();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            bS_Clients = new BindingSource(components);
            tabPage2 = new TabPage();
            btn_SendOrder = new Button();
            btn_DeleteOrder = new Button();
            btn_AddOrder = new Button();
            dGV_Orders = new DataGridView();
            bS_Orders = new BindingSource(components);
            ColumnCheck = new DataGridViewCheckBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            ClientName = new DataGridViewTextBoxColumn();
            creationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sendDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            p_Main.SuspendLayout();
            tC_Main.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_Products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bS_Products).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_Clients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bS_Clients).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_Orders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bS_Orders).BeginInit();
            SuspendLayout();
            // 
            // p_Main
            // 
            p_Main.Controls.Add(btn_LogOut);
            p_Main.Controls.Add(tC_Main);
            p_Main.Dock = DockStyle.Fill;
            p_Main.Location = new Point(0, 0);
            p_Main.Name = "p_Main";
            p_Main.Size = new Size(1251, 748);
            p_Main.TabIndex = 0;
            // 
            // btn_LogOut
            // 
            btn_LogOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_LogOut.BackColor = Color.White;
            btn_LogOut.Cursor = Cursors.Hand;
            btn_LogOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_LogOut.Location = new Point(1070, 12);
            btn_LogOut.Name = "btn_LogOut";
            btn_LogOut.Size = new Size(169, 43);
            btn_LogOut.TabIndex = 1;
            btn_LogOut.Text = "  Wyloguj";
            btn_LogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_LogOut.UseVisualStyleBackColor = false;
            btn_LogOut.Click += btn_LogOut_Click;
            // 
            // tC_Main
            // 
            tC_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tC_Main.Controls.Add(tabPage1);
            tC_Main.Controls.Add(tabPage3);
            tC_Main.Controls.Add(tabPage2);
            tC_Main.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tC_Main.Location = new Point(0, 75);
            tC_Main.Name = "tC_Main";
            tC_Main.SelectedIndex = 0;
            tC_Main.Size = new Size(1251, 673);
            tC_Main.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tV_Producers);
            tabPage1.Controls.Add(btn_DeleteProduct);
            tabPage1.Controls.Add(btn_AddProduct);
            tabPage1.Controls.Add(dGV_Products);
            tabPage1.Controls.Add(btn_DeleteProducer);
            tabPage1.Controls.Add(btn_AddProducer);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1243, 645);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Towary";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tV_Producers
            // 
            tV_Producers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tV_Producers.CheckBoxes = true;
            tV_Producers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tV_Producers.Location = new Point(8, 6);
            tV_Producers.Name = "tV_Producers";
            tV_Producers.Size = new Size(344, 562);
            tV_Producers.TabIndex = 7;
            tV_Producers.AfterCheck += tV_Producers_AfterCheck;
            tV_Producers.NodeMouseClick += tV_Producers_NodeMouseClick;
            tV_Producers.MouseDoubleClick += tV_Producers_MouseDoubleClick;
            // 
            // btn_DeleteProduct
            // 
            btn_DeleteProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_DeleteProduct.BackColor = Color.White;
            btn_DeleteProduct.Cursor = Cursors.Hand;
            btn_DeleteProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_DeleteProduct.Location = new Point(1066, 583);
            btn_DeleteProduct.Name = "btn_DeleteProduct";
            btn_DeleteProduct.Size = new Size(169, 43);
            btn_DeleteProduct.TabIndex = 6;
            btn_DeleteProduct.Text = "  Usuń towar";
            btn_DeleteProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_DeleteProduct.UseVisualStyleBackColor = false;
            btn_DeleteProduct.Click += btn_DeleteProduct_Click;
            // 
            // btn_AddProduct
            // 
            btn_AddProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_AddProduct.BackColor = Color.White;
            btn_AddProduct.Cursor = Cursors.Hand;
            btn_AddProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_AddProduct.Location = new Point(891, 583);
            btn_AddProduct.Name = "btn_AddProduct";
            btn_AddProduct.Size = new Size(169, 43);
            btn_AddProduct.TabIndex = 5;
            btn_AddProduct.Text = "  Dodaj towar";
            btn_AddProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_AddProduct.UseVisualStyleBackColor = false;
            btn_AddProduct.Click += btn_Add_Click;
            // 
            // dGV_Products
            // 
            dGV_Products.AllowUserToAddRows = false;
            dGV_Products.AllowUserToDeleteRows = false;
            dGV_Products.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dGV_Products.AutoGenerateColumns = false;
            dGV_Products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_Products.BackgroundColor = Color.White;
            dGV_Products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_Products.Columns.AddRange(new DataGridViewColumn[] { CheckColumn, ProductName, AmountInMagazin, AomuntUnit, weightDataGridViewTextBoxColumn, weightUnitDataGridViewTextBoxColumn });
            dGV_Products.DataSource = bS_Products;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dGV_Products.DefaultCellStyle = dataGridViewCellStyle1;
            dGV_Products.Location = new Point(358, 6);
            dGV_Products.Name = "dGV_Products";
            dGV_Products.Size = new Size(877, 562);
            dGV_Products.TabIndex = 4;
            dGV_Products.CellClick += dGV_Products_CellClick;
            dGV_Products.DoubleClick += dGV_Products_DoubleClick;
            // 
            // CheckColumn
            // 
            CheckColumn.DataPropertyName = "Checked";
            CheckColumn.FillWeight = 30.456852F;
            CheckColumn.HeaderText = "";
            CheckColumn.Name = "CheckColumn";
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Nazwa";
            ProductName.Name = "ProductName";
            // 
            // AmountInMagazin
            // 
            AmountInMagazin.DataPropertyName = "AmountInMagazin";
            AmountInMagazin.HeaderText = "Ilość na magazynie";
            AmountInMagazin.Name = "AmountInMagazin";
            AmountInMagazin.ReadOnly = true;
            // 
            // AomuntUnit
            // 
            AomuntUnit.DataPropertyName = "AomuntUnit";
            AomuntUnit.HeaderText = "Ilość j.m.";
            AomuntUnit.Name = "AomuntUnit";
            AomuntUnit.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            weightDataGridViewTextBoxColumn.FillWeight = 113.90863F;
            weightDataGridViewTextBoxColumn.HeaderText = "Waga ";
            weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightUnitDataGridViewTextBoxColumn
            // 
            weightUnitDataGridViewTextBoxColumn.DataPropertyName = "WeightUnit";
            weightUnitDataGridViewTextBoxColumn.FillWeight = 113.90863F;
            weightUnitDataGridViewTextBoxColumn.HeaderText = "Waga Jm.";
            weightUnitDataGridViewTextBoxColumn.Name = "weightUnitDataGridViewTextBoxColumn";
            weightUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bS_Products
            // 
            bS_Products.DataSource = typeof(Dtos.Dtos.MagazinProduct);
            // 
            // btn_DeleteProducer
            // 
            btn_DeleteProducer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_DeleteProducer.BackColor = Color.White;
            btn_DeleteProducer.Cursor = Cursors.Hand;
            btn_DeleteProducer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_DeleteProducer.Location = new Point(183, 583);
            btn_DeleteProducer.Name = "btn_DeleteProducer";
            btn_DeleteProducer.Size = new Size(169, 43);
            btn_DeleteProducer.TabIndex = 3;
            btn_DeleteProducer.Text = "  Usuń producenta";
            btn_DeleteProducer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_DeleteProducer.UseVisualStyleBackColor = false;
            btn_DeleteProducer.Click += btn_DeleteProducer_Click;
            // 
            // btn_AddProducer
            // 
            btn_AddProducer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_AddProducer.BackColor = Color.White;
            btn_AddProducer.Cursor = Cursors.Hand;
            btn_AddProducer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_AddProducer.Location = new Point(8, 583);
            btn_AddProducer.Name = "btn_AddProducer";
            btn_AddProducer.Size = new Size(169, 43);
            btn_AddProducer.TabIndex = 2;
            btn_AddProducer.Text = "  Dodaj producenta";
            btn_AddProducer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_AddProducer.UseVisualStyleBackColor = false;
            btn_AddProducer.Click += btn_Add_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btn_DeleteClient);
            tabPage3.Controls.Add(btn_AddClient);
            tabPage3.Controls.Add(dGV_Clients);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1243, 645);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Klienci";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteClient
            // 
            btn_DeleteClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_DeleteClient.BackColor = Color.White;
            btn_DeleteClient.Cursor = Cursors.Hand;
            btn_DeleteClient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_DeleteClient.Location = new Point(1068, 65);
            btn_DeleteClient.Name = "btn_DeleteClient";
            btn_DeleteClient.Size = new Size(169, 43);
            btn_DeleteClient.TabIndex = 11;
            btn_DeleteClient.Text = "  Usuń klienta";
            btn_DeleteClient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_DeleteClient.UseVisualStyleBackColor = false;
            btn_DeleteClient.Click += btn_DeleteClient_Click;
            // 
            // btn_AddClient
            // 
            btn_AddClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_AddClient.BackColor = Color.White;
            btn_AddClient.Cursor = Cursors.Hand;
            btn_AddClient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_AddClient.Location = new Point(1068, 16);
            btn_AddClient.Name = "btn_AddClient";
            btn_AddClient.Size = new Size(169, 43);
            btn_AddClient.TabIndex = 10;
            btn_AddClient.Text = "  Dodaj klienta";
            btn_AddClient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_AddClient.UseVisualStyleBackColor = false;
            btn_AddClient.Click += btn_Add_Click;
            // 
            // dGV_Clients
            // 
            dGV_Clients.AllowUserToAddRows = false;
            dGV_Clients.AllowUserToDeleteRows = false;
            dGV_Clients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dGV_Clients.AutoGenerateColumns = false;
            dGV_Clients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_Clients.BackgroundColor = Color.White;
            dGV_Clients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_Clients.Columns.AddRange(new DataGridViewColumn[] { dataGridViewCheckBoxColumn1, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dGV_Clients.DataSource = bS_Clients;
            dGV_Clients.GridColor = Color.White;
            dGV_Clients.Location = new Point(5, 3);
            dGV_Clients.Name = "dGV_Clients";
            dGV_Clients.Size = new Size(1058, 639);
            dGV_Clients.TabIndex = 9;
            dGV_Clients.CellClick += dGV_Clients_CellClick;
            dGV_Clients.DoubleClick += dGV_Clients_DoubleClick;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.DataPropertyName = "Checked";
            dataGridViewCheckBoxColumn1.FillWeight = 30.456852F;
            dataGridViewCheckBoxColumn1.HeaderText = "";
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewTextBoxColumn1.HeaderText = "Nazwa";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Email";
            dataGridViewTextBoxColumn2.HeaderText = "E-mail";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Tel1";
            dataGridViewTextBoxColumn3.HeaderText = "Telefon 1";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Tel2";
            dataGridViewTextBoxColumn4.HeaderText = "Telefon 1";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // bS_Clients
            // 
            bS_Clients.DataSource = typeof(Dtos.Dtos.Client);
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btn_SendOrder);
            tabPage2.Controls.Add(btn_DeleteOrder);
            tabPage2.Controls.Add(btn_AddOrder);
            tabPage2.Controls.Add(dGV_Orders);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1243, 645);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Zamówienia";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_SendOrder
            // 
            btn_SendOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_SendOrder.BackColor = Color.White;
            btn_SendOrder.Cursor = Cursors.Hand;
            btn_SendOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_SendOrder.Location = new Point(1068, 135);
            btn_SendOrder.Name = "btn_SendOrder";
            btn_SendOrder.Size = new Size(169, 43);
            btn_SendOrder.TabIndex = 13;
            btn_SendOrder.Text = "  Wysłano zamówienie";
            btn_SendOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_SendOrder.UseVisualStyleBackColor = false;
            btn_SendOrder.Click += btn_SendOrder_Click;
            // 
            // btn_DeleteOrder
            // 
            btn_DeleteOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_DeleteOrder.BackColor = Color.White;
            btn_DeleteOrder.Cursor = Cursors.Hand;
            btn_DeleteOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_DeleteOrder.Location = new Point(1068, 65);
            btn_DeleteOrder.Name = "btn_DeleteOrder";
            btn_DeleteOrder.Size = new Size(169, 43);
            btn_DeleteOrder.TabIndex = 12;
            btn_DeleteOrder.Text = "  Usuń zamówienie";
            btn_DeleteOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_DeleteOrder.UseVisualStyleBackColor = false;
            btn_DeleteOrder.Click += btn_DeleteOrder_Click;
            // 
            // btn_AddOrder
            // 
            btn_AddOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_AddOrder.BackColor = Color.White;
            btn_AddOrder.Cursor = Cursors.Hand;
            btn_AddOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_AddOrder.Location = new Point(1068, 16);
            btn_AddOrder.Name = "btn_AddOrder";
            btn_AddOrder.Size = new Size(169, 43);
            btn_AddOrder.TabIndex = 11;
            btn_AddOrder.Text = "  Dodaj zamówienie";
            btn_AddOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_AddOrder.UseVisualStyleBackColor = false;
            btn_AddOrder.Click += btn_AddOrder_Click;
            // 
            // dGV_Orders
            // 
            dGV_Orders.AllowUserToAddRows = false;
            dGV_Orders.AllowUserToDeleteRows = false;
            dGV_Orders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dGV_Orders.AutoGenerateColumns = false;
            dGV_Orders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_Orders.BackgroundColor = Color.White;
            dGV_Orders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_Orders.Columns.AddRange(new DataGridViewColumn[] { ColumnCheck, Id, ClientName, creationDateDataGridViewTextBoxColumn, sendDateDataGridViewTextBoxColumn });
            dGV_Orders.DataSource = bS_Orders;
            dGV_Orders.GridColor = Color.White;
            dGV_Orders.Location = new Point(5, 3);
            dGV_Orders.Name = "dGV_Orders";
            dGV_Orders.Size = new Size(1058, 639);
            dGV_Orders.TabIndex = 10;
            dGV_Orders.CellClick += dGV_Orders_CellClick;
            dGV_Orders.DataBindingComplete += dGV_Orders_DataBindingComplete;
            dGV_Orders.DoubleClick += dGV_Orders_DoubleClick;
            // 
            // bS_Orders
            // 
            bS_Orders.DataSource = typeof(Dtos.Dtos.Order);
            // 
            // ColumnCheck
            // 
            ColumnCheck.DataPropertyName = "Checked";
            ColumnCheck.FillWeight = 30.456852F;
            ColumnCheck.HeaderText = "";
            ColumnCheck.Name = "ColumnCheck";
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Numer zamówienia";
            Id.Name = "Id";
            // 
            // ClientName
            // 
            ClientName.DataPropertyName = "ClientName";
            ClientName.HeaderText = "Nazwa klienta";
            ClientName.Name = "ClientName";
            ClientName.ReadOnly = true;
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
            creationDateDataGridViewTextBoxColumn.HeaderText = "Data stworzenia:";
            creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            // 
            // sendDateDataGridViewTextBoxColumn
            // 
            sendDateDataGridViewTextBoxColumn.DataPropertyName = "SendDate";
            sendDateDataGridViewTextBoxColumn.HeaderText = "Data wysyłki";
            sendDateDataGridViewTextBoxColumn.Name = "sendDateDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 748);
            Controls.Add(p_Main);
            MinimumSize = new Size(1267, 787);
            Name = "MainForm";
            Text = "Zarządzanie magazynem";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            p_Main.ResumeLayout(false);
            tC_Main.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGV_Products).EndInit();
            ((System.ComponentModel.ISupportInitialize)bS_Products).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGV_Clients).EndInit();
            ((System.ComponentModel.ISupportInitialize)bS_Clients).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGV_Orders).EndInit();
            ((System.ComponentModel.ISupportInitialize)bS_Orders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel p_Main;
        private Button btn_LogOut;
        private BindingSource bS_Products;
        private BindingSource bS_Clients;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceUnitDataGridViewTextBoxColumn;
        private TabControl tC_Main;
        private TabPage tabPage1;
        private TreeView tV_Producers;
        private Button btn_DeleteProduct;
        private Button btn_AddProduct;
        private DataGridView dGV_Products;
        private Button btn_DeleteProducer;
        private Button btn_AddProducer;
        private TabPage tabPage3;
        private Button btn_DeleteClient;
        private Button btn_AddClient;
        private DataGridView dGV_Clients;
        private TabPage tabPage2;
        private Button btn_SendOrder;
        private Button btn_DeleteOrder;
        private Button btn_AddOrder;
        private DataGridView dGV_Orders;
        private BindingSource bS_Orders;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewCheckBoxColumn CheckColumn;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn AmountInMagazin;
        private DataGridViewTextBoxColumn AomuntUnit;
        private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn weightUnitDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn ColumnCheck;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ClientName;
        private DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sendDateDataGridViewTextBoxColumn;
    }
}