using YTArchivingGUI.Models;

namespace YTArchivingGUI.Forms
{
    public partial class NewSubscription : Form
    {
        // Fields

        private readonly Main main;
        private readonly SubFolder subFolder;

        // Constructor

        internal NewSubscription(Main main, SubFolder subFolder)
        {
            InitializeComponent();
            this.main = main;
            this.subFolder = subFolder;

            Text = $"New subscription for {subFolder.Name}";
        }

        // Private Methods

        private void HandleKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            string url = textBoxURL.Text;
            string name = textBoxFolderName.Text;

            if (string.IsNullOrWhiteSpace(url))
            {
                textBoxURL.Select();
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                textBoxFolderName.Select();
                return;
            }

            main.NewSubscription(name, url, subFolder);

            Close();
        }

        // UI Events

        private void TextBoxFolderName_KeyDown(object sender, KeyEventArgs e)
        {
            HandleKeyDown(e);
        }

        private void TextBoxURL_KeyDown(object sender, KeyEventArgs e)
        {
            HandleKeyDown(e);
        }

        private void NewSubscription_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
        }
    }
}
