using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.UI.Misc.InputBox
{
    public partial class InputBox : Form
    {
        private InputBox(string Hint)
        {
            InitializeComponent();

            Lbl_Hint.Text = Hint;
        }

        public static string Show(string Hint)
        {
            InputBox dialog = new InputBox(Hint);
            var dialogResult = dialog.ShowDialog();
            if (dialogResult == DialogResult.Cancel)
                return string.Empty;

            string userInput = dialog.tf_Input.Text;

            return userInput;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
