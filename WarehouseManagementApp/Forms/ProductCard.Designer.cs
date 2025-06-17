namespace WarehouseManagementApp.Forms
{
    partial class ProductCard
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
            tB_Net = new TextBox();
            tB_NetUnit = new TextBox();
            label3 = new Label();
            nUD_Amount = new NumericUpDown();
            nUD_Weight = new NumericUpDown();
            nUP_Gross = new NumericUpDown();
            tB_AmountUnit = new TextBox();
            label2 = new Label();
            tB_WeightUnit = new TextBox();
            label1 = new Label();
            tB_GrossUnit = new TextBox();
            label4 = new Label();
            label7 = new Label();
            tB_Description = new TextBox();
            tB_Name = new TextBox();
            tB_Code = new TextBox();
            p_Button = new Panel();
            btn_Save = new Button();
            p_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_Amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_Weight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUP_Gross).BeginInit();
            p_Button.SuspendLayout();
            SuspendLayout();
            // 
            // p_Main
            // 
            p_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p_Main.Controls.Add(tB_Net);
            p_Main.Controls.Add(tB_NetUnit);
            p_Main.Controls.Add(label3);
            p_Main.Controls.Add(nUD_Amount);
            p_Main.Controls.Add(nUD_Weight);
            p_Main.Controls.Add(nUP_Gross);
            p_Main.Controls.Add(tB_AmountUnit);
            p_Main.Controls.Add(label2);
            p_Main.Controls.Add(tB_WeightUnit);
            p_Main.Controls.Add(label1);
            p_Main.Controls.Add(tB_GrossUnit);
            p_Main.Controls.Add(label4);
            p_Main.Controls.Add(label7);
            p_Main.Controls.Add(tB_Description);
            p_Main.Controls.Add(tB_Name);
            p_Main.Controls.Add(tB_Code);
            p_Main.Location = new Point(0, 0);
            p_Main.Name = "p_Main";
            p_Main.Size = new Size(1062, 644);
            p_Main.TabIndex = 0;
            // 
            // tB_Net
            // 
            tB_Net.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_Net.Location = new Point(25, 208);
            tB_Net.Name = "tB_Net";
            tB_Net.ReadOnly = true;
            tB_Net.Size = new Size(120, 29);
            tB_Net.TabIndex = 35;
            // 
            // tB_NetUnit
            // 
            tB_NetUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_NetUnit.Location = new Point(163, 208);
            tB_NetUnit.Name = "tB_NetUnit";
            tB_NetUnit.ReadOnly = true;
            tB_NetUnit.Size = new Size(82, 29);
            tB_NetUnit.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(25, 184);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 33;
            label3.Text = "Cena netto:";
            // 
            // nUD_Amount
            // 
            nUD_Amount.DecimalPlaces = 2;
            nUD_Amount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            nUD_Amount.Increment = new decimal(new int[] { 10, 0, 0, 131072 });
            nUD_Amount.Location = new Point(25, 350);
            nUD_Amount.Maximum = new decimal(new int[] { -1593835520, 466537709, 54210, 0 });
            nUD_Amount.Name = "nUD_Amount";
            nUD_Amount.Size = new Size(120, 29);
            nUD_Amount.TabIndex = 32;
            // 
            // nUD_Weight
            // 
            nUD_Weight.DecimalPlaces = 2;
            nUD_Weight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            nUD_Weight.Increment = new decimal(new int[] { 10, 0, 0, 131072 });
            nUD_Weight.Location = new Point(25, 277);
            nUD_Weight.Maximum = new decimal(new int[] { -1593835520, 466537709, 54210, 0 });
            nUD_Weight.Name = "nUD_Weight";
            nUD_Weight.Size = new Size(120, 29);
            nUD_Weight.TabIndex = 31;
            // 
            // nUP_Gross
            // 
            nUP_Gross.DecimalPlaces = 2;
            nUP_Gross.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            nUP_Gross.Increment = new decimal(new int[] { 10, 0, 0, 131072 });
            nUP_Gross.Location = new Point(25, 152);
            nUP_Gross.Maximum = new decimal(new int[] { -1593835520, 466537709, 54210, 0 });
            nUP_Gross.Name = "nUP_Gross";
            nUP_Gross.Size = new Size(120, 29);
            nUP_Gross.TabIndex = 30;
            nUP_Gross.ValueChanged += nUP_Gross_ValueChanged;
            // 
            // tB_AmountUnit
            // 
            tB_AmountUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_AmountUnit.Location = new Point(163, 350);
            tB_AmountUnit.Name = "tB_AmountUnit";
            tB_AmountUnit.Size = new Size(82, 29);
            tB_AmountUnit.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(25, 326);
            label2.Name = "label2";
            label2.Size = new Size(144, 21);
            label2.TabIndex = 25;
            label2.Text = "Ilośc na magazynie:";
            // 
            // tB_WeightUnit
            // 
            tB_WeightUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_WeightUnit.Location = new Point(163, 277);
            tB_WeightUnit.Name = "tB_WeightUnit";
            tB_WeightUnit.Size = new Size(82, 29);
            tB_WeightUnit.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(25, 253);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 22;
            label1.Text = "Waga:";
            // 
            // tB_GrossUnit
            // 
            tB_GrossUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_GrossUnit.Location = new Point(163, 152);
            tB_GrossUnit.Name = "tB_GrossUnit";
            tB_GrossUnit.ReadOnly = true;
            tB_GrossUnit.Size = new Size(82, 29);
            tB_GrossUnit.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(25, 128);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 19;
            label4.Text = "Cena brutto:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(546, 128);
            label7.Name = "label7";
            label7.Size = new Size(45, 21);
            label7.TabIndex = 18;
            label7.Text = "Opis:";
            // 
            // tB_Description
            // 
            tB_Description.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tB_Description.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_Description.Location = new Point(546, 152);
            tB_Description.Multiline = true;
            tB_Description.Name = "tB_Description";
            tB_Description.ScrollBars = ScrollBars.Vertical;
            tB_Description.Size = new Size(504, 469);
            tB_Description.TabIndex = 17;
            // 
            // tB_Name
            // 
            tB_Name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tB_Name.BackColor = Color.White;
            tB_Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_Name.Location = new Point(25, 76);
            tB_Name.Name = "tB_Name";
            tB_Name.Size = new Size(1009, 29);
            tB_Name.TabIndex = 2;
            // 
            // tB_Code
            // 
            tB_Code.BackColor = Color.White;
            tB_Code.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_Code.Location = new Point(25, 31);
            tB_Code.Name = "tB_Code";
            tB_Code.ReadOnly = true;
            tB_Code.Size = new Size(173, 29);
            tB_Code.TabIndex = 1;
            tB_Code.TextAlign = HorizontalAlignment.Center;
            // 
            // p_Button
            // 
            p_Button.Controls.Add(btn_Save);
            p_Button.Dock = DockStyle.Bottom;
            p_Button.Location = new Point(0, 641);
            p_Button.Name = "p_Button";
            p_Button.Size = new Size(1062, 64);
            p_Button.TabIndex = 1;
            // 
            // btn_Save
            // 
            btn_Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Save.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_Save.Location = new Point(881, 9);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(169, 43);
            btn_Save.TabIndex = 1;
            btn_Save.Text = "  Zapisz zmiany";
            btn_Save.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 705);
            Controls.Add(p_Button);
            Controls.Add(p_Main);
            Name = "ProductCard";
            Text = "Karta produktu";
            WindowState = FormWindowState.Maximized;
            Load += ProductCard_Load;
            p_Main.ResumeLayout(false);
            p_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_Amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_Weight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUP_Gross).EndInit();
            p_Button.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel p_Main;
        private Panel p_Button;
        private Button btn_Save;
        private TextBox tB_Code;
        private TextBox tB_Name;
        private TextBox tB_Description;
        private Label label7;
        private Label label4;
        private TextBox tB_AmountUnit;
        private Label label2;
        private TextBox tB_WeightUnit;
        private Label label1;
        private TextBox tB_GrossUnit;
        private NumericUpDown nUD_Amount;
        private NumericUpDown nUD_Weight;
        private NumericUpDown nUP_Gross;
        private TextBox tB_NetUnit;
        private Label label3;
        private TextBox tB_Net;
    }
}