using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileEncryptor
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void Encode_Click(object sender, EventArgs e)
        {
            EncodeForm ef = new EncodeForm();
            ef.ShowDialog();
        }

        private void Discode_Click(object sender, EventArgs e)
        {
            DiscodeForm df = new DiscodeForm();
            df.ShowDialog();

        }
    }
}
