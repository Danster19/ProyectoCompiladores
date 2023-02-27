namespace Proyecto
{
    public class AnalizadorLexico
    {
        private List<char> simbolosPermitidos;
        private List<string> palabrasReservadas;
        List<string> palabras;

        public AnalizadorLexico()
        {
            palabras = new List<string>();
            simbolosPermitidos = new List<char>();
            palabrasReservadas = new List<string>();
            GetSimbolosPermitidos();
            GetPalabrasReservadas();
        }


        public void Escanear(string texto)
        {
            string palabra = "";
            var path = @"Archivos\Errores.txt";
            var sw = new StreamWriter(path);
            // Contadores para identificar la fila y columna actual
            int columna = 1;
            int fila = 1;

            for (int i = 0; i < texto.Length; i++)
            {
                var caracter = texto[i];
                // Si el caracter leído, no está dentro de la lista de caracteres permitidos
                // guarda el error y su ubicación en Errores.txt
                if (!simbolosPermitidos.Contains(caracter))
                {
                    string error = $"Simbolo no permitido: '{caracter}', fila: {fila}, columna: {columna}";
                    sw.WriteLine(error);
                }
                // Si el caracter leído es un espacio o un salto de línea, agrega la palabra a la
                // lista de palabras y si no, agrega el caracter a la palabra actual.
                if (!caracter.Equals(' ') && !caracter.Equals('\n'))
                {
                    palabra += caracter;
                }
                else
                {
                    palabras.Add(palabra);
                    palabra = "";
                }
                // Verifica si el caracter leído es el último de la cadena, si es así
                // agrega 'palabra' a la lista de palabras.
                if (i == texto.Length - 1)
                {
                    palabras.Add(palabra);
                    palabra = "";
                }
                // Si hay un salto de línea reinicia el contador de columna y agrega uno a fila
                if (caracter.Equals('\n'))
                {
                    fila++;
                    columna = 1;
                }
                else
                {   // Si el caracter leído no es un salto de línea, aumenta el contador de columna
                    columna++;
                }
            }
            sw.Close();
           /* foreach (string p in palabras)
            {
                MessageBox.Show($"Palabra: '{p}'");
            }*/
        }
        
        private void GetSimbolosPermitidos()
        {
            simbolosPermitidos.Add(' ');
            simbolosPermitidos.Add('\n');
            simbolosPermitidos.Add('\t');
            simbolosPermitidos.Add('\r');
            string path = @"Archivos\TablaDeSimbolos.txt";
            try
            {
                string text = File.ReadAllText(path);
                string[] filas = text.Split('\n');
                foreach (var fila in filas)
                {
                    string[] caracteres = fila.Split(' ');
                    foreach (var c in caracteres)
                    {
                        simbolosPermitidos.Add(c[0]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al abrir el archivo de símbolos permitidos: {e.Message}");
            }
        }

        private void GetPalabrasReservadas()
        {
            try
            {
                string path = @"Archivos\PalabrasReservadas.txt";
                string text = File.ReadAllText(path);
                string[] filas = text.Split('\n');
                foreach (var fila in filas)
                {
                    palabrasReservadas.Add(fila);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al abrir el archivo de palabras reservadas: {e.Message}");
                throw;
            }
        }
    }
}