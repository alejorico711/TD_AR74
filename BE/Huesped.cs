using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Huesped
    {
		private int _idHuesped;

		public int IdHuesped
		{
			get { return _idHuesped; }
			set { _idHuesped = value; }
		}
		private string _dni;

		public string DNI
		{
			get { return _dni; }
			set { _dni = value; }
		}
		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}
		private string _apellido;

		public string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}
		private string _email;

		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}
		private string _telefono;

		public string Telefono
		{
			get { return _telefono; }
			set { _telefono = value; }
		}
		private DateTime _fechaNacimiento;

		public DateTime FechaNacimiento
		{
			get { return _fechaNacimiento; }
			set { _fechaNacimiento = value; }
		}

        public override string ToString()
        {
            return $"{DNI} | {Nombre} {Apellido}";
        }
    }
}
