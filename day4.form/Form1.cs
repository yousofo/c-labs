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
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            MessageBox.Show($"UserName : {userName} | Password : {password}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
