using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
	public class Habitacion
	{
		private TipoHabitacion _tipo;

		public TipoHabitacion Tipo
		{
			get { return _tipo; }
			set { _tipo = value; }
		}
		private int _idHabitacion;

		public int IdHabitacion
        {
			get { return _idHabitacion; }
			set { _idHabitacion = value; }
		}
		private int _numero;

		public int Numero
		{
			get { return _numero; }
			set { _numero = value; }
		}
		private string _descripcion;

		public string Descripcion
		{
			get { return _descripcion; }
			set { _descripcion = value; }
		}
		private string _estado;

		public string Estado
		{
			get { return _estado; }
			set { _estado = value; }
		}

	}
}
