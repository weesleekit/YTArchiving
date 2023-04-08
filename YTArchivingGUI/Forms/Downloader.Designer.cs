namespace YTArchivingGUI.Forms
{
    partial class Downloader
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
            labelSkipped = new Label();
            textBoxConsole = new TextBox();
            listBoxTitles = new ListBox();
            progressBarDownload = new ProgressBar();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // labelSkipped
            // 
            labelSkipped.AutoSize = true;
            labelSkipped.Location = new Point(3, 6);
            labelSkipped.Name = "labelSkipped";
            labelSkipped.Size = new Size(25, 15);
            labelSkipped.TabIndex = 14;
            labelSkipped.Text = "123";
            // 
            // textBoxConsole
            // 
            textBoxConsole.Dock = DockStyle.Fill;
            textBoxConsole.Location = new Point(0, 0);
            textBoxConsole.Multiline = true;
            textBoxConsole.Name = "textBoxConsole";
            textBoxConsole.ScrollBars = ScrollBars.Vertical;
            textBoxConsole.Size = new Size(394, 416);
            textBoxConsole.TabIndex = 13;
            // 
            // listBoxTitles
            // 
            listBoxTitles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxTitles.FormattingEnabled = true;
            listBoxTitles.ItemHeight = 15;
            listBoxTitles.Location = new Point(3, 53);
            listBoxTitles.Name = "listBoxTitles";
            listBoxTitles.Size = new Size(368, 349);
            listBoxTitles.TabIndex = 12;
            // 
            // progressBarDownload
            // 
            progressBarDownload.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBarDownload.Location = new Point(3, 24);
            progressBarDownload.Name = "progressBarDownload";
            progressBarDownload.Size = new Size(368, 23);
            progressBarDownload.TabIndex = 11;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(progressBarDownload);
            splitContainer1.Panel1.Controls.Add(labelSkipped);
            splitContainer1.Panel1.Controls.Add(listBoxTitles);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(textBoxConsole);
            splitContainer1.Size = new Size(772, 416);
            splitContainer1.SplitterDistance = 374;
            splitContainer1.TabIndex = 15;
            // 
            // Downloader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 469);
            Controls.Add(splitContainer1);
            Name = "Downloader";
            Text = "Downloader";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelSkipped;
        private TextBox textBoxConsole;
        private ListBox listBoxTitles;
        private ProgressBar progressBarDownload;
        private SplitContainer splitContainer1;
    }
}