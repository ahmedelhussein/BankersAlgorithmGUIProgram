using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankersAlgorithmGUIProgram
{
    public partial class dataInputForm : Form
    {
        public dataInputForm()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out globalDataMembers.processesCount))
            {
                // The input is a valid integer

            }
            else
            {
                // The input is not a valid integer
                MessageBox.Show("Please enter a valid integer.");
            }

            if (int.TryParse(textBox2.Text, out globalDataMembers.resourcesCount))
            {
                // The input is a valid integer

            }
            else
            {
                // The input is not a valid integer
                MessageBox.Show("Please enter a valid integer.");
            }

            label3.Text = globalDataMembers.processesCount.ToString();
            label4.Text = globalDataMembers.resourcesCount.ToString();
        }
    }
}
