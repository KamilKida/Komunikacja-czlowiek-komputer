namespace WarehouseManagementApp.Forms
{
    partial class ChooseClientForm
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
            dGV_Clients = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tel1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tel2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bS_Clients = new BindingSource(components);
            p_Buttons = new Panel();
            btn_AddClient = new Button();
            p_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_Clients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bS_Clients).BeginInit();
            p_Buttons.SuspendLayout();
            SuspendLayout();
            // 
            // p_Main
            // 
            p_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p_Main.Controls.Add(dGV_Clients);
            p_Main.Location = new Point(0, 0);
            p_Main.Name = "p_Main";
            p_Main.Size = new Size(1049, 571);
            p_Main.TabIndex = 0;
            // 
            // dGV_Clients
            // 
            dGV_Clients.AllowUserToAddRows = false;
            dGV_Clients.AllowUserToDeleteRows = false;
            dGV_Clients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dGV_Clients.AutoGenerateColumns = false;
            dGV_Clients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_Clients.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dGV_Clients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dGV_Clients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_Clients.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, tel1DataGridViewTextBoxColumn, tel2DataGridViewTextBoxColumn });
            dGV_Clients.DataSource = bS_Clients;
            dGV_Clients.GridColor = Color.White;
            dGV_Clients.Location = new Point(6, 0);
            dGV_Clients.Name = "dGV_Clients";
            dGV_Clients.ReadOnly = true;
            dGV_Clients.Size = new Size(1043, 562);
            dGV_Clients.TabIndex = 0;
            dGV_Clients.DoubleClick += dGV_Clients_DoubleClick;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tel1DataGridViewTextBoxColumn
            // 
            tel1DataGridViewTextBoxColumn.DataPropertyName = "Tel1";
            tel1DataGridViewTextBoxColumn.HeaderText = "Tellefon 1";
            tel1DataGridViewTextBoxColumn.Name = "tel1DataGridViewTextBoxColumn";
            tel1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tel2DataGridViewTextBoxColumn
            // 
            tel2DataGridViewTextBoxColumn.DataPropertyName = "Tel2";
            tel2DataGridViewTextBoxColumn.HeaderText = "Tellefon 2";
            tel2DataGridViewTextBoxColumn.Name = "tel2DataGridViewTextBoxColumn";
            tel2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bS_Clients
            // 
            bS_Clients.DataSource = typeof(Dtos.Dtos.Client);
            // 
            // p_Buttons
            // 
            p_Buttons.Controls.Add(btn_AddClient);
            p_Buttons.Dock = DockStyle.Bottom;
            p_Buttons.Location = new Point(0, 568);
            p_Buttons.Name = "p_Buttons";
            p_Buttons.Size = new Size(1049, 64);
            p_Buttons.TabIndex = 1;
            // 
            // btn_AddClient
            // 
            btn_AddClient.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_AddClient.BackColor = Color.White;
            btn_AddClient.Cursor = Cursors.Hand;
            btn_AddClient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_AddClient.Location = new Point(877, 9);
            btn_AddClient.Name = "btn_AddClient";
            btn_AddClient.Size = new Size(169, 43);
            btn_AddClient.TabIndex = 11;
            btn_AddClient.Text = "  Dodaj klienta";
            btn_AddClient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_AddClient.UseVisualStyleBackColor = false;
            btn_AddClient.Click += btn_AddClient_Click;
            // 
            // ChooseClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 632);
            Controls.Add(p_Buttons);
            Controls.Add(p_Main);
            Name = "ChooseClientForm";
            Text = "Wybierz klienta";
            WindowState = FormWindowState.Maximized;
            Load += ChooseClientForm_Load;
            p_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGV_Clients).EndInit();
            ((System.ComponentModel.ISupportInitialize)bS_Clients).EndInit();
            p_Buttons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel p_Main;
        private Panel p_Buttons;
        private DataGridView dGV_Clients;
        private Button btn_AddClient;
        private BindingSource bS_Clients;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tel1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tel2DataGridViewTextBoxColumn;
    }
}