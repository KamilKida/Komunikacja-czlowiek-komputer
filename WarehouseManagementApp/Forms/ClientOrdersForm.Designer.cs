namespace WarehouseManagementApp.Forms
{
    partial class ClientOrdersForm
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
            bS_Orders = new BindingSource(components);
            p_Main = new Panel();
            dGV_Orders = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            clientNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            creationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sendDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bS_Orders).BeginInit();
            p_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_Orders).BeginInit();
            SuspendLayout();
            // 
            // bS_Orders
            // 
            bS_Orders.DataSource = typeof(Dtos.Dtos.Order);
            // 
            // p_Main
            // 
            p_Main.Controls.Add(dGV_Orders);
            p_Main.Dock = DockStyle.Fill;
            p_Main.Location = new Point(0, 0);
            p_Main.Name = "p_Main";
            p_Main.Size = new Size(1044, 652);
            p_Main.TabIndex = 0;
            // 
            // dGV_Orders
            // 
            dGV_Orders.AllowUserToAddRows = false;
            dGV_Orders.AllowUserToDeleteRows = false;
            dGV_Orders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dGV_Orders.AutoGenerateColumns = false;
            dGV_Orders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_Orders.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dGV_Orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dGV_Orders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_Orders.Columns.AddRange(new DataGridViewColumn[] { Id, clientNameDataGridViewTextBoxColumn, creationDateDataGridViewTextBoxColumn, sendDateDataGridViewTextBoxColumn });
            dGV_Orders.DataSource = bS_Orders;
            dGV_Orders.Location = new Point(12, 12);
            dGV_Orders.Name = "dGV_Orders";
            dGV_Orders.ReadOnly = true;
            dGV_Orders.Size = new Size(1020, 628);
            dGV_Orders.TabIndex = 0;
            dGV_Orders.CellDoubleClick += dGV_Orders_CellDoubleClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Numer zamówienia";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            clientNameDataGridViewTextBoxColumn.HeaderText = "Nazwa klienta";
            clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            clientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
            creationDateDataGridViewTextBoxColumn.HeaderText = "Data stworzenia";
            creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            creationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sendDateDataGridViewTextBoxColumn
            // 
            sendDateDataGridViewTextBoxColumn.DataPropertyName = "SendDate";
            sendDateDataGridViewTextBoxColumn.HeaderText = "Data wysyłki";
            sendDateDataGridViewTextBoxColumn.Name = "sendDateDataGridViewTextBoxColumn";
            sendDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ClientOrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 652);
            Controls.Add(p_Main);
            Name = "ClientOrdersForm";
            Text = "Zamówienia klienta";
            WindowState = FormWindowState.Maximized;
            Load += ClientOrdersForm_Load;
            ((System.ComponentModel.ISupportInitialize)bS_Orders).EndInit();
            p_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGV_Orders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bS_Orders;
        private Panel p_Main;
        private DataGridView dGV_Orders;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sendDateDataGridViewTextBoxColumn;
    }
}