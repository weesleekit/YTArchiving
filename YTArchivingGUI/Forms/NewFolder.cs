namespace YTArchivingGUI.Forms
{
    public partial class NewFolder : Form
    {
        // Fields

        private readonly Main main;

        // Constructor

        public NewFolder(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        // Private Methods

        private void TextBoxFolderName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            string name = textBoxFolderName.Text;

            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            main.NewFolder(name);

            Close();
        }

        private void NewFolder_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
        }
    }
}
