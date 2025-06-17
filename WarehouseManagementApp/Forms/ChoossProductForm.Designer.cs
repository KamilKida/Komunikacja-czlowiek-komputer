namespace WarehouseManagementApp.Forms
{
    partial class ChoossProductForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            p_Main = new Panel();
            dGV_Products = new DataGridView();
            bS_Products = new BindingSource(components);
            tV_Producers = new TreeView();
            p_Buttons = new Panel();
            btn_AddProduct = new Button();
            Column1 = new DataGridViewCheckBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            AmountInMagazin = new DataGridViewTextBoxColumn();
            AomuntUnit = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            WeightUnit = new DataGridViewTextBoxColumn();
            p_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_Products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bS_Products).BeginInit();
            p_Buttons.SuspendLayout();
            SuspendLayout();
            // 
            // p_Main
            // 
            p_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p_Main.Controls.Add(dGV_Products);
            p_Main.Controls.Add(tV_Producers);
            p_Main.Location = new Point(0, 0);
            p_Main.Name = "p_Main";
            p_Main.Size = new Size(1339, 601);
            p_Main.TabIndex = 0;
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
            dGV_Products.Columns.AddRange(new DataGridViewColumn[] { Column1, ProductName, AmountInMagazin, AomuntUnit, Weight, WeightUnit });
            dGV_Products.DataSource = bS_Products;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dGV_Products.DefaultCellStyle = dataGridViewCellStyle2;
            dGV_Products.Location = new Point(353, 3);
            dGV_Products.Name = "dGV_Products";
            dGV_Products.Size = new Size(983, 587);
            dGV_Products.TabIndex = 9;
            dGV_Products.DoubleClick += dGV_Products_DoubleClick;
            // 
            // bS_Products
            // 
            bS_Products.DataSource = typeof(Dtos.Dtos.MagazinProduct);
            // 
            // tV_Producers
            // 
            tV_Producers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tV_Producers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tV_Producers.Location = new Point(3, 3);
            tV_Producers.Name = "tV_Producers";
            tV_Producers.Size = new Size(344, 587);
            tV_Producers.TabIndex = 8;
            tV_Producers.NodeMouseClick += tV_Producers_NodeMouseClick;
            tV_Producers.MouseDoubleClick += tV_Producers_MouseDoubleClick;
            // 
            // p_Buttons
            // 
            p_Buttons.Controls.Add(btn_AddProduct);
            p_Buttons.Dock = DockStyle.Bottom;
            p_Buttons.Location = new Point(0, 596);
            p_Buttons.Name = "p_Buttons";
            p_Buttons.Size = new Size(1339, 75);
            p_Buttons.TabIndex = 1;
            // 
            // btn_AddProduct
            // 
            btn_AddProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_AddProduct.BackColor = Color.White;
            btn_AddProduct.Cursor = Cursors.Hand;
            btn_AddProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_AddProduct.Location = new Point(1158, 11);
            btn_AddProduct.Name = "btn_AddProduct";
            btn_AddProduct.Size = new Size(169, 43);
            btn_AddProduct.TabIndex = 6;
            btn_AddProduct.Text = "  Dodaj towar";
            btn_AddProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_AddProduct.UseVisualStyleBackColor = false;
            btn_AddProduct.Click += btn_AddProduct_Click;
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
            // AmountInMagazin
            // 
            AmountInMagazin.DataPropertyName = "AmountInMagazin";
            AmountInMagazin.HeaderText = "Ilość na magazynie:";
            AmountInMagazin.Name = "AmountInMagazin";
            AmountInMagazin.ReadOnly = true;
            // 
            // AomuntUnit
            // 
            AomuntUnit.DataPropertyName = "AomuntUnit";
            AomuntUnit.HeaderText = "Ilość Jm.";
            AomuntUnit.Name = "AomuntUnit";
            AomuntUnit.ReadOnly = true;
            // 
            // Weight
            // 
            Weight.DataPropertyName = "Weight";
            Weight.HeaderText = "Waga";
            Weight.Name = "Weight";
            Weight.ReadOnly = true;
            // 
            // WeightUnit
            // 
            WeightUnit.DataPropertyName = "WeightUnit";
            WeightUnit.HeaderText = "Waga Jm.";
            WeightUnit.Name = "WeightUnit";
            WeightUnit.ReadOnly = true;
            // 
            // ChoossProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 671);
            Controls.Add(p_Buttons);
            Controls.Add(p_Main);
            Name = "ChoossProductForm";
            Text = "Wybierz produkt";
            WindowState = FormWindowState.Maximized;
            Load += ChoossProductForm_Load;
            p_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGV_Products).EndInit();
            ((System.ComponentModel.ISupportInitialize)bS_Products).EndInit();
            p_Buttons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel p_Main;
        private Panel p_Buttons;
        private TreeView tV_Producers;
        private DataGridView dGV_Products;
        private Button btn_AddProduct;
        private BindingSource bS_Products;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn AmountInMagazin;
        private DataGridViewTextBoxColumn AomuntUnit;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewTextBoxColumn WeightUnit;
    }
}