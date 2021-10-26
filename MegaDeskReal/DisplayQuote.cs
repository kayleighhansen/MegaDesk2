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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(string name, decimal depth, decimal width, MegaDeskReal.DesktopMaterial surfaceMaterial, MegaDeskReal.ShippingType shippingType, decimal drawers, decimal quoteAmount)
        {
            InitializeComponent();

            customerNameBox.Text = name;
            depthNumeric.Value = depth;
            widthNumeric.Value = width;

            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            surfaceMaterialsCmb.DataSource = materials;

            List<ShippingType> shipping = Enum.GetValues(typeof(ShippingType)).Cast<ShippingType>().ToList();
            shippingTypeCmb.DataSource = shipping;

            surfaceMaterialsCmb.SelectedItem = surfaceMaterial;
            shippingTypeCmb.SelectedItem = shippingType;

            numOfDrawersNumeric.Value = drawers;
            quoteAmountBox.Text = quoteAmount.ToString();

        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Tag = this;
            mainMenu.Show();

            this.Hide();
        }

        private void ViewQuoteForm_Click(object sender, EventArgs e)
        {
            var viewQuotes = new ViewAllQuotes();
            viewQuotes.Tag = this;
            viewQuotes.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addQuote = new AddQuote();
            addQuote.Tag = this;
            addQuote.Show();

            this.Hide();
        }
    }
}
