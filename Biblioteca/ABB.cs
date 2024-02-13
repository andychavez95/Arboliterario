using System.Text;

namespace Biblioteca
{
    public class ABB
    {
        //Atributos
        private Libro l;
        private ABB padre, izq, der;

        /************************
        *****     CRUD      *****
        *************************/

        // Agrega un libro al abb.
        public void add(Libro lib)
        {
            // Para agregar un libro y su nodo padre usamos una función
            // diferente.
            this.addLibro(lib, null);
        }

        // Agrega un libro al abb y el nodo padre de este.
        private void addLibro(Libro lib, ABB nodoSuperior)
        {
            if (this.isEmpty())
            {
                /*
                 * Si vamos a ingresar un libro al abb por primera vez, este 
                 * será la raíz.
                 * Si el nodo no tiene un libro, se le asignará uno y su padre
                 * será el nodo que está por encima de él.
                 */
                this.l = lib;
                this.padre = nodoSuperior;
            }
            else
            {
                if (this.l.compare(lib) > 0)
                {
                    // Si el libro a ingresar tiene un id mayor al nodo con el 
                    // que se encuentra, buscara ingresar por el subárbol 
                    // derecho.
                    if (this.der is null) { this.der = new ABB(); }
                    this.der.addLibro(lib, this);
                }
                else if (this.l.compare(lib) < 0)
                {
                    // Si el libro a ingresar tiene un id menor al nodo con el 
                    // que se encuentra, buscara ingresar por el subárbol 
                    // izquierdo.
                    if (this.izq is null) { this.izq = new ABB(); }
                    this.izq.addLibro(lib, this);
                }
                else
                {
                    // Si se intenta ingresar un libro con un id que ya existe
                    // en el abb, lanzara un error.
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Parece que estas intentando ingresar un libro" +
                    " con el mismo id que otro ya cargado en el arbol. ");
                    sb.Append("Se ignorara este libro y se continuara con la" +
                    " carga de los demás libros.\n");
                    sb.Append("Revisar el libro titulado: " + lib.getTitulo());

                    MessageBoxButtons btnOk = MessageBoxButtons.OK;
                    MessageBoxIcon icoErr = MessageBoxIcon.Error;

                    string msg = sb.ToString();
                    string title = "Id de libro repetido";

                    MessageBox.Show(msg, title, btnOk, icoErr);
                }
            }
        }

        // Obtiene el libro que tenga el id que se le pasa como parametro.
        public Libro obtenerLibro(int id)
        {
            // Si el abb no está vacío hacemos la busqueda.
            if (!this.isEmpty())
            {
                if (this.l.compareId(id) == 0)
                {
                    // Si el id pasado como argumento coincide con el id del 
                    // libro que está en el nodo retorna este libro.
                    return this.l;
                }
                else if (this.der != null && (this.l.compareId(id) > 0))
                {
                    // Si el id a buscar es mayor que el id del libro que está
                    // en el nodo, recursivamente buscara por la derecha.
                    return this.der.obtenerLibro(id);
                }
                else if (this.izq != null && (this.l.compareId(id) < 0))
                {
                    // Si el id a buscar es menor que el id del libro que está
                    // en el nodo, recursivamente buscara por la izquierda.
                    return this.izq.obtenerLibro(id);
                }
                else
                {
                    // Si no encontramos el libro, enviamos un mensaje y
                    // retornamos null;
                    MessageBoxButtons btnOk = MessageBoxButtons.OK;
                    MessageBoxIcon icoErr = MessageBoxIcon.Error;
                    string msg = "El id de libro no existe.";
                    string title = "Libro no encontrado";
                    MessageBox.Show(msg, title, btnOk, icoErr);

                    return null;
                }
            }
            else
            {
                // Si el abb está vacío enviamos un mensaje al usuario y
                // retornamos null.
                StringBuilder sb = new StringBuilder();
                sb.Append("El árbol está vacio.\n");
                sb.Append("Primero registre un libro para hacer una busqueda.");

                MessageBoxButtons btnOk = MessageBoxButtons.OK;
                MessageBoxIcon icoErr = MessageBoxIcon.Error;

                string msg = sb.ToString();
                string title = "No hay libros registrados";

                MessageBox.Show(msg, title, btnOk, icoErr);
                return null;
            }
        }

