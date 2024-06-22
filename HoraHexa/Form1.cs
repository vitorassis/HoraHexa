namespace HoraHexa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Carregar();
        }

        public void Carregar()
        {
            lblDec.Text = "Hora Decimal: " + DateTime.Now.ToString("t");
            lblHexa.Text = "Hora Hexa:   " + ConversorHora.GetHoraHexaAtual();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Carregar();
        }
    }
}
