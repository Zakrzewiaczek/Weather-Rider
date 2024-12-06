using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Rider
{
    public partial class InputMessageBox : Form
    {
        private InputMessageBox(string content, string title)
        {
            InitializeComponent();

            Text = title;
            label.Text = content;
        }

        public static DialogResult Show(string title, string content, out string textboxOutput)
        {
            InputMessageBox inputMessageBox = new(content, title);
            DialogResult dialogResult = inputMessageBox.ShowDialog();

            textboxOutput = inputMessageBox.textBox.Text;
            return dialogResult;
        }

        private void OKButtonClicked(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        private void CancelButtonClicked(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void TextboxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
