namespace Proyecto
{
    public partial class Form1 : Form
    {
        AnalizadorLexico analizador = new AnalizadorLexico();
        public Form1()
        {
            InitializeComponent();
            analizador.GetSimbolosPermitidos();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textoPrincipal.Text;
            analizador.Escanear(text);
        }
    }
}