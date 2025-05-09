using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class Eat_In : UserControl
    {
        private bool isCheckboxChecked = false;
        private int currentValue = 0;
        private int currentValue1 = 0;
        private int currentValue2 = 0;
        private int currentValue3 = 0;
        private int currentValue4 = 0;
        private int currentValue5 = 0;
        private int currentValue6 = 0;
        private int currentValue7 = 0;
        private int currentValue8 = 0;
        private int currentValue9 = 0;
        private int currentValue10 = 0;
        private int currentValue11 = 0;
        public Eat_In()
        {
            InitializeComponent();
        }

        private void Eat_In_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue++;
                updatetextbox();
            }


        }
        private void updatetextbox()
        {
            textBox1.Text = currentValue.ToString();
        }
        private void updatetextbox1()
        {
            textBox2.Text = currentValue1.ToString();
        }
        private void updatetextbox2()
        {
            textBox3.Text = currentValue2.ToString();
        }
        private void updatetextbox3()
        {
            textBox15.Text = currentValue3.ToString();
        }
        private void updatetextbox4()
        {
            textBox14.Text = currentValue4.ToString();
        }
        private void updatetextbox5()
        {
            textBox13.Text = currentValue5.ToString();
        }
        private void updatetextbox6()
        {
            textBox4.Text = currentValue6.ToString();
        }
        private void updatetextbox7()
        {
            textBox5.Text = currentValue7.ToString();
        }
        private void updatetextbox8()
        {
            textBox6.Text = currentValue8.ToString();
        }
        private void updatetextbox9()
        {
            textBox10.Text = currentValue9.ToString();
        }
        private void updatetextbox10()
        {
            textBox11.Text = currentValue10.ToString();
        }
        private void updatetextbox11()
        {
            textBox12.Text = currentValue11.ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            isCheckboxChecked = checkBox1.Checked;
            button2.Enabled = button3.Enabled = isCheckboxChecked;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue--;
                if (currentValue < 0)
                {
                    currentValue = 0;
                }
                updatetextbox();
            }


        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked && currentValue > 0)
            {
                // Driver_Payment driver_Payment = new Driver_Payment(currentValue);
                // OnPlaceOrderClicked?.Invoke(this, EventArgs.Empty);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked = checkBox2.Checked;
            button4.Enabled = button26.Enabled = isCheckboxChecked;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue1++;
                updatetextbox1();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue1--;
                if (currentValue1 < 0)
                {
                    currentValue1 = 0;
                }
                updatetextbox1();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue2++;
                updatetextbox2();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked = checkBox3.Checked;
            button6.Enabled = button27.Enabled = isCheckboxChecked;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue2--;
                if (currentValue2 < 0)
                {
                    currentValue2 = 0;
                }
                updatetextbox2();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue3++;
                updatetextbox3();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked = checkBox15.Checked;
            button35.Enabled = button36.Enabled = isCheckboxChecked;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue3--;
                if (currentValue3 < 0)
                {
                    currentValue3 = 0;
                }
                updatetextbox3();
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked = checkBox14.Checked;
            button33.Enabled = button32.Enabled = isCheckboxChecked;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue4++;
                updatetextbox4();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue4--;
                if (currentValue4 < 0)
                {
                    currentValue4 = 0;
                }
                updatetextbox4();
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked = checkBox13.Checked;
            button30.Enabled = button29.Enabled = isCheckboxChecked;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue5++;
                updatetextbox5();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue5--;
                if (currentValue5 < 0)
                {
                    currentValue5 = 0;
                }
                updatetextbox5();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked = checkBox4.Checked;
            button8.Enabled = button9.Enabled = isCheckboxChecked;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue6++;
                updatetextbox6();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue6--;
                if (currentValue6 < 0)
                {
                    currentValue6 = 0;
                }
                updatetextbox6();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked = checkBox5.Checked;
            button11.Enabled = button12.Enabled = isCheckboxChecked;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue7++;
                updatetextbox7();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue7--;
                if (currentValue7 < 0)
                {
                    currentValue7 = 0;
                }
                updatetextbox7();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked = checkBox6.Checked;
            button39.Enabled = button38.Enabled = isCheckboxChecked;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue8--;
                if (currentValue8 < 0)
                {
                    currentValue8 = 0;
                }
                updatetextbox8();
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue8++;
                updatetextbox8();
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked = checkBox10.Checked;
            button20.Enabled = button21.Enabled = isCheckboxChecked;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue9--;
                if (currentValue9 < 0)
                {
                    currentValue9 = 0;
                }
                updatetextbox9();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue9++;
                updatetextbox9();
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked = checkBox11.Checked;
            button24.Enabled = button23.Enabled = isCheckboxChecked;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue10++;
                updatetextbox10();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue10--;
                if (currentValue10 < 0)
                {
                    currentValue10 = 0;
                }
                updatetextbox10();
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked = checkBox12.Checked;
            button42.Enabled = button41.Enabled = isCheckboxChecked;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue11++;
                updatetextbox11();
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked)
            {
                currentValue11--;
                if (currentValue11 < 0)
                {
                    currentValue11 = 0;
                }
                updatetextbox11();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (pictureBox8.Visible == true)
            {
                pictureBox7.Visible = true;
                pictureBox8.Visible = false;
            }
            else if (pictureBox7.Visible == true)
            {
                pictureBox8.Visible = true;
                pictureBox7.Visible=false;
            }
        }
    }
}
