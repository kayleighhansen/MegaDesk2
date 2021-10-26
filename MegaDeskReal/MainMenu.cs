using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskReal
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addQuote_Click(object sender, EventArgs e)
        {
            var addQuoteForm = new AddQuote();
            addQuoteForm.Tag = this;
            addQuoteForm.Show();

            this.Hide();
        }

        private void ViewAllQuotes_Click(object sender, EventArgs e)
        {
            var viewAllQuotesForm = new ViewAllQuotes();
            viewAllQuotesForm.Tag = this;
            viewAllQuotesForm.Show();

            this.Hide();
        }

        private void SearchQuotes_Click(object sender, EventArgs e)
        {
            var searchQuotesForm = new SearchQuotes();
            searchQuotesForm.Tag = this;
            searchQuotesForm.Show();

            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
