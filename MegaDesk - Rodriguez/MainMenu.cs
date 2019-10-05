using System;
using System.Windows.Forms;

namespace MegaDesk___Rodriguez
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = new AddQuote();
            viewAddQuote.Tag = this;
            viewAddQuote.Show(this);
            Hide();
        }

        private void DisplayQuoteButton_Click(object sender, EventArgs e)
        {
            DisplayQuote displayQuote = new DisplayQuote();
            displayQuote.Tag = this;
            displayQuote.Show(this);
            Hide();
        }

        private void ViewAllQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes allQuotes = new ViewAllQuotes();
            allQuotes.Tag = this;
            allQuotes.Show(this);
            Hide();
        }

        private void ViewSearchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes();
            searchQuotes.Tag = this;
            searchQuotes.Show(this);
            Hide();
        }
    }
}
