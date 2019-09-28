using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileEncryptor
{
    public partial class DiscodeForm : Form
    {
        public DiscodeForm()
        {
            InitializeComponent();
        }

        private void Discode_Load(object sender, EventArgs e)
        {

        }

        private void DecryptstartButton_Click(object sender, EventArgs e)
        {
            Encryption ecp = new Encryption();
            ecp.TargetPath = pathTextBox.Text;
            ecp.OutputPath = outputpathTextBox.Text;
            ecp.Passwd = passwordTextBox.Text;

            Thread processThread = new Thread(new ThreadStart(ecp.DecryptFile));
            processThread.Start();
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
    }
}
