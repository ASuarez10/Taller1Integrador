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

        public ArrayList getLista() => Lista;

        public void llenarLista() {

            lineas = File.ReadAllLines(Ruta);

            for (int i = 1; i < lineas.Length; i++) {

                var valores = lineas[i].Split(',');

                Lista.Add(new Departamento(valores[0], valores[1], valores[2], valores[3]+valores[4], valores[5]));
            
            }
        }

        public void cantidades() {
            
            for (int i = 0; i < Lista.Count; i++) {

                if (((Departamento)Lista[i]).getRegion().Equals("Región Eje Cafetero - Antioquia")) {
                    antioquia += 1;
                }

                if (((Departamento)Lista[i]).getRegion().Equals("Región Centro Oriente"))
                {
                    centroOriente += 1;
                }

                if (((Departamento)Lista[i]).getRegion().Equals("Región Caribe"))
                {
                    caribe += 1;
                }

                if (((Departamento)Lista[i]).getRegion().Equals("Región Llano"))
                {
                    llano += 1;
                }

                if (((Departamento)Lista[i]).getRegion().Equals("Región Centro Sur"))
                {
                    centroSur += 1;
                }

                if (((Departamento)Lista[i]).getRegion().Equals("Región Pacífico"))
                {
                    pacifico += 1;
                }

            }

        }

        public int getAntioquia() => antioquia;
        public int getCentroOriente() => centroOriente;
        public int getCaribe() => caribe;
        public int getLlano() => llano;
        public int getCentroSur() => centroSur;
        public int getPacifico() => pacifico;

    }
}
