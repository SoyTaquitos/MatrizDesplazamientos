namespace MatrizDesplazamientos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.matriz1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.ordenarFilaDeMenorAMayorDeIzquierdaADerechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.desplazamientoDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnaDeArribaHaciaAbajoDerizqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filaDerizqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.filaInferiorIzqderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matriz1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1263, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // matriz1ToolStripMenuItem
            // 
            this.matriz1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.descargarToolStripMenuItem,
            this.toolStripSeparator3,
            this.ordenarFilaDeMenorAMayorDeIzquierdaADerechaToolStripMenuItem,
            this.desplazamientoDeToolStripMenuItem,
            this.toolStripSeparator1,
            this.filaDerizqToolStripMenuItem,
            this.columnaDeArribaHaciaAbajoDerizqToolStripMenuItem,
            this.toolStripSeparator2,
            this.filaInferiorIzqderToolStripMenuItem});
            this.matriz1ToolStripMenuItem.Name = "matriz1ToolStripMenuItem";
            this.matriz1ToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.matriz1ToolStripMenuItem.Text = "Desplazamientos";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cargarToolStripMenuItem.Text = "Cargar";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // descargarToolStripMenuItem
            // 
            this.descargarToolStripMenuItem.Name = "descargarToolStripMenuItem";
            this.descargarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.descargarToolStripMenuItem.Text = "Descargar";
            this.descargarToolStripMenuItem.Click += new System.EventHandler(this.descargarToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(293, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(366, 69);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(67, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(47, 143);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(339, 236);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(413, 143);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(339, 236);
            this.textBox6.TabIndex = 7;
            // 
            // ordenarFilaDeMenorAMayorDeIzquierdaADerechaToolStripMenuItem
            // 
            this.ordenarFilaDeMenorAMayorDeIzquierdaADerechaToolStripMenuItem.Name = "ordenarFilaDeMenorAMayorDeIzquierdaADerechaToolStripMenuItem";
            this.ordenarFilaDeMenorAMayorDeIzquierdaADerechaToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.ordenarFilaDeMenorAMayorDeIzquierdaADerechaToolStripMenuItem.Text = "Fila  izq-der";
            this.ordenarFilaDeMenorAMayorDeIzquierdaADerechaToolStripMenuItem.Click += new System.EventHandler(this.ordenarFilaDeMenorAMayorDeIzquierdaADerechaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "CARGA LO QUE SEA EN LA MATRIZ Y MIRA EL DESPLZAMIENTO QUE QUERES ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "FILA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "COLUMNA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rango \"A\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rango \"B\"";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Matriz 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Vista del desplazamiento";
            // 
            // desplazamientoDeToolStripMenuItem
            // 
            this.desplazamientoDeToolStripMenuItem.Name = "desplazamientoDeToolStripMenuItem";
            this.desplazamientoDeToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.desplazamientoDeToolStripMenuItem.Text = "Columna de arriba hacia abajo de izq-der ";
            this.desplazamientoDeToolStripMenuItem.Click += new System.EventHandler(this.desplazamientoDeToolStripMenuItem_Click);
            // 
            // columnaDeArribaHaciaAbajoDerizqToolStripMenuItem
            // 
            this.columnaDeArribaHaciaAbajoDerizqToolStripMenuItem.Name = "columnaDeArribaHaciaAbajoDerizqToolStripMenuItem";
            this.columnaDeArribaHaciaAbajoDerizqToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.columnaDeArribaHaciaAbajoDerizqToolStripMenuItem.Text = "Columna de arriba hacia abajo der-izq";
            this.columnaDeArribaHaciaAbajoDerizqToolStripMenuItem.Click += new System.EventHandler(this.columnaDeArribaHaciaAbajoDerizqToolStripMenuItem_Click);
            // 
            // filaDerizqToolStripMenuItem
            // 
            this.filaDerizqToolStripMenuItem.Name = "filaDerizqToolStripMenuItem";
            this.filaDerizqToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.filaDerizqToolStripMenuItem.Text = "Fila der-izq";
            this.filaDerizqToolStripMenuItem.Click += new System.EventHandler(this.filaDerizqToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(291, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(291, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(291, 6);
            // 
            // filaInferiorIzqderToolStripMenuItem
            // 
            this.filaInferiorIzqderToolStripMenuItem.Name = "filaInferiorIzqderToolStripMenuItem";
            this.filaInferiorIzqderToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.filaInferiorIzqderToolStripMenuItem.Text = "Fila Inferior izq-der";
            this.filaInferiorIzqderToolStripMenuItem.Click += new System.EventHandler(this.filaInferiorIzqderToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 558);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem matriz1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descargarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ToolStripMenuItem ordenarFilaDeMenorAMayorDeIzquierdaADerechaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem desplazamientoDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnaDeArribaHaciaAbajoDerizqToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filaDerizqToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem filaInferiorIzqderToolStripMenuItem;
    }
}

