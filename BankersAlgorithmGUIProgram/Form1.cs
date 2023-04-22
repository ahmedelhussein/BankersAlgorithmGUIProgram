namespace BankersAlgorithmGUIProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            dataInputForm dataInput = new dataInputForm();
            dataInput.Show();
            this.Hide();
        }
    }
}