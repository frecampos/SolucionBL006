using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Cliente
    {
        private string _rut;
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;
        public int IdSexo { get; set; }
        public int IdEstadoCivil { get; set; }

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set {
                int annos = DateTime.Now.Date.Year - value.Year;
                if (annos>=18)
                {
                    _fechaNacimiento = value;
                }
                else
                {
                    throw new Exception("no es mayor de 18");
                }
                
            }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set {
                if (value.Trim().Length>=2)
                {
                    _nombre = value;
                }
                else
                {
                    throw new Exception("no existe nombre");
                }                
            }
        }
        public string Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }

        public Cliente()
        {

        }
    }
}
