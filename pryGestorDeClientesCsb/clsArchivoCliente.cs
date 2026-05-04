using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Int32 cantidadClientes() {

            string DatosLeidos;
            int cont = 0;
            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //leer
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                cont++;
                DatosLeidos = AD.ReadLine();
                
            }

            //Cerrar
            AD.Close();
            AD.Dispose();

            return cont;
        }

        public double sumarDeuda(DataGridView Grilla)
        {
            string DatosLeidos;
            string[] vecVentas = new string[4];
            double sum = 0;

            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //leer
            DatosLeidos = AD.ReadLine();
            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {

                vecVentas = DatosLeidos.Split(';');
                Grilla.Rows.Add(vecVentas[0], vecVentas[1], vecVentas[2], vecVentas[3]);
                sum += Convert.ToDouble(vecVentas[3]);;
                DatosLeidos = AD.ReadLine();
            }
            //Cerrar
            AD.Close();
            AD.Dispose();
            return sum;
        }

        public double promedioDeuda(int total, double suma)
        {
            double prom = suma / total;
            return prom;
        }

        public void ListarDeudores(DataGridView Grilla)
        {
            string DatosLeidos;
            string[] vecVentas = new string[4];


            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //leer
            DatosLeidos = AD.ReadLine();
            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {
                vecVentas = DatosLeidos.Split(';');
                if (Convert.ToInt32(vecVentas[3]) != 0)
                {
                    Grilla.Rows.Add(vecVentas[0], vecVentas[1], vecVentas[2], vecVentas[3]);
                }

                DatosLeidos = AD.ReadLine();

            }
            //Cerrar
            AD.Close();
            AD.Dispose();
        }

        public int cantidadClientesDeudores(DataGridView Grilla)
        {
            int cont = 0;
            string DatosLeidos;
            string[] vecVentas = new string[4];


            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //leer
            DatosLeidos = AD.ReadLine();
            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {
                vecVentas = DatosLeidos.Split(';');
                if (Convert.ToInt32(vecVentas[3]) != 0)
                {
                    cont ++;
                }

                DatosLeidos = AD.ReadLine();

            }
            //Cerrar
            AD.Close();
            AD.Dispose();

            return cont;
        }

        public void generarReporte()
        {
            string DatosLeidos;
            string[] vecVentas = new string[4];

            StreamWriter Reporte = new StreamWriter("Reporte.csv", false, Encoding.UTF8);
            int cantidad = 0;
            decimal total = 0;
            Reporte.WriteLine("Listado de Clientes\n");
            Reporte.WriteLine("Código;Nombre;Límite;Deuda");


            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //leer
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                vecVentas = DatosLeidos.Split(';');
                Reporte.Write(vecVentas[0]);
                Reporte.Write(';');
                Reporte.Write(vecVentas[1]);
                Reporte.Write(';');
                Reporte.Write(vecVentas[2]);
                Reporte.Write(';');
                Reporte.WriteLine(vecVentas[3]);
                DatosLeidos = AD.ReadLine();

                cantidad++;
                total = total + Convert.ToDecimal(vecVentas[2]);

            }
            Reporte.WriteLine("");
            Reporte.WriteLine("Total de deuda;;Cantidad de deudores;;Promedio de deuda");
            Reporte.Write(total);
            Reporte.Write(';');
            Reporte.Write(';');
            Reporte.Write(cantidad);
            Reporte.Write(';');
            Reporte.Write(';');
            Reporte.WriteLine(total/cantidad);

            //Cerrar



            AD.Close();
            AD.Dispose();

            Reporte.Close();
            Reporte.Dispose();
        }


        private struct regCliente
        {
            public Int32 Codigo;
            public String Nombre;
            public Decimal Deuda;
            public Decimal Limite;
        }

        private regCliente[] vecRegCliente = new regCliente[100];
        private int ind = 0;

        private void ordenarVector()
        {
            regCliente aux;

            for (int c = 0; c < ind-1; c++)
            {
                for (int i = 0; i < ind-1; i++) //Recorre el vector
                {
                    if (vecRegCliente[i].Codigo > vecRegCliente[i+1].Codigo)
                    {
                        aux = vecRegCliente[i];
                        vecRegCliente[i] = vecRegCliente[i + 1];
                        vecRegCliente[i + 1] = aux;
                    }
                }
            }
        }

        private void cargarVector() 
        {
            string DatosLeidos;
            string[] vecVentas = new string[4];

            ind = 0;
            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //leer
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                vecVentas = DatosLeidos.Split(';');
                vecRegCliente[ind].Codigo = Convert.ToInt32(vecVentas[0]);
                vecRegCliente[ind].Nombre = vecVentas[1];
                vecRegCliente[ind].Deuda = Convert.ToDecimal(vecVentas[2]);
                vecRegCliente[ind].Limite = Convert.ToDecimal(vecVentas[3]);
                ind++;
                DatosLeidos = AD.ReadLine();

            }
            //Cerrar
            AD.Close();
            AD.Dispose();
        }

        private void reescribirArchivo() 
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, false);

            for (int i = 0; i < ind; i++)
            {
                AD.Write(vecRegCliente[i].Codigo);
                AD.Write(";");
                AD.Write(vecRegCliente[i].Nombre);
                AD.Write(";");
                AD.Write(vecRegCliente[i].Deuda);
                AD.Write(";");
                AD.WriteLine(vecRegCliente[i].Limite);


            }

            AD.Close();
            AD.Dispose();
        }

        public void OrdenarArchivo()
        {
            cargarVector();
            ordenarVector();
            reescribirArchivo();
        }

    }
}
