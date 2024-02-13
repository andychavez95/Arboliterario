using System;

namespace Biblioteca
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //usuario Admin, contrasenia 12345
            if (txtUsuario.Text.Equals("admin") &&
                txtContrasenia.Text.Equals("12345"))
            {
                // Ruta de la carpeta.
                string rutaArchivo 
                    = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Nombre del archivo.
                string nombreArchivo = "libros.txt";

                // Nuevo árbol binario de busqueda accesible a lo largo 
                // de toda la aplicación mientras está en ejecución.
                ABB abb = new ABB();
                
                // Se crea una instancia de la clase LibroFileText.
                LibroFileText libFilTxt = 
                    new LibroFileText(rutaArchivo, nombreArchivo);

                // Aparece el formulario del menú principal.
                FrmMenuPrincipal menuPrincipal = 
                    new FrmMenuPrincipal(libFilTxt, abb);
                this.Hide();
                menuPrincipal.Show();
            }
            else
            {
                txtUsuario.Text = "";
                txtContrasenia.Text = "";
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
