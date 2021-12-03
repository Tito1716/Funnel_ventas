using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNNELVENTAS.Clases
{
    class Venta
    {
		public int id_venta { get; set; }
		public string nombre_cliente { get; set; }
		public string Ejecutivo_Cuentas { get; set; }
		public int tipo_gestion { get; set; }
		public int tipo_estado { get; set; }
		public int prox_Gestion { get; set; }
		public string fecha_inicial { get; set; }
		public int cantidad_equipo { get; set; }
		public int tipo_equipo { get; set; }
		public int marca_equipo { get; set; }
		public string detalle_equipo { get; set; }
		public int monto_equipo { get; set; }
		public int cantidad_enlace { get; set; }
		public int tipo_enlace { get; set; }
		public int tipo_ancho { get; set; }
		public string detalle_enlace { get; set; }
		public int monto_enlace { get; set; }
		public int cantidad_consultoria { get; set; }
		public int tipo_consultoria { get; set; }
		public int tipo_consultoria2 { get; set; }
		public string detalle_consultoria { get; set; }
		public int monto_consultoria { get; set; }
		public int total { get; set; }
	}
}
