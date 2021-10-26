using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MegaDeskReal
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();

            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            surfaceMaterialsCmb.DataSource = materials;
            surfaceMaterialsCmb.SelectedIndex = -1;

            List<ShippingType> shipping = Enum.GetValues(typeof(ShippingType)).Cast<ShippingType>().ToList();
            shippingTypeCmb.DataSource = shipping;
            shippingTypeCmb.SelectedIndex = -1;

            widthNumeric.Text = String.Empty;
            depthNumeric.Text = String.Empty;
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Tag = this;
            mainMenu.Show();

            this.Hide();
        }
        public bool ValidDepthInt(decimal depth)
        {

            if (depth > Desk.MIN_DEPTH && depth < Desk.MAX_DEPTH)
            {
                depthNumeric.ForeColor = System.Drawing.Color.Blue;
                const string message = "";
                warningDepthLabel.Text = message;
                return true;
            }
            else
            {
                depthNumeric.ForeColor = System.Drawing.Color.Red;
                const string message = "Invalid Depth";
                warningDepthLabel.Text = message;
                warningDepthLabel.ForeColor = System.Drawing.Color.Red;
                return false;
            }
        }

        public bool ValidWidthInt(decimal width)
        {
            if (width > Desk.MIN_WIDTH && width < Desk.MAX_WIDTH)
            {
                widthNumeric.ForeColor = System.Drawing.Color.Blue;
                const string message = "";
                warningWidthLabel.Text = message;
                return true;
            }
            else
            {
                widthNumeric.ForeColor = System.Drawing.Color.Red;
                const string message = "Invalid Width";
                warningWidthLabel.Text = message;
                warningWidthLabel.ForeColor = System.Drawing.Color.Red;
                return false;
            }
        }

        private void AddQuoteForm_Click(object sender, EventArgs e)
        {
            if (ValidWidthInt(widthNumeric.Value) && ValidDepthInt(depthNumeric.Value) &&
                surfaceMaterialsCmb.SelectedIndex > 0 && shippingTypeCmb.SelectedIndex > 0 &&
                customerNameBox.Text != String.Empty && numOfDrawersNumeric.Value > 0)
            {
                SubmitForm();
                return;
            }
            else
            {
                if (!ValidDepthInt(widthNumeric.Value))
                {
                    ValidDepthInt(widthNumeric.Value);
                }
                missingInfoWarning.Text = "Some information is missing";
                missingInfoWarning.ForeColor = System.Drawing.Color.Red;
            }

            var desk = new Desk
            {
                Depth = depthNumeric.Value,
                Width = widthNumeric.Value,
                NumberOfDrawers = (int)numOfDrawersNumeric.Value,
                desktopMaterial = (DesktopMaterial)surfaceMaterialsCmb.SelectedValue,
            };

            var deskQuote = new DeskQuote
            {
                Desk = desk,
                CustomerName = customerNameBox.Text,
                QuoteDate = DateTime.Now,
                shipping = (ShippingType)shippingTypeCmb.SelectedValue,
            };

            try
            {
                var price = deskQuote.GetQuotePrice();

                deskQuote.QuoteAmount = price;

                AddQuoteToFile(deskQuote);

                SubmitForm();

                //DisplayQuote frmDisplayQuote = new DisplayQuote(_mainMenu, deskQuote);
                //frmDisplayQuote.Show();
                //Hide();
            }
            catch (Exception err)
            {
                MessageBox.Show("There was an error creating the quote. {0}", err.InnerException.ToString());
            };
        }

        private void SubmitForm()
        {

            var desk = new Desk();
            desk.Depth = depthNumeric.Value;
            desk.Width = widthNumeric.Value;
            desk.NumberOfDrawers = (int)numOfDrawersNumeric.Value;
            desk.desktopMaterial = (DesktopMaterial)surfaceMaterialsCmb.SelectedValue;

            var deskQuote = new DeskQuote();
            deskQuote.Desk = desk;
            deskQuote.CustomerName = customerNameBox.Text;
            deskQuote.QuoteDate = DateTime.Now;
            deskQuote.shipping = (ShippingType)shippingTypeCmb.SelectedValue;

            var quoteAmount = deskQuote.GetQuotePrice();

            var displayQuote = new DisplayQuote(deskQuote.CustomerName, desk.Depth, desk.Width, desk.desktopMaterial, deskQuote.shipping, desk.NumberOfDrawers, quoteAmount);
            displayQuote.Tag = this;
            displayQuote.Show();

            this.Hide();
        }

        private void AddQuoteToFile(DeskQuote deskQuote)
        {
            var quotesFile = @"quotes.json";
            List<DeskQuote> deskQuotes = System.Text.Json.JsonSerializer.Deserialize<List<DeskQuote>>(quotesFile);
        }

        private void numDeskDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || Char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("please enter digits only");
                e.Handled = true;
            }
        }

        // EVENTS I MADE ON ACCIDENT

        private void depthWarningLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }
    }
}
