namespace Ariketa1_esaldiak_lotu_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool botonGuardarHabilitado = true;
        List<string> textosGuardados = new List<string>();
        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEsaldia1_Click(object sender, EventArgs e)
        {
            if (botonGuardarHabilitado)
            {
                string textoIngresado = textBox1.Text;
                textosGuardados.Add(textoIngresado);
                txtBox.Clear(); // Limpia el TextBox después de guardar el texto
                botonGuardarHabilitado = false;
                btnGuardar.Enabled = false; // Desactiva el botón
                btnDesactivar.Enabled = true; // Activa el botón de desactivar
            }
        }
        private void btnEsaldia2_Click(object sender, EventArgs e)
        {
            if (botonGuardarHabilitado)
            {
                string textoIngresado = textBox1.Text;
                textosGuardados.Add(textoIngresado);
                textBox1.Clear(); // Limpia el TextBox después de guardar el texto
                botonGuardarHabilitado = false;
                btnGuardar.Enabled = false; // Desactiva el botón
                btnDesactivar.Enabled = true; // Activa el botón de desactivar
            }
        }
        private void btnEsaldia3_Click(object sender, EventArgs e)
        {
            string textoAInsertar = "egun";
            txtBox.Text += textoAInsertar;
        }
        private void btnEsaldia4_Click(object sender, EventArgs e)
        {
            string textoAInsertar = "handia";
            txtBox.Text += textoAInsertar;
        }
        private void btnEsaldia5_Click(object sender, EventArgs e)
        {
            string textoAInsertar = "da";
            txtBox.Text += textoAInsertar;
        }
        private void btnLotu_Click(object sender, EventArgs e)
        {

        }
        private void btnBorratu_Click(object sender, EventArgs e)
        {

        }
        private void btnItxi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



    }
}