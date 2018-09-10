namespace MusicaYoutube
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.acolar = new System.Windows.Forms.Button();
            this.reproducir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancion = new System.Windows.Forms.TextBox();
            this.album = new System.Windows.Forms.TextBox();
            this.artista = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lista = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.acolar);
            this.panel1.Controls.Add(this.reproducir);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cancion);
            this.panel1.Controls.Add(this.album);
            this.panel1.Controls.Add(this.artista);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 77);
            this.panel1.TabIndex = 0;
            // 
            // acolar
            // 
            this.acolar.Location = new System.Drawing.Point(277, 50);
            this.acolar.Name = "acolar";
            this.acolar.Size = new System.Drawing.Size(252, 23);
            this.acolar.TabIndex = 2;
            this.acolar.Text = "Acolar";
            this.acolar.UseVisualStyleBackColor = true;
            // 
            // reproducir
            // 
            this.reproducir.Location = new System.Drawing.Point(12, 51);
            this.reproducir.Name = "reproducir";
            this.reproducir.Size = new System.Drawing.Size(259, 23);
            this.reproducir.TabIndex = 2;
            this.reproducir.Text = "Reproducir";
            this.reproducir.UseVisualStyleBackColor = true;
            this.reproducir.Click += new System.EventHandler(this.reproducir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cancion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Album";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artista";
            // 
            // cancion
            // 
            this.cancion.Location = new System.Drawing.Point(535, 26);
            this.cancion.Name = "cancion";
            this.cancion.Size = new System.Drawing.Size(252, 20);
            this.cancion.TabIndex = 0;
            // 
            // album
            // 
            this.album.Location = new System.Drawing.Point(277, 26);
            this.album.Name = "album";
            this.album.Size = new System.Drawing.Size(252, 20);
            this.album.TabIndex = 0;
            // 
            // artista
            // 
            this.artista.Location = new System.Drawing.Point(12, 26);
            this.artista.Name = "artista";
            this.artista.Size = new System.Drawing.Size(259, 20);
            this.artista.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(277, 80);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(523, 370);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(4, 80);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(267, 368);
            this.lista.TabIndex = 2;
            this.lista.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lista_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cancion;
        private System.Windows.Forms.TextBox album;
        private System.Windows.Forms.TextBox artista;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button acolar;
        private System.Windows.Forms.Button reproducir;
        private System.Windows.Forms.ListBox lista;
    }
}

