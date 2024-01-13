using Microsoft.Toolkit.Uwp.Notifications;
using System.Configuration;

namespace server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadIPAddressSetting();
        }

        private void LoadIPAddressSetting()
        {
            string ipAddress = ConfigurationManager.AppSettings["IPAddress"];
            if (!string.IsNullOrEmpty(ipAddress))
            {
                richTextBox1.AppendText($"以前のアドレス名{ipAddress}を読み込みました\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ipadder = textBox1.Text;
            richTextBox1.AppendText($"アドレス名「{ipadder}」を設定しました");

            SaveIPAddressSetting(ipadder);
        }

        private void SaveIPAddressSetting(string ipadder)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["IPAddress"].Value = ipadder;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
            else
            {
                Application.Exit();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("数字のみ入力できます。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
