using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace FastFood
{
    public partial class drink : UserControl
    {
        private bool isCheckboxChecked_1 = false;
        private bool isCheckboxChecked_2 = false;
        private bool isCheckboxChecked_3 = false;
        private bool isCheckboxChecked_4 = false;
        private bool isCheckboxChecked_5 = false;
        private bool isCheckboxChecked_6 = false;
        private bool isCheckboxChecked_7 = false;
        private bool isCheckboxChecked_8 = false;
        private bool isCheckboxChecked_9 = false;
        private int currentValue = 0;
        private int currentValue1 = 0;
        private int currentValue2 = 0;
        private int currentValue3 = 0;
        private int currentValue4 = 0;
        private int currentValue5 = 0;
        private int currentValue6 = 0;
        private int currentValue7 = 0;
        private int currentValue8 = 0;
        public drink()
        {
            InitializeComponent();
        }

        private void Delivery_Load(object sender, EventArgs e)
        {

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
            textBox4.Text = currentValue3.ToString();
        }
        private void updatetextbox4()
        {
            textBox5.Text = currentValue4.ToString();
        }
        private void updatetextbox5()
        {
            textBox6.Text = currentValue5.ToString();
        }
        private void updatetextbox6()
        {
            textBox7.Text = currentValue6.ToString();
        }
        private void updatetextbox7()
        {
            textBox8.Text = currentValue7.ToString();
        }
        private void updatetextbox8()
        {
            textBox9.Text = currentValue8.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked_1 = checkBox1.Checked;
            button2.Enabled = button3.Enabled = isCheckboxChecked_1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked_1)
            {
                currentValue++;
                updatetextbox();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked_1)
            {
                currentValue--;
                if (currentValue < 0)
                {
                    currentValue = 0;
                }
                updatetextbox();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked_2 = checkBox2.Checked;
            button6.Enabled = button5.Enabled = isCheckboxChecked_2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked_2)
            {
                currentValue1++;
                updatetextbox1();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked_2)
            {
                currentValue1--;
                if (currentValue1 < 0)
                {
                    currentValue1 = 0;
                }
                updatetextbox1();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked_3 = checkBox3.Checked;
            button9.Enabled = button8.Enabled = isCheckboxChecked_3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked_3)
            {
                currentValue2++;
                updatetextbox2();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked_3)
            {
                currentValue2--;
                if (currentValue2 < 0)
                {
                    currentValue2 = 0;
                }
                updatetextbox2();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked_4 = checkBox4.Checked;
            button11.Enabled = button12.Enabled = isCheckboxChecked_4;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked_4)
            {
                currentValue3++;
                updatetextbox3();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked_4)
            {
                currentValue3--;
                if (currentValue3 < 0)
                {
                    currentValue3 = 0;
                }
                updatetextbox3();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked_5 = checkBox5.Checked;
            button14.Enabled = button15.Enabled = isCheckboxChecked_5;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked_5)
            {
                currentValue4++;
                updatetextbox4();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked_5)
            {
                currentValue4--;
                if (currentValue4 < 0)
                {
                    currentValue4 = 0;
                }
                updatetextbox4();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked_6 = checkBox6.Checked;
            button17.Enabled = button18.Enabled = isCheckboxChecked_6;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked_6)
            {
                currentValue5++;
                updatetextbox5();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked_6)
            {
                currentValue5--;
                if (currentValue5 < 0)
                {
                    currentValue5 = 0;
                }
                updatetextbox5();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked_7 = checkBox7.Checked;
            button20.Enabled = button21.Enabled = isCheckboxChecked_7;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked_7)
            {
                currentValue6++;
                updatetextbox6();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked_7)
            {
                currentValue6--;
                if (currentValue6 < 0)
                {
                    currentValue6 = 0;
                }
                updatetextbox6();
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked_8 = checkBox8.Checked;
            button23.Enabled = button24.Enabled = isCheckboxChecked_8;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked_8)
            {
                currentValue7--;
                if (currentValue7 < 0)
                {
                    currentValue7 = 0;
                }
                updatetextbox7();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked_8)
            {
                currentValue7++;
                updatetextbox7();
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxChecked_9 = checkBox9.Checked;
            button26.Enabled = button27.Enabled = isCheckboxChecked_9;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked_9)
            {
                currentValue8--;
                if (currentValue8 < 0)
                {
                    currentValue8 = 0;
                }
                updatetextbox8();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (isCheckboxChecked_9)
            {
                currentValue8++;
                updatetextbox8();
            }
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
