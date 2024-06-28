using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifrovyPrekladac.src.forms
{
    public partial class PrekladForm : Form
    {
        public PrekladForm()
        {
            InitializeComponent();
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm form = new MainMenuForm();
            form.ShowDialog();
            this.Close();
        }

        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {
            string text = TextBoxInput.Text;

            TextBoxOutput.Text = text;
        }
    }
}
