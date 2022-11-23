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
    public partial class drugAviForm : Form
    {
        public drugAviForm(int drugId)
        {
            InitializeComponent();
            Avaliabilities avController = new Avaliabilities();
            label1.Text = "Средняя цена: " + Math.Round(avController.AverageData(drugId),2).ToString();
            foreach(string[] s in avController.GetDataByDrugId(drugId))
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void drugAviForm_Load(object sender, EventArgs e)
        {

        }
    }
}
