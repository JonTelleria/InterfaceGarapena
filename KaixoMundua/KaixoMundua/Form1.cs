namespace KaixoMundua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaixo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KAIXO MUNDUA");
        }

        private void btnItxi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}