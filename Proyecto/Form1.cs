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
            string sigue=@"Archivos\Errores.txt";
            //editado por Daniel C.
            string txtError = File.ReadAllText(sigue);//lee los erores de la tabla de simbolos
            textoSecundario.Text = txtError;
        }
    }
}