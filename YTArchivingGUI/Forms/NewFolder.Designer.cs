namespace YTArchivingGUI.Forms
{
    partial class NewFolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFolder));
            textBoxFolderName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxFolderName
            // 
            textBoxFolderName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFolderName.Location = new Point(93, 12);
            textBoxFolderName.Name = "textBoxFolderName";
            textBoxFolderName.Size = new Size(180, 23);
            textBoxFolderName.TabIndex = 0;
            textBoxFolderName.KeyDown += TextBoxFolderName_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "Folder Name";
            // 
            // NewFolder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 45);
            Controls.Add(label1);
            Controls.Add(textBoxFolderName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewFolder";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NewFolder";
            FormClosing += NewFolder_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFolderName;
        private Label label1;
    }
}