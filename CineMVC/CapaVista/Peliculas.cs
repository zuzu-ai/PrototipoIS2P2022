using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL.nav;
using CapaControlador;

namespace CapaVista
{
	public partial class Peliculas : Form
	{
		public Peliculas()
		{
			InitializeComponent();
			TextBox[] alias = navegador1.ClasificaTextboxsegunParent(this);
			navegador1.ObtenerCamposdeTabla(alias, "Peliculas", "hotelSanCarlos");
			navegador1.MetodoSalirVista(this);
			//navegador1.LlenarCombobox(cbxGenero, "Genero", "", "nombre", "estado");
			//navegador1.LlenarCombobox(cbxIDEmpresa, "empresa", "idEmpresa", "nombre", "estatus");

			//inicio de elementos para dar de baja
			navegador1.campoEstado = "estado";
			//fin de elementos para dar de baja

			/* Inicio ID Aplicacion usada para reportes y ayudas */
			navegador1.idAplicacion = "0019";
			navegador1.idmodulo = "1";
			/* Inicio ID Aplicacion usada para reportes y ayudas */

			//inicio de elementos para ejecutar la ayuda
			navegador1.tablaAyuda = "Aplicacion";
			navegador1.campoAyuda = "pkId";
			//fin de elementos para ejecutar la ayuda


			// Inicio datos para ejecurar reportes
			navegador1.LlamarRutaReporte("ruta", "idAplicacion", "Reporte");
			// Final datos para ejecutar reportes

			navegador1.ObtenerNombreDGV(this.dgvVistaPrevia);
			navegador1.LlenarTabla();
			navegador1.ObtenerReferenciaFormActual(this);
			//String cadena = txtprueba.Text;
			//navegador1.pruebaMensaje(cadena);
		}

		private void txtsubtitulado_TextChanged(object sender, EventArgs e)
		{
			navegador1.ActivaRadiobtn(rbnSi, rbnNo, txtsubtitulado);
		}

		private void txtestado_TextChanged(object sender, EventArgs e)
		{
			navegador1.ActivaRadiobtn(rbnactivo, rbninactivo, txtestado);
		}

		private void rbnNo_CheckedChanged(object sender, EventArgs e)
		{
			navegador1.CambioEstadoTextbox(txtsubtitulado, rbnNo, "0");
		}

		private void rbnSi_CheckedChanged(object sender, EventArgs e)
		{
			navegador1.CambioEstadoTextbox(txtsubtitulado, rbnSi, "1");
		}

		private void rbnactivo_CheckedChanged(object sender, EventArgs e)
		{
			navegador1.CambioEstadoTextbox(txtestado, rbnactivo, "1");
		}

		private void rbninactivo_CheckedChanged(object sender, EventArgs e)
		{
			navegador1.CambioEstadoTextbox(txtestado, rbninactivo, "0");
		}
	}
}
