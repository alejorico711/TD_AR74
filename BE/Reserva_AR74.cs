using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Reserva_AR74
    {
		private DateTime _fechaInicio;

		public DateTime FechaInicio
		{
			get { return _fechaInicio; }
			set { _fechaInicio = value; }
		}

		private DateTime _fechaFin;

		public DateTime FechaFin
		{
			get { return _fechaFin; }
			set { _fechaFin = value; }
		}
		private Habitacion _habitacion;

		public Habitacion Habitacion
		{
			get { return _habitacion; }
			set { _habitacion = value; }
		}
		private int _cantidadPersonas;

		public int CantidadPersonas
		{
			get { return _cantidadPersonas; }
			set { _cantidadPersonas = value; }
		}

		private BE.Huesped _huesped;

		public BE.Huesped Huesped
		{
			get { return _huesped; }
			set { _huesped = value; }
		}

	}
}
