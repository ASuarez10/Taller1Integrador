using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Taller1Integrador.ui
{
    public partial class VentanaGrafico : Form
    {


        public VentanaGrafico()
        {
            InitializeComponent();
        }

        private void VentanaGrafico_Load_1(object sender, EventArgs e)
        {
            string[] series = { "Alejandro", "Esteban", "Juan" };
            int[] puntos = { 20, 50, 70};

            chart2.Titles.Add("Ejemplo");

            for (int i = 0; i < series.Length; i++)
            {

                //titulos
                Series serie = chart2.Series.Add(series[i]);

                //cantidades
                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
            }
        }
    }
}
