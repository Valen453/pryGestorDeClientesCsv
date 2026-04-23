using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace pryGestorDeClientesCsb
{
    internal class clsArchivoCliente
    {

        public string NombreArchivo = "Clientes.csv";

        public void Grabar(string Codigo, string Usuario, string Deuda, string Limite)
        {
            //Abrir
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            //Cargar
            AD.Write(Codigo);
            AD.Write(";");
            AD.Write(Usuario);
            AD.Write(";");
            AD.Write(Deuda);
            AD.Write(";");
            AD.WriteLine(Limite);
            //Cerrar
            AD.Close();
            AD.Dispose();
        }

        public void Listar(DataGridView Grilla)
        {
            string DatosLeidos;
            string[] vecVentas = new string[4];


            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //leer
            DatosLeidos = AD.ReadLine();
            Grilla.Rows.Clear();
            while (DatosLeidos != null) {
                vecVentas = DatosLeidos.Split(';');
                Grilla.Rows.Add(vecVentas[0], vecVentas[1], vecVentas[2], vecVentas[3]);
                DatosLeidos = AD.ReadLine() ;
            
            }
            //Cerrar
            AD.Close();
            AD.Dispose();
        }


    }
}
