using SerialGenerator.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComboBoxSize.SelectedIndex = 0;
            ComboBoxDivisor.SelectedIndex = 0;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            CheckUpper.Checked = true;
            CheckLower.Checked = true;
            CheckNumber.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckUpper.Checked == false && CheckLower.Checked == false && CheckNumber.Checked == false)
            {
                MessageBox.Show("Check at least one type box", "ALERT!");
                return;
            }
            else 
            {
                bool U = CheckUpper.Checked;
                bool L = CheckLower.Checked;
                bool N = CheckNumber.Checked;
                int sizeString = int.Parse(ComboBoxSize.SelectedItem.ToString());
                int divisors;
                if (ComboBoxDivisor.SelectedItem.ToString() == "None") 
                {
                    divisors = 0;
                }else divisors = int.Parse(ComboBoxDivisor.SelectedItem.ToString());
                Ramdomize r = new (sizeString, divisors, U, L, N);
                r.Ramdom();
                groupBox2.Enabled = true;
                txtWithDivider.Text = r.SerialWithDivider();
                txtWithoutDivider.Text = r.SerialWithoutDivider();
            }
        }
    }
}
