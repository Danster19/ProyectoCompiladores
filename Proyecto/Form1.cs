
using System.Text.RegularExpressions; //para poder utilizar funciones de color

namespace Proyecto

{
    public partial class Form1 : Form
    {
        
        AnalizadorLexico analizador;
        public Form1()
        {
            InitializeComponent();
            LimpiarErrores();
            analizador = new AnalizadorLexico();
        }
//aqui agregaremos la funcion para que las palabras reserbadas tengan 
//un color propio.
        /*public void Color_Palabra(){
            String val = "";
            String[] Frace ={"entero","si"};
            foreach (var item in Frace)
            {
                val += item + "|";
            }

            Regex N = new Regex(val);
            int Index = textoPrincipal.SelectionStart;

            foreach (Match item2 in N.Matches(textoPrincipal.Text))
            {
                textoPrincipal.Select(item2.Index,item2.Value.Length);
                textoPrincipal.SelectionColor=Color.Blue;
                textoPrincipal.SelectionStart = Index;
            }
            textoPrincipal.SelectionColor = Color.Black;
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textoPrincipal.Text;
            analizador.Escanear(text);
            string sigue=@"Archivos\Errores.txt";
            //editado por Daniel C.
            string txtError = File.ReadAllText(sigue);//lee los erores de la tabla de simbolos
            textoSecundario.Text = txtError;
        }

        private void button2_Click(object sender, EventArgs e){
            Close();
        }

        /* Cada vez que se abra el programa los errores que habian quedado se eliminarán.
         * Esta función se llama cuando se inicializa el form.
         */
        private void LimpiarErrores(){
            try{
                string path =@"Archivos\Errores.txt";
                File.WriteAllText(path, String.Empty);
            }catch(Exception e){
                MessageBox.Show($"Error al inicializar el archivo de errores: {e.Message}");
            }
        }
    }
}