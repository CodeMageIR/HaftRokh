using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaftRokh
{
    public partial class About : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public About()
        {
            InitializeComponent();
        }
        private JToken GithubData;
        private void About_Load(object sender, EventArgs e)
        {
            LabelVersion.Text = string.Format("نسخه فعلی: {0}", Application.ProductVersion);
            Task.Factory.StartNew(() => CheckForUpdate());
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CheckForUpdate()
        {
            try
            {
                PictureBoxLoading.Invoke((MethodInvoker)(() => PictureBoxLoading.Visible = true));
                Thread.Sleep(1500);
                Version AppVersion = new Version(Application.ProductVersion);

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                WebClient client = new WebClient();
                client.Headers.Add("User-Agent: Other");
                GithubData = JToken.Parse(client.DownloadString("https://api.github.com/repos/CodeMageIR/HaftRokh/releases"));

                if (GithubData.SelectToken(".[0]") != null)
                {
                    Version ServerVersion = new Version(Convert.ToString(GithubData.SelectToken(".[0].tag_name").ToString().Remove(0, 1)));

                    int Result = AppVersion.CompareTo(ServerVersion);
                    if (Result < 0)
                    {
                        LabelUpdateStatus.Invoke((MethodInvoker)(() => LabelUpdateStatus.Text = string.Format("آپدیت نسخه {0} موجود است.", ServerVersion)));
                        PictureBoxLoading.Invoke((MethodInvoker)(() => PictureBoxLoading.Visible = false));
                        ButtonUpdate.Invoke((MethodInvoker)(() => ButtonUpdate.Visible = true));
                        LabelUpdateStatus.Invoke((MethodInvoker)(() => LabelUpdateStatus.Location = new Point(165, 478)));
                    }
                    else if (Result >= 0)
                    {
                        LabelUpdateStatus.Invoke((MethodInvoker)(() => LabelUpdateStatus.Text = "آخرین نسخه نرم افزار نصب  است."));
                        PictureBoxLoading.Invoke((MethodInvoker)(() => PictureBoxLoading.Visible = false));
                        LabelUpdateStatus.Invoke((MethodInvoker)(() => LabelUpdateStatus.Location = new Point(165, 478)));
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                LabelUpdateStatus.Invoke((MethodInvoker)(() => LabelUpdateStatus.Text = "ارتباط با سرور برقرار نشد."));
                PictureBoxLoading.Invoke((MethodInvoker)(() => PictureBoxLoading.Visible = false));
                LabelUpdateStatus.Invoke((MethodInvoker)(() => LabelUpdateStatus.Location = new Point(165, 478)));
            }
        }
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            Process.Start(GithubData.SelectToken(".[0].html_url").ToString());
        }
        private void Topbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void LabelEmail_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:info@codemage.ir");
        }
        private void LabelTelegram_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/CodeMageIR");
        }
        private void LabelGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/CodeMageIR/HaftRokh");
        }
        private void LabelDonate_Click(object sender, EventArgs e)
        {
            Process.Start("https://zarinp.al/@amirhoseindavat");
        }
    }
}
