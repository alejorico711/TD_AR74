using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TipoHabitacion
    {
		private int _idTipoHabitacion;

		public int IdTipoHabitacion
		{
			get { return _idTipoHabitacion; }
			set { _idTipoHabitacion = value; }
		}
		private string _descripcion;

		public string Descripcion
		{
			get { return _descripcion; }
			set { _descripcion = value; }
		}
		private decimal _precioPorNoche;

		public decimal PrecioPorNoche
		{
			get { return _precioPorNoche; }
			set { _precioPorNoche = value; }
		}


		private int _capacidad;

		public int Capacidad
		{
			get { return _capacidad; }
			set { _capacidad = value; }
		}

	}
}
