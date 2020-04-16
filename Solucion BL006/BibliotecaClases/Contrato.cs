using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Contrato
    {
        public string Numero { get; set; }
        public DateTime FechaCreacion { get; set; }
        private string _rut;
        public string CodigoPlan { get; set; }
        private DateTime _fechaIncioVigencia;
        public DateTime FechaFinVigencia { get; set; }
        public bool Vigente { get; set; }
        public bool DeclaracionSalud { get; set; }
        public float PrimaAnual { get; set; }
        public float PrimaMensual { get; set; }
        private string _observaciones;

        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }
        public DateTime FechaInicioVigencia
        {
            get { return _fechaIncioVigencia; }
            set {
                _fechaIncioVigencia = value;
            }
        }
        public string Rut
        {
            get { return _rut; }
            set {
                if (value.Trim().Length==10)
                {
                    _rut = value;
                }
                else
                {
                    throw new Exception("rut invalido");
                }
                 }
        }

        public Contrato()
        {

        }
    }
}