        // Actualizamos un libro.        
        public void ActualizarLibro(Libro l, string titulo, string autor,
            string editorial, string pais, int anio)
        {
            l.setTitulo(titulo);
            l.setAutor(autor);
            l.setEditorial(editorial);
            l.setPais(pais);
            l.setAnio(anio);
        }

        private void eliminarLibro(ABB nodo)
        {
            if (nodo.izq is not null && nodo.der is not null)
            {
                // Caso cuando el nodo a eliminar tiene dos hijos.

                // Desde el subárbol izquierdo de nodo, buscamos el nodo con
                // el id más grande para intercambiarlo con el nodo que vamos
                // a borrar.
                ABB aux = nodo.izq.maxArbIzq();
                nodo.l = aux.l;
                this.eliminarLibro(aux);
            }
            else if (nodo.izq is not null || nodo.der is not null)
            {
                // Caso cuando el nodo a eliminar tiene un hijo.
                ABB aux = (nodo.izq is not null) ? nodo.izq : nodo.der;
                nodo.l = aux.l;
                nodo.izq = aux.izq;
                nodo.der = aux.der;
            }
            else
            {
                // Eliminacion de nodos que son hojas.
                if (nodo.padre is not null)
                {
                    if(nodo.padre.izq is not null && nodo.padre.izq == nodo)
                    {
                        // Si se elimina el hijo izquierdo de un nodo, el hijo
                        // será nulo.
                        nodo.padre.izq = null;
                    }
                    else
                    {
                        // Si se elimina el hijo derecho de un nodo, el hijo
                        // será nulo.
                        nodo.padre.der = null;
                    }
                }
                // Al ya no ser necesario el nodo, este apuntará a nulo.
                nodo = null;
            }
        }

        public void eliminar(int id)
        {
            if (!this.isEmpty())
            {
                if(this.l.compareId(id) == 0)
                {
                    this.eliminarLibro(this);
                }
                else if (this.l.compareId(id) > 0 && this.der is not null)
                {
                    this.der.eliminar(id);
                }
                else if (this.l.compareId(id) < 0 && this.izq is not null)
                {
                    this.izq.eliminar(id);
                }
                else
                {
                    // Si no encontramos el libro, enviamos un mensaje;
                    MessageBoxButtons btnOk = MessageBoxButtons.OK;
                    MessageBoxIcon icoErr = MessageBoxIcon.Error;
                    string msg = "El id de libro no existe.";
                    string title = "Libro no encontrado";
                    MessageBox.Show(msg, title, btnOk, icoErr);
                }
            }
            else
            {
                // Si el abb está vacío enviamos un mensaje al usuario.
                StringBuilder sb = new StringBuilder();
                sb.Append("El árbol está vacio.\n");
                sb.Append("Primero registre un libro para hacer una busqueda.");

                MessageBoxButtons btnOk = MessageBoxButtons.OK;
                MessageBoxIcon icoErr = MessageBoxIcon.Error;

                string msg = sb.ToString();
                string title = "No hay libros registrados";

                MessageBox.Show(msg, title, btnOk, icoErr);
            }
        }

        /************************
        *****   FIN CRUD    *****
        *************************/

        private ABB maxArbIzq()
        {
            if (this.der is not null){ return this.der.maxArbIzq(); }
            else { return this; }
        }

        /*
         * Imprime en consola los nodos del árbol desde el nodo más a la 
         * izquierda del subárbol izquierdo (representando el número 
         * menor) hasta el nodo más a la derecha del subárbol derecho
         * (representando el número mayor)
         */
        public void inOrdenPrint()
        {
            if (this.l is not null)
            {
                if (this.izq is not null) { this.izq.inOrdenPrint(); }
                MessageBox.Show(this.l.getTitulo());
                if (this.der is not null) { this.der.inOrdenPrint(); }
            }
        }

        // Obtiene el id del libro con el id más alto.
        public int getGreaterId()
        {
            if (this.der != null) { return this.der.getGreaterId(); }
            else { return this.l.getId(); }
        }

        public bool isEmpty()
        {
            return this.l is null;
        }

        public bool treeWithoutSheets()
        {
            return this.l is not null && this.izq is null && this.der is null;
        }
    }
}
