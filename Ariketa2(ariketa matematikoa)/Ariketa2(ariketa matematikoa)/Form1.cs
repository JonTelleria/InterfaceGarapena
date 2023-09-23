using Ariketa2_ariketa_matematikoa_;

namespace Ariketa2
{
    public partial class Form1 : Form
    {
        public int a = 0;
        Ariketa test = new Ariketa();
        public Form1()
        {
            InitializeComponent();
        }







        private void Form1_Load(object sender, EventArgs e)
        {







        }







        private void lbZenbakia_Click(object sender, EventArgs e)
        {







        }







        private void tbEmaitza_TextChanged(object sender, EventArgs e)
        {







        }







        private void btnHurrengoa_Click(object sender, EventArgs e)
        {
            switch (a)
            {
                case 0:
                    lbZenbakia.Text = "Ariketa 2";
                    test.zenb1 = float.Parse(tbEmaitza.Text);
                    tbEmaitza.Clear();
                    a++;


                    break;
                case 1:
                    lbZenbakia.Text = "Ariketa 3";
                    test.zenb2 = float.Parse(tbEmaitza.Text);
                    tbEmaitza.Clear();
                    a++;
                    break;
                case 2:
                    lbZenbakia.Text = "Ariketa 4";
                    test.zenb3 = float.Parse(tbEmaitza.Text);
                    tbEmaitza.Clear();
                    a++;
                    break;
                case 3:
                    lbZenbakia.Text = "Emaitza";
                    test.zenb4 = float.Parse(tbEmaitza.Text);
                    tbEmaitza.Text = "(" + test.zenb1 + " + (" + test.zenb2 + "x2)" + " + (" + test.zenb3 + "x3)" + " + (" + test.zenb4 + "x4)/4 = " + test.eragiketaluzea().ToString();
                    
                    a++;
                    break;
                



                   





            }





        }







        private void btnGarbitu_Click(object sender, EventArgs e)
        {

            tbEmaitza.Clear();
            lbZenbakia.Text = "1. zenbakia";





        }







        private void btIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();





        }
    }
}