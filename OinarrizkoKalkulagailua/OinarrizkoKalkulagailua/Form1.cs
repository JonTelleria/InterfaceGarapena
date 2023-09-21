namespace OinarrizkoKalkulagailua
{
    public partial class Form1 : Form
    {
        Kalkulagailua kalkulagailua = new Kalkulagailua();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnKen_Click(object sender, EventArgs e)
        {
            // Kalkulagailua kalkulagailua = new Kalkulagailua(float.Parse(txtZenbakia1.Text), float.Parse(txtZenbakia2.Text));
            // MessageBox.Show(kalkulagailua.Kenketa().ToString());
            try
            {
                Balidazio();
            }
            catch (Exception ex)
            {
                MessageBox.Show("zenbakiak ez dute formatu zuzena");
            }
            //kalkulagailua.Zenbakia1 = float.Parse(txtZenbakia1.Text);
            // kalkulagailua.Zenbakia2 = float.Parse(txtZenbakia2.Text);
            MessageBox.Show(kalkulagailua.Kenketa().ToString());
        }

        private void btnBider_Click(object sender, EventArgs e)
        {
            try
            {
                Balidazio();
            }
            catch (Exception ex)
            {
                MessageBox.Show("zenbakiak ez dute formatu zuzena");
            }
            
            MessageBox.Show(kalkulagailua.Biderketa().ToString());
        }
        private void btnZati_Click(object sender, EventArgs e)
        {
            try
            {
                Balidazio();
            }
            catch (Exception ex)
            {
                MessageBox.Show("zenbakiak ez dute formatu zuzena");
            }
            
            MessageBox.Show(kalkulagailua.Zatiketa().ToString());
        }

        private void btnGehi_Click(object sender, EventArgs e)
        {
            try
            {
                Balidazio();
            }catch (Exception ex)
            { 
                MessageBox.Show("zenbakiak ez dute formatu zuzena");
            }
            
            MessageBox.Show(kalkulagailua.Gehiketa().ToString());

        }
         
        private void Balidazio() 
        {
            kalkulagailua.Zenbakia1 = float.Parse(txtZenbakia1.Text);
            kalkulagailua.Zenbakia2 = float.Parse(txtZenbakia2.Text);
        }
        
    }

       
}
