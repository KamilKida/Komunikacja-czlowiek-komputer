namespace WarehouseManagementApp.Forms
{
    partial class OrderForm
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
            btn_ClientList = new Button();
            cB_ReapeatList = new ComboBox();
            dTP_SendDate = new DateTimePicker();
            dTP_OrderCreation = new DateTimePicker();
            l_Repeat = new Label();
            cB_Repeat = new CheckBox();
            l_SendDate = new Label();
            l_OrderCreation = new Label();
            tB_ClientName = new TextBox();
            tB_OrderNumber = new TextBox();
            p_Buttons = new Panel();
            label2 = new Label();
            label1 = new Label();
            tB_BruttoSum = new TextBox();
            btn_Save = new Button();
            btn_DeleteProduct = new Button();
            btn_AddProduct = new Button();
            tB_NetSum = new TextBox();
            dGV_Products = new DataGridView();
            bS_OrderProducts = new BindingSource(components);
            Column1 = new DataGridViewCheckBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            OrderedAmount = new DataGridViewTextBoxColumn();
            OrderedAmountUnit = new DataGridViewTextBoxColumn();
            Gross = new DataGridViewTextBoxColumn();
            c_Net = new DataGridViewTextBoxColumn();
            GrossUnit = new DataGridViewTextBoxColumn();
            p_Main.SuspendLayout();
            p_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_Products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bS_OrderProducts).BeginInit();
            SuspendLayout();
            // 
            // p_Main
            // 
            p_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p_Main.Controls.Add(btn_ClientList);
            p_Main.Controls.Add(cB_ReapeatList);
            p_Main.Controls.Add(dTP_SendDate);
            p_Main.Controls.Add(dTP_OrderCreation);
            p_Main.Controls.Add(l_Repeat);
            p_Main.Controls.Add(cB_Repeat);
            p_Main.Controls.Add(l_SendDate);
            p_Main.Controls.Add(l_OrderCreation);
            p_Main.Controls.Add(tB_ClientName);
            p_Main.Controls.Add(tB_OrderNumber);
            p_Main.Location = new Point(0, 0);
            p_Main.Name = "p_Main";
            p_Main.Size = new Size(1357, 224);
            p_Main.TabIndex = 0;
            // 
            // btn_ClientList
            // 
            btn_ClientList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_ClientList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btn_ClientList.Location = new Point(1316, 24);
            btn_ClientList.Name = "btn_ClientList";
            btn_ClientList.Size = new Size(29, 29);
            btn_ClientList.TabIndex = 12;
            btn_ClientList.UseVisualStyleBackColor = true;
            btn_ClientList.Visible = false;
            btn_ClientList.Click += btn_ClientList_Click;
            // 
            // cB_ReapeatList
            // 
            cB_ReapeatList.Enabled = false;
            cB_ReapeatList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cB_ReapeatList.FormattingEnabled = true;
            cB_ReapeatList.Location = new Point(434, 102);
            cB_ReapeatList.Name = "cB_ReapeatList";
            cB_ReapeatList.Size = new Size(186, 29);
            cB_ReapeatList.TabIndex = 11;
            // 
            // dTP_SendDate
            // 
            dTP_SendDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dTP_SendDate.Location = new Point(31, 172);
            dTP_SendDate.Name = "dTP_SendDate";
            dTP_SendDate.Size = new Size(283, 29);
            dTP_SendDate.TabIndex = 10;
            dTP_SendDate.ValueChanged += dTP_SendOrder_ValueChanged;
            // 
            // dTP_OrderCreation
            // 
            dTP_OrderCreation.Enabled = false;
            dTP_OrderCreation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dTP_OrderCreation.Location = new Point(31, 99);
            dTP_OrderCreation.Name = "dTP_OrderCreation";
            dTP_OrderCreation.Size = new Size(283, 29);
            dTP_OrderCreation.TabIndex = 9;
            // 
            // l_Repeat
            // 
            l_Repeat.AutoSize = true;
            l_Repeat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            l_Repeat.Location = new Point(413, 78);
            l_Repeat.Name = "l_Repeat";
            l_Repeat.Size = new Size(196, 21);
            l_Repeat.TabIndex = 8;
            l_Repeat.Text = "Częstotliwośc powtarzania:";
            // 
            // cB_Repeat
            // 
            cB_Repeat.AutoSize = true;
            cB_Repeat.Enabled = false;
            cB_Repeat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cB_Repeat.Location = new Point(413, 109);
            cB_Repeat.Name = "cB_Repeat";
            cB_Repeat.Size = new Size(15, 14);
            cB_Repeat.TabIndex = 6;
            cB_Repeat.UseVisualStyleBackColor = true;
            cB_Repeat.CheckedChanged += cB_Repeat_CheckedChanged;
            // 
            // l_SendDate
            // 
            l_SendDate.AutoSize = true;
            l_SendDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            l_SendDate.Location = new Point(31, 148);
            l_SendDate.Name = "l_SendDate";
            l_SendDate.Size = new Size(178, 21);
            l_SendDate.TabIndex = 5;
            l_SendDate.Text = "Planowana data wysyłki:";
            // 
            // l_OrderCreation
            // 
            l_OrderCreation.AutoSize = true;
            l_OrderCreation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            l_OrderCreation.Location = new Point(31, 77);
            l_OrderCreation.Name = "l_OrderCreation";
            l_OrderCreation.Size = new Size(126, 21);
            l_OrderCreation.TabIndex = 4;
            l_OrderCreation.Text = "Data utworzenia:";
            // 
            // tB_ClientName
            // 
            tB_ClientName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tB_ClientName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tB_ClientName.Location = new Point(247, 24);
            tB_ClientName.Name = "tB_ClientName";
            tB_ClientName.ReadOnly = true;
            tB_ClientName.Size = new Size(1063, 29);
            tB_ClientName.TabIndex = 1;
            // 
            // tB_OrderNumber
            // 
            tB_OrderNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tB_OrderNumber.Location = new Point(31, 24);
            tB_OrderNumber.Name = "tB_OrderNumber";
            tB_OrderNumber.Size = new Size(178, 29);
            tB_OrderNumber.TabIndex = 0;
            tB_OrderNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // p_Buttons
            // 
            p_Buttons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p_Buttons.Controls.Add(label2);
            p_Buttons.Controls.Add(label1);
            p_Buttons.Controls.Add(tB_BruttoSum);
            p_Buttons.Controls.Add(btn_Save);
            p_Buttons.Controls.Add(btn_DeleteProduct);
            p_Buttons.Controls.Add(btn_AddProduct);
            p_Buttons.Controls.Add(tB_NetSum);
            p_Buttons.Controls.Add(dGV_Products);
            p_Buttons.Location = new Point(0, 217);
            p_Buttons.Name = "p_Buttons";
            p_Buttons.Size = new Size(1357, 439);
            p_Buttons.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(1176, 307);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 11;
            label2.Text = "Suma netto:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(1176, 251);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 10;
            label1.Text = "Suma brutto:";
            // 
            // tB_BruttoSum
            // 
            tB_BruttoSum.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tB_BruttoSum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_BruttoSum.Location = new Point(1176, 275);
            tB_BruttoSum.Name = "tB_BruttoSum";
            tB_BruttoSum.ReadOnly = true;
            tB_BruttoSum.Size = new Size(176, 29);
            tB_BruttoSum.TabIndex = 9;
            tB_BruttoSum.Text = "0,00 zł";
            // 
            // btn_Save
            // 
            btn_Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Save.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_Save.Location = new Point(1176, 384);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(169, 43);
            btn_Save.TabIndex = 8;
            btn_Save.Text = "  Zapisz zmiany";
            btn_Save.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_DeleteProduct
            // 
            btn_DeleteProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_DeleteProduct.BackColor = Color.White;
            btn_DeleteProduct.Cursor = Cursors.Hand;
            btn_DeleteProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_DeleteProduct.Location = new Point(1176, 62);
            btn_DeleteProduct.Name = "btn_DeleteProduct";
            btn_DeleteProduct.Size = new Size(169, 43);
            btn_DeleteProduct.TabIndex = 7;
            btn_DeleteProduct.Text = "  Usuń towar";
            btn_DeleteProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_DeleteProduct.UseVisualStyleBackColor = false;
            btn_DeleteProduct.Click += btn_DeleteProduct_Click;
            // 
            // btn_AddProduct
            // 
            btn_AddProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_AddProduct.BackColor = Color.White;
            btn_AddProduct.Cursor = Cursors.Hand;
            btn_AddProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_AddProduct.Location = new Point(1176, 13);
            btn_AddProduct.Name = "btn_AddProduct";
            btn_AddProduct.Size = new Size(169, 43);
            btn_AddProduct.TabIndex = 6;
            btn_AddProduct.Text = "  Dodaj towar";
            btn_AddProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_AddProduct.UseVisualStyleBackColor = false;
            btn_AddProduct.Click += btn_AddProduct_Click;
            // 
            // tB_NetSum
            // 
            tB_NetSum.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tB_NetSum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_NetSum.Location = new Point(1176, 331);
            tB_NetSum.Name = "tB_NetSum";
            tB_NetSum.Size = new Size(176, 29);
            tB_NetSum.TabIndex = 2;
            tB_NetSum.Text = "0,00zł";
            // 
            // dGV_Products
            // 
            dGV_Products.AllowUserToAddRows = false;
            dGV_Products.AllowUserToDeleteRows = false;
            dGV_Products.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dGV_Products.AutoGenerateColumns = false;
            dGV_Products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_Products.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dGV_Products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dGV_Products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_Products.Columns.AddRange(new DataGridViewColumn[] { Column1, ProductName, OrderedAmount, OrderedAmountUnit, Gross, c_Net, GrossUnit });
            dGV_Products.DataSource = bS_OrderProducts;
            dGV_Products.Location = new Point(30, 13);
            dGV_Products.MinimumSize = new Size(1140, 0);
            dGV_Products.Name = "dGV_Products";
            dGV_Products.Size = new Size(1140, 414);
            dGV_Products.TabIndex = 0;
            dGV_Products.CellValueChanged += dGV_Products_CellValueChanged;
            dGV_Products.DoubleClick += dGV_Products_DoubleClick;
            // 
            // bS_OrderProducts
            // 
            bS_OrderProducts.DataSource = typeof(Dtos.Dtos.OrderProduct);
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Checked";
            Column1.FillWeight = 30.456852F;
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Nazwa";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // OrderedAmount
            // 
            OrderedAmount.DataPropertyName = "OrderedAmount";
            OrderedAmount.HeaderText = "Ilosć";
            OrderedAmount.Name = "OrderedAmount";
            // 
            // OrderedAmountUnit
            // 
            OrderedAmountUnit.DataPropertyName = "OrderedAmountUnit";
            OrderedAmountUnit.HeaderText = "Ilość j.m.";
            OrderedAmountUnit.Name = "OrderedAmountUnit";
            OrderedAmountUnit.ReadOnly = true;
            // 
            // Gross
            // 
            Gross.DataPropertyName = "GroosTimesAmount";
            Gross.HeaderText = "Brutto";
            Gross.Name = "Gross";
            Gross.ReadOnly = true;
            // 
            // c_Net
            // 
            c_Net.DataPropertyName = "Net";
            c_Net.HeaderText = "Netto";
            c_Net.Name = "c_Net";
            c_Net.ReadOnly = true;
            // 
            // GrossUnit
            // 
            GrossUnit.DataPropertyName = "OrginalGroosTimesAmountUnit";
            GrossUnit.HeaderText = "Waluta j.m.";
            GrossUnit.Name = "GrossUnit";
            GrossUnit.ReadOnly = true;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 656);
            Controls.Add(p_Buttons);
            Controls.Add(p_Main);
            MinimumSize = new Size(1373, 695);
            Name = "OrderForm";
            Text = "Kartas zamówienia";
            WindowState = FormWindowState.Maximized;
            Load += OrderForm_Load;
            p_Main.ResumeLayout(false);
            p_Main.PerformLayout();
            p_Buttons.ResumeLayout(false);
            p_Buttons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_Products).EndInit();
            ((System.ComponentModel.ISupportInitialize)bS_OrderProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel p_Main;
        private Panel p_Buttons;
        private TextBox tB_ClientName;
        private TextBox tB_OrderNumber;
        private Label l_SendDate;
        private Label l_OrderCreation;
        private TextBox tB_PlanedSendDate;
        private TextBox tB_CreationDate;
        private CheckedListBox checkedListBox1;
        private Label l_Repeat;
        private TextBox tB_RepeatList;
        private CheckBox cB_Repeat;
        private ComboBox cB_ReapeatList;
        private DateTimePicker dTP_SendDate;
        private DateTimePicker dTP_OrderCreation;
        private TextBox tB_NetSum;
        private DataGridView dGV_Products;
        private Button btn_AddProduct;
        private Button btn_DeleteProduct;
        private Button btn_ClientList;
        private Button btn_Save;
        private BindingSource bS_OrderProducts;
        private TextBox tB_BruttoSum;
        private Label label2;
        private Label label1;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn OrderedAmount;
        private DataGridViewTextBoxColumn OrderedAmountUnit;
        private DataGridViewTextBoxColumn Gross;
        private DataGridViewTextBoxColumn c_Net;
        private DataGridViewTextBoxColumn GrossUnit;
    }
}