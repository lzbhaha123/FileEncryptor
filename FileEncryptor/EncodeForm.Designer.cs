namespace FileEncryptor
{
    partial class EncodeForm
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
            this.selectfileButton = new System.Windows.Forms.Button();
            this.fileselectDialog = new System.Windows.Forms.OpenFileDialog();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectfolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.outputpathTextBox = new System.Windows.Forms.TextBox();
            this.getfolderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.encryptstartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectfileButton
            // 
            this.selectfileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectfileButton.Location = new System.Drawing.Point(597, 64);
            this.selectfileButton.Name = "selectfileButton";
            this.selectfileButton.Size = new System.Drawing.Size(191, 48);
            this.selectfileButton.TabIndex = 0;
            this.selectfileButton.Text = "Select file";
            this.selectfileButton.UseVisualStyleBackColor = true;
            this.selectfileButton.Click += new System.EventHandler(this.SelectfileButton_Click);
            // 
            // fileselectDialog
            // 
            this.fileselectDialog.FileName = "fileselectDialog";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathTextBox.Location = new System.Drawing.Point(233, 12);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(555, 35);
            this.pathTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Origin file path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output path:";
            // 
            // outputpathTextBox
            // 
            this.outputpathTextBox.Location = new System.Drawing.Point(178, 131);
            this.outputpathTextBox.Name = "outputpathTextBox";
            this.outputpathTextBox.Size = new System.Drawing.Size(610, 35);
            this.outputpathTextBox.TabIndex = 4;
            // 
            // getfolderButton
            // 
            this.getfolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getfolderButton.Location = new System.Drawing.Point(597, 189);
            this.getfolderButton.Name = "getfolderButton";
            this.getfolderButton.Size = new System.Drawing.Size(191, 48);
            this.getfolderButton.TabIndex = 5;
            this.getfolderButton.Text = "Select folder";
            this.getfolderButton.UseVisualStyleBackColor = true;
            this.getfolderButton.Click += new System.EventHandler(this.GetfolderButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(162, 260);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(626, 35);
            this.passwordTextBox.TabIndex = 7;
            // 
            // encryptstartButton
            // 
            this.encryptstartButton.Location = new System.Drawing.Point(597, 313);
            this.encryptstartButton.Name = "encryptstartButton";
            this.encryptstartButton.Size = new System.Drawing.Size(191, 48);
            this.encryptstartButton.TabIndex = 8;
            this.encryptstartButton.Text = "Encrypt";
            this.encryptstartButton.UseVisualStyleBackColor = true;
            this.encryptstartButton.Click += new System.EventHandler(this.EncryptstartButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.encryptstartButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.getfolderButton);
            this.Controls.Add(this.outputpathTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.selectfileButton);
            this.Name = "MainForm";
            this.Text = "File Encryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button selectfileButton;
        private System.Windows.Forms.OpenFileDialog fileselectDialog;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog selectfolderDialog;
        private System.Windows.Forms.TextBox outputpathTextBox;
        private System.Windows.Forms.Button getfolderButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button encryptstartButton;
    }
}

