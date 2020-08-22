using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller1Integrador.model;

namespace Taller1Integrador.src
{
    class Datos
    {

        private string Ruta;
        private ArrayList Lista;
        private string[] lineas;
        private int antioquia, centroOriente, caribe, centroSur, llano, pacifico;

        public Datos(string ruta)
        {
            this.Ruta = ruta;
            Lista = new ArrayList();
            llenarLista();
            cantidades();
        }

        public void llenarLista() {

            lineas = File.ReadAllLines(Ruta);

            for (int i = 1; i < lineas.Length; i++) {

                var valores = lineas[i].Split(',');

                Lista.Add(new Departamento(valores[0], valores[1], valores[2], valores[3], valores[4]));
            
            }
        }

        public void cantidades() {
            
            for (int i = 0; i < Lista.Count; i++) {

                if (Lista[i].Equals("Región Eje Cafetero - Antioquia")) {
                    antioquia += 1;
                }

                if (Lista[i].Equals("Región Centro Oriente"))
                {
                    centroOriente += 1;
                }

                if (Lista[i].Equals("Región Caribe"))
                {
                    caribe += 1;
                }

                if (Lista[i].Equals("Región Llano"))
                {
                    llano += 1;
                }

                if (Lista[i].Equals("Región Centro Sur"))
                {
                    centroSur += 1;
                }

                if (Lista[i].Equals("Región Pacífico"))
                {
                    pacifico += 1;
                }

            }

        }

    }
}
