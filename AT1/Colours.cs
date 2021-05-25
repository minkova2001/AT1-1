using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT1
{
    public partial class Colours : Form
    {
        public Colours()
        {
            InitializeComponent();
        }

        private void Colours_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "atelieDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.atelieDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "atelieDataSet.Colours". При необходимости она может быть перемещена или удалена.
            this.coloursTableAdapter.Fill(this.atelieDataSet.Colours);

        }
    }
}
