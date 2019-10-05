using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk___Rodriguez
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (true)
            {
                //Sending a message to the user in case the value is not right
                textBox1.Text = String.Empty;
                textBox1.Focus();
            }
        }
    }
}
