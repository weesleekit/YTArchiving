namespace YTArchivingGUI.Forms
{
    partial class NewSubscription
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
            label1 = new Label();
            textBoxFolderName = new TextBox();
            label2 = new Label();
            textBoxURL = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 3;
            label1.Text = "Folder Name";
            // 
            // textBoxFolderName
            // 
            textBoxFolderName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFolderName.Location = new Point(93, 15);
            textBoxFolderName.Name = "textBoxFolderName";
            textBoxFolderName.Size = new Size(214, 23);
            textBoxFolderName.TabIndex = 2;
            textBoxFolderName.KeyDown += TextBoxFolderName_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 5;
            label2.Text = "URL";
            // 
            // textBoxURL
            // 
            textBoxURL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxURL.Location = new Point(93, 44);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(214, 23);
            textBoxURL.TabIndex = 4;
            textBoxURL.KeyDown += TextBoxURL_KeyDown;
            // 
            // NewSubscription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 83);
            Controls.Add(label2);
            Controls.Add(textBoxURL);
            Controls.Add(label1);
            Controls.Add(textBoxFolderName);
            Name = "NewSubscription";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NewSubscription";
            FormClosing += NewSubscription_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxFolderName;
        private Label label2;
        private TextBox textBoxURL;
    }
}