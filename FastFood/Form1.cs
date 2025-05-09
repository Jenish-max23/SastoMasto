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
    public partial class Form1 : Form
    {
        private Eat_In eat_In;

        public static Form2 jenish;
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = Home.Height;
            SidePanel.Top = Home.Top;
            home1.BringToFront();

            eat_In = new Eat_In();



        }
        private void Eat_In_OnPlaceOrderClicked(object sender, EventArgs e)
        {
            // Handle the event when the Place Order button is clicked
            try
            {
                // Your handling logic here
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Home.Height;
            SidePanel.Top = Home.Top;
            home1.BringToFront();
        }

        private void Eatin_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Eatin.Height;
            SidePanel.Top = Eatin.Top;
            eat_In1.BringToFront();
        }

        private void collections_Click(object sender, EventArgs e)
        {
            SidePanel.Height = collections.Height;
            SidePanel.Top = collections.Top;
            delivery1.BringToFront();
        }

        private void takeaway_Click(object sender, EventArgs e)
        {
            SidePanel.Height = takeaway.Height;
            SidePanel.Top = takeaway.Top;
            take_Away1.BringToFront();
        }

        private void driverpayment_Click(object sender, EventArgs e)
        {
            SidePanel.Height = driverpayment.Height;
            SidePanel.Top = driverpayment.Top;
            driver_Payment1.BringToFront();
        }

        private void customers_Click(object sender, EventArgs e)
        {
            SidePanel.Height = customers.Height;
            SidePanel.Top = customers.Top;
            customers1.BringToFront();
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void home1_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            notification form = new notification();
            form.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            settings form = new settings();
            form.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Help form = new Help();
            form.Show();
        }
    }
}
