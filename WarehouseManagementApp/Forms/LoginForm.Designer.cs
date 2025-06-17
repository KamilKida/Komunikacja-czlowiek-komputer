namespace WarehouseManagementApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            p_Main = new Panel();
            l_Error = new Label();
            cB_RememberMe = new CheckBox();
            btn_ShowPassword = new Button();
            tB_Password = new TextBox();
            l_Password = new Label();
            tB_Login = new TextBox();
            l_Login = new Label();
            p_Buttons = new Panel();
            btn_Cancel = new Button();
            btn_Confirm = new Button();
            p_Main.SuspendLayout();
            p_Buttons.SuspendLayout();
            SuspendLayout();
            // 
            // p_Main
            // 
            p_Main.Controls.Add(l_Error);
            p_Main.Controls.Add(cB_RememberMe);
            p_Main.Controls.Add(btn_ShowPassword);
            p_Main.Controls.Add(tB_Password);
            p_Main.Controls.Add(l_Password);
            p_Main.Controls.Add(tB_Login);
            p_Main.Controls.Add(l_Login);
            p_Main.Dock = DockStyle.Top;
            p_Main.Location = new Point(0, 0);
            p_Main.Name = "p_Main";
            p_Main.Size = new Size(607, 264);
            p_Main.TabIndex = 0;
            p_Main.MouseDown += LoginForm_MouseDown;
            // 
            // l_Error
            // 
            l_Error.AutoSize = true;
            l_Error.BackColor = Color.White;
            l_Error.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            l_Error.ForeColor = Color.Red;
            l_Error.Location = new Point(41, 171);
            l_Error.Name = "l_Error";
            l_Error.Size = new Size(168, 17);
            l_Error.TabIndex = 6;
            l_Error.Text = "!!! Błedny login lub hasło !!!";
            l_Error.Visible = false;
            // 
            // cB_RememberMe
            // 
            cB_RememberMe.AutoSize = true;
            cB_RememberMe.Location = new Point(447, 170);
            cB_RememberMe.Name = "cB_RememberMe";
            cB_RememberMe.Size = new Size(115, 19);
            cB_RememberMe.TabIndex = 5;
            cB_RememberMe.Text = "Zapamiętaj mnie";
            cB_RememberMe.UseVisualStyleBackColor = true;
            // 
            // btn_ShowPassword
            // 
            btn_ShowPassword.Cursor = Cursors.Hand;
            btn_ShowPassword.FlatStyle = FlatStyle.Flat;
            btn_ShowPassword.Image = (Image)resources.GetObject("btn_ShowPassword.Image");
            btn_ShowPassword.Location = new Point(527, 135);
            btn_ShowPassword.Name = "btn_ShowPassword";
            btn_ShowPassword.Size = new Size(29, 29);
            btn_ShowPassword.TabIndex = 4;
            btn_ShowPassword.UseVisualStyleBackColor = true;
            btn_ShowPassword.Click += btn_ShowPassword_Click;
            // 
            // tB_Password
            // 
            tB_Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_Password.Location = new Point(40, 135);
            tB_Password.Name = "tB_Password";
            tB_Password.Size = new Size(457, 29);
            tB_Password.TabIndex = 3;
            tB_Password.UseSystemPasswordChar = true;
            // 
            // l_Password
            // 
            l_Password.AutoSize = true;
            l_Password.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            l_Password.Location = new Point(40, 111);
            l_Password.Name = "l_Password";
            l_Password.Size = new Size(57, 21);
            l_Password.TabIndex = 2;
            l_Password.Text = "Hasło:";
            // 
            // tB_Login
            // 
            tB_Login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tB_Login.Location = new Point(40, 66);
            tB_Login.Name = "tB_Login";
            tB_Login.Size = new Size(523, 29);
            tB_Login.TabIndex = 1;
            // 
            // l_Login
            // 
            l_Login.AutoSize = true;
            l_Login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            l_Login.Location = new Point(40, 42);
            l_Login.Name = "l_Login";
            l_Login.Size = new Size(57, 21);
            l_Login.TabIndex = 0;
            l_Login.Text = "Login:";
            // 
            // p_Buttons
            // 
            p_Buttons.Controls.Add(btn_Cancel);
            p_Buttons.Controls.Add(btn_Confirm);
            p_Buttons.Dock = DockStyle.Bottom;
            p_Buttons.Location = new Point(0, 196);
            p_Buttons.Name = "p_Buttons";
            p_Buttons.Size = new Size(607, 68);
            p_Buttons.TabIndex = 1;
            p_Buttons.MouseDown += LoginForm_MouseDown;
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = Color.White;
            btn_Cancel.Cursor = Cursors.Hand;
            btn_Cancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_Cancel.Location = new Point(350, 13);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(169, 43);
            btn_Cancel.TabIndex = 1;
            btn_Cancel.Text = "  Anuluj";
            btn_Cancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Confirm
            // 
            btn_Confirm.BackColor = Color.White;
            btn_Confirm.Cursor = Cursors.Hand;
            btn_Confirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_Confirm.Location = new Point(76, 13);
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.Size = new Size(169, 43);
            btn_Confirm.TabIndex = 0;
            btn_Confirm.Text = "  Zatwierdź";
            btn_Confirm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Confirm.UseVisualStyleBackColor = false;
            btn_Confirm.Click += btn_Confirm_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 264);
            Controls.Add(p_Buttons);
            Controls.Add(p_Main);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            ShowIcon = false;
            Load += LoginForm_Load;
            MouseDown += LoginForm_MouseDown;
            p_Main.ResumeLayout(false);
            p_Main.PerformLayout();
            p_Buttons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel p_Main;
        private Panel p_Buttons;
        private Button btn_ShowPassword;
        private TextBox tB_Password;
        private Label l_Password;
        private TextBox tB_Login;
        private Label l_Login;
        private Label l_Error;
        private CheckBox cB_RememberMe;
        private Button btn_Cancel;
        private Button btn_Confirm;
    }
}
