using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller1Integrador.model;
using Taller1Integrador.src;
using System.Windows.Forms.DataVisualization.Charting;

namespace Taller1Integrador
{
    public partial class Inicio : Form
    {
        private Datos datos;

        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {

                string rutan = openFileDialog1.FileName;

                lblRuta.Text = rutan;

                datos = new Datos(rutan);

                ArrayList departamentos = datos.getLista();

                for (int i = 0; i < departamentos.Count; i++) {

                    int n = dtgv.Rows.Add();

                    dtgv.Rows[n].Cells[0].Value = ((Departamento)departamentos[i]).getRegion();
                    dtgv.Rows[n].Cells[1].Value = ((Departamento)departamentos[i]).getCodDep();
                    dtgv.Rows[n].Cells[2].Value = ((Departamento)departamentos[i]).getNombre();
                    dtgv.Rows[n].Cells[3].Value = ((Departamento)departamentos[i]).getCodMun();
                    dtgv.Rows[n].Cells[4].Value = ((Departamento)departamentos[i]).getMunicipio();

                }

                string[] series = {"Región Centro Oriente", "Región Caribe", "Región Pacífico", "Región Eje Cafetero - Antioquia", "Región Centro Sur",
                "Región Llano"};
                int[] puntos = {datos.getCentroOriente(), datos.getCaribe(), datos.getPacifico(), datos.getAntioquia(), datos.getCentroSur(), datos.getLlano()
                };

                grafica.Titles.Add("Municipios por departamento");

                for (int i = 0; i < series.Length; i++)
                {

                    //titulos
                    Series serie = grafica.Series.Add(series[i]);

                    //cantidades
                    serie.Label = puntos[i].ToString();

                    serie.Points.Add(puntos[i]);
                }

            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void cbbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cbbDepartamento.SelectedIndex;
            string dep = cbbDepartamento.Items[indice].ToString();

            if (datos == null)
            {
                MessageBox.Show("No has escogido ningún archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                int y = 0;
                if (y != -1) {

                    dtgv.Rows.Clear();

                    ArrayList departamentos = datos.getLista();

                    for (int i = 0; i < departamentos.Count; i++)
                    {

                        if (((Departamento)departamentos[i]).getNombre().Equals(dep))
                        {

                        int n = dtgv.Rows.Add();

                        dtgv.Rows[n].Cells[0].Value = ((Departamento)departamentos[i]).getRegion();
                        dtgv.Rows[n].Cells[1].Value = ((Departamento)departamentos[i]).getCodDep();
                        dtgv.Rows[n].Cells[2].Value = ((Departamento)departamentos[i]).getNombre();
                        dtgv.Rows[n].Cells[3].Value = ((Departamento)departamentos[i]).getCodMun();
                        dtgv.Rows[n].Cells[4].Value = ((Departamento)departamentos[i]).getMunicipio();
                        }
                    }
                }

            }
        }
    }
}
