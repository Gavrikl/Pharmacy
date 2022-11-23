using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void pharmacyButton_Click(object sender, EventArgs e)
        {
            new CreatePharmacyForm().Show();
        }

        private void drugButton_Click(object sender, EventArgs e)
        {
            new DrugsForm().Show();
        }

        private void aviabilityButton_Click(object sender, EventArgs e)
        {
            new AvaliabilityForm().Show();
        }
    }
}
