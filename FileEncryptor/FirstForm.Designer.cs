namespace FileEncryptor
{
    partial class FirstForm
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
            this.Encode = new System.Windows.Forms.Button();
            this.Discode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Encode
            // 
            this.Encode.Location = new System.Drawing.Point(37, 32);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(260, 201);
            this.Encode.TabIndex = 0;
            this.Encode.Text = "Encode";
            this.Encode.UseVisualStyleBackColor = true;
            this.Encode.Click += new System.EventHandler(this.Encode_Click);
            // 
            // Discode
            // 
            this.Discode.Location = new System.Drawing.Point(316, 32);
            this.Discode.Name = "Discode";
            this.Discode.Size = new System.Drawing.Size(260, 201);
            this.Discode.TabIndex = 1;
            this.Discode.Text = "Discode";
            this.Discode.UseVisualStyleBackColor = true;
            this.Discode.Click += new System.EventHandler(this.Discode_Click);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 268);
            this.Controls.Add(this.Discode);
            this.Controls.Add(this.Encode);
            this.Name = "FirstForm";
            this.Text = "FirstForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Encode;
        private System.Windows.Forms.Button Discode;
    }
}