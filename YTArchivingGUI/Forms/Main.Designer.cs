namespace YTArchivingGUI.Forms
{
    partial class Main
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
            buttonNewFolder = new Button();
            buttonNewSub = new Button();
            buttonDelete = new Button();
            treeViewFoldersAndSubs = new TreeView();
            buttonSyncAll = new Button();
            buttonSyncSelected = new Button();
            buttonLoadPreset = new Button();
            progressBarDownload = new ProgressBar();
            listBoxTitles = new ListBox();
            textBoxConsole = new TextBox();
            labelSkipped = new Label();
            textBoxOutputPath = new TextBox();
            label1 = new Label();
            buttonBrowseOutputPath = new Button();
            SuspendLayout();
            // 
            // buttonNewFolder
            // 
            buttonNewFolder.Location = new Point(12, 12);
            buttonNewFolder.Name = "buttonNewFolder";
            buttonNewFolder.Size = new Size(75, 23);
            buttonNewFolder.TabIndex = 0;
            buttonNewFolder.Text = "New Folder";
            buttonNewFolder.UseVisualStyleBackColor = true;
            buttonNewFolder.Click += ButtonNewFolder_Click;
            // 
            // buttonNewSub
            // 
            buttonNewSub.Location = new Point(93, 12);
            buttonNewSub.Name = "buttonNewSub";
            buttonNewSub.Size = new Size(75, 23);
            buttonNewSub.TabIndex = 1;
            buttonNewSub.Text = "New Sub";
            buttonNewSub.UseVisualStyleBackColor = true;
            buttonNewSub.Click += ButtonNewSub_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(174, 12);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // treeViewFoldersAndSubs
            // 
            treeViewFoldersAndSubs.CheckBoxes = true;
            treeViewFoldersAndSubs.Location = new Point(12, 41);
            treeViewFoldersAndSubs.Name = "treeViewFoldersAndSubs";
            treeViewFoldersAndSubs.Size = new Size(237, 368);
            treeViewFoldersAndSubs.TabIndex = 3;
            treeViewFoldersAndSubs.AfterCheck += TreeViewFoldersAndSubs_AfterCheck;
            // 
            // buttonSyncAll
            // 
            buttonSyncAll.Location = new Point(12, 415);
            buttonSyncAll.Name = "buttonSyncAll";
            buttonSyncAll.Size = new Size(75, 23);
            buttonSyncAll.TabIndex = 4;
            buttonSyncAll.Text = "Sync all";
            buttonSyncAll.UseVisualStyleBackColor = true;
            buttonSyncAll.Click += ButtonSyncAll_Click;
            // 
            // buttonSyncSelected
            // 
            buttonSyncSelected.Location = new Point(93, 415);
            buttonSyncSelected.Name = "buttonSyncSelected";
            buttonSyncSelected.Size = new Size(75, 23);
            buttonSyncSelected.TabIndex = 5;
            buttonSyncSelected.Text = "Sync one";
            buttonSyncSelected.UseVisualStyleBackColor = true;
            buttonSyncSelected.Click += ButtonSyncSelected_Click;
            // 
            // buttonLoadPreset
            // 
            buttonLoadPreset.Location = new Point(174, 415);
            buttonLoadPreset.Name = "buttonLoadPreset";
            buttonLoadPreset.Size = new Size(75, 23);
            buttonLoadPreset.TabIndex = 6;
            buttonLoadPreset.Text = "LoadPreset";
            buttonLoadPreset.UseVisualStyleBackColor = true;
            buttonLoadPreset.Click += ButtonLoadPreset_Click;
            // 
            // progressBarDownload
            // 
            progressBarDownload.Location = new Point(297, 54);
            progressBarDownload.Name = "progressBarDownload";
            progressBarDownload.Size = new Size(491, 23);
            progressBarDownload.TabIndex = 7;
            // 
            // listBoxTitles
            // 
            listBoxTitles.FormattingEnabled = true;
            listBoxTitles.ItemHeight = 15;
            listBoxTitles.Location = new Point(297, 83);
            listBoxTitles.Name = "listBoxTitles";
            listBoxTitles.Size = new Size(491, 154);
            listBoxTitles.TabIndex = 8;
            // 
            // textBoxConsole
            // 
            textBoxConsole.Location = new Point(297, 243);
            textBoxConsole.Multiline = true;
            textBoxConsole.Name = "textBoxConsole";
            textBoxConsole.Size = new Size(491, 195);
            textBoxConsole.TabIndex = 9;
            // 
            // labelSkipped
            // 
            labelSkipped.AutoSize = true;
            labelSkipped.Location = new Point(297, 20);
            labelSkipped.Name = "labelSkipped";
            labelSkipped.Size = new Size(58, 15);
            labelSkipped.TabIndex = 10;
            labelSkipped.Text = "x Skipped";
            // 
            // textBoxOutputPath
            // 
            textBoxOutputPath.Location = new Point(90, 454);
            textBoxOutputPath.Name = "textBoxOutputPath";
            textBoxOutputPath.Size = new Size(617, 23);
            textBoxOutputPath.TabIndex = 11;
            textBoxOutputPath.Text = "C:\\Output";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 457);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 12;
            label1.Text = "Output Path";
            // 
            // buttonBrowseOutputPath
            // 
            buttonBrowseOutputPath.Location = new Point(713, 454);
            buttonBrowseOutputPath.Name = "buttonBrowseOutputPath";
            buttonBrowseOutputPath.Size = new Size(75, 23);
            buttonBrowseOutputPath.TabIndex = 13;
            buttonBrowseOutputPath.Text = "Browse";
            buttonBrowseOutputPath.UseVisualStyleBackColor = true;
            buttonBrowseOutputPath.Click += buttonBrowseOutputPath_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 493);
            Controls.Add(buttonBrowseOutputPath);
            Controls.Add(label1);
            Controls.Add(textBoxOutputPath);
            Controls.Add(labelSkipped);
            Controls.Add(textBoxConsole);
            Controls.Add(listBoxTitles);
            Controls.Add(progressBarDownload);
            Controls.Add(buttonLoadPreset);
            Controls.Add(buttonSyncSelected);
            Controls.Add(buttonSyncAll);
            Controls.Add(treeViewFoldersAndSubs);
            Controls.Add(buttonDelete);
            Controls.Add(buttonNewSub);
            Controls.Add(buttonNewFolder);
            Name = "Main";
            Text = "YT Archiving";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNewFolder;
        private Button buttonNewSub;
        private Button buttonDelete;
        private TreeView treeViewFoldersAndSubs;
        private Button buttonSyncAll;
        private Button buttonSyncSelected;
        private Button buttonLoadPreset;
        private ProgressBar progressBarDownload;
        private ListBox listBoxTitles;
        private TextBox textBoxConsole;
        private Label labelSkipped;
        private TextBox textBoxOutputPath;
        private Label label1;
        private Button buttonBrowseOutputPath;
    }
}