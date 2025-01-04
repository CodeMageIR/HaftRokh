using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaftRokh
{
    public partial class Settings : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Settings()
        {
            InitializeComponent();
        }
        private void ToggleCompatibility_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            Properties.Settings.Default.Compatibility = ToggleCompatibility.Checked;
            Properties.Settings.Default.Save();
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            ToggleCompatibility.Checked = Properties.Settings.Default.Compatibility;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Topbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}