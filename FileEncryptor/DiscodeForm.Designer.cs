namespace FileEncryptor
{
    partial class DiscodeForm
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
            this.decryptstartButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.getfolderButton = new System.Windows.Forms.Button();
            this.outputpathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.selectfileButton = new System.Windows.Forms.Button();
            this.selectfolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.fileselectDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // decryptstartButton
            // 
            this.decryptstartButton.Location = new System.Drawing.Point(597, 313);
            this.decryptstartButton.Name = "decryptstartButton";
            this.decryptstartButton.Size = new System.Drawing.Size(191, 48);
            this.decryptstartButton.TabIndex = 17;
            this.decryptstartButton.Text = "Decrypt";
            this.decryptstartButton.UseVisualStyleBackColor = true;
            this.decryptstartButton.Click += new System.EventHandler(this.DecryptstartButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(162, 260);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(626, 35);
            this.passwordTextBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password:";
            // 
            // getfolderButton
            // 
            this.getfolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getfolderButton.Location = new System.Drawing.Point(597, 189);
            this.getfolderButton.Name = "getfolderButton";
            this.getfolderButton.Size = new System.Drawing.Size(191, 48);
            this.getfolderButton.TabIndex = 14;
            this.getfolderButton.Text = "Select folder";
            this.getfolderButton.UseVisualStyleBackColor = true;
            this.getfolderButton.Click += new System.EventHandler(this.GetfolderButton_Click);
            // 
            // outputpathTextBox
            // 
            this.outputpathTextBox.Location = new System.Drawing.Point(178, 131);
            this.outputpathTextBox.Name = "outputpathTextBox";
            this.outputpathTextBox.Size = new System.Drawing.Size(610, 35);
            this.outputpathTextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Output path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Origin file path:";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathTextBox.Location = new System.Drawing.Point(233, 12);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(555, 35);
            this.pathTextBox.TabIndex = 10;
            // 
            // selectfileButton
            // 
            this.selectfileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectfileButton.Location = new System.Drawing.Point(597, 64);
            this.selectfileButton.Name = "selectfileButton";
            this.selectfileButton.Size = new System.Drawing.Size(191, 48);
            this.selectfileButton.TabIndex = 9;
            this.selectfileButton.Text = "Select file";
            this.selectfileButton.UseVisualStyleBackColor = true;
            this.selectfileButton.Click += new System.EventHandler(this.SelectfileButton_Click);
            // 
            // fileselectDialog
            // 
            this.fileselectDialog.FileName = "fileselectDialog";
            // 
            // DiscodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.decryptstartButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.getfolderButton);
            this.Controls.Add(this.outputpathTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.selectfileButton);
            this.Name = "DiscodeForm";
            this.Text = "discode";
            this.Load += new System.EventHandler(this.Discode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button decryptstartButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button getfolderButton;
        private System.Windows.Forms.TextBox outputpathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button selectfileButton;
        private System.Windows.Forms.FolderBrowserDialog selectfolderDialog;
        private System.Windows.Forms.OpenFileDialog fileselectDialog;
    }
}