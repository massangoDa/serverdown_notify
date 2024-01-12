namespace server
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            CreateNotifyIcon();
            Application.Run(new Form1());
        }

        private static void CreateNotifyIcon()
        {
            var icon = new NotifyIcon();
            icon.Icon = new Icon(@"tuuti.ico");
            icon.ContextMenuStrip = ContextMenu();
            icon.Text = "í’“ƒAƒvƒŠ";
            icon.Visible = true;
        }

        private static ContextMenuStrip ContextMenu()
        {
            var menu = new ContextMenuStrip();
            menu.Items.Add("I—¹", null, (s, e) => {
                Application.Exit();
            });
            return menu;
        }
    }
}