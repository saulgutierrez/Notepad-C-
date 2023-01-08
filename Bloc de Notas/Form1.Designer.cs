namespace Bloc_de_Notas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.s = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.d = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjusteLinea = new System.Windows.Forms.ToolStripMenuItem();
            this.btnColor = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.s,
            this.ediciónToolStripMenuItem,
            this.d});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(427, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // s
            // 
            this.s.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnAbrir,
            this.btnGuardar,
            this.btnGuardarComo,
            this.btnSalir});
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(60, 20);
            this.s.Text = "Archivo";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(150, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(150, 22);
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnGuardarComo
            // 
            this.btnGuardarComo.Name = "btnGuardarComo";
            this.btnGuardarComo.Size = new System.Drawing.Size(150, 22);
            this.btnGuardarComo.Text = "Guardar como";
            this.btnGuardarComo.Click += new System.EventHandler(this.btnGuardarComo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCortar,
            this.btnCopiar,
            this.btnPegar});
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // btnCortar
            // 
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(180, 22);
            this.btnCortar.Text = "Cortar";
            this.btnCortar.Click += new System.EventHandler(this.btnCortar_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(180, 22);
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnPegar
            // 
            this.btnPegar.Name = "btnPegar";
            this.btnPegar.Size = new System.Drawing.Size(180, 22);
            this.btnPegar.Text = "Pegar";
            this.btnPegar.Click += new System.EventHandler(this.btnPegar_Click);
            // 
            // d
            // 
            this.d.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAjusteLinea,
            this.btnColor,
            this.btnFuente});
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(64, 20);
            this.d.Text = "Formato";
            // 
            // btnAjusteLinea
            // 
            this.btnAjusteLinea.CheckOnClick = true;
            this.btnAjusteLinea.Name = "btnAjusteLinea";
            this.btnAjusteLinea.Size = new System.Drawing.Size(151, 22);
            this.btnAjusteLinea.Text = "Ajuste de linea";
            this.btnAjusteLinea.Click += new System.EventHandler(this.btnAjusteLinea_Click);
            // 
            // btnColor
            // 
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(151, 22);
            this.btnColor.Text = "Color";
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFuente
            // 
            this.btnFuente.Name = "btnFuente";
            this.btnFuente.Size = new System.Drawing.Size(151, 22);
            this.btnFuente.Text = "Fuente...";
            this.btnFuente.Click += new System.EventHandler(this.btnFuente_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTexto.Location = new System.Drawing.Point(0, 24);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTexto.Size = new System.Drawing.Size(427, 256);
            this.txtTexto.TabIndex = 1;
            this.txtTexto.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 280);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloc de notas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem s;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem d;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.ToolStripMenuItem btnNuevo;
        private System.Windows.Forms.ToolStripMenuItem btnAbrir;
        private System.Windows.Forms.ToolStripMenuItem btnGuardar;
        private System.Windows.Forms.ToolStripMenuItem btnGuardarComo;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
        private System.Windows.Forms.ToolStripMenuItem btnCortar;
        private System.Windows.Forms.ToolStripMenuItem btnCopiar;
        private System.Windows.Forms.ToolStripMenuItem btnPegar;
        private System.Windows.Forms.ToolStripMenuItem btnAjusteLinea;
        private System.Windows.Forms.ToolStripMenuItem btnColor;
        private System.Windows.Forms.ToolStripMenuItem btnFuente;
    }
}

