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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            buttonNewFolder = new Button();
            buttonNewSub = new Button();
            buttonDelete = new Button();
            treeViewFoldersAndSubs = new TreeView();
            buttonSyncAll = new Button();
            buttonSyncSelected = new Button();
            buttonLoadPreset = new Button();
            textBoxOutputPath = new TextBox();
            label1 = new Label();
            buttonBrowseOutputPath = new Button();
            buttonOpenBinFolder = new Button();
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
            treeViewFoldersAndSubs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            treeViewFoldersAndSubs.CheckBoxes = true;
            treeViewFoldersAndSubs.Location = new Point(12, 41);
            treeViewFoldersAndSubs.Name = "treeViewFoldersAndSubs";
            treeViewFoldersAndSubs.Size = new Size(493, 469);
            treeViewFoldersAndSubs.TabIndex = 3;
            treeViewFoldersAndSubs.AfterCheck += TreeViewFoldersAndSubs_AfterCheck;
            // 
            // buttonSyncAll
            // 
            buttonSyncAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSyncAll.Location = new Point(12, 516);
            buttonSyncAll.Name = "buttonSyncAll";
            buttonSyncAll.Size = new Size(75, 23);
            buttonSyncAll.TabIndex = 4;
            buttonSyncAll.Text = "Sync all";
            buttonSyncAll.UseVisualStyleBackColor = true;
            buttonSyncAll.Click += ButtonSyncAll_Click;
            // 
            // buttonSyncSelected
            // 
            buttonSyncSelected.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSyncSelected.Location = new Point(93, 516);
            buttonSyncSelected.Name = "buttonSyncSelected";
            buttonSyncSelected.Size = new Size(75, 23);
            buttonSyncSelected.TabIndex = 5;
            buttonSyncSelected.Text = "Sync one";
            buttonSyncSelected.UseVisualStyleBackColor = true;
            buttonSyncSelected.Click += ButtonSyncSelected_Click;
            // 
            // buttonLoadPreset
            // 
            buttonLoadPreset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonLoadPreset.Location = new Point(174, 516);
            buttonLoadPreset.Name = "buttonLoadPreset";
            buttonLoadPreset.Size = new Size(75, 23);
            buttonLoadPreset.TabIndex = 6;
            buttonLoadPreset.Text = "LoadPreset";
            buttonLoadPreset.UseVisualStyleBackColor = true;
            buttonLoadPreset.Click += ButtonLoadPreset_Click;
            // 
            // textBoxOutputPath
            // 
            textBoxOutputPath.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOutputPath.Location = new Point(90, 555);
            textBoxOutputPath.Name = "textBoxOutputPath";
            textBoxOutputPath.Size = new Size(334, 23);
            textBoxOutputPath.TabIndex = 11;
            textBoxOutputPath.Text = "C:\\Output";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(12, 558);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 12;
            label1.Text = "Output Path";
            // 
            // buttonBrowseOutputPath
            // 
            buttonBrowseOutputPath.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonBrowseOutputPath.Location = new Point(430, 555);
            buttonBrowseOutputPath.Name = "buttonBrowseOutputPath";
            buttonBrowseOutputPath.Size = new Size(75, 23);
            buttonBrowseOutputPath.TabIndex = 13;
            buttonBrowseOutputPath.Text = "Browse";
            buttonBrowseOutputPath.UseVisualStyleBackColor = true;
            buttonBrowseOutputPath.Click += ButtonBrowseOutputPath_Click;
            // 
            // buttonOpenBinFolder
            // 
            buttonOpenBinFolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonOpenBinFolder.Location = new Point(394, 12);
            buttonOpenBinFolder.Name = "buttonOpenBinFolder";
            buttonOpenBinFolder.Size = new Size(111, 23);
            buttonOpenBinFolder.TabIndex = 14;
            buttonOpenBinFolder.Text = "Open bin folder";
            buttonOpenBinFolder.UseVisualStyleBackColor = true;
            buttonOpenBinFolder.Click += buttonOpenBinFolder_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 594);
            Controls.Add(buttonOpenBinFolder);
            Controls.Add(buttonBrowseOutputPath);
            Controls.Add(label1);
            Controls.Add(textBoxOutputPath);
            Controls.Add(buttonLoadPreset);
            Controls.Add(buttonSyncSelected);
            Controls.Add(buttonSyncAll);
            Controls.Add(treeViewFoldersAndSubs);
            Controls.Add(buttonDelete);
            Controls.Add(buttonNewSub);
            Controls.Add(buttonNewFolder);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "YT Archiving";
            FormClosing += Main_FormClosing;
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
        private TextBox textBoxOutputPath;
        private Label label1;
        private Button buttonBrowseOutputPath;
        private Button buttonOpenBinFolder;
    }
}