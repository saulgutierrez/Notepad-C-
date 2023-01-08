using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Manejo de archivos en el S.O.

namespace Bloc_de_Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = "";

        #region Archivo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            path = "";
            txtTexto.Clear();
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // Filtros de apertura de archivos
            open.Filter = "Archivos TXT|*.txt|Todos los archivos|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.FileName;
                StreamReader sr = new StreamReader(path); // Abrir
                txtTexto.Text = sr.ReadToEnd(); // Leer
                sr.Close(); // Cerrar
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Si la ruta de asociacion del fichero existe
            if (path != "")
            {
                StreamWriter sw = File.CreateText(path); // Sobreescribir el archivo
                sw.Write(txtTexto.Text); // Escribir el contenido
                sw.Close();
            }
            else
                btnGuardarComo_Click(sender, e);
        }
        private void btnGuardarComo_Click(object sender, EventArgs e)
        {
            // Crea una ruta de asociacion del fichero en el sistema
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivos TXT|*.txt|Todos los archivos|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                path = save.FileName;
                btnGuardar_Click(sender, e);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Portapapeles
        private void btnCortar_Click(object sender, EventArgs e)
        {
            txtTexto.Cut();
        }
        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtTexto.SelectedText);
            // txtTexto.Copy();
        }
        private void btnPegar_Click(object sender, EventArgs e)
        {
            txtTexto.Paste();
        }
        #endregion
        #region Formato
        private void btnAjusteLinea_Click(object sender, EventArgs e)
        {
            // Ajuste a la inversa del valor booleano WordWrap
            txtTexto.WordWrap = !txtTexto.WordWrap;
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            // Abrir dialogo de seleccion de color
            ColorDialog frm = new ColorDialog();
            frm.Color = txtTexto.ForeColor;

            if (frm.ShowDialog() == DialogResult.OK)
                txtTexto.ForeColor = frm.Color;
        }
        private void btnFuente_Click(object sender, EventArgs e)
        {
            // Abrir cuadro de dialogo de seleccion de fuente
            FontDialog frm = new FontDialog();
            frm.Font = txtTexto.Font;

            if (frm.ShowDialog() == DialogResult.OK)
                txtTexto.Font = frm.Font;
        }
        #endregion

    }
}
