namespace Proyecto
{
    public partial class Form1 : Form
    {
        AnalizadorLexico analizador;
        public Form1()
        {
            InitializeComponent();
            analizador = new AnalizadorLexico();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textoPrincipal.Text;
            analizador.Escanear(text);
        }
    }
}