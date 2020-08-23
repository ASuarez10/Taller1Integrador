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

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ui.VentanaGrafico cambioVentana = new ui.VentanaGrafico();
            cambioVentana.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }
    }
}
