using System.Runtime.InteropServices;
using Microsoft.VisualBasic.ApplicationServices;
using WarehouseManagementApp.Dtos.BaseValues;
using WarehouseManagementApp.Forms;

namespace WarehouseManagementApp
{
    public partial class LoginForm : Form
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        private Bitmap _showImageScaled;
        private Bitmap _hideImageScaled;

        public BaseImagesValues _baseImagesValues;

        public LoginForm()
        {
            InitializeComponent();

        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                p_Main.BackColor = BaseColors.MainColor;
                p_Buttons.BackColor = BaseColors.SecondaryColor;

                var showImage = Image.FromFile("Icons\\ViewPassword.png");
                var hideImage = Image.FromFile("Icons\\HiedPassword.png");

                _showImageScaled = new Bitmap(showImage, btn_ShowPassword.Size);
                _hideImageScaled = new Bitmap(hideImage, btn_ShowPassword.Size);

                btn_ShowPassword.Image = _showImageScaled;

                var confirmImage = Image.FromFile("Icons\\Confirm.png");
                var cancelImage = Image.FromFile("Icons\\Cancel.png");

                var buttonImageSize = new Size(btn_Confirm.Height - 12, btn_Confirm.Height - 12);

                _baseImagesValues = new BaseImagesValues();

                _baseImagesValues.ConfirmImage = new Bitmap(confirmImage, buttonImageSize);
                _baseImagesValues.CancelImage = new Bitmap(cancelImage, buttonImageSize);

                _baseImagesValues.BtnConfirmPadding = new Padding(btn_Confirm.Width / 8, 0, 0, 0);
                _baseImagesValues.BtnCancelPadding = new Padding(btn_Confirm.Width / 6, 0, 0, 0);

                btn_Confirm.Padding = _baseImagesValues.BtnConfirmPadding;
                btn_Cancel.Padding = _baseImagesValues.BtnCancelPadding;

                btn_Confirm.Image = _baseImagesValues.ConfirmImage;
                btn_Cancel.Image = _baseImagesValues.CancelImage;
            }
            catch
            {
                MessageBox.Show("Coœ posz³o nie tak podczas uruchamiania aplikacji.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                Application.Exit();
            }

        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                }
            }
            catch
            {
                
            }
        }

        private void btn_ShowPassword_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (btn_ShowPassword.Image == _showImageScaled)
                {
                    btn_ShowPassword.Image = _hideImageScaled;
                    tB_Password.UseSystemPasswordChar = false;
                }
                else
                {
                    btn_ShowPassword.Image = _showImageScaled;
                    tB_Password.UseSystemPasswordChar = true;
                }
            }
            catch
            {
                
            }
        }

        private void btn_Cancel_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Confirm_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tB_Login.Text) || String.IsNullOrEmpty(tB_Password.Text))
                {
                    System.Media.SystemSounds.Hand.Play();

                    l_Error.Visible = true;
                }
                else
                {
                    this.Hide();
                    var mainForm = new MainForm(_baseImagesValues);
                    mainForm.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Coœ posz³o nie tak podczas zatwierdzania loginu lub/i has³a.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                Application.Exit();
            }

        }

    }
}
