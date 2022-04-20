using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
using CapaVistaSeguridadHSC;

namespace CapaVista
{
	public partial class MDICine : Form
	{
		CapaControlador.Controlador controlador = new CapaControlador.Controlador();
		public MDICine()
		{
			InitializeComponent();
		}

		private void MDICine_Load(object sender, EventArgs e)
		{
			frmLoginHSC form = new frmLoginHSC();
			if (form.ShowDialog() == DialogResult.OK)
			{
				txtUsuario.Text = form.usuario();
			}
			else
			{
				this.Close();
			}
		}

		private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmLoginHSC form = new frmLoginHSC();
			if (form.ShowDialog() == DialogResult.OK)
			{
				txtUsuario.Text = form.usuario();
			}
			else
			{ this.Close(); }
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Peliculas form3 = new Peliculas();
				form3.MdiParent = this;
				form3.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		private void cinesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Cines form3 = new Cines();
				form3.MdiParent = this;
				form3.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		private void salasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Salas form3 = new Salas();
				form3.MdiParent = this;
				form3.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		private void horariosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Horarios form3 = new Horarios();
				form3.MdiParent = this;
				form3.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Clientes form3 = new Clientes();
				form3.MdiParent = this;
				form3.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		private void asientosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Asientos form3 = new Asientos();
				form3.MdiParent = this;
				form3.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}
	}
}
