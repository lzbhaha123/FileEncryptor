using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace FileEncryptor
{
    public partial class EncodeForm : Form
    {
        public EncodeForm()
        {
            InitializeComponent();
        }


        private void SelectfileButton_Click(object sender, EventArgs e)
        {
            this.fileselectDialog.ShowDialog();
            this.pathTextBox.Text = fileselectDialog.FileName;
        }

        private void GetfolderButton_Click(object sender, EventArgs e)
        {
            this.selectfolderDialog.ShowDialog();
            this.outputpathTextBox.Text = selectfolderDialog.SelectedPath;
        }

        private void EncryptstartButton_Click(object sender, EventArgs e)
        {
            Encryption ecp = new Encryption();
            ecp.TargetPath = pathTextBox.Text;
            ecp.OutputPath = outputpathTextBox.Text;
            ecp.Passwd = passwordTextBox.Text;



            Thread processThread = new Thread(new ThreadStart(ecp.EncryptFile));
            processThread.Start();
        }
        
    }
}
