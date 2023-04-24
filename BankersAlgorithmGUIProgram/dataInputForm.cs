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
                if (textBox1.Text == "" || textBox1.Text == null || int.Parse(textBox1.Text) <= 0)
                {
                    MessageBox.Show("Please enter a valid integer.");
                }

                else
                {
                    // The input is a valid integer
                    if (textBox2.Text == "" || textBox2.Text == null || int.Parse(textBox2.Text) <= 0)
                    {
                        MessageBox.Show("Please enter a valid integer.");
                    }
                    else
                    {
                        if (int.TryParse(textBox2.Text, out globalDataMembers.resourcesCount))
                        {
                            // The input is a valid integer
                            this.Hide();
                            dataInputForm2 dataInputForm2 = new dataInputForm2();
                            dataInputForm2.ShowDialog();
                        }
                        else
                        {
                            // The input is not a valid integer
                            MessageBox.Show("Please enter a valid integer.");
                        }
                    }
                }
            }

            else
            {
                // The input is not a valid integer
                MessageBox.Show("Please enter a valid integer.");
            }
        }
    }
}
