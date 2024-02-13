using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FrmBusquedaLibro : Form
    {
        public FrmBusquedaLibro(LibroFileText libroFileText, ABB abb)
        {
            InitializeComponent();
            this.libFileText = libroFileText;
            this.abb = abb;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = this.txtId.Text;

            if (!id.Equals(""))
            {
                // Recuperamos el libro que coincida con el id buscado.
                // Esto lo recuperamos del abb.
                this.l = this.abb.obtenerLibro(int.Parse(id));

                if (this.l is not null)
                {
                    // Llenamos los cuadros de texto con la información
                    // recuperada.
                    this.txtTitulo.Text = l.getTitulo();
                    this.txtAutor.Text = l.getAutor();
                    this.txtEditorial.Text = l.getEditorial();
                    this.txtPais.Text = l.getPais();
                    this.txtAnio.Text = l.getAnio().ToString();
                    this.lblDisp.Text = l.msgDisponible();
                    this.enableTxtBox();
                    btnActualizar.Enabled = true;
                    btnBorrar.Enabled = true;
                }
            }
            else
            {
                // Enviamos un mensaje si no encontramos un libro que
                // coincida con el id.
                MessageBoxButtons btnOk = MessageBoxButtons.OK;
                MessageBoxIcon icoWarn = MessageBoxIcon.Warning;
                string msg = "Ingrese el id de libro a buscar.";
                string title = "Validar campos";
                MessageBox.Show(msg, title, btnOk, icoWarn);
            }
        }

        private bool validateTxtBox()
        {
            TextBox[] textBoxes = new TextBox[5];
            textBoxes[0] = this.txtTitulo;
            textBoxes[1] = this.txtAutor;
            textBoxes[2] = this.txtEditorial;
            textBoxes[3] = this.txtPais;
            textBoxes[4] = this.txtAnio;

            foreach (TextBox tb in textBoxes)
            {
                if (tb.Text.Equals("")) { return false; }
            }
            return true;
        }

        private void resetTxtBox()
        {
            TextBox[] textBoxes = new TextBox[6];
            textBoxes[0] = this.txtTitulo;
            textBoxes[1] = this.txtAutor;
            textBoxes[2] = this.txtEditorial;
            textBoxes[3] = this.txtPais;
            textBoxes[4] = this.txtAnio;
            textBoxes[5] = this.txtId;

            foreach (TextBox tb in textBoxes) { tb.Text = ""; }
        }

        private void enableTxtBox()
        {
            TextBox[] textBoxes = new TextBox[5];
            textBoxes[0] = this.txtTitulo;
            textBoxes[1] = this.txtAutor;
            textBoxes[2] = this.txtEditorial;
            textBoxes[3] = this.txtPais;
            textBoxes[4] = this.txtAnio;

            foreach (TextBox tb in textBoxes) { tb.Enabled = true; }
        }

        private void disableTxtBox()
        {
            TextBox[] textBoxes = new TextBox[5];
            textBoxes[0] = this.txtTitulo;
            textBoxes[1] = this.txtAutor;
            textBoxes[2] = this.txtEditorial;
            textBoxes[3] = this.txtPais;
            textBoxes[4] = this.txtAnio;

            foreach (TextBox tb in textBoxes) { tb.Enabled = false; }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.validateTxtBox())
            {
                // Atributos de libro modificables.
                string titulo = this.txtTitulo.Text;
                string autor = this.txtAutor.Text;
                string editorial = this.txtEditorial.Text;
                string pais = this.txtPais.Text;
                int anio = int.Parse(this.txtAnio.Text);     

                // Actualizar archivo de texto.
                string libroActualizado = this.createLine();
                int idLibro = this.l.getId();
                this.libFileText.actRegFileText(idLibro, libroActualizado);

                // Actualizar atributos del libro en el árbol.
                this.abb.ActualizarLibro(this.l, titulo, autor, editorial,
                    pais, anio);

                MessageBoxButtons btnOk = MessageBoxButtons.OK;
                MessageBoxIcon icoWarn = MessageBoxIcon.Information;
                string msg = "Libro actualizado.";
                string title = "Actualización de libro";
                MessageBox.Show(msg, title, btnOk, icoWarn);
            }
            else
            {
                MessageBoxButtons btnOk = MessageBoxButtons.OK;
                MessageBoxIcon icoWarn = MessageBoxIcon.Warning;
                string msg = "Aún hay campos por llenar.";
                string title = "Validar campos";
                MessageBox.Show(msg, title, btnOk, icoWarn);
            }

        }

        private string createLine()
        {
            return this.l.getId() + ";" + this.txtTitulo.Text + ";"
                + this.txtAutor.Text + ";" + this.txtEditorial.Text + ";"
                + this.txtPais.Text + ";" + this.txtAnio.Text;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Se crea un mensaje para el usuario, preguntando si en verdad
            // quiere eliminar el libro.
            MessageBoxButtons btnYesNo = MessageBoxButtons.YesNo;
            MessageBoxIcon icoWarn = MessageBoxIcon.Warning;
            string msg = "Desea eliminar el libro: " + this.l.getTitulo();
            string title = "Eliminación de libro";
            DialogResult result = MessageBox.Show(msg, title, btnYesNo, icoWarn);

            if (result == DialogResult.Yes)
            {
                // Si decide borrar el libro:

                // limpia los cuadros de texto.
                this.resetTxtBox(); 

                // Deshabilita los cuadros de texto que dan información del
                // libro buscado. Con la finalidad de que el usuario busque
                // otro libro.
                this.disableTxtBox();

                // Se deshabilitan los botones de actualizar y borrar.
                this.btnBorrar.Enabled = false;
                this.btnActualizar.Enabled = false;

                // Se elimina libro del archivo de texto.
                int idLibro = this.l.getId();
                this.libFileText.delRegFileText(idLibro);

                // Se elimina el libro del abb.
                this.abb.eliminar(this.l.getId());
            }
        }
    }
}
