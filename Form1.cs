using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matematica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variables
        int[] Datos = new int[9];

        int[] DatosOrdenados;

        int[] xi;

        /*int[] FrecuenciaAbsoluta;*/

        private void Form1_Load(object sender, EventArgs e)
        {
            //instanciando clase predefinida en visual, que me permite generar en un determinado intervalo
            Random random = new Random();


            //Defino una variable para la cantidad de digitos
            int limite = 9;

            Datos[0] = random.Next(limite);
            Datos[1] = random.Next(limite);
            Datos[2] = random.Next(limite);
            Datos[3] = random.Next(limite);
            Datos[4] = random.Next(limite);
            Datos[5] = random.Next(limite);
            Datos[6] = random.Next(limite);
            Datos[7] = random.Next(limite);
            Datos[8] = random.Next(limite);


            //el array hereda las propiedad de Datos
            DatosOrdenados = Datos;
            OrdenarDatos();
            MostrarLabel();
            xicalc();

        }
        //Definir for para mostrar los datos en label
        private void MostrarLabel()
        {
            for (int i = 0; i < Datos.Length; i++)
            {
                label1.Text = label1.Text + DatosOrdenados[i] + ", ";
            }
        }
        #region Parametros Centralización
        //Defino funcion para ordenar los datos a menor a mayor
        private void OrdenarDatos()
        {
            //funcion para ordenar los datos random 
            Array.Sort(DatosOrdenados);
        }

        private void xicalc()
        {

            int Contador = 1;
            int DatoActual = DatosOrdenados[0];

            for (int i = 0; i < DatosOrdenados.Length; i++)
            {
                if (DatoActual != DatosOrdenados[i])
                {
                    DatoActual = DatosOrdenados[i];
                    Contador = Contador + 1;
                }
            }

            xi = new int[Contador]; 
            DatoActual = DatosOrdenados[0];
            int Posicion = 0;

            for (int i = 0; i < DatosOrdenados.Length; i++)
            {
                if (DatoActual != DatosOrdenados[i])
                {
                    xi[Posicion] = DatoActual;
                    DatoActual = DatosOrdenados[i];
                    Posicion = Posicion + 1;
                }
            }
            xi[xi.Length - 1] = DatosOrdenados[DatosOrdenados.Length - 1];
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            //media
            //le doy a resultado, el valor 0 para comenzar la suma del primer dato
            double Resultado = 0;

            for (int i = 0; i < Datos.Length; i++)
            {
                Resultado = Resultado + Datos[i];
            }

            Resultado = Resultado / Datos.Length;

            lblMedia.Text = Convert.ToString(Resultado);
        }



        private void btnModa_Click(object sender, EventArgs e)
        {
            int[] FrecuenciaAbsoluta = new int[0];  
            int DatoActual = DatosOrdenados[0];
            int Contador = 1;

            for (int i = 0; i < DatosOrdenados.Length; i++)
            {
                if (DatoActual == DatosOrdenados[i])
                {
                    DatoActual = DatosOrdenados[i];
                    Contador = Contador + 1;
                }
            }

            FrecuenciaAbsoluta = new int[Contador];
            DatoActual = DatosOrdenados[0];
            Contador = 0;
            int Posicion = 0;

            for (int i = 0; i < DatosOrdenados.Length; i++)
            {
                if (DatoActual != DatosOrdenados[i])
                {
                    DatoActual = DatosOrdenados[i];
                    FrecuenciaAbsoluta[Posicion] = Contador;
                    Posicion = Posicion + 1;
                    Contador = 0;
                }

                else
                {
                    Contador = Contador + 1;
                }
            }

            DatoActual = FrecuenciaAbsoluta[0];
            int Resultado = 0;

            for (int i = 0; i < FrecuenciaAbsoluta.Length; i++)
            {
                for (int j = 0; j < FrecuenciaAbsoluta.Length; j++)
                {
                    if (FrecuenciaAbsoluta[i] > FrecuenciaAbsoluta[j])
                    {
                        Resultado = i;
                        DatoActual = FrecuenciaAbsoluta[i];
                    }
                }
            }

            lblModa.Text = Convert.ToString(Resultado);
        }


        private void btnMediana_Click(object sender, EventArgs e)
        {
            int mediana = 0;

            if ((DatosOrdenados.Length % 2) == 0)
            {
                mediana = DatosOrdenados.Length / 2;
                lblMediana.Text = Convert.ToString((DatosOrdenados[mediana] + DatosOrdenados[mediana - 1]) / (double) 2 );
            }
            else
            {
                mediana = DatosOrdenados.Length / 2;
                lblMediana.Text = Convert.ToString(DatosOrdenados[mediana]);
            }
        }
        #endregion

    }
}