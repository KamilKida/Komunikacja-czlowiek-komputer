namespace WarehouseManagementApp.Forms
{
    partial class AddForm
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
            l_Error = new Label();
            btn_File = new Button();
            tB_FilePath = new TextBox();
            label1 = new Label();
            p_Button = new Panel();
            btn_Save = new Button();
            p_Main.SuspendLayout();
            p_Button.SuspendLayout();
            SuspendLayout();
            // 
            // p_Main
            // 
            p_Main.Controls.Add(l_Error);
            p_Main.Controls.Add(btn_File);
            p_Main.Controls.Add(tB_FilePath);
            p_Main.Controls.Add(label1);
            p_Main.Dock = DockStyle.Top;
            p_Main.Location = new Point(0, 0);
            p_Main.Name = "p_Main";
            p_Main.Size = new Size(800, 117);
            p_Main.TabIndex = 0;
            // 
            // l_Error
            // 
            l_Error.AutoSize = true;
            l_Error.Location = new Point(12, 76);
            l_Error.Name = "l_Error";
            l_Error.Size = new Size(0, 15);
            l_Error.TabIndex = 3;
            l_Error.Visible = false;
            // 
            // btn_File
            // 
            btn_File.Location = new Point(737, 28);
            btn_File.Name = "btn_File";
            btn_File.Size = new Size(40, 40);
            btn_File.TabIndex = 2;
            btn_File.UseVisualStyleBackColor = true;
            btn_File.Click += btn_File_Click;
            // 
            // tB_FilePath
            // 
            tB_FilePath.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_FilePath.Location = new Point(12, 33);
            tB_FilePath.Name = "tB_FilePath";
            tB_FilePath.ReadOnly = true;
            tB_FilePath.Size = new Size(719, 29);
            tB_FilePath.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 0;
            label1.Text = "Plik JSON:";
            // 
            // p_Button
            // 
            p_Button.Controls.Add(btn_Save);
            p_Button.Dock = DockStyle.Bottom;
            p_Button.Location = new Point(0, 117);
            p_Button.Name = "p_Button";
            p_Button.Size = new Size(800, 56);
            p_Button.TabIndex = 1;
            // 
            // btn_Save
            // 
            btn_Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Save.BackColor = Color.White;
            btn_Save.Cursor = Cursors.Hand;
            btn_Save.Enabled = false;
            btn_Save.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_Save.Location = new Point(619, 6);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(169, 43);
            btn_Save.TabIndex = 3;
            btn_Save.Text = "  Zapisz";
            btn_Save.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 173);
            Controls.Add(p_Button);
            Controls.Add(p_Main);
            MaximizeBox = false;
            MaximumSize = new Size(816, 212);
            MinimizeBox = false;
            MinimumSize = new Size(816, 212);
            Name = "AddForm";
            Load += AddForm_Load;
            p_Main.ResumeLayout(false);
            p_Main.PerformLayout();
            p_Button.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel p_Main;
        private Button btn_File;
        private TextBox tB_FilePath;
        private Label label1;
        private Panel p_Button;
        private Button btn_Save;
        private Label l_Error;
    }
}