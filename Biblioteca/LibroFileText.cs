using System;
using System.IO;

namespace Biblioteca
{
    public class LibroFileText
    {
        private string rutaArchivo;

        private string nombreArchivo;

        private string rutaCompletaArchivo;

        private string nombreArchivoRespaldo = "respaldo.txt";

        private string nombreArchivoTemp = "temp.tmp";

        public LibroFileText(string rutaArchivo, string nombreArchivo)
        {
            this.rutaArchivo = rutaArchivo;
            this.nombreArchivo = nombreArchivo;
            this.rutaCompletaArchivo = 
                rutaArchivo + "\\" + nombreArchivo;
        }

        public string getRutCompArch()
        {
            return this.rutaCompletaArchivo;
        }
        
        public void nueRegFileText(string registro)
        {
           using(StreamWriter sw = new StreamWriter(this.rutaCompletaArchivo))
           {
                sw.WriteLine(registro);
           }
        }

        // Actualiza un registro del archivo de texto que contiene los libros.
        public void actRegFileText(int idLibro, string atribLibAct)
        {
            // Leemos el archivo que contiene los libros.
            StreamReader sr = new StreamReader(this.rutaCompletaArchivo);

            // Leemos linea por linea.
            string registro = sr.ReadLine();

            // Ruta completa del archivo de texto a borrar.
            string rutaCompletaTemp = this.rutaArchivo + "\\" 
                + this.nombreArchivoTemp;

            while (registro is not null)
            {
                if(!this.obtenerIdReg(registro).Equals("" + idLibro))
                {
                    // Escribimos las lineas que no son iguales al registro que
                    // contiene el id del libro a modificar.
                    using(StreamWriter sw = File.AppendText(rutaCompletaTemp))
                    {
                        sw.WriteLine(registro);
                    }
                }

                // Leemos la siguiente linea del archivo.
                registro = sr.ReadLine();
            }

            //Cerramos el archivo original que contiene los libros.
            sr.Close();

            // Escribimos el nuevo registro en el archivo que contiene los
            // libros.
            using (StreamWriter sw = File.AppendText(rutaCompletaTemp))
            {
                sw.WriteLine(atribLibAct);
            }      
            
            // Ruta completa de archivo de respaldo.
            string rutaCompletaRespaldo = this.rutaArchivo + "\\"
                + this.nombreArchivoRespaldo;

            // Cambiamos el nombre del archivo temporal a uno de respaldo.
            File.Move(rutaCompletaTemp, rutaCompletaRespaldo);

            // Borramos el archivo original.
            File.Delete(this.rutaCompletaArchivo);

            // Cambiamos el nombre del archivo de respaldo al nombre del archivo
            // original
            File.Move(rutaCompletaRespaldo, this.rutaCompletaArchivo);
        }

        public void delRegFileText(int idLibro)
        {
            // Leemos el archivo que contiene los libros.
            StreamReader sr = new StreamReader(this.rutaCompletaArchivo);
            // Leemos linea por linea.
            string registro = sr.ReadLine();

            // Ruta completa del archivo de texto a borrar.
            string rutaCompletaTemp = this.rutaArchivo + "\\" 
                + this.nombreArchivoTemp;

            while (registro is not null)
            {
                if(!this.obtenerIdReg(registro).Equals("" + idLibro))
                {
                    // Escribimos las lineas que no son iguales al registro que
                    // contiene el id del libro a modificar.
                    using(StreamWriter sw = File.AppendText(rutaCompletaTemp))
                    {
                        sw.WriteLine(registro);
                    }
                }

                // Leemos la siguiente linea del archivo.
                registro = sr.ReadLine();
            }

            // Cerramos el archivo.
            sr.Close();
           
            // Ruta completa de archivo de respaldo.
            string rutaCompletaRespaldo = this.rutaArchivo + "\\"
                + this.nombreArchivoRespaldo;

            // Cambiamos el nombre del archivo temporal a uno de respaldo.
            File.Move(rutaCompletaTemp, rutaCompletaRespaldo);

            // Borramos el archivo original.
            File.Delete(this.rutaCompletaArchivo);

            // Cambiamos el nombre del archivo de respaldo al nombre del archivo
            // original
            File.Move(rutaCompletaRespaldo, this.rutaCompletaArchivo);
        }

        private string obtenerIdReg(string registro)
        {
            return registro.Substring(0, registro.IndexOf(";"));
        }
    }
}
