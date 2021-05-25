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
    public partial class Open : Form
    {
        public Open()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Colours = new Colours();
            Colours.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Count_of_materials = new Count_of_materials();
            Count_of_materials.Show();
        }
    }
}
