namespace day4.form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //textBox1.Click += (object sender,EventArgs e) => { };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num2Temp;

            if (!(float.TryParse(num1.Text, out float num1Temp) &&
                float.TryParse(num2.Text, out num2Temp)))
            {

                MessageBox.Show($"numbers only");
                return;
            }
            MessageBox.Show((num1Temp + num2Temp).ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void num2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
