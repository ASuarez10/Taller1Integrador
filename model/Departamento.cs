using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Integrador.model
{
    class Departamento
    {

        private string region, codigoDepartamento, nombre, codigoMunicipio, municipio;

        public Departamento(string region, string codigoDepartamento, string nombre, string codigoMunicipio, string municipio)
        {
            this.region = region;
            this.codigoDepartamento = codigoDepartamento;
            this.nombre = nombre;
            this.codigoMunicipio = codigoMunicipio;
            this.municipio = municipio;
        }

        public string getRegion() => region;

        public string getCodDep() => codigoDepartamento;
        public string getNombre() => nombre;
        public string getCodMun() => codigoMunicipio;
        public string getMunicipio() => municipio;

    }
}
