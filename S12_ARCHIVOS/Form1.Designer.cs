
namespace S12_ARCHIVOS
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
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageDirectorios = new System.Windows.Forms.TabPage();
            this.tabPageArchivos = new System.Windows.Forms.TabPage();
            this.tabPageStream = new System.Windows.Forms.TabPage();
            this.buttonPathActual = new System.Windows.Forms.Button();
            this.labelPathActual = new System.Windows.Forms.Label();
            this.labelPathEscritorio = new System.Windows.Forms.Label();
            this.buttonPathEscritorio = new System.Windows.Forms.Button();
            this.labelPathCombinado = new System.Windows.Forms.Label();
            this.labelPathRelativo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.textBoxContenidoArchivos = new System.Windows.Forms.TextBox();
            this.buttonArchivos = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxContenidoStream = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.tabControlPrincipal.SuspendLayout();
            this.tabPageDirectorios.SuspendLayout();
            this.tabPageArchivos.SuspendLayout();
            this.tabPageStream.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.tabPageDirectorios);
            this.tabControlPrincipal.Controls.Add(this.tabPageArchivos);
            this.tabControlPrincipal.Controls.Add(this.tabPageStream);
            this.tabControlPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(767, 426);
            this.tabControlPrincipal.TabIndex = 0;
            this.tabControlPrincipal.SelectedIndexChanged += new System.EventHandler(this.tabControlPrincipal_SelectedIndexChanged);
            // 
            // tabPageDirectorios
            // 
            this.tabPageDirectorios.Controls.Add(this.labelPathRelativo);
            this.tabPageDirectorios.Controls.Add(this.labelPathCombinado);
            this.tabPageDirectorios.Controls.Add(this.labelPathEscritorio);
            this.tabPageDirectorios.Controls.Add(this.buttonPathEscritorio);
            this.tabPageDirectorios.Controls.Add(this.labelPathActual);
            this.tabPageDirectorios.Controls.Add(this.buttonPathActual);
            this.tabPageDirectorios.Location = new System.Drawing.Point(4, 22);
            this.tabPageDirectorios.Name = "tabPageDirectorios";
            this.tabPageDirectorios.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDirectorios.Size = new System.Drawing.Size(759, 400);
            this.tabPageDirectorios.TabIndex = 0;
            this.tabPageDirectorios.Text = "Directorios";
            this.tabPageDirectorios.UseVisualStyleBackColor = true;
            // 
            // tabPageArchivos
            // 
            this.tabPageArchivos.Controls.Add(this.textBoxContenidoArchivos);
            this.tabPageArchivos.Controls.Add(this.buttonArchivos);
            this.tabPageArchivos.Controls.Add(this.textBoxContenido);
            this.tabPageArchivos.Controls.Add(this.button1);
            this.tabPageArchivos.Location = new System.Drawing.Point(4, 22);
            this.tabPageArchivos.Name = "tabPageArchivos";
            this.tabPageArchivos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArchivos.Size = new System.Drawing.Size(759, 400);
            this.tabPageArchivos.TabIndex = 1;
            this.tabPageArchivos.Text = "Archivos";
            this.tabPageArchivos.UseVisualStyleBackColor = true;
            // 
            // tabPageStream
            // 
            this.tabPageStream.Controls.Add(this.labelError);
            this.tabPageStream.Controls.Add(this.textBoxContenidoStream);
            this.tabPageStream.Controls.Add(this.button2);
            this.tabPageStream.Controls.Add(this.treeView1);
            this.tabPageStream.Location = new System.Drawing.Point(4, 22);
            this.tabPageStream.Name = "tabPageStream";
            this.tabPageStream.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStream.Size = new System.Drawing.Size(759, 400);
            this.tabPageStream.TabIndex = 2;
            this.tabPageStream.Text = "Stream";
            this.tabPageStream.UseVisualStyleBackColor = true;
            // 
            // buttonPathActual
            // 
            this.buttonPathActual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPathActual.Location = new System.Drawing.Point(25, 24);
            this.buttonPathActual.Name = "buttonPathActual";
            this.buttonPathActual.Size = new System.Drawing.Size(100, 54);
            this.buttonPathActual.TabIndex = 0;
            this.buttonPathActual.Text = "Mostrar Directorio Actual";
            this.buttonPathActual.UseVisualStyleBackColor = true;
            this.buttonPathActual.Click += new System.EventHandler(this.buttonPathActual_Click);
            // 
            // labelPathActual
            // 
            this.labelPathActual.AutoSize = true;
            this.labelPathActual.Location = new System.Drawing.Point(172, 45);
            this.labelPathActual.Name = "labelPathActual";
            this.labelPathActual.Size = new System.Drawing.Size(69, 13);
            this.labelPathActual.TabIndex = 1;
            this.labelPathActual.Text = "path actual...";
            // 
            // labelPathEscritorio
            // 
            this.labelPathEscritorio.AutoSize = true;
            this.labelPathEscritorio.Location = new System.Drawing.Point(172, 128);
            this.labelPathEscritorio.Name = "labelPathEscritorio";
            this.labelPathEscritorio.Size = new System.Drawing.Size(79, 13);
            this.labelPathEscritorio.TabIndex = 3;
            this.labelPathEscritorio.Text = "path escritorio..";
            // 
            // buttonPathEscritorio
            // 
            this.buttonPathEscritorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPathEscritorio.Location = new System.Drawing.Point(25, 128);
            this.buttonPathEscritorio.Name = "buttonPathEscritorio";
            this.buttonPathEscritorio.Size = new System.Drawing.Size(100, 54);
            this.buttonPathEscritorio.TabIndex = 2;
            this.buttonPathEscritorio.Text = "Mostrar Path Escritorio";
            this.buttonPathEscritorio.UseVisualStyleBackColor = true;
            this.buttonPathEscritorio.Click += new System.EventHandler(this.buttonPathEscritorio_Click);
            // 
            // labelPathCombinado
            // 
            this.labelPathCombinado.AutoSize = true;
            this.labelPathCombinado.Location = new System.Drawing.Point(172, 169);
            this.labelPathCombinado.Name = "labelPathCombinado";
            this.labelPathCombinado.Size = new System.Drawing.Size(86, 13);
            this.labelPathCombinado.TabIndex = 4;
            this.labelPathCombinado.Text = "path combinado.";
            // 
            // labelPathRelativo
            // 
            this.labelPathRelativo.AutoSize = true;
            this.labelPathRelativo.Location = new System.Drawing.Point(172, 149);
            this.labelPathRelativo.Name = "labelPathRelativo";
            this.labelPathRelativo.Size = new System.Drawing.Size(110, 13);
            this.labelPathRelativo.TabIndex = 5;
            this.labelPathRelativo.Text = "path relativo escritorio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar Subdirectorios STORES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.Location = new System.Drawing.Point(190, 40);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.Size = new System.Drawing.Size(531, 78);
            this.textBoxContenido.TabIndex = 1;
            // 
            // textBoxContenidoArchivos
            // 
            this.textBoxContenidoArchivos.Location = new System.Drawing.Point(194, 164);
            this.textBoxContenidoArchivos.Multiline = true;
            this.textBoxContenidoArchivos.Name = "textBoxContenidoArchivos";
            this.textBoxContenidoArchivos.Size = new System.Drawing.Size(531, 78);
            this.textBoxContenidoArchivos.TabIndex = 3;
            // 
            // buttonArchivos
            // 
            this.buttonArchivos.Location = new System.Drawing.Point(33, 158);
            this.buttonArchivos.Name = "buttonArchivos";
            this.buttonArchivos.Size = new System.Drawing.Size(84, 56);
            this.buttonArchivos.TabIndex = 2;
            this.buttonArchivos.Text = "Mostrar Archivos STORES";
            this.buttonArchivos.UseVisualStyleBackColor = true;
            this.buttonArchivos.Click += new System.EventHandler(this.buttonArchivos_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(14, 18);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(253, 362);
            this.treeView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Leer Stream seleccionado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxContenidoStream
            // 
            this.textBoxContenidoStream.Location = new System.Drawing.Point(294, 47);
            this.textBoxContenidoStream.Multiline = true;
            this.textBoxContenidoStream.Name = "textBoxContenidoStream";
            this.textBoxContenidoStream.Size = new System.Drawing.Size(448, 310);
            this.textBoxContenidoStream.TabIndex = 2;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(500, 367);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabPageDirectorios.ResumeLayout(false);
            this.tabPageDirectorios.PerformLayout();
            this.tabPageArchivos.ResumeLayout(false);
            this.tabPageArchivos.PerformLayout();
            this.tabPageStream.ResumeLayout(false);
            this.tabPageStream.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabPageDirectorios;
        private System.Windows.Forms.TabPage tabPageArchivos;
        private System.Windows.Forms.TabPage tabPageStream;
        private System.Windows.Forms.Label labelPathActual;
        private System.Windows.Forms.Button buttonPathActual;
        private System.Windows.Forms.Label labelPathRelativo;
        private System.Windows.Forms.Label labelPathCombinado;
        private System.Windows.Forms.Label labelPathEscritorio;
        private System.Windows.Forms.Button buttonPathEscritorio;
        private System.Windows.Forms.TextBox textBoxContenido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxContenidoArchivos;
        private System.Windows.Forms.Button buttonArchivos;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBoxContenidoStream;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelError;
    }
}

