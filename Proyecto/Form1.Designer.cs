namespace Proyecto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoPrincipal = new System.Windows.Forms.RichTextBox();
            this.textoSecundario = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoPrincipal instroduccion de valores
            // 
            this.textoPrincipal.Location = new System.Drawing.Point(50, 50);
            this.textoPrincipal.Name = "textoPrincipal";
            this.textoPrincipal.Size = new System.Drawing.Size(450, 300);
            this.textoPrincipal.TabIndex = 0;
            this.textoPrincipal.Text = "";
            //
            //texto Secundario visualizacion de errores
            //
            this.textoSecundario.Location = new System.Drawing.Point(540, 50);
            this.textoSecundario.Name = "textoSecundario";
            this.textoSecundario.Size = new System.Drawing.Size(450, 300);
            this.textoSecundario.TabIndex = 0;
            this.textoSecundario.Text = "";
            // 
            // button1 Generar analisis
            // 
            this.button1.Location = new System.Drawing.Point(1000, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            //button2 Salida
            //modificado por Daniel C
            this.button2.Location = new System.Drawing.Point(1000, 100);
            this.button2.Name = "BtnSalir";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            //
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textoPrincipal);
            this.Controls.Add(this.textoSecundario);
            this.Name = "Form1";
            this.Text = "C+-";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox textoPrincipal;
        private RichTextBox textoSecundario;
        private Button button1;
        private Button button2;

    }
}