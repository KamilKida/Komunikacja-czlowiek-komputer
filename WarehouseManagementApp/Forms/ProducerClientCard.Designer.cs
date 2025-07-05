namespace WarehouseManagementApp.Forms
{
    partial class ProducerClientCard
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
            p_Main = new Panel();
            tB_Acronim = new TextBox();
            tB_Name = new TextBox();
            label7 = new Label();
            tB_Description = new TextBox();
            tB_Phone2 = new TextBox();
            label6 = new Label();
            tB_Phone1 = new TextBox();
            label5 = new Label();
            tB_Email = new TextBox();
            label4 = new Label();
            tB_Country = new TextBox();
            label3 = new Label();
            tB_Street = new TextBox();
            label2 = new Label();
            tB_PostalCodde = new TextBox();
            label1 = new Label();
            tB_City = new TextBox();
            l_City = new Label();
            p_Button = new Panel();
            btn_ClientOrders = new Button();
            btn_Save = new Button();
            p_Main.SuspendLayout();
            p_Button.SuspendLayout();
            SuspendLayout();
            // 
            // p_Main
            // 
            p_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p_Main.Controls.Add(tB_Acronim);
            p_Main.Controls.Add(tB_Name);
            p_Main.Controls.Add(label7);
            p_Main.Controls.Add(tB_Description);
            p_Main.Controls.Add(tB_Phone2);
            p_Main.Controls.Add(label6);
            p_Main.Controls.Add(tB_Phone1);
            p_Main.Controls.Add(label5);
            p_Main.Controls.Add(tB_Email);
            p_Main.Controls.Add(label4);
            p_Main.Controls.Add(tB_Country);
            p_Main.Controls.Add(label3);
            p_Main.Controls.Add(tB_Street);
            p_Main.Controls.Add(label2);
            p_Main.Controls.Add(tB_PostalCodde);
            p_Main.Controls.Add(label1);
            p_Main.Controls.Add(tB_City);
            p_Main.Controls.Add(l_City);
            p_Main.Location = new Point(0, 0);
            p_Main.Name = "p_Main";
            p_Main.Size = new Size(1062, 644);
            p_Main.TabIndex = 0;
            // 
            // tB_Acronim
            // 
            tB_Acronim.BackColor = Color.White;
            tB_Acronim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_Acronim.Location = new Point(31, 42);
            tB_Acronim.Name = "tB_Acronim";
            tB_Acronim.ReadOnly = true;
            tB_Acronim.Size = new Size(108, 29);
            tB_Acronim.TabIndex = 0;
            tB_Acronim.TextAlign = HorizontalAlignment.Center;
            // 
            // tB_Name
            // 
            tB_Name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tB_Name.BackColor = Color.White;
            tB_Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_Name.Location = new Point(145, 42);
            tB_Name.Name = "tB_Name";
            tB_Name.Size = new Size(887, 29);
            tB_Name.TabIndex = 1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(528, 228);
            label7.Name = "label7";
            label7.Size = new Size(57, 21);
            label7.TabIndex = 17;
            label7.Text = "Uwagi:";
            // 
            // tB_Description
            // 
            tB_Description.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tB_Description.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_Description.Location = new Point(528, 252);
            tB_Description.Multiline = true;
            tB_Description.Name = "tB_Description";
            tB_Description.ScrollBars = ScrollBars.Vertical;
            tB_Description.Size = new Size(504, 368);
            tB_Description.TabIndex = 16;
            // 
            // tB_Phone2
            // 
            tB_Phone2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_Phone2.Location = new Point(29, 401);
            tB_Phone2.Name = "tB_Phone2";
            tB_Phone2.Size = new Size(286, 29);
            tB_Phone2.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(29, 377);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 14;
            label6.Text = "Telefon 2:";
            // 
            // tB_Phone1
            // 
            tB_Phone1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_Phone1.Location = new Point(29, 326);
            tB_Phone1.Name = "tB_Phone1";
            tB_Phone1.Size = new Size(286, 29);
            tB_Phone1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(29, 302);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 12;
            label5.Text = "Telefon 1:";
            // 
            // tB_Email
            // 
            tB_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_Email.Location = new Point(29, 252);
            tB_Email.Name = "tB_Email";
            tB_Email.Size = new Size(286, 29);
            tB_Email.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(29, 228);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 10;
            label4.Text = "E-mail:";
            // 
            // tB_Country
            // 
            tB_Country.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_Country.Location = new Point(321, 136);
            tB_Country.Name = "tB_Country";
            tB_Country.Size = new Size(230, 29);
            tB_Country.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(275, 144);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 8;
            label3.Text = "Kraj:";
            // 
            // tB_Street
            // 
            tB_Street.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_Street.Location = new Point(634, 91);
            tB_Street.Name = "tB_Street";
            tB_Street.Size = new Size(398, 29);
            tB_Street.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(581, 99);
            label2.Name = "label2";
            label2.Size = new Size(47, 21);
            label2.TabIndex = 6;
            label2.Text = "Ulica:";
            // 
            // tB_PostalCodde
            // 
            tB_PostalCodde.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_PostalCodde.Location = new Point(145, 136);
            tB_PostalCodde.Name = "tB_PostalCodde";
            tB_PostalCodde.Size = new Size(97, 29);
            tB_PostalCodde.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(29, 144);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 4;
            label1.Text = "Kod pocztowy:";
            // 
            // tB_City
            // 
            tB_City.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_City.Location = new Point(95, 91);
            tB_City.Name = "tB_City";
            tB_City.Size = new Size(456, 29);
            tB_City.TabIndex = 3;
            // 
            // l_City
            // 
            l_City.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            l_City.AutoSize = true;
            l_City.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            l_City.Location = new Point(29, 99);
            l_City.Name = "l_City";
            l_City.Size = new Size(60, 21);
            l_City.TabIndex = 2;
            l_City.Text = "Miasto:";
            // 
            // p_Button
            // 
            p_Button.Controls.Add(btn_ClientOrders);
            p_Button.Controls.Add(btn_Save);
            p_Button.Dock = DockStyle.Bottom;
            p_Button.Location = new Point(0, 641);
            p_Button.Name = "p_Button";
            p_Button.Size = new Size(1062, 64);
            p_Button.TabIndex = 1;
            // 
            // btn_ClientOrders
            // 
            btn_ClientOrders.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_ClientOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_ClientOrders.Location = new Point(12, 9);
            btn_ClientOrders.Name = "btn_ClientOrders";
            btn_ClientOrders.Size = new Size(169, 43);
            btn_ClientOrders.TabIndex = 1;
            btn_ClientOrders.Text = "  Pokaż zamówienia";
            btn_ClientOrders.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ClientOrders.UseVisualStyleBackColor = true;
            btn_ClientOrders.Visible = false;
            btn_ClientOrders.Click += btn_ClientOrders_Click;
            // 
            // btn_Save
            // 
            btn_Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Save.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_Save.Location = new Point(881, 9);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(169, 43);
            btn_Save.TabIndex = 0;
            btn_Save.Text = "  Zapisz zmiany";
            btn_Save.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // ProducerClientCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 705);
            Controls.Add(p_Button);
            Controls.Add(p_Main);
            MinimumSize = new Size(1078, 744);
            Name = "ProducerClientCard";
            Text = "ProducerCard";
            WindowState = FormWindowState.Maximized;
            Load += ProducerCard_Load;
            p_Main.ResumeLayout(false);
            p_Main.PerformLayout();
            p_Button.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel p_Main;
        private Panel p_Button;
        private Label l_City;
        private TextBox tB_Name;
        private TextBox tB_Acronim;
        private TextBox tB_City;
        private TextBox tB_Phone2;
        private Label label6;
        private TextBox tB_Phone1;
        private Label label5;
        private TextBox tB_Email;
        private Label label4;
        private TextBox tB_Country;
        private Label label3;
        private TextBox tB_Street;
        private Label label2;
        private TextBox tB_PostalCodde;
        private Label label1;
        private Button btn_Save;
        private TextBox tB_Description;
        private Label label7;
        private Button btn_ClientOrders;
    }
}