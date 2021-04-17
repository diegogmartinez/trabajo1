
namespace listadopromedio
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
            this.buttonArreglo = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.CargarArchivo = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.buttonpromedionotas = new System.Windows.Forms.Button();
            this.buttonnotamaxima = new System.Windows.Forms.Button();
            this.buttonnotaminima = new System.Windows.Forms.Button();
            this.buttonnotaparcial2 = new System.Windows.Forms.Button();
            this.buttonnotaparcial = new System.Windows.Forms.Button();
            this.buttonnotaparcial3 = new System.Windows.Forms.Button();
            this.listBoxnotas = new System.Windows.Forms.ListBox();
            this.textBoxpromedio = new System.Windows.Forms.TextBox();
            this.textBoxnotamaxima = new System.Windows.Forms.TextBox();
            this.textBoxnotaminima = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonArreglo
            // 
            this.buttonArreglo.Location = new System.Drawing.Point(0, 0);
            this.buttonArreglo.Name = "buttonArreglo";
            this.buttonArreglo.Size = new System.Drawing.Size(75, 23);
            this.buttonArreglo.TabIndex = 13;
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 20;
            this.listBoxResultado.Location = new System.Drawing.Point(462, 35);
            this.listBoxResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(269, 444);
            this.listBoxResultado.TabIndex = 1;
            // 
            // CargarArchivo
            // 
            this.CargarArchivo.Location = new System.Drawing.Point(14, 93);
            this.CargarArchivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CargarArchivo.Name = "CargarArchivo";
            this.CargarArchivo.Size = new System.Drawing.Size(128, 31);
            this.CargarArchivo.TabIndex = 2;
            this.CargarArchivo.Text = "Cargar Archivo";
            this.CargarArchivo.UseVisualStyleBackColor = true;
            this.CargarArchivo.Click += new System.EventHandler(this.CargarArchivo_Click);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(159, 35);
            this.textBoxResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResultado.Size = new System.Drawing.Size(295, 454);
            this.textBoxResultado.TabIndex = 3;
            this.textBoxResultado.TextChanged += new System.EventHandler(this.textBoxResultado_TextChanged);
            // 
            // buttonNombres
            // 
            this.buttonNombres.Location = new System.Drawing.Point(14, 132);
            this.buttonNombres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(128, 31);
            this.buttonNombres.TabIndex = 4;
            this.buttonNombres.Text = "Nombres";
            this.buttonNombres.UseVisualStyleBackColor = true;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // buttonpromedionotas
            // 
            this.buttonpromedionotas.Location = new System.Drawing.Point(862, 43);
            this.buttonpromedionotas.Name = "buttonpromedionotas";
            this.buttonpromedionotas.Size = new System.Drawing.Size(128, 29);
            this.buttonpromedionotas.TabIndex = 5;
            this.buttonpromedionotas.Text = "Promedio Notas";
            this.buttonpromedionotas.UseVisualStyleBackColor = true;
            this.buttonpromedionotas.Click += new System.EventHandler(this.buttonpromedionotas_Click);
            // 
            // buttonnotamaxima
            // 
            this.buttonnotamaxima.Location = new System.Drawing.Point(859, 170);
            this.buttonnotamaxima.Name = "buttonnotamaxima";
            this.buttonnotamaxima.Size = new System.Drawing.Size(128, 29);
            this.buttonnotamaxima.TabIndex = 6;
            this.buttonnotamaxima.Text = "Nota Maxima";
            this.buttonnotamaxima.UseVisualStyleBackColor = true;
            this.buttonnotamaxima.Click += new System.EventHandler(this.buttonnotamaxima_Click);
            // 
            // buttonnotaminima
            // 
            this.buttonnotaminima.Location = new System.Drawing.Point(862, 302);
            this.buttonnotaminima.Name = "buttonnotaminima";
            this.buttonnotaminima.Size = new System.Drawing.Size(128, 29);
            this.buttonnotaminima.TabIndex = 7;
            this.buttonnotaminima.Text = "Nota Minima";
            this.buttonnotaminima.UseVisualStyleBackColor = true;
            this.buttonnotaminima.Click += new System.EventHandler(this.buttonnotaminima_Click);
            // 
            // buttonnotaparcial2
            // 
            this.buttonnotaparcial2.Location = new System.Drawing.Point(14, 225);
            this.buttonnotaparcial2.Name = "buttonnotaparcial2";
            this.buttonnotaparcial2.Size = new System.Drawing.Size(128, 51);
            this.buttonnotaparcial2.TabIndex = 9;
            this.buttonnotaparcial2.Text = "Nota parcial 2";
            this.buttonnotaparcial2.UseVisualStyleBackColor = true;
            this.buttonnotaparcial2.Click += new System.EventHandler(this.buttonnotaparcial2_Click);
            // 
            // buttonnotaparcial
            // 
            this.buttonnotaparcial.Location = new System.Drawing.Point(14, 170);
            this.buttonnotaparcial.Name = "buttonnotaparcial";
            this.buttonnotaparcial.Size = new System.Drawing.Size(128, 49);
            this.buttonnotaparcial.TabIndex = 10;
            this.buttonnotaparcial.Text = "Nota Parcial 1";
            this.buttonnotaparcial.UseVisualStyleBackColor = true;
            this.buttonnotaparcial.Click += new System.EventHandler(this.buttonnotaparcial_Click);
            // 
            // buttonnotaparcial3
            // 
            this.buttonnotaparcial3.Location = new System.Drawing.Point(14, 282);
            this.buttonnotaparcial3.Name = "buttonnotaparcial3";
            this.buttonnotaparcial3.Size = new System.Drawing.Size(128, 49);
            this.buttonnotaparcial3.TabIndex = 11;
            this.buttonnotaparcial3.Text = "Nota Parcial 3";
            this.buttonnotaparcial3.UseVisualStyleBackColor = true;
            this.buttonnotaparcial3.Click += new System.EventHandler(this.buttonnotaparcial3_Click);
            // 
            // listBoxnotas
            // 
            this.listBoxnotas.FormattingEnabled = true;
            this.listBoxnotas.ItemHeight = 20;
            this.listBoxnotas.Location = new System.Drawing.Point(737, 35);
            this.listBoxnotas.Name = "listBoxnotas";
            this.listBoxnotas.Size = new System.Drawing.Size(119, 444);
            this.listBoxnotas.TabIndex = 12;
            // 
            // textBoxpromedio
            // 
            this.textBoxpromedio.Location = new System.Drawing.Point(865, 78);
            this.textBoxpromedio.Multiline = true;
            this.textBoxpromedio.Name = "textBoxpromedio";
            this.textBoxpromedio.Size = new System.Drawing.Size(125, 63);
            this.textBoxpromedio.TabIndex = 14;
            this.textBoxpromedio.TextChanged += new System.EventHandler(this.textBoxpromedio_TextChanged);
            // 
            // textBoxnotamaxima
            // 
            this.textBoxnotamaxima.Location = new System.Drawing.Point(862, 205);
            this.textBoxnotamaxima.Multiline = true;
            this.textBoxnotamaxima.Name = "textBoxnotamaxima";
            this.textBoxnotamaxima.Size = new System.Drawing.Size(125, 71);
            this.textBoxnotamaxima.TabIndex = 15;
            this.textBoxnotamaxima.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxnotaminima
            // 
            this.textBoxnotaminima.Location = new System.Drawing.Point(865, 337);
            this.textBoxnotaminima.Multiline = true;
            this.textBoxnotaminima.Name = "textBoxnotaminima";
            this.textBoxnotaminima.Size = new System.Drawing.Size(125, 71);
            this.textBoxnotaminima.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1092, 600);
            this.Controls.Add(this.textBoxnotaminima);
            this.Controls.Add(this.textBoxnotamaxima);
            this.Controls.Add(this.textBoxpromedio);
            this.Controls.Add(this.listBoxnotas);
            this.Controls.Add(this.buttonnotaparcial3);
            this.Controls.Add(this.buttonnotaparcial);
            this.Controls.Add(this.buttonnotaparcial2);
            this.Controls.Add(this.buttonnotaminima);
            this.Controls.Add(this.buttonnotamaxima);
            this.Controls.Add(this.buttonpromedionotas);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.CargarArchivo);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.buttonArreglo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArreglo;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Button CargarArchivo;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonNombres;
        private System.Windows.Forms.Button buttonpromedionotas;
        private System.Windows.Forms.Button buttonnotamaxima;
        private System.Windows.Forms.Button buttonnotaminima;
        private System.Windows.Forms.Button buttonnotaparcial2;
        private System.Windows.Forms.Button buttonnotaparcial;
        private System.Windows.Forms.Button buttonnotaparcial3;
        private System.Windows.Forms.ListBox listBoxnotas;
        private System.Windows.Forms.TextBox textBoxpromedio;
        private System.Windows.Forms.TextBox textBoxnotamaxima;
        private System.Windows.Forms.TextBox textBoxnotaminima;
    }
}

