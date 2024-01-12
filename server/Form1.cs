using Microsoft.Toolkit.Uwp.Notifications;
using System.Configuration;

namespace server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ipadder = textBox1.Text;
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
                MessageBox.Show("”Žš‚Ì‚Ý“ü—Í‚Å‚«‚Ü‚·B", "ƒGƒ‰[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

    }
}
