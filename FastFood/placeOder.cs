using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class placeOder : Form
    {
        public placeOder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main form = new main();
            form.Show();
        }

        private void placeOder_Load(object sender, EventArgs e)
        {

        }
    }
}
